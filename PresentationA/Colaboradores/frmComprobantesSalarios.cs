using DataAccesA;
using DomainA;
using System;
using System.Data;
using System.Windows.Forms;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System.IO;
using Font = iTextSharp.text.Font;

namespace PresentationA.Colaboradores
{
    
    public partial class frmComprobantesSalarios : frmHijo
    {
        EventosModelo eventoModelo = new EventosModelo();
        ColaboradorModelo colaboradorModelo= new ColaboradorModelo();
        CuentaColaboradorModelo cuentaColaborador = new CuentaColaboradorModelo();
        
        public frmComprobantesSalarios()
        {
            InitializeComponent();
            cmbLegajo.SelectedIndex = -1;
            limpiarCampos();
            LlenarCombo(cmbLegajo, DataManager.GetInstance().ConsultaSQL("SELECT * FROM Colaborador WHERE borradoLogico = 0"), "legajo", "legajo");
            label8.Visible = false;
            label9.Visible = false;
            label15.Visible = false;
            label17.Visible = false;
            label21.Visible = false;
            label22.Visible = false;
            
            cmbMesGeneracion.SelectedIndex = -1;
            cmbAñoComprobantes.SelectedIndex = -1;
            
            
        }
        private void cargarDG(int legajo,int mes,int año)
        {
            DataTable  feriados = eventoModelo.getAllFeriadosYBonos(legajo,mes,año);
            dgvFeriados.Rows.Clear();
            for (int i = 0; i < feriados.Rows.Count; i++)
            {
                //crear metodo completar labels
                dgvFeriados.Rows.Add(feriados.Rows[i]["id_evento"], feriados.Rows[i]["nombre"], feriados.Rows[i]["fechaInicio"], feriados.Rows[i]["monto"]);
            }
            
        }

        private void LlenarCombo(ComboBox cbo, Object source, string display, String value)
        {
            cbo.ValueMember = value;
            cbo.DisplayMember = display;
            cbo.DataSource = source;
            cbo.SelectedIndex = -1;
        }

        private void btnGenerarOrdenFeriado_Click(object sender, EventArgs e)
        {
            try
            {


                int tipoEvento;
                DateTime fechaFeriado = dtpFechaFeriado.Value.Date;
                int diaCompleto;
                float montoferiado;
                string descripcion = "No especifica";
                if (chkFeriado.Checked)
                {
                    tipoEvento = 7;
                    if (cmbDiaCompleto.SelectedIndex == -1)
                    {
                        MessageBox.Show("Debe seleccionar si fue dia completo o medio dia.");
                        return;
                    }
                    else
                    {
                        diaCompleto = cmbDiaCompleto.SelectedIndex;
                    }

                    if (diaCompleto == 0)
                    {
                        montoferiado = colaboradorModelo.sueldo / 30;
                    }
                    else
                    {
                        montoferiado = (colaboradorModelo.sueldo / 30) / (2);
                    }
                }
                else
                {
                    tipoEvento = 9;
                    if (txtMontoBono.Text == "")
                    {
                        MessageBox.Show("Debe ingresar un monto.");
                        return;
                    }
                    montoferiado = float.Parse(txtMontoBono.Text);

                }
                if (txtDescripcion1.Text != "")
                {
                    descripcion = txtDescripcion1.Text;
                }
                if (cmbMesGeneracion.SelectedIndex == -1)
                {
                    MessageBox.Show("Seleccione un mes de generacion de comprobante");
                    return;
                }
                if (cmbAñoComprobantes.SelectedIndex == -1)
                {
                    MessageBox.Show("Seleccione un Año de generacion de comprobante");
                    return;
                }

                string resultado = eventoModelo.comprobantesFeriadoYBonos(colaboradorModelo.legajo, fechaFeriado, montoferiado, descripcion, tipoEvento);
                MessageBox.Show(resultado);
                actualizarSueldoAnticiposYDescuentos(colaboradorModelo.legajo, eventoModelo.mesGeneracionComprobante, eventoModelo.añoGeneracionComprobante);
                cargarDatos(colaboradorModelo.legajo, eventoModelo.mesGeneracionComprobante, eventoModelo.añoGeneracionComprobante);
                cargarDG(colaboradorModelo.legajo, eventoModelo.mesGeneracionComprobante, eventoModelo.añoGeneracionComprobante);
                generarOrden(colaboradorModelo.nombre.ToString() + " " + colaboradorModelo.apellido.ToString(),colaboradorModelo.calle + " " +colaboradorModelo.nroCalle.ToString(), montoferiado);
            }catch(Exception ex){
                MessageBox.Show(ex.ToString());
                txtMontoBono.Text = "";
                return;
            }
            //Aca va el codigo para generar el archivo del comprobante!!


        }

