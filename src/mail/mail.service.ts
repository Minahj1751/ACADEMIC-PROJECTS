import { Injectable, Logger } from '@nestjs/common';
import { MailerService } from '@nestjs-modules/mailer';
import { User } from '../admin/entities/user.entity';

@Injectable()
export class MailService {
  private readonly logger = new Logger(MailService.name);
  constructor(private readonly mailerService: MailerService) {}

  async sendUserConfirmation(user: User, token: string): Promise<void> {
    const url = `http://localhost:3000/auth/confirm?token=${token}`;
    try {
      await this.mailerService.sendMail({
        to: user.email,
        subject: 'Welcome to Our App! Please Confirm Your Email',
        text: `Welcome ${user.name}!
        Please confirm your email by visiting this link: ${url}
        This link will expire in 24 hours.
        If you didn't request this, please ignore this email.
        `.trim(),
      });
      this.logger.log(`Confirmation email sent to ${user.email}`);
    } catch (error) {
      this.logger.error(`Failed to send confirmation email to ${user.email}`, error.stack);
      throw new Error('Failed to send confirmation email');
    }
  }

  async sendUserApproval(email: string, data: { name: string; role: string; isActive: string }): Promise<void> {
    try {
      console.log("[MailService] Sending approval email to:", email);
      await this.mailerService.sendMail({
        to:email,
        subject: 'Account Approved Successfully',
        text: `Hello ${data.name},
        Your account has been approved with the following details:
        - Role: ${data.role}
        - Status: ${data.isActive}
        You can now login to your account.
        Thank you,
        The Support Team
        `.trim(),
      });
      this.logger.log(`Approval email sent to ${email}`);
    } catch (error) {
      this.logger.error(`Failed to send approval email to ${email}`, error.stack);
      throw new Error('Failed to send approval email');
    }
    console.log("Sending approval email to:", email);
  }

  async sendMail(mailOptions: {
    to: string;
    subject: string;
    text: string;
    html?: string;
  }): Promise<void> {
    await this.mailerService.sendMail({
      to: mailOptions.to,
      subject: mailOptions.subject,
      text: mailOptions.text,
      html: mailOptions.html,
    });
  }

  async sendPasswordChangeConfirmation(email: string): Promise<void> {
    try {
      await this.mailerService.sendMail({
        to: email,
        subject: 'Password Changed Successfully',
        text:`Password Update Confirmation
              Your password was successfully changed.
              If you didn't make this change, please contact support immediately.
              Security Team
        `.trim(),
      });
      this.logger.log(`Password change confirmation sent to ${email}`);
    } catch (error) {
      this.logger.error(`Failed to send password change confirmation to ${email}`, error.stack);
      throw new Error('Failed to send password change confirmation');
    }
  }

  async sendAccountStatusChangeEmail(to: string, context: { name: string; isActive: boolean }): Promise<void> {
    const status = context.isActive ? 'Active' : 'Inactive';
    
    try {
      await this.mailerService.sendMail({
        to,
        subject: 'Account Status Updated',
        text:`Hello ${context.name},
              Your account status has been changed to: ${status}
${
  context.isActive 
    ? 'You can now access all system features.' 
    : 'You will no longer be able to access the system until your account is reactivated.'
}

If you have any questions, please contact support.

Best regards,
Account Management Team
        `.trim(),
      });
      this.logger.log(`Account status notification sent to ${to}`);
    } catch (error) {
      this.logger.error(`Failed to send account status notification to ${to}`, error.stack);
      throw new Error('Failed to send account status notification');
    }
  }

  async sendCourseApprovalNotification(email: string, data: { name: string; courseTitle: string }) {
    console.log(`Sending course approval email to ${email}`);
  }
  

  
}