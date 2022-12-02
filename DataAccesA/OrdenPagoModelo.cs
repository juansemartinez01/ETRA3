using System;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Resources;
namespace DataAccesA
{
    public class OrdenPagoModelo
    {
        public void generarOrden(PrintPageEventArgs e, string nombre, string apellido, string direccion, float saldoCtaCte, float sueldoNeto, string descipcion) 
        {
            Font font = new Font("Arial", 11);
            int ancho = 800;
            int y = 70;
            Bitmap original = (Bitmap)Image.FromFile("Resources/ETRA_Isologotipo-01.png");
            Bitmap resized = new Bitmap(original, new Size(original.Width / 20, original.Height / 20));
            e.Graphics.DrawImage(resized, 10, 0);

            e.Graphics.DrawRectangle(new Pen(Color.Black), 10, y + 10, ancho, 90);
            e.Graphics.DrawString("ORDEN DE PAGO Nº: ", font, Brushes.Black, new RectangleF(460, y + 20, ancho, 30));
            e.Graphics.DrawString("Original", font, Brushes.Black, new RectangleF(10, y + 20, ancho, 30));
            e.Graphics.DrawString("Colaborador: " + nombre + " " + apellido, font, Brushes.Black, new RectangleF(10, y + 50, ancho, 30));
            e.Graphics.DrawString("Dir: " + direccion, font, Brushes.Black, new RectangleF(10, y + 80, ancho, 30));
            e.Graphics.DrawString("Fecha: " + DateTime.Now.ToString(), font, Brushes.Black, new RectangleF(460, y + 50, ancho, 30)); ;

            e.Graphics.DrawString("Saldo Cta Cte: " + saldoCtaCte.ToString(), font, Brushes.Black, new RectangleF(10, y + 110, ancho, 30));

            e.Graphics.DrawRectangle(new Pen(Color.Black), 10, y + 130, ancho, 20);
            e.Graphics.DrawString("Cuenta", font, Brushes.Black, new RectangleF(10, y + 130, ancho, 30));
            e.Graphics.DrawString("001 - CAJA ADMIN", font, Brushes.Black, new RectangleF(10, y + 160, ancho, 30));
            e.Graphics.DrawString("Debe", font, Brushes.Black, new RectangleF(460, y + 130, ancho, 30));
            e.Graphics.DrawString(sueldoNeto.ToString(), font, Brushes.Black, new RectangleF(460, y + 160, ancho, 30));
            e.Graphics.DrawString("Haber", font, Brushes.Black, new RectangleF(610, y + 130, ancho, 30));
            e.Graphics.DrawString("0,00", font, Brushes.Black, new RectangleF(610, y + 160, ancho, 30));

            e.Graphics.DrawRectangle(new Pen(Color.Black), 10, y + 250, ancho, 20);
            e.Graphics.DrawString("TOTAL: $" + sueldoNeto.ToString(), font, Brushes.Black, new RectangleF(610, y + 250, ancho, 30));

            e.Graphics.DrawString("Notas: " + descipcion, font, Brushes.Black, new RectangleF(10, y + 300, ancho, 30));
            e.Graphics.DrawString("Recibí conforme de ETRA DISTRIBUCIONES S.R.L. EN FORMACIÓN EL IMPORTE EN PESOS:__________ ", font, Brushes.Black, new RectangleF(10, y + 330, ancho + 100, 50));

            e.Graphics.DrawString("___________________", font, Brushes.Black, new RectangleF(10, y + 390, ancho, 30));
            e.Graphics.DrawString("FIRMA", font, Brushes.Black, new RectangleF(10, y + 420, ancho, 30));

            e.Graphics.DrawString("___________________", font, Brushes.Black, new RectangleF(260, y + 390, ancho, 30));
            e.Graphics.DrawString("ACLARACIÓN", font, Brushes.Black, new RectangleF(260, y + 420, ancho, 30));

            e.Graphics.DrawString("___________________", font, Brushes.Black, new RectangleF(510, y + 390, ancho, 30));
            e.Graphics.DrawString("TIPO Y NRO DE DOC.", font, Brushes.Black, new RectangleF(510, y + 420, ancho, 30));


        }
    }
}
