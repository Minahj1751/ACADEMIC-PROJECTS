import { Injectable } from '@nestjs/common';

@Injectable()
export class StudentService {
  getHello(): string {
    return 'This is User Dashboard';
  }
}
