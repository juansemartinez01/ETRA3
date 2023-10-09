using DomainA;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationA.Colaboradores.Individual
{
    public partial class frmVestimenta : frmHijo
    {
        bool tieneVestimenta = false;
        VestimentaModelo vestimenta = new VestimentaModelo();
        public frmVestimenta(string legajo)
        {
            InitializeComponent();
            vestimenta.legajoColaborador = int.Parse(legajo);
            LlenarCombo(cmbSucursal, DataManager.GetInstance().ConsultaSQL("SELECT * FROM Sucursal"), "nombre", "codigoSucursal");
            LlenarCombo(cmbArea, DataManager.GetInstance().ConsultaSQL("SELECT * FROM AREA"), "nombre", "idArea");
            load();
        }

        private void load()
        {
            vestimenta = setVestimenta(vestimenta.obtenerVestimenta(vestimenta.legajoColaborador.ToString()));
            cmbSucursal.SelectedIndex = cmbSucursal.FindString(vestimenta.nombreSucursal);
            cmbArea.SelectedIndex = cmbArea.FindString(vestimenta.nombreArea);
            txtBuzo.Text = vestimenta.buzo;
            txtCalzado.Value = Convert.ToDecimal(vestimenta.calzado);
            txtPantalon.Value = Convert.ToDecimal(vestimenta.pantalon);
            txtRemera.Text = vestimenta.remera;
        }

        private void LlenarCombo(ComboBox cbo, Object source, string display, String value)
        {
            cbo.ValueMember = value;
            cbo.DisplayMember = display;
            cbo.DataSource = source;
            cbo.SelectedIndex = 0;
        }

        private VestimentaModelo setVestimenta(DataTable dtVestimenta)
        {
            if (dtVestimenta.Rows.Count == 0)
            {
                tieneVestimenta = false;
                vestimenta.calzado = null;
                vestimenta.nombreArea = "";
                vestimenta.pantalon = null;
                vestimenta.buzo = "";
                vestimenta.remera = "";
                vestimenta.nombreSucursal = "";
                return vestimenta;
            }
            tieneVestimenta = true;
            vestimenta.calzado = int.Parse(dtVestimenta.Rows[0]["Calzado"].ToString());
            vestimenta.nombreArea = dtVestimenta.Rows[0]["Area"].ToString();
            vestimenta.pantalon = int.Parse(dtVestimenta.Rows[0]["Pantalon"].ToString());
            vestimenta.buzo = dtVestimenta.Rows[0]["Buzo"].ToString();
            vestimenta.remera = dtVestimenta.Rows[0]["Remera"].ToString();
            vestimenta.nombreSucursal = dtVestimenta.Rows[0]["Sucursal"].ToString();
            return vestimenta;
        }

        private void msgError(string msg)
        {
            lblError.Text = "      " + msg;
            lblError.Visible = true;
        }

        private void ModifyState()
        {
            cmbArea.Enabled = true;
            cmbSucursal.Enabled = true;
            txtBuzo.Enabled = true;
            txtCalzado.Enabled = true;
            txtPantalon.Enabled = true;
            txtRemera.Enabled = true;

            btnGuardar.Text = "Guardar";
            btnGuardar.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
        }

        private void ViewState()
        {
            load();
            cmbArea.Enabled = false;
            cmbSucursal.Enabled = false;
            txtBuzo.Enabled = false;
            txtCalzado.Enabled = false;
            txtPantalon.Enabled = false;
            txtRemera.Enabled = false;

            btnGuardar.Text = "Modificar";
            btnGuardar.IconChar = FontAwesome.Sharp.IconChar.Pen;
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if(btnGuardar.Text == "Guardar")
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
                    if (!tieneVestimenta) { vestimenta.InsertarVestimenta(vestimenta.legajoColaborador, sucursal, area, pantalon, buzo, remera, calzado); tieneVestimenta = true; }
                    else { vestimenta.ModificarVestimenta(vestimenta.legajoColaborador, sucursal, area, pantalon, buzo, remera, calzado); }

                    MessageBox.Show("Se modifico la vestimenta correctamente.");
                }
                ViewState();
                return;
            }
            ModifyState();
            return;

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            ViewState();
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
