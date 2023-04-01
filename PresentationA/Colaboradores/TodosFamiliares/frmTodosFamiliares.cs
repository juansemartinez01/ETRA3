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

        private void dgvFamiliares_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            
            if (DialogResult.No == MessageBox.Show("Esta seguro que desea eliminar el colaborador?", "AVISO", MessageBoxButtons.YesNo))
            {
                return;
            }
            if (familiar.indiceFamiliar == -1)
            {
                MessageBox.Show("Debe seleccionar un archivo.");
                return;
            }
            DataGridViewRow filaSeleccionada = dgvFamiliares.Rows[familiar.indiceFamiliar];
            int idFamiliar = int.Parse(filaSeleccionada.Cells["Numero"].Value.ToString());
            familiar.EliminarFamiliarColaborador(idFamiliar);
            CargarTabla(0);
        }
        public void CargarTabla(int legajo)
        {

            try
            {
                dgvFamiliares.Rows.Clear();
                DataTable familiares = new DataTable();
                familiares = familiar.obtenerFamiliares(legajo);
                for (int i = 0; i < familiares.Rows.Count; i++)
                {
                    //crear metodo completar labels
                    dgvFamiliares.Rows.Add(familiares.Rows[i]["idFamiliar"], familiares.Rows[i]["legajo"], familiares.Rows[i]["Nombre"], familiares.Rows[i]["Apellido"], familiares.Rows[i]["Tipo Familiar"], familiares.Rows[i]["Escolarización"], familiares.Rows[i]["Fecha Nacimiento"], familiares.Rows[i]["DNI"], familiares.Rows[i]["obraSocial"], familiares.Rows[i]["trabaja"], familiares.Rows[i]["aportes"], familiares.Rows[i]["nombrecalle"], familiares.Rows[i]["numerocalle"], familiares.Rows[i]["piso"], familiares.Rows[i]["departamento"], familiares.Rows[i]["localidad"], familiares.Rows[i]["provincia"]);
                }


            }
            catch (Exception ex)
            {
                throw ex;
            }
            dgvFamiliares.Sort(dgvFamiliares.Columns[0], ListSortDirection.Ascending);
        }

        private void btnModificar_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show(familiar.indiceFamiliar.ToString());
            frmTodosModificarFamiliar modificar = new frmTodosModificarFamiliar(familiar.indiceFamiliar);
            modificar.ShowDialog();
        }
    }
}
