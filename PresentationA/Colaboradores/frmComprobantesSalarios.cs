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
            cmbLegajo.SelectedIndex = -1;
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
            int diaCompleto;
            float montoferiado;
            string descripcion = "No especifica";
            if (chkFeriado.Checked)
            {
                if(cmbDiaCompleto.SelectedIndex == -1)
                {
                    MessageBox.Show("Debe seleccionar si fue dia completo o medio dia.");
                    return;
                }
                else
                {
                    diaCompleto = cmbDiaCompleto.SelectedIndex;
                }
                DateTime fechaFeriado = dtpFechaFeriado.Value.Date;
                if(diaCompleto == 0)
                {
                    montoferiado = colaboradorModelo.sueldo / 30;
                }
                else
                {
                    montoferiado = (colaboradorModelo.sueldo / 30)/(2);
                }
            }
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
                colaboradorModelo.nombre = datosColaborador.Rows[0]["nombre"].ToString();
                colaboradorModelo.apellido = datosColaborador.Rows[0]["apellido"].ToString();
                colaboradorModelo.sueldo = float.Parse(datosColaborador.Rows[0]["monto"].ToString());
                colaboradorModelo.saldoCuenta = float.Parse(datosColaborador.Rows[0]["saldoAdeudado"].ToString());
                label8.Visible = true;
                label9.Visible = true;
                label15.Visible = true;
                label8.Text = colaboradorModelo.nombre;
                label9.Text = colaboradorModelo.apellido;
                label15.Text = colaboradorModelo.saldoCuenta.ToString();
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
                dtpFechaFeriado.Enabled = false;
                txtMontoBono.Enabled = true;
                cmbDiaCompleto.Enabled = false;
            }
            else
            {
                chkBono.Checked = false;
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
    }
}
