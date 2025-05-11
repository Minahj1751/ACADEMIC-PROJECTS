import { Entity, PrimaryGeneratedColumn, Column, BeforeInsert, OneToOne, BeforeUpdate, OneToMany } from 'typeorm';
import { Account } from './account.entity';
import * as bcrypt from 'bcryptjs';
import { Course } from 'src/instructor/entities/course.entity';

@Entity()
export class User {
  @PrimaryGeneratedColumn()
  id: number;

  @Column({ unique: true })
  email: string;

  @Column()
  password: string;

  @Column()
  name: string;

  @Column({ nullable: true })
  phonenumber: string;

  @Column({ nullable: true, type: 'varchar' })
  resetToken: string | null;

  @Column({ nullable: true, type: 'timestamp' })
  resetTokenExpiry: Date | null;

  @OneToMany(() => Course, course => course.user)
  courses: Course[];

  @OneToOne(() => Account, account => account.user)
  account: Account;


  @BeforeInsert()
  @BeforeUpdate()
  async hashPassword() {
    if (this.password) {
      this.password = await bcrypt.hash(this.password, 10);
    }
  }

  async comparePassword(attempt: string): Promise<boolean> {
    return await bcrypt.compare(attempt, this.password);
  }
}