        private void limpiarCampos()
        {
            chkFeriado.Checked = false;
            chkBono.Checked = false;
            chkFeriado.Enabled = false;
            chkBono.Enabled = false;
            cmbDiaCompleto.Enabled = false;
            cmbDiaCompleto.SelectedIndex = -1;
            txtMontoBono.Enabled = false;
            txtMontoBono.Text = "";
            dtpFechaFeriado.Enabled=false;
            btnGenerarOrdenFeriado.Enabled = false;
            txtCuotaCtaCorriente.Enabled = false;
            txtCuotaCtaCorriente.Text = "";
            txtAnticipo.Enabled = false;
            txtAnticipo.Text = "";
            btnMinutoContable.Enabled = false;
            

        }
        
        private void cmbLegajo_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if(cmbLegajo.SelectedIndex == 0 && eventoModelo.primerInicioComprobantes == false)
            {
                return;
            }
            if (cmbLegajo.SelectedIndex != -1)
            {
                DataTable datosColaborador = new DataTable();
                datosColaborador = colaboradorModelo.BuscarColaborador(cmbLegajo.SelectedValue.ToString(), "", "");
                if (cmbMesGeneracion.SelectedIndex == -1)
                {
                    MessageBox.Show("Primero debe seleccionar un mes de generacion de comprobante");
                    
                    cmbLegajo.SelectedIndex= -1;
                    return;
                }
                
                
                
                colaboradorModelo.legajo = int.Parse(datosColaborador.Rows[0]["legajo"].ToString());
                colaboradorModelo.nombre = datosColaborador.Rows[0]["nombre"].ToString();
                colaboradorModelo.apellido = datosColaborador.Rows[0]["apellido"].ToString();
                colaboradorModelo.sueldo = float.Parse(datosColaborador.Rows[0]["monto"].ToString());
                colaboradorModelo.saldoCuenta = float.Parse(datosColaborador.Rows[0]["saldoAdeudado"].ToString());
                colaboradorModelo.calle = datosColaborador.Rows[0]["nombreCalle"].ToString();
                colaboradorModelo.nroCalle = int.Parse(datosColaborador.Rows[0]["numeroCalle"].ToString());
                cargarDatos(colaboradorModelo.legajo, eventoModelo.mesGeneracionComprobante,eventoModelo.añoGeneracionComprobante);
            }
            
        }
        private void cargarDatos(int legajo,int mes,int año)
        {
            label8.Visible = true;
            label9.Visible = true;
            label15.Visible = true;
            label21.Visible = true;
            label22.Visible = true;
            label8.Text = colaboradorModelo.nombre;
            label9.Text = colaboradorModelo.apellido;
            actualizarSueldoAnticiposYDescuentos(legajo, mes,año);
            label15.Text = colaboradorModelo.saldoCuenta.ToString();
            label21.Text = colaboradorModelo.sueldo.ToString();
            cargarDG(legajo, mes,año);

            label22.Text = (colaboradorModelo.sueldo + eventoModelo.agregadoSueldo - eventoModelo.restaSueldo).ToString();
            activarCampos();
        }
        
