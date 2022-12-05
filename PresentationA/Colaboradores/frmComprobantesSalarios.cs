using DataAccesA;
using DomainA;
using FontAwesome.Sharp;
using System;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Resources;
using System.Windows.Forms;

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
            limpiarCampos();
            LlenarCombo(cmbLegajo, DataManager.GetInstance().ConsultaSQL("SELECT * FROM Colaborador WHERE borradoLogico = 0"), "legajo", "legajo");
            label8.Visible = false;
            label9.Visible = false;
            label15.Visible = false;
            label17.Visible = false;
            label21.Visible = false;
            label22.Visible = false;
            cmbLegajo.SelectedIndex = -1;
            cmbMesGeneracion.SelectedIndex = -1;
            
            
        }
        private void cargarDG(int legajo,int mes)
        {
            DataTable  feriados = eventoModelo.getAllFeriadosYBonos(legajo,mes);
            
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
            int tipoEvento;
            DateTime fechaFeriado = dtpFechaFeriado.Value.Date;
            int diaCompleto;
            float montoferiado;
            string descripcion = "No especifica";
            if (chkFeriado.Checked)
            {
                tipoEvento = 7;
                if(cmbDiaCompleto.SelectedIndex == -1)
                {
                    MessageBox.Show("Debe seleccionar si fue dia completo o medio dia.");
                    return;
                }
                else
                {
                    diaCompleto = cmbDiaCompleto.SelectedIndex;
                }
                
                if(diaCompleto == 0)
                {
                    montoferiado = colaboradorModelo.sueldo / 30;
                }
                else
                {
                    montoferiado = (colaboradorModelo.sueldo / 30)/(2);
                }
            }
            else
            {
                tipoEvento = 9;
                montoferiado = float.Parse(txtMontoBono.Text);
                
            }
            if(txtDescripcion1.Text != "")
            {
                descripcion= txtDescripcion1.Text;
            }
            if(cmbMesGeneracion.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un mes de generacion de comprobante");
                return;
            }

            string resultado = eventoModelo.comprobantesFeriadoYBonos(colaboradorModelo.legajo,fechaFeriado,montoferiado,descripcion,tipoEvento);
            MessageBox.Show(resultado);
            actualizarSueldoAnticiposYDescuentos(colaboradorModelo.legajo, eventoModelo.mesGeneracionComprobante);
            cargarDG(colaboradorModelo.legajo, eventoModelo.mesGeneracionComprobante);

            //Aca va el codigo para generar el archivo del comprobante!!
<<<<<<< HEAD
            try
            {
                pntOrden = new PrintDocument();
                PrinterSettings ps = new PrinterSettings();
                pntOrden.PrinterSettings = ps;
                pntOrden.PrintPage += printOrden;
                pntOrden.Print();
            }
            catch (Exception ex) { throw ex; }
=======
            pntOrden = new PrintDocument();
            PrinterSettings ps = new PrinterSettings();
            pntOrden.PrinterSettings = ps;
            pntOrden.PrintPage += printOrden;
            pntOrden.Print();

>>>>>>> refs/remotes/origin/Sandbox
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
            
            if(cmbLegajo.SelectedIndex == 0 && int.Parse(cmbLegajo.SelectedValue.ToString()) != 10000)
            {
                cmbLegajo.SelectedIndex= -1;
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
                cargarDatos(colaboradorModelo.legajo, eventoModelo.mesGeneracionComprobante);
            }
            
        }
        private void cargarDatos(int legajo,int mes)
        {
            label8.Visible = true;
            label9.Visible = true;
            label15.Visible = true;
            label21.Visible = true;
            label22.Visible = true;
            label8.Text = colaboradorModelo.nombre;
            label9.Text = colaboradorModelo.apellido;
            actualizarSueldoAnticiposYDescuentos(legajo, mes);
            label15.Text = colaboradorModelo.saldoCuenta.ToString();
            label21.Text = colaboradorModelo.sueldo.ToString();
            cargarDG(legajo, mes);

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
        private void actualizarSueldoAnticiposYDescuentos(int legajo,int mes)
        {
            
            eventoModelo.agregadoSueldo = eventoModelo.sumaFeriadosYAnticiposADescontar(legajo, mes, 7,9);
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
            eventoModelo.mesGeneracionComprobante = cmbMesGeneracion.SelectedIndex + 1;

            if(colaboradorModelo.legajo != 0)
            {
                cargarDatos(colaboradorModelo.legajo, eventoModelo.mesGeneracionComprobante);
            }
            cargarDG(colaboradorModelo.legajo, eventoModelo.mesGeneracionComprobante);

        }

        private void txtCuotaCtaCorriente_TextChanged(object sender, EventArgs e)
        {
            int resta = 0;
            if(txtCuotaCtaCorriente.Text != "")
            {
                if(txtAnticipo.Text != "")
                {
                    resta = int.Parse(txtAnticipo.Text);
                }
                resta = resta + int.Parse(txtCuotaCtaCorriente.Text);
            }
            eventoModelo.restaSueldo = resta;
            label22.Text = (colaboradorModelo.sueldo + eventoModelo.agregadoSueldo - eventoModelo.restaSueldo).ToString();

        }

        private void txtAnticipo_TextChanged(object sender, EventArgs e)
        {
            int resta = 0;
            if (txtAnticipo.Text != "")
            {
                if (txtCuotaCtaCorriente.Text != "")
                {
                    resta = int.Parse(txtAnticipo.Text);
                }
                resta = resta + int.Parse(txtAnticipo.Text);
            }
            eventoModelo.restaSueldo = resta;
            label22.Text = (colaboradorModelo.sueldo + eventoModelo.agregadoSueldo - eventoModelo.restaSueldo).ToString();
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

            string resultado = eventoModelo.comprobantesFeriadoYBonos(colaboradorModelo.legajo, fechaFeriado, restoTotal, descripcion, 8);
            MessageBox.Show(resultado);
            pntMinuta = new PrintDocument();
            PrinterSettings ps = new PrinterSettings();
            pntMinuta.PrinterSettings = ps;
            pntMinuta.PrintPage += printMinuta;
            pntMinuta.Print();
        }

        private void btnEliminarFeriado_Click(object sender, EventArgs e)
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
            cargarDG(colaboradorModelo.legajo, eventoModelo.mesGeneracionComprobante);
            actualizarSueldoAnticiposYDescuentos(colaboradorModelo.legajo, eventoModelo.mesGeneracionComprobante);
            label22.Text = (colaboradorModelo.sueldo + eventoModelo.agregadoSueldo - eventoModelo.restaSueldo).ToString();
        }

        private void dgvFeriados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;
            eventoModelo.feriadoSeleccionado = indice;
        }

        private void printOrden(object sender, PrintPageEventArgs e)
        {
            DataTable colaborador = colaboradorModelo.BuscarColaborador(cmbLegajo.SelectedValue.ToString(), "", "");
            string direccion = colaborador.Rows[0]["nombreCalle"].ToString() + " " +  colaborador.Rows[0]["numeroCalle"].ToString();
            Font font = new Font("Arial", 11);
            int ancho = 800;
            int y = 70;
            Bitmap original = (Bitmap)Image.FromFile("Resources/ETRA_Isologotipo-01.png");
            Bitmap resized = new Bitmap(original, new Size(original.Width / 20, original.Height / 20));
            e.Graphics.DrawImage(resized, 10, 0);
            e.Graphics.DrawString("ETRA DISTRIBUCIONES S.R.L. EN FORMACIÓN", font, Brushes.Black, new RectangleF(resized.Size.Width + 10, 0, ancho, 30));
            e.Graphics.DrawString("Las Heras 555 - Río Tercero - CÓRDOBA", font, Brushes.Black, new RectangleF(resized.Size.Width + 10, 30, ancho, 30));
            e.Graphics.DrawString("C.U.I.T.: 30-71605992-4", font, Brushes.Black, new RectangleF(resized.Size.Width + 10, 60, ancho, 30));
            e.Graphics.DrawString("Ing. Brutos: 282470888", font, Brushes.Black, new RectangleF(460, 60, ancho, 30));

            e.Graphics.DrawRectangle(new Pen(Color.Black),10, y + 10, ancho ,90);
            e.Graphics.DrawString("ORDEN DE PAGO Nº: ", font, Brushes.Black, new RectangleF(460,y +20, ancho, 30));
            e.Graphics.DrawString("Original", font, Brushes.Black, new RectangleF(10, y + 20, ancho, 30));
            e.Graphics.DrawString("Colaborador: "  + colaborador.Rows[0]["nombre"].ToString() + " " + colaborador.Rows[0]["apellido"].ToString(), font, Brushes.Black, new RectangleF(10, y + 50, ancho, 30));
            e.Graphics.DrawString("Dir: " + direccion , font, Brushes.Black, new RectangleF(10, y + 80, ancho, 30));
            e.Graphics.DrawString("Fecha: " + DateTime.Now.ToString(), font, Brushes.Black, new RectangleF(460, y + 50, ancho, 30)); ;

            e.Graphics.DrawString("Saldo Cta Cte: " + label15.Text, font, Brushes.Black, new RectangleF(10, y + 110, ancho, 30));

            e.Graphics.DrawRectangle(new Pen(Color.Black), 10, y + 130, ancho, 20);
            e.Graphics.DrawString("Cuenta", font, Brushes.Black, new RectangleF(10, y + 130, ancho, 30));
            e.Graphics.DrawString("001 - CAJA ADMIN", font, Brushes.Black, new RectangleF(10, y + 160, ancho, 30));
            e.Graphics.DrawString("Debe", font, Brushes.Black, new RectangleF(460, y + 130, ancho, 30));
            e.Graphics.DrawString(label17.Text, font, Brushes.Black, new RectangleF(460, y + 160, ancho, 30));
            e.Graphics.DrawString("Haber", font, Brushes.Black, new RectangleF(610, y + 130, ancho, 30));
            e.Graphics.DrawString("0,00", font, Brushes.Black, new RectangleF(610, y + 160, ancho, 30));
            
            e.Graphics.DrawRectangle(new Pen(Color.Black), 10, y + 250, ancho, 20);
            e.Graphics.DrawString("TOTAL: $" + label17.Text, font, Brushes.Black, new RectangleF(610, y + 250, ancho, 30));

            e.Graphics.DrawString("Notas: " + txtDescripcion1.Text, font, Brushes.Black, new RectangleF(10, y + 300, ancho, 30));
            e.Graphics.DrawString("Recibí conforme de ETRA DISTRIBUCIONES S.R.L. EN FORMACIÓN EL IMPORTE EN PESOS:__________ " , font, Brushes.Black, new RectangleF(10, y + 330, ancho + 100, 50));

            e.Graphics.DrawString("___________________", font, Brushes.Black, new RectangleF(10, y + 390, ancho, 30));
            e.Graphics.DrawString("FIRMA", font, Brushes.Black, new RectangleF(10, y + 420, ancho, 30));

            e.Graphics.DrawString("___________________", font, Brushes.Black, new RectangleF(260, y + 390, ancho, 30));
            e.Graphics.DrawString("ACLARACIÓN", font, Brushes.Black, new RectangleF(260, y + 420, ancho, 30));

            e.Graphics.DrawString("___________________", font, Brushes.Black, new RectangleF(510, y + 390, ancho, 30));
            e.Graphics.DrawString("TIPO Y NRO DE DOC.", font, Brushes.Black, new RectangleF(510, y + 420, ancho, 30));

            
        }

        private void printMinuta(object sender, PrintPageEventArgs e)
        {
            DataTable colaborador = colaboradorModelo.BuscarColaborador(cmbLegajo.SelectedValue.ToString(), "", "");
            string direccion = colaborador.Rows[0]["nombreCalle"].ToString() + " " + colaborador.Rows[0]["numeroCalle"].ToString();
            Font font = new Font("Arial", 11);
            int ancho = 800;
            int y = 70;
            Bitmap original = (Bitmap)Image.FromFile("Resources/ETRA_Isologotipo-01.png");
            Bitmap resized = new Bitmap(original, new Size(original.Width / 20, original.Height / 20));
            e.Graphics.DrawImage(resized, 10, 0);
            e.Graphics.DrawString("ETRA DISTRIBUCIONES S.R.L. EN FORMACIÓN", font, Brushes.Black, new RectangleF(resized.Size.Width + 10, 0, ancho, 30));
            e.Graphics.DrawString("Las Heras 555 - Río Tercero - CÓRDOBA", font, Brushes.Black, new RectangleF(resized.Size.Width + 10, 30, ancho, 30));
            e.Graphics.DrawString("C.U.I.T.: 30-71605992-4", font, Brushes.Black, new RectangleF(resized.Size.Width + 10, 60, ancho, 30));
            e.Graphics.DrawString("Ing. Brutos: 282470888", font, Brushes.Black, new RectangleF(460, 60, ancho, 30));

            e.Graphics.DrawRectangle(new Pen(Color.Black), 10, y + 10, ancho, 90);
            e.Graphics.DrawString("MINUTA CONTABLE Nº: ", font, Brushes.Black, new RectangleF(460, y + 20, ancho, 30));
            e.Graphics.DrawString("Original", font, Brushes.Black, new RectangleF(10, y + 20, ancho, 30));
            e.Graphics.DrawString("Colaborador: " + colaborador.Rows[0]["nombre"].ToString() + " " + colaborador.Rows[0]["apellido"].ToString(), font, Brushes.Black, new RectangleF(10, y + 50, ancho, 30));
            e.Graphics.DrawString("Dir: " + direccion, font, Brushes.Black, new RectangleF(10, y + 80, ancho, 30));
            e.Graphics.DrawString("Fecha: " + DateTime.Now.ToString(), font, Brushes.Black, new RectangleF(460, y + 50, ancho, 30)); ;

           

            e.Graphics.DrawRectangle(new Pen(Color.Black), 10, y + 130, ancho, 20);
            e.Graphics.DrawString("Cuenta", font, Brushes.Black, new RectangleF(10, y + 130, ancho, 30));
            e.Graphics.DrawString("001 - CAJA ADMIN", font, Brushes.Black, new RectangleF(10, y + 160, ancho, 30));
            e.Graphics.DrawString("Debe", font, Brushes.Black, new RectangleF(460, y + 130, ancho, 30));
            e.Graphics.DrawString(label22.Text, font, Brushes.Black, new RectangleF(460, y + 160, ancho, 30));
            e.Graphics.DrawString("Haber", font, Brushes.Black, new RectangleF(610, y + 130, ancho, 30));
            e.Graphics.DrawString(label22.Text, font, Brushes.Black, new RectangleF(610, y + 160, ancho, 30));

            e.Graphics.DrawRectangle(new Pen(Color.Black), 10, y + 250, ancho, 20);
            e.Graphics.DrawString("TOTAL: $" + label22.Text, font, Brushes.Black, new RectangleF(610, y + 250, ancho, 30));

            e.Graphics.DrawString("Notas: " + txtDescripcion2.Text, font, Brushes.Black, new RectangleF(10, y + 300, ancho, 30));
            

            e.Graphics.DrawString("___________________", font, Brushes.Black, new RectangleF(10, y + 390, ancho, 30));
            e.Graphics.DrawString("FIRMA", font, Brushes.Black, new RectangleF(10, y + 420, ancho, 30));

            e.Graphics.DrawString("___________________", font, Brushes.Black, new RectangleF(260, y + 390, ancho, 30));
            e.Graphics.DrawString("ACLARACIÓN", font, Brushes.Black, new RectangleF(260, y + 420, ancho, 30));

            e.Graphics.DrawString("___________________", font, Brushes.Black, new RectangleF(510, y + 390, ancho, 30));
            e.Graphics.DrawString("TIPO Y NRO DE DOC.", font, Brushes.Black, new RectangleF(510, y + 420, ancho, 30));


        }
    }
}
