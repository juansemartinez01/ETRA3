using DomainA;
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
        VestimentaModelo vestimenta = new VestimentaModelo();
        public frmVestimenta()
        {
            InitializeComponent();
            btnEliminar.Enabled= false;
            btnModificar.Enabled= false;
            CargarTabla("0");
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
            foreach (DataGridViewColumn col in dgvVestimenta.Columns)
            {
                icol++;
                excel.Cells[1, icol] = col.Name;
                foreach (DataGridViewRow row in dgvVestimenta.Rows)
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
            frmModificarVestimenta modificar = new frmModificarVestimenta(vestimenta.legajoColaborador);
            modificar.ShowDialog();
            btnEliminar.Enabled = false;
            btnModificar.Enabled = false;
            
        }

        public void CargarTabla(string legajo)
        {

            try
            {
                dgvVestimenta.Rows.Clear();
                DataTable vestimentas = vestimenta.obtenerVestimenta(legajo);
                for (int i = 0; i < vestimentas.Rows.Count; i++)
                {
                    //crear metodo completar labels
                    dgvVestimenta.Rows.Add(vestimentas.Rows[i]["Legajo"], vestimentas.Rows[i]["Sucursal"], vestimentas.Rows[i]["Area"], vestimentas.Rows[i]["Pantalon"], vestimentas.Rows[i]["Buzo"], vestimentas.Rows[i]["Remera"], vestimentas.Rows[i]["Calzado"]);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            dgvVestimenta.Sort(dgvVestimenta.Columns[1], ListSortDirection.Ascending);
        }

        private void btnAplicar_Click(object sender, EventArgs e)
        {
            if(cmbColaborador.SelectedValue != null)
            {
                CargarTabla(cmbColaborador.SelectedValue.ToString());
            }
            
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            
            vestimenta.EliminarVestimenta(vestimenta.legajoColaborador);
            MessageBox.Show("Se elimino la vestimenta del legajo " + vestimenta.legajoColaborador + ".");
            btnEliminar.Enabled = false;
            btnModificar.Enabled = false;
            
        }

        private void dgvVestimenta_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;
            vestimenta.filaSeleccionada = indice;
            DataGridViewRow filaSeleccionada = dgvVestimenta.Rows[vestimenta.filaSeleccionada];
            vestimenta.legajoColaborador = int.Parse(filaSeleccionada.Cells["legajoColaborador"].Value.ToString());
            btnEliminar.Enabled = true;
            btnModificar.Enabled = true;
        }
    }
}
