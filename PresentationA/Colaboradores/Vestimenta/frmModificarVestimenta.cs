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
        public frmModificarVestimenta(DataTable colaborador)
        {
            InitializeComponent();
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
    }
}
