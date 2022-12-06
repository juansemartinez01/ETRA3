using DomainA;
using System;
using System.Data;
using System.Drawing.Printing;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System.IO;
using Font = iTextSharp.text.Font;

namespace PresentationA.Colaboradores
{
    public partial class frmSalarios : frmHijo
    {
        Salario sal = new Salario();
        ColaboradorModelo colaboradorModelo = new ColaboradorModelo();
        int auxiliar = 0;
        public frmSalarios()
        {
            InitializeComponent();
            CargarTabla(1,"","",0,0);
            LlenarCombo(cmbModificarSalarioCargo, DataManager.GetInstance().ConsultaSQL("SELECT * FROM Cargo WHERE borradoLogico = 0"), "nombre", "id_cargo");
            LlenarCombo(cmbCargoPorcentaje, DataManager.GetInstance().ConsultaSQL("SELECT * FROM Cargo WHERE borradoLogico = 0"), "nombre", "id_cargo");
            LlenarCombo(cmbFiltroCargo, DataManager.GetInstance().ConsultaSQL("SELECT * FROM Cargo WHERE borradoLogico = 0"), "nombre", "id_cargo");

        }
        private void LlenarCombo(ComboBox cbo, Object source, string display, String value)
        {
            cbo.ValueMember = value;
            cbo.DisplayMember = display;
            cbo.DataSource = source;
            cbo.SelectedIndex = -1;
        }
        public void CargarTabla(int legajo,string nombre,string apellido, float monto, int cargo)
        {
            dgvSalarios.Rows.Clear();
            DataTable salarios = new DataTable();
            salarios = sal.getAllSalarios(legajo,nombre,apellido,monto,cargo);
            for (int i = 0; i < salarios.Rows.Count; i++)
            {
                //crear metodo completar labels
                dgvSalarios.Rows.Add(salarios.Rows[i]["legajo"], salarios.Rows[i]["nombre"], salarios.Rows[i]["apellido"], salarios.Rows[i]["monto"], salarios.Rows[i]["fechaInicio"]);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if(txtLegajoColaboradorModificacion.Text == "")
            {
                MessageBox.Show("Debe ingresar un legajo para modificar un salario");
                return;
            }
            if(txtMontoModificacion.Text == "")
            {
                MessageBox.Show("Debe ingresar un monto para modificar un salario");
                return;
            }
            DataTable colaboradorAModificar = colaboradorModelo.BuscarColaborador(txtLegajoColaboradorModificacion.Text, "", "");
            if(colaboradorAModificar.Rows.Count > 0)
            {
                string respuesta = sal.modificarSalarioColaborador(int.Parse(txtLegajoColaboradorModificacion.Text), float.Parse(txtMontoModificacion.Text));
                MessageBox.Show(respuesta);
                CargarTabla(1, "", "", 0, 0);
                LimpiarCampos();
                return;
                
            }
            MessageBox.Show("El legajo del colaborador que solicita no existe o ha sido eliminado");
            LimpiarCampos();
        }
        private void LimpiarCampos()
        {
            txtLegajoColaboradorModificacion.Text = "";
            txtMontoModificacion.Text = "";
            cmbModificarSalarioCargo.SelectedIndex = -1;
            txtMontoModificarSalarioCargo.Text = "";
            txtApellidoBusqueda.Text = "";
            txtLegajoBusqueda.Text = "";
            txtPorcentaje.Text = "";
            cmbCargoPorcentaje.SelectedIndex = -1;
            cmbFiltroCargo.SelectedIndex = -1;
            txtMontoBusqueda.Text = "";
            txtNombreBusqueda.Text = "";
        }

        private void btnAplicar_Click(object sender, EventArgs e)
        {
            int legajo = 1;
            string nombre = "";
            string apellido = "";
            float monto = 0;
            int cargo = 0;
            if(txtLegajoBusqueda.Text != "")
            {
                legajo = int.Parse(txtLegajoBusqueda.Text);
            }
            if(txtNombreBusqueda.Text != "")
            {
                nombre = txtNombreBusqueda.Text;
            }
            if(txtApellidoBusqueda.Text != "")
            {
                apellido = txtApellidoBusqueda.Text;
            }
            if(txtMontoBusqueda.Text != "")
            {
                monto = float.Parse(txtMontoBusqueda.Text);
            }
            if(cmbFiltroCargo.SelectedIndex != -1)
            {
                cargo = int.Parse(cmbFiltroCargo.SelectedValue.ToString());
            }
            CargarTabla(legajo,nombre, apellido, monto, cargo);
        }


        private void btnExportar_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            excel.Application.Workbooks.Add(true);
            int icol = 0;
            int irow = 0;
            foreach (DataGridViewColumn col in dgvSalarios.Columns)
            {
                icol++;
                excel.Cells[1, icol] = col.Name;
                foreach (DataGridViewRow row in dgvSalarios.Rows)
                {
                    irow++;
                    excel.Cells[irow + 1, icol] = row.Cells[col.Name].Value;
                }
                irow = 0;
            }

            excel.Visible = true;
        }

