using DataAccesA;
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

namespace PresentationA.Colaboradores.Consulta
{
    public partial class frmCtaCte : frmHijo
    {
        CuentaColaboradorModelo cuenta = new CuentaColaboradorModelo();
        DataTable cuentaColaborador;
        public frmCtaCte(string legajo)
        {
            InitializeComponent();
            LlenarCombo(cmbTipoMovimiento, DataManager.GetInstance().ConsultaSQL("SELECT * FROM TipoMovimiento WHERE borradoLogico = 0"), "nombre", "id_tipoMovimiento");
            CargarDG(legajo);
        }
        private void LlenarCombo(ComboBox cbo, Object source, string display, String value)
        {
            cbo.ValueMember = value;
            cbo.DisplayMember = display;
            cbo.DataSource = source;
            cbo.SelectedIndex = -1;
        }
        private void CargarDG(string legajo)
        {
            try
            {
                cuentaColaborador = cuenta.buscarCuentaColaborador(int.Parse(legajo));
                dgvBusqueda.DataSource =cuentaColaborador;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            float monto = float.Parse(txtMontoMovimiento.Text);

        }
    }
}
