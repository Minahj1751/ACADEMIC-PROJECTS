import { Injectable, NotFoundException } from '@nestjs/common';
import { InjectRepository } from '@nestjs/typeorm';
import { Repository } from 'typeorm';
import { Notification } from 'src/admin/entities/notification.entity';
import { ApproveRejectCourseDto } from './dto/content-moderation.dto';
import { User } from 'src/admin/entities/user.entity';
import { Course } from 'src/instructor/entities/course.entity';

@Injectable()
export class ManagerService {
  constructor(
    @InjectRepository(Course)
    private readonly courseRepository: Repository<Course>,
    @InjectRepository(Notification)
    private readonly notificationRepository: Repository<Notification>,
    @InjectRepository(User)
    private readonly userRepository: Repository<User>,
   
  ) {}
  
  async approveCourse(approvalData: ApproveRejectCourseDto) {
    const course = await this.courseRepository.findOne({
      where: { id: approvalData.courseId },
      relations: ['instructor'],
    });

    if (!course) {
      throw new NotFoundException('Course not found');
    }

    course.status = 'approved';
    const updatedCourse = await this.courseRepository.save(course);
    return updatedCourse;
  }

  async rejectCourse(rejectionData: ApproveRejectCourseDto) {
    const course = await this.courseRepository.findOne({
      where: { id: rejectionData.courseId },
      relations: ['instructor'],
    });

    if (!course) {
      throw new NotFoundException('Course not found');
    }

    course.status = 'rejected';
    const updatedCourse = await this.courseRepository.save(course);
    return updatedCourse;
  }

  async getPendingCourses() {
    return this.courseRepository.find({
      where: { status: 'pending' },
      relations: ['instructor'],
      order: { createdAt: 'DESC' },
    });
  }

  async getCourseDetails(courseId: number) {
    return this.courseRepository.findOne({
      where: { id: courseId },
      relations: ['instructor']
    });
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
}