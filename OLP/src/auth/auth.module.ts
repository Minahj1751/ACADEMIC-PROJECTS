import { Module, forwardRef } from '@nestjs/common';
import { JwtModule } from '@nestjs/jwt';
import { TypeOrmModule } from '@nestjs/typeorm';
import { User } from '../admin/entities/user.entity';
import { Account } from '../admin/entities/account.entity';
import { AuthService } from './auth.service';
import { AuthController } from './auth.controller';
import { JwtStrategy } from './strategies/jwt.strategy';
import { AdminModule } from '../admin/admin.module';
import { MailModule } from '../mail/mail.module';
import { CacheModule } from '@nestjs/cache-manager';
import * as redisStore from 'cache-manager-redis-store';

@Module({
  imports: [
    CacheModule.register({
  store: redisStore,
  host: 'localhost', // Redis host
  port: 6379, // Redis port
  ttl: 3600, // Global TTL for cache (set a default for cache items)
}),
    TypeOrmModule.forFeature([User, Account]),
    JwtModule.register({
      secret: 'secret',
      signOptions: { expiresIn: '1h' },
    }),
    forwardRef(() => AdminModule),
    MailModule,
  ],
  providers: [AuthService, JwtStrategy],
  controllers: [AuthController],
})
export class AuthModule {}
