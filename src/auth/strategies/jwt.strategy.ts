import { Injectable, UnauthorizedException } from '@nestjs/common';
import { PassportStrategy } from '@nestjs/passport';
import { ExtractJwt, Strategy } from 'passport-jwt';
import { AuthService } from '../auth.service';
import { CACHE_MANAGER } from '@nestjs/cache-manager';
import { Inject } from '@nestjs/common';
import { Cache } from 'cache-manager';
import { Request } from 'express';

@Injectable()
export class JwtStrategy extends PassportStrategy(Strategy) {
  constructor(
    private authService: AuthService,
    @Inject(CACHE_MANAGER) private cacheManager: Cache,
  ) {
    super({
      jwtFromRequest: ExtractJwt.fromAuthHeaderAsBearerToken(),
      ignoreExpiration: false,
      secretOrKey: 'secret',
      passReqToCallback: true,
    });
  }

async validate(req: Request, payload: any) {
  const token = req.headers?.authorization?.split(' ')[1];
  
  if (!token) {
    throw new UnauthorizedException('Token not found');
  }

  const isBlacklisted = await this.cacheManager.get(`blacklist_${token}`);
  if (isBlacklisted) {
    throw new UnauthorizedException('Token has been invalidated');
  }

  return {
    id: payload.id,
    email: payload.email,
    role: payload.role
  };
}



}