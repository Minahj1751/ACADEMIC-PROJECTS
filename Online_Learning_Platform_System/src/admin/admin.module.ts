import { Module, forwardRef } from '@nestjs/common';
import { TypeOrmModule } from '@nestjs/typeorm';
import { User } from './entities/user.entity';
import { Account } from './entities/account.entity';
import { AdminController } from './admin.controller';
import { AuthModule } from '../auth/auth.module';
import { MailModule } from '../mail/mail.module';
import { AdminService } from './admin.service';
import { Notification } from './entities/notification.entity';
import { Course } from 'src/instructor/entities/course.entity';

@Module({
  imports: [
    TypeOrmModule.forFeature([User, Account,Course, Notification]),
    forwardRef(() => AuthModule),
    MailModule,
  ],
  providers: [AdminService],
  controllers: [AdminController],
  exports: [AdminService],
})
export class AdminModule {}
