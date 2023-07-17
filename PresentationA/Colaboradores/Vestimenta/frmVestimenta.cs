using PresentationA.Colaboradores.TodosFamiliares;
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
    public partial class frmVestimenta : frmHijo
    {
        public frmVestimenta()
        {
            InitializeComponent();
            LlenarCombo(cmbColaborador, DataManager.GetInstance().ConsultaSQL("SELECT * FROM Colaborador WHERE borradoLogico = 0"), "legajo", "legajo");
        }
        private void LlenarCombo(ComboBox cbo, Object source, string display, String value)
        {
            cbo.ValueMember = value;
            cbo.DisplayMember = display;
            cbo.DataSource = source;
            cbo.SelectedIndex = -1;
        }
        private void btnExportar_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            excel.Application.Workbooks.Add(true);
            int icol = 0;
            int irow = 0;
            foreach (DataGridViewColumn col in dgvDocumentos.Columns)
            {
                icol++;
                excel.Cells[1, icol] = col.Name;
                foreach (DataGridViewRow row in dgvDocumentos.Rows)
                {
                    irow++;
                    excel.Cells[irow + 1, icol] = row.Cells[col.Name].Value;
                }
                irow = 0;
            }

            excel.Visible = true;

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmNuevaVestimenta agregar = new frmNuevaVestimenta();
            agregar.ShowDialog();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            frmModificarVestimenta modificar = new frmModificarVestimenta(new DataTable());
            modificar.ShowDialog();
        }
    }
}
