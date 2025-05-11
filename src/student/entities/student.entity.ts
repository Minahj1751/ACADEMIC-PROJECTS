import { Entity, PrimaryGeneratedColumn, Column, OneToMany } from 'typeorm';
import { Purchase } from './purchase.entity';

@Entity()
export class Student {
  @PrimaryGeneratedColumn()
  id: number;

  @Column()
  name: string;

  @Column({ unique: true })
  email: string;

  @Column()
  password: string;

  @Column({ default: 'Student' })
  role: string;

  @Column({ default: true })
  isActive: boolean;

  @OneToMany(() => Purchase, (purchase) => purchase.student)
  purchases: Purchase[];
}
