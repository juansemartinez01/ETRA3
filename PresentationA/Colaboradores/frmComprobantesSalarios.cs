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
                var folderBrowserDialog1 = new FolderBrowserDialog();
                DialogResult result = folderBrowserDialog1.ShowDialog();
                if (result != DialogResult.OK) { return; }
                string folderName = folderBrowserDialog1.SelectedPath;
                string fileName = folderName + "\\Feriado_" + colaboradorModelo.nombre.ToString() + " " + colaboradorModelo.apellido.ToString() + "_" + DateTime.Now.ToString("yyyy-MM-dd") + ".pdf";

                ComprobanteModelo feriado = new ComprobanteModelo();
                MessageBox.Show(feriado.generarOrden(colaboradorModelo.nombre.ToString() + " " + colaboradorModelo.apellido.ToString(),colaboradorModelo.calle + " " +colaboradorModelo.nroCalle.ToString(), montoferiado,fileName, "ORDEN DE PAGO", txtDescripcion1.Text));
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
            

            string resultado = eventoModelo.comprobantesFeriadoYBonos(colaboradorModelo.legajo, fechaFeriado, restoTotal, descripcion, 8);
            MessageBox.Show(resultado);

            var folderBrowserDialog1 = new FolderBrowserDialog();
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result != DialogResult.OK) { return; }
            string folderName = folderBrowserDialog1.SelectedPath;
            string fileName = folderName + "\\MinutaContable_" + colaboradorModelo.nombre.ToString() + " " + colaboradorModelo.apellido.ToString() + "_" + DateTime.Now.ToString("yyyy-MM-dd") + ".pdf";


            ComprobanteModelo minuta = new ComprobanteModelo();
            MessageBox.Show(minuta.generarOrden(colaboradorModelo.nombre + " " + colaboradorModelo.apellido, colaboradorModelo.calle + " " + colaboradorModelo.nroCalle, float.Parse(label22.Text.ToString()), fileName, "MINUTA CONTABLE", txtDescripcion2.Text));
            txtAnticipo.Text = "";
            txtCuotaCtaCorriente.Text = "";

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

        private void txtAnticipo_TextChanged_1(object sender, EventArgs e)
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

        private void txtCuotaCtaCorriente_TextChanged_1(object sender, EventArgs e)
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
    }
}