        private void btnModificarSalariosCargo_Click(object sender, EventArgs e)
        {
            if(txtMontoModificarSalarioCargo.Text == "" || cmbModificarSalarioCargo.SelectedIndex == -1)
            {
                MessageBox.Show("Debe completar ambos campos para poder modificar");
                LimpiarCampos();
                return;
            }
            else
            {
                string mensaje = sal.modificarSalariosDeCargo(int.Parse(cmbModificarSalarioCargo.SelectedValue.ToString()), float.Parse(txtMontoModificarSalarioCargo.Text.ToString()));
                MessageBox.Show(mensaje);
                LimpiarCampos();
                CargarTabla(1,"","",0,0);
            }
            
        }

        private void btnPorcentaje_Click(object sender, EventArgs e)
        {
            if(txtPorcentaje.Text == "" || cmbCargoPorcentaje.SelectedIndex == -1)
            {
                MessageBox.Show("Debe completar ambos campos para poder modificar");
                LimpiarCampos();
                return;
            }
            else
            {
                string mensaje = sal.modificarSalariosCargoPorcentaje(int.Parse(cmbCargoPorcentaje.SelectedValue.ToString()), float.Parse(txtPorcentaje.Text.ToString()));
                MessageBox.Show(mensaje);
                LimpiarCampos();
                CargarTabla(1, "", "", 0, 0);
            }
        }

        private void txtLegajoBusqueda_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void txtMontoBusqueda_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void txtLegajoColaboradorModificacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void txtMontoModificarSalarioCargo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void txtPorcentaje_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void txtMontoModificacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void cmbFiltroCargo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cmbModificarSalarioCargo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cmbCargoPorcentaje_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            CargarTabla(1, "", "", 0, 0);
        }

