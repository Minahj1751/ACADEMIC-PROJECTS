import { Entity, PrimaryGeneratedColumn, Column,JoinColumn, ManyToOne } from 'typeorm';
import { User } from './user.entity';

@Entity()
export class Account {
  @PrimaryGeneratedColumn()
  id: number;

  @Column({ default: false })
  isActive: boolean;

  @Column({ type: 'varchar', length: 20 })
  role: string; // 'admin', 'manager', 'instructor', 'student'

  @Column({ type: 'timestamp', default: () => 'CURRENT_TIMESTAMP' })
  joinDate: Date;

  @ManyToOne(() => User, user => user.account)
  
  @JoinColumn({ name: 'userid' }) 
  user: User;
    static isActive: any;
}