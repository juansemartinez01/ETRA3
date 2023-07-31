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
    public partial class frmNuevaVestimenta : frmHijo
    {
        VestimentaModelo vestimentaNueva = new VestimentaModelo();
        public frmNuevaVestimenta()
        {
            InitializeComponent();
            
            LlenarCombo(cmbLegajo, DataManager.GetInstance().ConsultaSQL("SELECT * FROM Colaborador WHERE borradoLogico = 0"), "legajo", "legajo");
            LlenarCombo(cmbSucursal, DataManager.GetInstance().ConsultaSQL("SELECT * FROM Sucursal"), "nombre", "codigoSucursal");
            LlenarCombo(cmbArea, DataManager.GetInstance().ConsultaSQL("SELECT * FROM Area"),  "nombre", "idArea");
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
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            bool errorValidacion = false; 
            if (int.Parse(cmbLegajo.SelectedValue.ToString()) == 0) { errorValidacion = true; }
            if (int.Parse(cmbSucursal.SelectedValue.ToString()) == 0) { errorValidacion = true; }
            if (int.Parse(cmbArea.SelectedValue.ToString()) == 0) { errorValidacion = true; }
            if(txtBuzo.Text.Length == 0) { errorValidacion = true; }
            if (txtCalzado.Text.Length == 0) { errorValidacion = true; }
            if (txtPantalon.Text.Length == 0) { errorValidacion = true; }
            if (txtRemera.Text.Length == 0) { errorValidacion = true; }
            if(errorValidacion) { 
                MessageBox.Show("Debe completar todos los campos obligatoriamente.");
            }
            else{
                int legajo = int.Parse(cmbLegajo.SelectedValue.ToString());
                int sucursal = int.Parse(cmbSucursal.SelectedValue.ToString());
                int area = int.Parse(cmbArea.SelectedValue.ToString());
                string pantalon = txtPantalon.Text.Trim();
                string buzo = txtBuzo.Text.Trim();
                string calzado = txtCalzado.Text.Trim();
                string remera = txtRemera.Text.Trim();
                vestimentaNueva.InsertarVestimenta(legajo, sucursal, area, pantalon, buzo, remera, calzado);
                MessageBox.Show("Se agrego la vestimenta correctamente.");
                
            }

        }
    }
}
