using DomainA;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationA.Colaboradores
{
    
    public partial class frmComprobantesSalarios : Form
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
            DataTable feriados = new DataTable();
            feriados = eventoModelo.getAllFeriadosYBonos(legajo,mes);
            
            dgvFeriados.DataSource = feriados;
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
            
            DataTable datosColaborador = new DataTable();
            datosColaborador = colaboradorModelo.BuscarColaborador(cmbLegajo.SelectedValue.ToString(), "", "");
            colaboradorModelo.saldoCuenta = float.Parse(datosColaborador.Rows[0]["saldoAdeudado"].ToString());

            label15.Text = colaboradorModelo.saldoCuenta.ToString();

            string resultado = eventoModelo.comprobantesFeriadoYBonos(colaboradorModelo.legajo, fechaFeriado, restoTotal, descripcion, 8);
            MessageBox.Show(resultado);

        }
    }
}
