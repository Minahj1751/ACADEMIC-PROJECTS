import { Entity, PrimaryGeneratedColumn, Column } from 'typeorm';

@Entity('notifications')
export class Notification {
  @PrimaryGeneratedColumn()
  id: number;

  @Column({ name: 'userId', nullable:false})
  userId: number;

  @Column({nullable:false})
  message: string;

  @Column({ name: 'isRead', default: false })
  isRead: boolean;

  @Column({nullable:false})
  type: string;

  @Column({ name: 'createdAt', type: 'timestamp', default: () => 'CURRENT_TIMESTAMP' })
  createdAt: Date;
}