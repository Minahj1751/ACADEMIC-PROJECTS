import { Injectable } from '@nestjs/common';
import { InjectRepository } from '@nestjs/typeorm';
import { Repository } from 'typeorm';
import { Course } from 'src/instructor/entities/course.entity';
import { CreateCourseDto } from './dtos/create-course.dto';
import { User } from 'src/admin/entities/user.entity';
import { PdfService } from 'src/pdf/pdf.service';
import { Response } from 'express';

@Injectable()
export class InstructorService {
  constructor(
    @InjectRepository(Course)
    private readonly courseRepository: Repository<Course>,
    private readonly pdfService: PdfService,
  ) {}


  async createCourse(userId: number, createCourseDto: CreateCourseDto) {
    const course = this.courseRepository.create({
      ...createCourseDto,
      userId,
      status: 'pending',
      createdAt: new Date(),
      updatedAt: new Date()
    });
    
    return await this.courseRepository.save(course);
  }
  

async getInstructorCourses(user: User) {
  return this.courseRepository.find({
    where: { user: { id: user.id } },
    relations: ['instructor'] 
  });
}

async downloadCoursePdf(courseId: number, res: Response) {
  const course = await this.courseRepository.findOne({ where: { id: courseId }, relations: ['user'] });

  if (!course) {
    throw new Error('Course not found');
  }

  const title = `Course_${course.title}`;
  const content = `Title: ${course.title}\nDescription: ${course.description}\nInstructor: ${course.user.name}`;

  this.pdfService.generate(res, title, content);
}

}