        private void activarCampos()
        {
            chkFeriado.Enabled = true;
            chkBono.Enabled = true;
            btnGenerarOrdenFeriado.Enabled = true;
            txtAnticipo.Enabled = true;
            txtCuotaCtaCorriente.Enabled = true;
            btnMinutoContable.Enabled = true;
        }
        private void actualizarSueldoAnticiposYDescuentos(int legajo,int mes,int año)
        {
            
            eventoModelo.agregadoSueldo = eventoModelo.sumaFeriadosYAnticiposADescontar(legajo, mes, 7,9,año);
        }

        private void chkFeriado_CheckedChanged(object sender, EventArgs e)
        {
            cmbDiaCompleto.SelectedIndex= -1;
            if(chkFeriado.Checked)
            {
                chkBono.Checked = false;
                dtpFechaFeriado.Enabled = true;
                txtMontoBono.Enabled = false;
                cmbDiaCompleto.Enabled = true;
                
            }
            else
            {
                chkBono.Checked = true;
                dtpFechaFeriado.Enabled = true;
                txtMontoBono.Enabled = true;
                cmbDiaCompleto.Enabled = false;
                label17.Visible = false;
            }
        }

        private void chkBono_CheckedChanged(object sender, EventArgs e)
        {
            cmbDiaCompleto.SelectedIndex = -1;
            if (chkBono.Checked)
            {
                chkBono.Checked = true;
                chkFeriado.Checked= false;
                dtpFechaFeriado.Enabled = true;
                txtMontoBono.Enabled = true;
                cmbDiaCompleto.Enabled = false;
                label17.Visible = false;
            }
            else
            {
                chkBono.Checked = false;
                chkFeriado.Checked= true;
                dtpFechaFeriado.Enabled = true;
                txtMontoBono.Enabled = false;
                cmbDiaCompleto.Enabled = true;
                
            }
        }

        private void cmbDiaCompleto_SelectedIndexChanged(object sender, EventArgs e)
        {
            float montoferiado;
            
            if (cmbDiaCompleto.SelectedIndex == 0)
            {
                montoferiado = colaboradorModelo.sueldo / 30;
            }
            else
            {
                montoferiado = (colaboradorModelo.sueldo / 30) / (2);
            }
            label17.Visible = true;
            label17.Text = montoferiado.ToString();
        }

