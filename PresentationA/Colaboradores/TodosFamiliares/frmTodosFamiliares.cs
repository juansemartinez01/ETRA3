using PresentationA.Colaboradores.Consulta.Familiares;
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

namespace PresentationA.Colaboradores
{
    public partial class frmTodosFamiliares : frmHijo
    {
        public frmTodosFamiliares()
        {
            InitializeComponent();
            //JUANSE: Metodo para cargar datagridview
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmTodosAgregarFamiliar agregar = new frmTodosAgregarFamiliar();
            agregar.ShowDialog();
        }

        private void cmb_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if(dgvFamiliares.SelectedRows.Count == 0) 
            {
                MessageBox.Show("Debe seleccionar un familiar");
                return;
            }
            DataTable familiar = new DataTable();
            foreach (DataGridViewColumn column in dgvFamiliares.Columns)
                familiar.Columns.Add(column.Name, column.CellType); //better to have cell type
            for (int i = 0; i < dgvFamiliares.SelectedRows.Count; i++)
            {
                familiar.Rows.Add();
                for (int j = 0; j < dgvFamiliares.Columns.Count; j++)
                {
                    familiar.Rows[i][j] = dgvFamiliares.SelectedRows[i].Cells[j].Value;
                }
                break;
            }
            frmTodosModificarFamiliar modificar = new frmTodosModificarFamiliar(familiar);
            modificar.ShowDialog();
        }

        private void btnAplicar_Click(object sender, EventArgs e)
        {
            //JUANSE: Filtro
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
           //JUANSE: Limpiar filtros
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            excel.Application.Workbooks.Add(true);
            int icol = 0;
            int irow = 0;
            foreach (DataGridViewColumn col in dgvFamiliares.Columns)
            {
                icol++;
                excel.Cells[1, icol] = col.Name;
                foreach (DataGridViewRow row in dgvFamiliares.Rows)
                {
                    irow++;
                    excel.Cells[irow + 1, icol] = row.Cells[col.Name].Value;
                }
                irow = 0;
            }

            excel.Visible = true;
        }

        private void dgvFamiliares_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            int indice = e.RowIndex;

            //eventosModelo.FilaSeleccionadaHistorialEvento = indice;
            if (indice == -1)
            {
                btnEliminar.Enabled = false;
                btnModificar.Enabled = false;
                return;
            }
            btnEliminar.Enabled = true;
            btnModificar.Enabled = true;

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            
            if (DialogResult.No == MessageBox.Show("Esta seguro que desea eliminar el colaborador?", "AVISO", MessageBoxButtons.YesNo))
            {
                return;
            }
            //JUANSE: Metodo eliminar familiar
        }
    }
}
