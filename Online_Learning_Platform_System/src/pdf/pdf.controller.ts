import { Controller, Get, Query, Res } from '@nestjs/common';
import { Response } from 'express';
import { PdfService } from './pdf.service';

@Controller('pdf')
export class PdfController {
  constructor(private readonly pdfService: PdfService) {}

  @Get('download')
  downloadPdf(
    @Query('title') title: string,
    @Query('content') content: string,
    @Res() res: Response
  ) {
    this.pdfService.generate(res, title || 'example', content || 'This is the PDf file.');
  }
}
