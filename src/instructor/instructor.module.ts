import { Module } from '@nestjs/common';
import { TypeOrmModule } from '@nestjs/typeorm';
import { JwtModule } from '@nestjs/jwt';
import { User } from 'src/admin/entities/user.entity';
import { Course } from 'src/instructor/entities/course.entity';
import { Notification } from 'src/admin/entities/notification.entity';
import { InstructorController } from './instructor.controller';
import { InstructorService } from './instructor.service';
import { Account } from 'src/admin/entities/account.entity';
import { PdfService } from 'src/pdf/pdf.service';

@Module({
  imports: [
    TypeOrmModule.forFeature([User, Account, Course, Notification]),
    JwtModule.register({
      secret: 'secret', 
      signOptions: { expiresIn: '1d' }, 
    }),
  ],
  controllers: [InstructorController],
  providers: [InstructorService, PdfService],
})
export class InstructorModule {}
