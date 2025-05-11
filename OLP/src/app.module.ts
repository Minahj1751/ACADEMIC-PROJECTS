import { Module } from '@nestjs/common';
import { AuthModule } from './auth/auth.module';
import { AdminModule} from './admin/admin.module';
import { MailModule } from './mail/mail.module';
import { TypeOrmModule } from '@nestjs/typeorm';
import { Account } from './admin/entities/account.entity';
import { User } from './admin/entities/user.entity';
import { CacheModule } from '@nestjs/cache-manager';
import * as redisStore from 'cache-manager-redis-store';
import { Notification } from './admin/entities/notification.entity';
import { Course } from './instructor/entities/course.entity';
import { ManagerModule } from './manager/manager.module';
import { StudentModule } from './student/student.module';
import { InstructorModule } from './instructor/instructor.module';
import { PdfModule } from './pdf/pdf.module';

@Module({
  imports: [
    CacheModule.register({
      store: redisStore,
      host: 'localhost',
      port: 6379,
      ttl: 0,
    }),
    TypeOrmModule.forRoot({
      type: 'postgres',
      host: 'localhost',
      port: 5432,
      username: 'postgres',
      password: 'tanvir',
      database: 'Project',
      entities: [User, Account, Notification, Course],
      synchronize: true,
    }),
    AuthModule,
    AdminModule,
    MailModule,
    ManagerModule,
    StudentModule,
    InstructorModule,
    PdfModule,
  ],
})
export class AppModule {}
