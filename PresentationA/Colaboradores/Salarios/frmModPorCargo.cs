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

namespace PresentationA.Colaboradores.Salarios
{
    public partial class frmModPorCargo : frmHijo
    {
        Salario sal = new Salario();
        public frmModPorCargo()
        {
            InitializeComponent();
            LlenarCombo(cmbCargo, DataManager.GetInstance().ConsultaSQL("SELECT * FROM Cargo WHERE borradoLogico = 0"), "nombre", "id_cargo");
            txtPorcentaje.Enabled = false;
            label13.Enabled = false;
        }
        private void msgError(string msg)
        {
            lblError.Text = "      " + msg;
            lblError.Visible = true;
        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void LlenarCombo(ComboBox cbo, Object source, string display, String value)
        {
            cbo.ValueMember = value;
            cbo.DisplayMember = display;
            cbo.DataSource = source;
            cbo.SelectedIndex = -1;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            txtPorcentaje.Enabled = ckbPorcentaje.Checked;
            label13.Enabled = ckbPorcentaje.Checked;
            txtMonto.Enabled = !ckbPorcentaje.Checked;
            label2.Enabled = !ckbPorcentaje.Checked;
        }

        private void btnModificarSalariosCargo_Click(object sender, EventArgs e)
        {
            if (txtMonto.Text == "" || cmbCargo.SelectedIndex == -1)
            {
                msgError("Debe seleccionar un cargo e ingresar un monto");
                return;
            }
            if (ckbPorcentaje.Checked)
            {
                //Es por porcentaje
                string mensaje = sal.modificarSalariosCargoPorcentaje(int.Parse(cmbCargo.SelectedValue.ToString()), float.Parse(txtPorcentaje.Text.ToString()));
                MessageBox.Show(mensaje);
                this.Close();
            }
            else
            {
                //Es por monto
                string mensaje = sal.modificarSalariosDeCargo(int.Parse(cmbCargo.SelectedValue.ToString()), float.Parse(txtMonto.Text.ToString()));
                MessageBox.Show(mensaje);
                this.Close();
            }


        }
        private void cmb_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
