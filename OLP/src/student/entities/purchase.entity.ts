import { Entity, PrimaryGeneratedColumn, ManyToOne, Column, CreateDateColumn } from 'typeorm';
import { Student } from './student.entity';
import { Course } from 'src/instructor/entities/course.entity';

@Entity()
export class Purchase {
  @PrimaryGeneratedColumn()
  id: number;

  @ManyToOne(() => Student, (student) => student.purchases)
  student: Student;

 // @ManyToOne(() => Course, (course) => course.purchases)
 // course: Course;

  @CreateDateColumn()
  purchasedAt: Date;

  @Column({ default: false })
  quizPassed: boolean;
}