        private void btnGenerarOrdenes_Click(object sender, EventArgs e)
        {
            if (txtDescripcionComprobante.Text == "")
            {
                MessageBox.Show("Debe ingresar una descripcion");
                return;
            }
            
            DataTable salarios = new DataTable();
            salarios = sal.getAllSalarios(1, "", "", 0, 0);
            MessageBox.Show("Por favor, a continuación, seleccione una carpeta para guardar los comprobantes");
            var folderBrowserDialog1 = new FolderBrowserDialog();
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result != DialogResult.OK) { return; }
            string folderName = folderBrowserDialog1.SelectedPath;
            //Este loop va a buscar todos los datos necesarios para cada comprobante, para cada colaborador
            for (int i = 0; i < salarios.Rows.Count; i++)
            {
                int legajoColaborador = (int)salarios.Rows[i]["legajo"];
                DataTable colab = colaboradorModelo.BuscarColaborador(legajoColaborador.ToString(), salarios.Rows[i]["nombre"].ToString(), salarios.Rows[i]["apellido"].ToString());
                string nombreColaborador = salarios.Rows[i]["nombre"].ToString() + " " + salarios.Rows[i]["apellido"].ToString();
                float salarioColaborador = float.Parse(salarios.Rows[i]["monto"].ToString());
                //Aca iria el codigo que genere cada Orden de pago de cada colaborador, los datos que varian son los que estan arriba.
                generarOrden(nombreColaborador, colab.Rows[0]["nombreCalle"] + " " + colab.Rows[0]["numeroCalle"], salarioColaborador, folderName);
            }


        }

        private void pintaLinea(Document PdfDoc)
        {
            Paragraph lineSeparato = new Paragraph(new Chunk(new iTextSharp.text.pdf.draw.LineSeparator(0.75F, 100.0F, BaseColor.BLACK, Element.ALIGN_LEFT, 1)));
            lineSeparato.SetLeading(0.5F, 0.5F);

            PdfDoc.Add(lineSeparato);
        }

        private void generarOrden(string nombre, string direccion, float debe, string folderName)
        {

            
            string fileName = folderName + "\\OrdenDePago_" + nombre + "_" + DateTime.Now.ToString("yyyy-MM-dd") + ".pdf";
            Document pdf = new Document();
            PdfWriter pdfWritter = PdfWriter.GetInstance(pdf, new FileStream(fileName, FileMode.Create));
            Font font8 = new Font(FontFactory.GetFont(FontFactory.HELVETICA, 8, iTextSharp.text.Font.NORMAL));
            Font fBold = new Font(FontFactory.GetFont(FontFactory.HELVETICA, 8, iTextSharp.text.Font.BOLD));
            Font fBoldBig = new Font(FontFactory.GetFont(FontFactory.HELVETICA, 12, iTextSharp.text.Font.BOLD));
            PdfPCell cvacio = new PdfPCell(new Phrase(" "));
            cvacio.Border = 0;

            pdf.Open();

            PdfPTable tablaEnca = new PdfPTable(4);
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

            col3 = new PdfPCell(new Phrase("ORDEN DE PAGO", fBold));
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
            float[] widths2 = new float[] { 3.0F, 8.0F, 3.0F, 2.0F };
            tablaColab.SetWidths(widths2);

            tablaColab.WidthPercentage = 95;
            tablaColab.AddCell(cvacio);
            tablaColab.AddCell(cvacio);
            tablaColab.AddCell(cvacio);
            tablaColab.AddCell(cvacio);
            col1 = new PdfPCell(new Phrase("Colaborador: ", fBold));
            col1.Border = 0;
            tablaColab.AddCell(col1);

            col2 = new PdfPCell(new Phrase(nombre, font8));
            col2.Border = 0;
            tablaColab.AddCell(col2);

            col3 = new PdfPCell(new Phrase("Fecha Emisión: ", fBold));
            col3.Border = 0;
            tablaColab.AddCell(col3);

            col4 = new PdfPCell(new Phrase(DateTime.Now.ToString("dd/M/yyyy"), font8));
            col4.Border = 0;
            tablaColab.AddCell(col4);

            tablaColab.AddCell(cvacio);
            tablaColab.AddCell(cvacio);

            //Numeor orden de pago:
            tablaColab.AddCell(cvacio);
            //Nro
            tablaColab.AddCell(cvacio);

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
            float[] widths3 = new float[] { 3.0F, 8.0F, 3.0F, 3.0F, 3.0F, 3.0F, 1.0F };
            tablaCabe.WidthPercentage = 95;
            tablaCabe.SetWidths(widths3);


            col1 = new PdfPCell(new Phrase("CUENTA", fBold));
            col1.Border = 0;
            tablaCabe.AddCell(col1);

            col2 = new PdfPCell(new Phrase("DESCRIPCIÓN", fBold));
            col2.Border = 0;
            tablaCabe.AddCell(col2);

            tablaCabe.AddCell(cvacio);

            col3 = new PdfPCell(new Phrase("DEBE", font8));
            col3.Border = 0;
            tablaCabe.AddCell(col3);


            col4 = new PdfPCell(new Phrase("HABER", font8));
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
            float[] widths4 = new float[] { 3.0F, 8.0F, 3.0F, 3.0F, 3.0F, 3.0F, 1.0F };
            tablaDetalle.SetWidths(widths4);
            tablaDetalle.WidthPercentage = 95;

            col1 = new PdfPCell(new Phrase("001 - CAJA ADMIN", font8));
            col1.Border = 0;
            tablaDetalle.AddCell(col1);

            col2 = new PdfPCell(new Phrase(txtDescripcionComprobante.Text, font8));
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

            col4 = new PdfPCell(new Phrase(debe.ToString("0.00"), font8));
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
        }

    }
}
