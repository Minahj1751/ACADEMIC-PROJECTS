import { BadRequestException, ForbiddenException, Injectable, NotFoundException } from '@nestjs/common';
import { InjectRepository } from '@nestjs/typeorm';
import { Repository } from 'typeorm';
import { User } from './entities/user.entity';
import { Account } from './entities/account.entity';
import { CreateAccountDto } from './dto/create-account.dto';
import { MailService } from '../mail/mail.service';
import { Notification } from './entities/notification.entity';
import { Role } from 'src/shared/constants/roles.constants';
import { Course } from 'src/instructor/entities/course.entity';

@Injectable()
export class AdminService {
  constructor(
    @InjectRepository(User)
    private userRepository: Repository<User>,
    @InjectRepository(Account)
    private accountRepository: Repository<Account>,
    private mailService: MailService,
    @InjectRepository(Notification)
    private notificationRepository: Repository<Notification>,
    @InjectRepository(Course)
    private courseRepository: Repository<Course>,

  ) {}

  async findAllUsers(): Promise<User[]> {
    return this.userRepository.find({ relations: ['account'] });
  }

  async findUserById(id: number): Promise<User> {
    console.log("Approving user ID:", id);

    const user = await this.userRepository.findOne({ where: { id } });
    console.log("Loaded user for approval:", user);

    if (!user) {
      throw new NotFoundException('User not found');
    }

    return user;
  }

  async createAccount(createAccountDto: CreateAccountDto, requestingAdminId: number): Promise<Account> {
    const adminAccount = await this.accountRepository.findOne({
      where: { user: { id: requestingAdminId }, role: Role.ADMIN },
      relations: ['user']
    });
  
    if (!adminAccount) {
      throw new NotFoundException('Only admins can create accounts');
    }
  
    const { userId, role, isActive } = createAccountDto;
    console.log("[UserService] Requested userId:", userId);
  
    if (role === Role.ADMIN) {
      throw new BadRequestException('Cannot create admin accounts through this endpoint');
    }
  
    const user = await this.userRepository.findOne({ 
      where: { id: userId },
      select: ["id", "email", "name"] 
    });
    console.log("[UserService] Found user:", user);
  
    if (!user) throw new NotFoundException('User not found');
  
    const account = this.accountRepository.create({ user, role, isActive });
    await this.accountRepository.save(account);
  
    console.log("[UserService] Sending approval email to:", user.email);
    await this.mailService.sendUserApproval(user.email, {
      name: user.name,
      role,
      isActive: isActive ? 'Active' : 'Inactive',
    });
  
    return account;
  }

  
  async updateAccountStatus(
    accountId: number, 
    isActive: boolean,
    requestingAdminId: number
  ): Promise<Account> {
    const adminAccount = await this.accountRepository.findOne({
      where: { user: { id: requestingAdminId }, role: Role.ADMIN },
      relations: ['user']
    });
  
    if (!adminAccount) {
      throw new ForbiddenException('Only admins can update account status');
    }
  
    const targetAccount = await this.accountRepository.findOne({
      where: { id: accountId },
      relations: ['user']
    });
  
    if (!targetAccount) {
      throw new NotFoundException('Target account not found');
    }
  
    if (targetAccount.role === Role.ADMIN && targetAccount.id !== adminAccount.id) {
      throw new ForbiddenException('Admins cannot block other admins');
    }
  
    if (targetAccount.role === Role.ADMIN && targetAccount.id === adminAccount.id && isActive === false) {
      throw new ForbiddenException('Admins cannot deactivate themselves');
    }
  
    targetAccount.isActive = isActive;
    const updatedAccount = await this.accountRepository.save(targetAccount);
  
    await this.mailService.sendAccountStatusChangeEmail(
      targetAccount.user.email,
      {
        name: targetAccount.user.name,
        isActive,
      }
    );
  
    return updatedAccount;
  }
  

  async getNotificationMessage(notificationId: number) {
    const notification = await this.notificationRepository.findOne({
      where: { id: notificationId },
    });
  
    if (!notification) {
      throw new NotFoundException('Notification not found');
    }
  
    return { message: notification.message };
  }

  async approveCourse(courseId: number, adminId: number) {
    const adminAccount = await this.accountRepository.findOne({
      where: { user: { id: adminId }, role: Role.ADMIN },
      relations: ['user'],
    });
  
    if (!adminAccount) {
      throw new ForbiddenException('Only admins can approve courses');
    }
  
    const adminName = adminAccount.user.name;
  
    const course = await this.courseRepository.findOne({
      where: { id: courseId },
      relations: ['user'],
    });
  
    if (!course) {
      throw new NotFoundException('Course not found');
    }
  
    if (course.status === 'approved') {
      throw new BadRequestException('Course is already approved');
    }
  
    course.status = 'approved';
    await this.courseRepository.save(course);
  
    await this.mailService.sendCourseApprovalNotification(course.user.email, {
      name: course.user.name,
      courseTitle: course.title,
    });
  
    return {
      message: 'Course approved successfully',
      course,
      approvedBy: {
        adminId: adminId,
        adminName: adminName,
      },
    };
  }
  
}
