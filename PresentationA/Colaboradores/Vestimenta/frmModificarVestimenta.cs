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
        public frmModificarVestimenta(int legajoColaborador)
        {
            InitializeComponent();
            legajoColaboradorModificar = legajoColaborador;
            LlenarCombo(cmbSucursal, DataManager.GetInstance().ConsultaSQL("SELECT * FROM Sucursal"), "nombre", "codigoSucursal");
            LlenarCombo(cmbArea, DataManager.GetInstance().ConsultaSQL("SELECT * FROM Area"), "nombre", "idArea");
        }
        private void LlenarCombo(ComboBox cbo, Object source, string display, String value)
        {
            cbo.ValueMember = value;
            cbo.DisplayMember = display;
            cbo.DataSource = source;
            cbo.SelectedIndex = 0;
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
                MessageBox.Show("Debe completar todos los campos obligatoriamente.");
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
            }
        }
    }
}
