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

namespace PresentationA.Colaboradores.Vestimenta
{
    public partial class frmModificarVestimenta : frmHijo
    {
        public int legajoColaboradorModificar = 0;
        VestimentaModelo vestimentaModificada = new VestimentaModelo();
        public frmModificarVestimenta(VestimentaModelo vestimentaOriginal)
        {
            InitializeComponent();
            legajoColaboradorModificar = vestimentaOriginal.legajoColaborador;
            txtLegajo.Text= vestimentaOriginal.legajoColaborador.ToString();
            LlenarCombo(cmbSucursal, DataManager.GetInstance().ConsultaSQL("SELECT * FROM Sucursal"), "nombre", "codigoSucursal");
            cmbSucursal.SelectedIndex = cmbSucursal.FindString(vestimentaOriginal.nombreSucursal);
            LlenarCombo(cmbArea, DataManager.GetInstance().ConsultaSQL("SELECT * FROM Area"), "nombre", "idArea");
            cmbArea.SelectedIndex = cmbArea.FindString(vestimentaOriginal.nombreArea); 
            txtBuzo.Text = vestimentaOriginal.buzo;
            txtCalzado.Value = Convert.ToDecimal(vestimentaOriginal.calzado);
            txtPantalon.Value = Convert.ToDecimal(vestimentaOriginal.pantalon);
            txtRemera.Text = vestimentaOriginal.remera;

        }
        private void LlenarCombo(ComboBox cbo, Object source, string display, String value)
        {
            cbo.ValueMember = value;
            cbo.DisplayMember = display;
            cbo.DataSource = source;
            cbo.SelectedIndex = 0;
        }

        private void msgError(string msg)
        {
            lblError.Text = "      " + msg;
            lblError.Visible = true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            bool errorValidacion = false;

            if (int.Parse(cmbSucursal.SelectedValue.ToString()) == 0) { errorValidacion = true; }
            if (int.Parse(cmbArea.SelectedValue.ToString()) == 0) { errorValidacion = true; }
            if (txtBuzo.Text.Length == 0) { errorValidacion = true; }
            if (txtCalzado.Text.Length == 0) { errorValidacion = true; }
            if (txtPantalon.Text.Length == 0) { errorValidacion = true; }
            if (txtRemera.Text.Length == 0) { errorValidacion = true; }
            if (errorValidacion)
            {
                msgError("Debe completar todos los campos obligatoriamente.");
            }
            else
            {

                int sucursal = int.Parse(cmbSucursal.SelectedValue.ToString());
                int area = int.Parse(cmbArea.SelectedValue.ToString());
                string pantalon = txtPantalon.Text.Trim();
                string buzo = txtBuzo.Text.Trim();
                string calzado = txtCalzado.Text.Trim();
                string remera = txtRemera.Text.Trim();
                vestimentaModificada.ModificarVestimenta(legajoColaboradorModificar, sucursal, area, pantalon, buzo, remera, calzado);
                MessageBox.Show("Se modifico la vestimenta correctamente.");
                this.Close();
            }
        }
        private void txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }
        private void textBox_TextChanged(TextBox sender, EventArgs e)
        {
            sender.SelectionStart = sender.Text.Length;
            sender.Text = sender.Text.ToUpper();

        }


        private void txtBuzo_TextChanged(object sender, EventArgs e)
        {
            textBox_TextChanged(txtBuzo, e);
        }
        private void txtRemera_TextChanged(object sender, EventArgs e)
        {
            textBox_TextChanged(txtRemera, e);
        }
    }
}