        private void cmbMesGeneracion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbAñoComprobantes.SelectedIndex == -1)
            {
                MessageBox.Show("Primero seleccione un año.");
                cmbMesGeneracion.SelectedIndex = -1;
                cmbLegajo.SelectedIndex = -1;
                return;

                
            }
            eventoModelo.mesGeneracionComprobante = cmbMesGeneracion.SelectedIndex + 1;
            

            if (colaboradorModelo.legajo != 0)
            {
                cargarDatos(colaboradorModelo.legajo, eventoModelo.mesGeneracionComprobante,eventoModelo.añoGeneracionComprobante);
            }
            cargarDG(colaboradorModelo.legajo, eventoModelo.mesGeneracionComprobante,eventoModelo.añoGeneracionComprobante);

        }

        private void txtCuotaCtaCorriente_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int cuota = 0;
                int anticipo = 0;
                int resta = 0;
                if (txtAnticipo.Text != "")
                {
                    anticipo = int.Parse(txtAnticipo.Text);

                }
                if (txtCuotaCtaCorriente.Text != "")
                {
                    cuota = int.Parse(txtCuotaCtaCorriente.Text);
                }
                resta = cuota + anticipo;




                eventoModelo.restaSueldo = resta;
                label22.Text = (colaboradorModelo.sueldo + eventoModelo.agregadoSueldo - eventoModelo.restaSueldo).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                txtAnticipo.Text = "";
                txtCuotaCtaCorriente.Text = "";
                return;
            }

        }

        private void txtAnticipo_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int cuota = 0;
                int anticipo = 0;
                int resta = 0;
                if (txtAnticipo.Text != "")
                {
                    anticipo = int.Parse(txtAnticipo.Text);

                }
                if (txtCuotaCtaCorriente.Text != "")
                {
                    cuota = int.Parse(txtCuotaCtaCorriente.Text);
                }
                resta = cuota + anticipo;



                
                eventoModelo.restaSueldo = resta;
                label22.Text = (colaboradorModelo.sueldo + eventoModelo.agregadoSueldo - eventoModelo.restaSueldo).ToString();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                txtAnticipo.Text = "";
                txtCuotaCtaCorriente.Text = "";
                return;
            }
        }

        private void btnMinutoContable_Click(object sender, EventArgs e)
        {
            string descripcion = "No especifica";
            if(txtDescripcion2.Text != "")
            {
                descripcion= txtDescripcion2.Text;
            }
            int cuota = 0;
            int anticipo = 0;
            if(txtCuotaCtaCorriente.Text != "")
            {
                cuota = int.Parse(txtCuotaCtaCorriente.Text);
            }
            if (txtAnticipo.Text != "")
            {
                anticipo = int.Parse(txtAnticipo.Text);
            }
            int restoTotal = cuota + anticipo;
            
            DateTime fechaFeriado = DateTime.Now;

            cuentaColaborador.modificarSaldo(colaboradorModelo.legajo, restoTotal, 1,"Pago cuota y anticipo");
            
            DataTable datosColaborador = colaboradorModelo.BuscarColaborador(cmbLegajo.SelectedValue.ToString(), "", "");
            colaboradorModelo.saldoCuenta = float.Parse(datosColaborador.Rows[0]["saldoAdeudado"].ToString());

            label15.Text = colaboradorModelo.saldoCuenta.ToString();
            txtAnticipo.Text = "";
            txtCuotaCtaCorriente.Text = "";

            string resultado = eventoModelo.comprobantesFeriadoYBonos(colaboradorModelo.legajo, fechaFeriado, restoTotal, descripcion, 8);
            MessageBox.Show(resultado);
            generarMinuta(colaboradorModelo.nombre + " " + colaboradorModelo.apellido, colaboradorModelo.calle + " " + colaboradorModelo.nroCalle, float.Parse(label22.Text.ToString()));
        }

        private void btnEliminarFeriado_Click(object sender, EventArgs e)
        {
            try
            {


                if (eventoModelo.feriadoSeleccionado == -1)
                {
                    MessageBox.Show("Debe seleccionar un Feriado o Bono.");
                    return;
                }
                DataGridViewRow filaSeleccionada = dgvFeriados.Rows[eventoModelo.feriadoSeleccionado];
                int idFeriado = int.Parse(filaSeleccionada.Cells["id_evento"].Value.ToString());
                string respuesta = eventoModelo.eliminarEvento(idFeriado);
                MessageBox.Show(respuesta);
                cargarDG(colaboradorModelo.legajo, eventoModelo.mesGeneracionComprobante,eventoModelo.añoGeneracionComprobante);
                actualizarSueldoAnticiposYDescuentos(colaboradorModelo.legajo, eventoModelo.mesGeneracionComprobante,eventoModelo.añoGeneracionComprobante);
                label22.Text = (colaboradorModelo.sueldo + eventoModelo.agregadoSueldo - eventoModelo.restaSueldo).ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Seleccione un elemento para eliminar.");
            }
        }

        private void dgvFeriados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;
            eventoModelo.feriadoSeleccionado = indice;
        }

        private void dgvFeriados_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvFeriados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;
            eventoModelo.feriadoSeleccionado = indice;
        }

        private void cmbAñoComprobantes_SelectedIndexChanged(object sender, EventArgs e)
        {
            eventoModelo.primerInicioComprobantes = true;
            int año = 2022;
            int seleccion = cmbAñoComprobantes.SelectedIndex;
            año = año + seleccion;
            eventoModelo.añoGeneracionComprobante = año;
            if(eventoModelo.mesGeneracionComprobante != -1 && cmbLegajo.SelectedIndex != -1)
            {
                cargarDatos(colaboradorModelo.legajo, eventoModelo.mesGeneracionComprobante, eventoModelo.añoGeneracionComprobante);
            }
        }

        private void txtCuotaCtaCorriente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void txtAnticipo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void txtMontoBono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void cmbLegajo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cmbMesGeneracion_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cmbAñoComprobantes_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cmbDiaCompleto_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void pintaLinea(Document PdfDoc)
        {
            Paragraph lineSeparato = new Paragraph(new Chunk(new iTextSharp.text.pdf.draw.LineSeparator(0.75F, 100.0F, BaseColor.BLACK, Element.ALIGN_LEFT, 1)));
            lineSeparato.SetLeading(0.5F, 0.5F);

            PdfDoc.Add(lineSeparato);
        }

        private void generarOrden(string nombre, string direccion, float debe)
        {

            var folderBrowserDialog1 = new FolderBrowserDialog();
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result != DialogResult.OK) {return; }
            string folderName = folderBrowserDialog1.SelectedPath;
            string fileName = folderName + "\\Feriado_" + nombre + "_" + DateTime.Now.ToString("yyyy-MM-dd") + ".pdf";
            Document pdf = new Document();
            PdfWriter pdfWritter = PdfWriter.GetInstance(pdf, new FileStream(fileName,FileMode.Create) );
            Font font8 = new Font(FontFactory.GetFont(FontFactory.HELVETICA,8,iTextSharp.text.Font.NORMAL));
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
            col1 = new PdfPCell(new Phrase("COLABORADOR",fBold));
            col1.Border = 0;
            tablaColab.AddCell(col1);

            col2 = new PdfPCell(new Phrase(nombre,font8));
            col2.Border = 0;
            tablaColab.AddCell(col2);

            col3 = new PdfPCell(new Phrase("Fecha Emisión: " , fBold));
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

            

            col6 = new PdfPCell(new Phrase("SUB TOTAL",fBold));
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

            col2 = new PdfPCell(new Phrase(txtDescripcion1.Text, font8));
            col2.Border = 0;
            tablaDetalle.AddCell(col2);

            tablaDetalle.AddCell(cvacio);

            //Aca iria el valor de cada feriado?
            col3 = new PdfPCell(new Phrase(debe.ToString("0.00"), font8));
            col3.Border = 0;
            tablaDetalle.AddCell(col3);

            col4 = new PdfPCell(new Phrase("0.00", font8));
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

        private void generarMinuta(string nombre, string direccion, float debe)
        {
            System.IO.MemoryStream memoryStream = new System.IO.MemoryStream();

            var folderBrowserDialog1 = new FolderBrowserDialog();
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result != DialogResult.OK) { return; }
            string folderName = folderBrowserDialog1.SelectedPath;
            string fileName = folderName + "\\MinutaContable_" + nombre + "_" + DateTime.Now.ToString("yyyy-MM-dd") + ".pdf";
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

            col3 = new PdfPCell(new Phrase("MINUTA CONTABLE", fBold));
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
            col1 = new PdfPCell(new Phrase("COLABORADOR", fBold));
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


            col1 = new PdfPCell(new Phrase("NOMBRE", fBold));
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
            float[] widths4 = new float[] { 5.0F, 8.0F, 3.0F, 3.0F, 3.0F, 3.0F, 1.0F };
            tablaDetalle.SetWidths(widths4);
            tablaDetalle.WidthPercentage = 95;

            col1 = new PdfPCell(new Phrase("COLABORADORES", font8));
            col1.Border = 0;
            tablaDetalle.AddCell(col1);

            col2 = new PdfPCell(new Phrase(txtDescripcion1.Text, font8));
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

            col2 = new PdfPCell(new Phrase(txtDescripcion1.Text, font8));
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
