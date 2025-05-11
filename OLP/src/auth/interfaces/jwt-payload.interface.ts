import { Role } from '../../shared/constants/roles.constants';
export interface JwtPayload {
  id: number;
  email: string;
  role: Role;
}