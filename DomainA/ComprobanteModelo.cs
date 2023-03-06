using System;
using System.IO;
using iTextSharp.text.pdf;
using iTextSharp.text;
using Font = iTextSharp.text.Font;

namespace DomainA
{
    public class ComprobanteModelo
    {
        public string tipoComprobante;
        public string nombreColab;
        public string direccionColab;
        public float debe;
        public float haber;
        public string folderName;
        public string fileName;

        private void pintaLinea(Document PdfDoc)
        {
            Paragraph lineSeparato = new Paragraph(new Chunk(new iTextSharp.text.pdf.draw.LineSeparator(0.75F, 100.0F, BaseColor.BLACK, Element.ALIGN_LEFT, 1)));
            lineSeparato.SetLeading(0.5F, 0.5F);

            PdfDoc.Add(lineSeparato);
        }

        public string generarOrden(string nombre, string direccion, float debe, string fileName, string tipoComprobante, string descrip, string legajo, string fechaMovimiento = null, float haber = 0)
        {
            try
            {
                //string fileName = folderName + "\\" + tipoComprobante + "_" + nombre + "_" + DateTime.Now.ToString("yyyy-MM-dd") + ".pdf";
                Document pdf = new Document();
                PdfWriter pdfWritter = PdfWriter.GetInstance(pdf, new FileStream(fileName, FileMode.Create));
                Font font8 = new Font(FontFactory.GetFont(FontFactory.HELVETICA, 8, iTextSharp.text.Font.NORMAL));
                Font fBold = new Font(FontFactory.GetFont(FontFactory.HELVETICA, 8, iTextSharp.text.Font.BOLD));
                Font fBoldBig = new Font(FontFactory.GetFont(FontFactory.HELVETICA, 12, iTextSharp.text.Font.BOLD));
                PdfPCell cvacio = new PdfPCell(new Phrase(" "));
                cvacio.Border = 0;

                pdf.Open();

                PdfPTable tablaEnca = new PdfPTable(4);
                PdfPCell col0;
                PdfPCell col00;
                PdfPCell col1;
                PdfPCell col2;
                PdfPCell col3;
                PdfPCell col4;
                PdfPCell col5;
                PdfPCell col6;
                int Iline;
                int IRow;

                tablaEnca.WidthPercentage = 95;
                float[] widths = new float[] { 4.0F, 7.0F, 1.0F, 4.0F };
                tablaEnca.SetWidths(widths);

                //Encabezado

                iTextSharp.text.Image logo = iTextSharp.text.Image.GetInstance("Resources/ETRA_Isologotipo-01.png");
                logo.ScaleToFit(110.0F, 140.0F);
                logo.SpacingBefore = 20.0F;
                logo.SpacingAfter = 10.0F;
                logo.SetAbsolutePosition(40, 780);
                pdf.Add(logo);


                tablaEnca.AddCell(cvacio);
                col2 = new PdfPCell(new Phrase("ETRA DISTRIBUCIONES S.R.L. EN FORMACIÓN", fBold));
                col2.Border = 0;
                tablaEnca.AddCell(col2);
                tablaEnca.AddCell(cvacio);

                col3 = new PdfPCell(new Phrase(tipoComprobante, fBold));
                col3.Border = 0;
                tablaEnca.AddCell(col3);
                tablaEnca.AddCell(cvacio);

                col2 = new PdfPCell(new Phrase("Las Heras 555 - Río Tercero - CÓRDOBA", font8));
                col2.Border = 0;
                tablaEnca.AddCell(col2);
                tablaEnca.AddCell(cvacio);




                //col3 = new PdfPCell(new Phrase("Nro: 1111111", fBold));
                //col3.Border = 0;
                tablaEnca.AddCell(cvacio);
                tablaEnca.AddCell(cvacio);
                pdf.Add(tablaEnca);

                pintaLinea(pdf);

                //Colaborador
                PdfPTable tablaColab = new PdfPTable(4);
                float[] widths2 = new float[] { 3.0F, 8.0F, 3.0F, 3.0F };
                tablaColab.SetWidths(widths2);

                tablaColab.WidthPercentage = 95;
                tablaColab.AddCell(cvacio);
                tablaColab.AddCell(cvacio);
                tablaColab.AddCell(cvacio);
                tablaColab.AddCell(cvacio);

                col0 = new PdfPCell(new Phrase("Legajo: ", fBold));
                col0.Border = 0;
                tablaColab.AddCell(col0);

                col00 = new PdfPCell(new Phrase(legajo, font8));
                col00.Border = 0;
                tablaColab.AddCell(col00);

                col1 = new PdfPCell(new Phrase("Fecha Emisión: ", fBold));
                col1.Border = 0;
                tablaColab.AddCell(col1);

                col2 = new PdfPCell(new Phrase(DateTime.Now.ToString("dd/M/yyyy"), font8));
                col2.Border = 0;
                tablaColab.AddCell(col2);

               
                col3 = new PdfPCell(new Phrase("Colaborador: ", fBold));
                col3.Border = 0;
                tablaColab.AddCell(col3);

                col4 = new PdfPCell(new Phrase(nombre, font8));
                col4.Border = 0;
                tablaColab.AddCell(col4);
                

                if (fechaMovimiento != null)
                {
                    col5 = new PdfPCell(new Phrase("Fecha Movimiento: ", fBold));
                    col5.Border = 0;
                    tablaColab.AddCell(col5);

                    col6 = new PdfPCell(new Phrase(fechaMovimiento, font8));
                    col6.Border = 0;
                    tablaColab.AddCell(col6);
                }
                else
                {
                    //Numeor orden de pago:
                    tablaColab.AddCell(cvacio);
                    //Nro
                    tablaColab.AddCell(cvacio);
                }


                col1 = new PdfPCell(new Phrase("Dirección: ", fBold));
                col1.Border = 0;
                tablaColab.AddCell(col1);

                col2 = new PdfPCell(new Phrase(direccion, font8));
                col2.Border = 0;
                tablaColab.AddCell(col2);

                
                


                

                tablaColab.AddCell(cvacio);
                tablaColab.AddCell(cvacio);

                pdf.Add(tablaColab);
                pintaLinea(pdf);
                //Cabecera
                PdfPTable tablaCabe = new PdfPTable(7);
                float[] widths3 = new float[] { 4.0F, 8.0F, 3.0F, 3.0F, 4.0F, 3.0F, 1.0F };
                tablaCabe.WidthPercentage = 95;
                tablaCabe.SetWidths(widths3);

                if (tipoComprobante == "MINUTA CONTABLE")
                {
                    col1 = new PdfPCell(new Phrase("NOMBRE", fBold));
                    col1.Border = 0;
                    tablaCabe.AddCell(col1);
                }
                else
                {
                    col1 = new PdfPCell(new Phrase("CUENTA", fBold));
                    col1.Border = 0;
                    tablaCabe.AddCell(col1);
                }


                col2 = new PdfPCell(new Phrase("DESCRIPCIÓN", fBold));
                col2.Border = 0;
                tablaCabe.AddCell(col2);

                tablaCabe.AddCell(cvacio);

                col3 = new PdfPCell(new Phrase("DEBE", fBold));
                col3.Border = 0;
                tablaCabe.AddCell(col3);


                col4 = new PdfPCell(new Phrase("HABER", fBold));
                col4.Border = 0;
                tablaCabe.AddCell(col4);



                col6 = new PdfPCell(new Phrase("SUB TOTAL", fBold));
                col6.Border = 0;
                col6.HorizontalAlignment = 2;
                tablaCabe.AddCell(col6);

                tablaCabe.AddCell(cvacio);
                pdf.Add(tablaCabe);
                pintaLinea(pdf);
                //Detalle
                PdfPTable tablaDetalle = new PdfPTable(7);
                tablaDetalle.SetWidths(widths3);
                tablaDetalle.WidthPercentage = 95;

                float subtotal = debe + haber;

                if (tipoComprobante == "MINUTA CONTABLE")
                {
                    col1 = new PdfPCell(new Phrase("COLABORADORES", font8));
                    col1.Border = 0;
                    tablaDetalle.AddCell(col1);

                    col2 = new PdfPCell(new Phrase(descrip, font8));
                    col2.Border = 0;
                    tablaDetalle.AddCell(col2);

                    tablaDetalle.AddCell(cvacio);

                    //Aca iria el valor de cada feriado?
                    col3 = new PdfPCell(new Phrase(debe.ToString("0.00"), font8));
                    col3.Border = 0;
                    tablaDetalle.AddCell(col3);

                    col4 = new PdfPCell(new Phrase("0,00", font8));
                    col4.Border = 0;
                    tablaDetalle.AddCell(col4);



                    col6 = new PdfPCell(new Phrase(debe.ToString("0.00"), font8));
                    col6.Border = 0;
                    col6.HorizontalAlignment = 2;
                    tablaDetalle.AddCell(col6);

                    tablaDetalle.AddCell(cvacio);

                    col1 = new PdfPCell(new Phrase("SUELDOS A PAGAR", font8));
                    col1.Border = 0;
                    tablaDetalle.AddCell(col1);

                    col2 = new PdfPCell(new Phrase(descrip, font8));
                    col2.Border = 0;
                    tablaDetalle.AddCell(col2);

                    tablaDetalle.AddCell(cvacio);

                    //Aca iria el valor de cada feriado?
                    col3 = new PdfPCell(new Phrase("0,00", font8));
                    col3.Border = 0;
                    tablaDetalle.AddCell(col3);

                    col4 = new PdfPCell(new Phrase(debe.ToString("0.00"), font8));
                    col4.Border = 0;
                    tablaDetalle.AddCell(col4);



                    col6 = new PdfPCell(new Phrase(subtotal.ToString("0.00"), font8));
                    col6.Border = 0;
                    col6.HorizontalAlignment = 2;
                    tablaDetalle.AddCell(col6);

                    tablaDetalle.AddCell(cvacio);

                }

                else
                {
                    col1 = new PdfPCell(new Phrase("001 - CAJA ADMIN", font8));
                    col1.Border = 0;
                    tablaDetalle.AddCell(col1);

                    col2 = new PdfPCell(new Phrase(descrip, font8));
                    col2.Border = 0;
                    tablaDetalle.AddCell(col2);

                    tablaDetalle.AddCell(cvacio);

                    //Aca iria el valor de cada feriado?
                    col3 = new PdfPCell(new Phrase(debe.ToString("0.00"), font8));
                    col3.Border = 0;
                    tablaDetalle.AddCell(col3);

                    col4 = new PdfPCell(new Phrase(haber.ToString("0.00"), font8));
                    col4.Border = 0;
                    tablaDetalle.AddCell(col4);


                    
                    col6 = new PdfPCell(new Phrase(subtotal.ToString("0.00"), font8));
                    col6.Border = 0;
                    col6.HorizontalAlignment = 2;
                    tablaDetalle.AddCell(col6);

                    tablaDetalle.AddCell(cvacio);

                }
                pdf.Add(tablaDetalle);
                for (IRow = 1; IRow <= 5; IRow++)
                {
                    pdf.Add(new Paragraph("."));
                    Iline = (int)pdfWritter.GetVerticalPosition(true);
                    if (Iline < 200) { break; }

                }

                pintaLinea(pdf);
                //Pie
                PdfPTable tablaPie = new PdfPTable(7);
                float[] widths5 = new float[] { 5.0F, 5.0F, 5.0F, 0.0F, 3.0F, 2.0F, 1.0F };
                tablaPie.SetWidths(widths5);
                tablaPie.WidthPercentage = 95;


                tablaPie.AddCell(cvacio);
                tablaPie.AddCell(cvacio);
                tablaPie.AddCell(cvacio);
                tablaPie.AddCell(cvacio);
                col3 = new PdfPCell(new Phrase("TOTAL: $", font8));
                col3.Border = 0;
                tablaPie.AddCell(col3);

                col4 = new PdfPCell(new Phrase(subtotal.ToString("0.00"), font8));
                col4.Border = 0;
                col4.HorizontalAlignment = 2;
                tablaPie.AddCell(col4);

                tablaPie.AddCell(cvacio);
                col1 = new PdfPCell(new Phrase("______________", font8));
                col1.Border = 0;
                tablaPie.AddCell(col1);

                col2 = new PdfPCell(new Phrase("______________", font8));
                col2.Border = 0;
                tablaPie.AddCell(col2);

                col3 = new PdfPCell(new Phrase("______________", font8));
                col3.Border = 0;
                tablaPie.AddCell(col3);
                tablaPie.AddCell(cvacio);
                tablaPie.AddCell(cvacio);
                tablaPie.AddCell(cvacio);
                tablaPie.AddCell(cvacio);

                col1 = new PdfPCell(new Phrase("FIRMA", font8));
                col1.Border = 0;
                tablaPie.AddCell(col1);

                col2 = new PdfPCell(new Phrase("ACLARACIÓN", font8));
                col2.Border = 0;
                tablaPie.AddCell(col2);

                col3 = new PdfPCell(new Phrase("TIPO Y Nº DOC.", font8));
                col3.Border = 0;
                tablaPie.AddCell(col3);

                tablaPie.AddCell(cvacio);
                tablaPie.AddCell(cvacio);
                tablaPie.AddCell(cvacio);
                tablaPie.AddCell(cvacio);

                pdf.Add(tablaPie);
                pdf.Close();
                return "Archivos generados correctamente";
            }
            catch (Exception ex)
            { return ex.Message; }
            
        }

    }
}
