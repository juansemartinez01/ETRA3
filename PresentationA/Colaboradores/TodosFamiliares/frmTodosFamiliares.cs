using DomainA;
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
using System.Windows.Controls;
using System.Windows.Forms;

namespace PresentationA.Colaboradores
{
    public partial class frmTodosFamiliares : frmHijo
    {
        FamiliarColaboradorModelo familiar = new FamiliarColaboradorModelo();
        public frmTodosFamiliares()
        {
            InitializeComponent();
            CargarTabla(0);
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

        

        private void btnAplicar_Click(object sender, EventArgs e)
        {
            if (txtLegajoBusqueda.Text == "")
            {
                CargarTabla(0);
            }
            else
            {
                CargarTabla(int.Parse(txtLegajoBusqueda.Text));
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtLegajoBusqueda.Text = "";
            this.btnAplicar_Click(sender,e);
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

        

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            
            if (DialogResult.No == MessageBox.Show("Esta seguro que desea eliminar el familiar?", "AVISO", MessageBoxButtons.YesNo))
            {
                return;
            }
            if (familiar.indiceFamiliar == -1)
            {
                MessageBox.Show("Debe seleccionar un familiar.");
                return;
            }
            DataGridViewRow filaSeleccionada = dgvFamiliares.Rows[familiar.indiceFamiliar];
            int idFamiliar = int.Parse(filaSeleccionada.Cells["idFamiliar"].Value.ToString());
            familiar.EliminarFamiliarColaborador(idFamiliar);
            CargarTabla(0);
        }
        public void CargarTabla(int legajo)
        {

            try
            {
                dgvFamiliares.Rows.Clear();
                DataTable familiares = familiar.obtenerFamiliares(legajo);
                for (int i = 0; i < familiares.Rows.Count; i++)
                {
                    //crear metodo completar labels
                    dgvFamiliares.Rows.Add(familiares.Rows[i]["idFamiliar"], familiares.Rows[i]["legajo"], familiares.Rows[i]["Nombre"], familiares.Rows[i]["Apellido"], familiares.Rows[i]["Tipo Familiar"], familiares.Rows[i]["Escolarización"], familiares.Rows[i]["Fecha Nacimiento"], familiares.Rows[i]["DNI"], familiares.Rows[i]["obraSocial"], familiares.Rows[i]["trabaja"], familiares.Rows[i]["aportes"], familiares.Rows[i]["nombrecalle"], familiares.Rows[i]["numerocalle"], familiares.Rows[i]["piso"], familiares.Rows[i]["departamento"], familiares.Rows[i]["localidad"], familiares.Rows[i]["provincia"], familiares.Rows[i]["idDireccion"]);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            dgvFamiliares.Sort(dgvFamiliares.Columns[1], ListSortDirection.Ascending);
        }

        private void btnModificar_Click_1(object sender, EventArgs e)
        {
            frmTodosModificarFamiliar modificar = new frmTodosModificarFamiliar(selectedRowTo(dgvFamiliares));
            modificar.ShowDialog();
            CargarTabla(0);
        }

        private DataTable selectedRowTo(DataGridView dgv)
        {
            DataTable dt = new DataTable();
            foreach (DataGridViewColumn column in dgv.Columns)
                dt.Columns.Add(column.Name); //better to have cell type
            for (int i = 0; i < dgv.SelectedRows.Count; i++)
            {
                dt.Rows.Add();
                for (int j = 0; j < dgv.Columns.Count; j++)
                {
                    dt.Rows[i][j] = dgv.SelectedRows[i].Cells[j].Value;
                    //^^^^^^^^^^^
                }
                break;
            }
            return dt;
        }
        private void dgvFamiliares_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;
            familiar.indiceFamiliar = indice;
            DataGridViewRow filaSeleccionada = dgvFamiliares.Rows[familiar.indiceFamiliar];
            int idFamiliar = int.Parse(filaSeleccionada.Cells["idFamiliar"].Value.ToString());
            int idDireccionFamiliar = int.Parse(filaSeleccionada.Cells["idDireccion"].Value.ToString());
            familiar.idFamiliar = idFamiliar;
            familiar.idDireccion = idDireccionFamiliar;
            if (familiar.indiceFamiliar != -1)
            {
                btnEliminar.Enabled = true;
                btnModificar.Enabled = true;
            }
            else
            {
                btnEliminar.Enabled = false;
                btnModificar.Enabled = false;
            }
        }

        private void txtLegajoBusqueda_KeyPress(object sender, KeyPressEventArgs e)
        {
                if (!char.IsNumber(e.KeyChar) && (e.KeyChar != (char)Keys.Back))
                {
                    e.Handled = true;
                }
        }
    }
}
