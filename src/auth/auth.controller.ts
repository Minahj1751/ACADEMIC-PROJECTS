import { Controller, Post, Body, UseGuards, Req, Patch,Get, UnauthorizedException } from '@nestjs/common';
import { AuthService } from './auth.service';
import { LoginDto } from './dto/login.dto';
import { SignUpDto } from './dto/signup.dto';
import { ChangePasswordDto } from './dto/change-password.dto';
import { AuthGuard } from '@nestjs/passport';
import { Request } from 'express';
import { ForgotPasswordDto } from './dto/forgot-password.dto';
import { ResetPasswordDto } from './dto/reset-password.dto';

@Controller('auth')
export class AuthController {
  constructor(private readonly authService: AuthService) {}

  @Post('signup')
  async signUp(@Body() signUpDto: SignUpDto) {
    return this.authService.signUp(signUpDto);
  }

  @Post('login')
  async login(@Body() loginDto: LoginDto) {
    return this.authService.login(loginDto);
  }

  @Patch('change-password')
  @UseGuards(AuthGuard('jwt'))
  async changePassword(
  @Req() req: any,
  @Body() changePasswordDto: ChangePasswordDto
) {
  const userId = req.user.id;
  return this.authService.changePassword(userId, changePasswordDto);
}

  @Post('logout')
  @UseGuards(AuthGuard('jwt'))
  async logout(@Req() req: Request) {
    const authHeader = req.headers.authorization;
    if (!authHeader) {
      throw new UnauthorizedException('Authorization header missing');
    }
    
    const token = authHeader.split(' ')[1];
    return this.authService.logout(token);
  }


  @Post('forgot-password')
  async forgotPassword(@Body() forgotPasswordDto: ForgotPasswordDto) {
  return this.authService.forgotPassword(forgotPasswordDto);
}

  @Post('reset-password')
  async resetPassword(@Body() resetPasswordDto: ResetPasswordDto) {
  return this.authService.resetPassword(resetPasswordDto);
}

@Get('profile')
@UseGuards(AuthGuard('jwt'))
async getProfile(@Req() req: any) {
  const userId = req.user.id;
  if (!userId) {
    throw new UnauthorizedException('User ID not found in token');
  }
  return this.authService.getProfile(userId);
}


}