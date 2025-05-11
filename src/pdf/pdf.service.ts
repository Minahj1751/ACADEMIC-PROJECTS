import { Injectable } from '@nestjs/common';
import * as PDFDocument from 'pdfkit';
import { Response } from 'express';

@Injectable()
export class PdfService {
  generate(res: Response, title: string, content: string) {
    const doc = new PDFDocument();

    res.setHeader('Content-Type', 'application/pdf');
    res.setHeader('Content-Disposition', `attachment; filename=${title}.pdf`);

    doc.pipe(res);

    doc.fontSize(20).text(title, { align: 'center' });
    doc.moveDown();
    doc.fontSize(14).text(content);

    doc.end();
  }
}
