import { Module } from '@nestjs/common';
import { TypeOrmModule } from '@nestjs/typeorm';
import { JwtModule } from '@nestjs/jwt';
import { User } from 'src/admin/entities/user.entity';
import { Notification } from 'src/admin/entities/notification.entity';
import { ManagerController } from './manager.controller';
import { ManagerService } from './manager.service';
import { Course } from 'src/instructor/entities/course.entity';
import { Account } from 'src/admin/entities/account.entity';

@Module({
  imports: [
    TypeOrmModule.forFeature([User,Account, Course, Notification]),
    JwtModule.register({
      secret: 'secret', 
      signOptions: { expiresIn: '1h' }, 
    }),
  ],
  controllers: [ManagerController],
  providers: [ManagerService],
})
export class ManagerModule {}
