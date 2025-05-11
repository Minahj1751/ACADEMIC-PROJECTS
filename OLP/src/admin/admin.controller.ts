import { Controller, Get, Post, Body, Param, Patch, UseGuards, ParseIntPipe, BadRequestException, Req, ForbiddenException } from '@nestjs/common';
import { AdminService } from './admin.service';
import { CreateAccountDto } from './dto/create-account.dto';
import { AuthGuard } from '@nestjs/passport';
import { Request } from 'express';
import { Roles } from '../shared/decorators/roles.decorator';
import { Role } from '../shared/constants/roles.constants';
import { JwtPayload } from 'src/auth/interfaces/jwt-payload.interface';

@Controller('admin')
@UseGuards(AuthGuard('jwt'))
export class AdminController {
  constructor(private readonly adminService: AdminService) {}

  @Get()
  @Roles(Role.ADMIN)
  async findAll() {
    return this.adminService.findAllUsers();
  }

  @Get(':id')
  @Roles(Role.ADMIN)
  async findOne(@Param('id', ParseIntPipe) id: number) { 
    return this.adminService.findUserById(id);
  }

  @Post('account')
  @Roles(Role.ADMIN)
  async createAccount(
    @Body() createAccountDto: CreateAccountDto,
    @Req() req: Request & { user: JwtPayload },
  ) {
    if (req.user.role !== Role.ADMIN) {
      throw new ForbiddenException('Only admins can create accounts');
    }
    return this.adminService.createAccount(createAccountDto, req.user.id);
  }

  @Patch('account/:id/status')
  @Roles(Role.ADMIN)
  async updateAccountStatus(
    @Param('id', ParseIntPipe) id: number,
    @Body('isActive') isActive: boolean,
    @Req() req: Request & { user: JwtPayload },
  ) {
    if (req.user.role !== Role.ADMIN) {
      throw new ForbiddenException('Only admins can update account status');
    }
    return this.adminService.updateAccountStatus(id, isActive, req.user.id);
  }
  @Get('notification/:id')
  async getNotificationMessage(@Param('id') id: string) {
    const notificationId = parseInt(id, 10);
    if (isNaN(notificationId)) {
      throw new BadRequestException('Invalid notification ID');
    }
    return this.adminService.getNotificationMessage(notificationId);
  }

  @Patch('course/:id/approve')
  @Roles(Role.ADMIN)
  async approveCourse(
  @Param('id', ParseIntPipe) id: number,
  @Req() req: Request & { user: JwtPayload },
) {
  if (req.user.role !== Role.ADMIN) {
    throw new ForbiddenException('Only admins can approve courses');
  }
  return this.adminService.approveCourse(id, req.user.id);
}



} 