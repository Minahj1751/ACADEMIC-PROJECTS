import { Injectable, UnauthorizedException, BadRequestException, Inject, InternalServerErrorException, NotFoundException } from '@nestjs/common';
import { JwtService } from '@nestjs/jwt';
import { InjectRepository } from '@nestjs/typeorm';
import { MoreThan, Repository } from 'typeorm';
import { User } from '../admin/entities/user.entity';
import { Account } from '../admin/entities/account.entity';
import { LoginDto } from './dto/login.dto';
import { SignUpDto } from './dto/signup.dto';
import { ChangePasswordDto } from './dto/change-password.dto';
import { MailService } from '../mail/mail.service';
import { JwtPayload } from './interfaces/jwt-payload.interface';
import { CACHE_MANAGER } from '@nestjs/cache-manager';
import { Cache } from 'cache-manager';
import * as crypto from 'crypto';
import { addHours } from 'date-fns';
import { ForgotPasswordDto } from './dto/forgot-password.dto';
import { ResetPasswordDto } from './dto/reset-password.dto';
import { Role } from 'src/shared/constants/roles.constants';

@Injectable()
export class AuthService {
  constructor(
    @InjectRepository(User)
    private userRepository: Repository<User>,
    @InjectRepository(Account)
    private accountRepository: Repository<Account>,
    private jwtService: JwtService,
    private mailService: MailService,
    @Inject(CACHE_MANAGER) private cacheManager: Cache,
  ) {}

  async signUp(signUpDto: SignUpDto): Promise<{ message: string; userId: number }> { 
    const { email, password, name, phonenumber } = signUpDto;

    const existingUser = await this.userRepository.findOne({ where: { email } });
    if (existingUser) {
      throw new BadRequestException('Email already exists');
    }

    const user = this.userRepository.create({
      email,
      password,
      name,
      phonenumber,
    });

    await this.userRepository.save(user);

    return { 
      message: 'Signup successful. Wait for admin approval.',
      userId: user.id 
    };
  }

  async login(loginDto: LoginDto): Promise<{ accessToken: string; user: any }> {
    const { email, password } = loginDto;
    const user = await this.userRepository.findOne({ 
      where: { email }, 
      relations: ['account'] 
    });

    if (!user) {
      throw new UnauthorizedException('Invalid credentials');
    }

    if (!user.account || !user.account.isActive) {
      throw new UnauthorizedException('Account not approved or inactive');
    }

    const isPasswordValid = await user.comparePassword(password);
    if (!isPasswordValid) {
      throw new UnauthorizedException('Invalid credentials');
    }

    const payload: JwtPayload = {
      id: user.id,
      email: user.email,
      role: user.account.role as Role,
    };

    const accessToken = this.jwtService.sign(payload);
    
    return { 
      accessToken,
      user: {
        id: user.id,
        email: user.email,
        name: user.name,
        role: user.account.role
      }
    };
  }

  async changePassword(userId: number, changePasswordDto: ChangePasswordDto): Promise<{ message: string }> {
    const { currentPassword, newPassword } = changePasswordDto;
    
    const user = await this.userRepository.findOne({ where: { id: userId } });
    if (!user) {
      throw new UnauthorizedException('User not found');
    }
  
    const isPasswordValid = await user.comparePassword(currentPassword);
    if (!isPasswordValid) {
      throw new UnauthorizedException('Current password is incorrect');
    }
  
    user.password = newPassword;
    await this.userRepository.save(user);
  
    await this.mailService.sendPasswordChangeConfirmation(user.email);
  
    return { message: 'Password changed successfully' };
  }

async logout(token: string): Promise<{ message: string }> {
  try {
    // Decode the token and check if it’s valid
    const decoded = this.jwtService.decode(token) as any;
    if (!decoded || typeof decoded === 'string') {
      throw new BadRequestException('Invalid token');
    }

    // Get expiration time (exp) and calculate the TTL (Time to Live)
    const exp = decoded.exp;
    const now = Math.floor(Date.now() / 1000);
    const ttl = exp - now; // Time to live until the token expires

    console.log(`Token Expiration: ${exp}`);
    console.log(`Current Time: ${now}`);
    console.log(`TTL (seconds): ${ttl}`);

    if (ttl <= 0) {
      return { message: 'Token already expired' };
    }

    // Blacklist the token by saving it in the cache (Redis or in-memory)
    await this.cacheManager.set(`blacklist_${token}`, true, ttl);

    console.log(`Token blacklisted successfully`);

    return { message: 'Logout successful' };
  } catch (error) {
    console.error('Logout failed:', error);
    throw new InternalServerErrorException('Logout failed');
  }
}
  


  async forgotPassword(forgotPasswordDto: ForgotPasswordDto): Promise<{ message: string }> {
    const user = await this.userRepository.findOne({ 
      where: { email: forgotPasswordDto.email } 
    });

    if (!user) {
      throw new NotFoundException('User not found with this email');
    }

    
    const resetToken = crypto.randomBytes(32).toString('hex');
    const resetTokenExpiry = addHours(new Date(), 1);

    await this.userRepository.update(user.id, {
      resetToken,
      resetTokenExpiry
    });

    
    const resetUrl = `http://localhost:3000/auth/reset-password?token=${resetToken}`;
    
    await this.mailService.sendMail({
      to: user.email,
      subject: 'Password Reset Request',
      text: `To reset your password, please click on this link: ${resetUrl}\n\nThis link will expire in 1 hour.`,
      html: `<p>To reset your password, please click on this link: <a href="${resetUrl}">Reset Password</a></p><p>This link will expire in 1 hour.</p>`
    });

    console.log('Reset Token:', resetToken);
    return { message: 'Password reset email has been sent' };
    

  }

  async resetPassword(resetPasswordDto: ResetPasswordDto): Promise<{ message: string }> {
  
    const user = await this.userRepository.findOne({
      where: {
        resetToken: resetPasswordDto.token,
        resetTokenExpiry: MoreThan(new Date())
      }
    });

    if (!user) {
      throw new BadRequestException('Invalid or expired token');
    }

  
    user.password = resetPasswordDto.newPassword;
    user.resetToken = null;
    user.resetTokenExpiry = null;
    await this.userRepository.save(user);

    await this.mailService.sendPasswordChangeConfirmation(user.email);

    return { message: 'Password has been reset successfully' };
  }

  async getProfile(userId: number): Promise<any> {
  try {
    const user = await this.userRepository.findOne({
      where: { id: userId },
      relations: ['account'],
    });

    if (!user) {
      throw new NotFoundException('User not found');
    }

    return {
      id: user.id,
      email: user.email,
      name: user.name,
      phoneNumber: user.phonenumber,
      role: user.account?.role || 'User',
      isActive: user.account?.isActive || false,
      joinDate: user.account?.joinDate || null,
    };
  } catch (error) {
    throw new NotFoundException('Profile not found or not accessible');
  }
}

  
}
