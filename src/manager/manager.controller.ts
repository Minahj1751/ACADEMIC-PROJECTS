import { BadRequestException, Body, Controller, Get, Param, Post, UseGuards } from "@nestjs/common";
import { ApproveRejectCourseDto } from "./dto/content-moderation.dto";
import { AuthGuard } from "@nestjs/passport";
import { ManagerService } from "./manager.service";
import { Roles } from "src/shared/decorators/roles.decorator";
import { Role } from "src/shared/constants/roles.constants";

@Controller('manager')
@UseGuards(AuthGuard('jwt'))
export class ManagerController {
  constructor(private readonly managerService: ManagerService) {}

  @Post('approve-course')
   @Roles(Role.MANAGER)
  async approveCourse(@Body() approvalData: ApproveRejectCourseDto) {
    return this.managerService.approveCourse(approvalData);
  }
  

  @Post('reject-course')
  @Roles(Role.MANAGER)
  async rejectCourse(@Body() rejectionData: ApproveRejectCourseDto) {
    return this.managerService.rejectCourse(rejectionData);
  }

  @Get('pending-courses')
  @Roles(Role.MANAGER)
  async getPendingCourses() {
    return this.managerService.getPendingCourses();
  }

  @Get(':id')
  @Roles(Role.MANAGER)
  async getCourseDetails(@Param('id') id: string) {
    const courseId = parseInt(id, 10);
    if (isNaN(courseId)) {
      throw new BadRequestException('Invalid course ID');
    }
    return this.managerService.getCourseDetails(courseId);
  }

  @Get('notification/:id')
  async getNotificationMessage(@Param('id') id: string) {
    const notificationId = parseInt(id, 10);
    if (isNaN(notificationId)) {
      throw new BadRequestException('Invalid notification ID');
    }
    return this.managerService.getNotificationMessage(notificationId);
  }
}
