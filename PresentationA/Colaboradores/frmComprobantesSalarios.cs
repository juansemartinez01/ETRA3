using DomainA;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationA.Colaboradores
{
    
    public partial class frmComprobantesSalarios : Form
    {
        EventosModelo eventoModelo = new EventosModelo();
        ColaboradorModelo colaboradorModelo= new ColaboradorModelo();
        
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

        private void LlenarCombo(ComboBox cbo, Object source, string display, String value)
        {
            cbo.ValueMember = value;
            cbo.DisplayMember = display;
            cbo.DataSource = source;
            cbo.SelectedIndex = -1;
        }

        private void btnGenerarOrdenFeriado_Click(object sender, EventArgs e)
        {
            DateTime fechaFeriado;
            int diaCompleto;
            float montoferiado;
            string descripcion = "No especifica";
            if (chkFeriado.Checked)
            {
                fechaFeriado = dtpFechaFeriado.Value.Date;
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
                montoferiado = float.Parse(txtMontoBono.Text);
                fechaFeriado = DateTime.Now;
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

            string resultado = eventoModelo.comprobantesFeriadoYBonos(colaboradorModelo.legajo,fechaFeriado,montoferiado,descripcion,0);
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
                if(cmbMesGeneracion.SelectedIndex == -1)
                {
                    MessageBox.Show("Primero debe seleccionar un mes de generacion de comprobante");
                    return;
                }
                
                DataTable datosColaborador = new DataTable();
                datosColaborador = colaboradorModelo.BuscarColaborador(cmbLegajo.SelectedValue.ToString(), "", "");
                colaboradorModelo.legajo = int.Parse(datosColaborador.Rows[0]["legajo"].ToString());
                colaboradorModelo.nombre = datosColaborador.Rows[0]["nombre"].ToString();
                colaboradorModelo.apellido = datosColaborador.Rows[0]["apellido"].ToString();
                colaboradorModelo.sueldo = float.Parse(datosColaborador.Rows[0]["monto"].ToString());
                colaboradorModelo.saldoCuenta = float.Parse(datosColaborador.Rows[0]["saldoAdeudado"].ToString());
                label8.Visible = true;
                label9.Visible = true;
                label15.Visible = true;
                label21.Visible = true;
                label22.Visible = true;
                label8.Text = colaboradorModelo.nombre;
                label9.Text = colaboradorModelo.apellido;
                actualizarSueldoAnticiposYDescuentos(colaboradorModelo.legajo, eventoModelo.mesGeneracionComprobante);
                label15.Text = colaboradorModelo.saldoCuenta.ToString();
                label21.Text = colaboradorModelo.sueldo.ToString();
                
                label22.Text = (colaboradorModelo.sueldo + eventoModelo.agregadoSueldo - eventoModelo.restaSueldo).ToString();
                activarCampos();
            }
            
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
            eventoModelo.restaSueldo = eventoModelo.sumaFeriadosYAnticiposADescontar(legajo, mes, 8);
            eventoModelo.agregadoSueldo = eventoModelo.sumaFeriadosYAnticiposADescontar(legajo, mes, 7);
        }

        private void chkFeriado_CheckedChanged(object sender, EventArgs e)
        {
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
                dtpFechaFeriado.Enabled = false;
                txtMontoBono.Enabled = true;
                cmbDiaCompleto.Enabled = false;
            }
        }

        private void chkBono_CheckedChanged(object sender, EventArgs e)
        {
            if(chkBono.Checked)
            {
                chkBono.Checked = true;
                chkFeriado.Checked= false;
                dtpFechaFeriado.Enabled = false;
                txtMontoBono.Enabled = true;
                cmbDiaCompleto.Enabled = false;
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
            
        }
    }
}
