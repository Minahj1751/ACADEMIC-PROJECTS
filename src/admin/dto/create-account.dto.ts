import { IsString, IsDateString, IsBoolean, IsInt } from 'class-validator';

export class CreateAccountDto {
  @IsInt()
  userId: number;

  @IsString()
  role: string;

  @IsDateString()
  joinDate: Date;

  @IsBoolean()
  isActive: boolean;
}