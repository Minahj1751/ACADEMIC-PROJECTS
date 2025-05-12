import { Controller, Post, Body, Get, UseGuards, Req, UnauthorizedException } from '@nestjs/common';
import { InstructorService } from './instructor.service';
import { CreateCourseDto } from './dtos/create-course.dto';
import { RolesGuard } from 'src/auth/guards/roles.guard';
import { Request } from 'express';
import { User } from 'src/admin/entities/user.entity';
import { Roles } from '../shared/decorators/roles.decorator';
import { Role } from '../shared/constants/roles.constants';
import { AuthGuard } from '@nestjs/passport';
import { Res, Param } from '@nestjs/common';
import { Response } from 'express';
import { JwtPayload } from 'src/auth/interfaces/jwt-payload.interface';

@Controller('instructor')
@UseGuards(AuthGuard('jwt'))
export class InstructorController {
  constructor(private readonly instructorService: InstructorService) {}


  @Post('createCourse')
@Roles(Role.INSTRUCTOR)
@UseGuards(AuthGuard('jwt'), RolesGuard)
async createCourse(
  @Req() req: Request,
  @Body() createCourseDto: CreateCourseDto
) {
  const user = req.user as JwtPayload;
  
  if (!user || !user.id) {
    throw new UnauthorizedException('Invalid user credentials');
  }

  return this.instructorService.createCourse(user.id, createCourseDto);
}
  @Get('allcourse')
  @Roles(Role.INSTRUCTOR)
  async getCourses(@Req() req: Request) {
    const user = (req as any).user as User;
    if (!user) {
      throw new UnauthorizedException('User not authenticated');
    }
    return this.instructorService.getInstructorCourses(user);
  }

  @Get('course/:id/pdf')
  @Roles(Role.INSTRUCTOR)
  async downloadCoursePdf(@Param('id') id: string, @Res() res: Response) {
  return this.instructorService.downloadCoursePdf(Number(id), res);
}
}