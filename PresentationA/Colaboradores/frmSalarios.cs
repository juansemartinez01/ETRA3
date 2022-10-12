using DomainA;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;


namespace PresentationA.Colaboradores
{
    public partial class frmSalarios : frmHijo
    {
        Salario sal = new Salario();
        ColaboradorModelo colaboradorModelo = new ColaboradorModelo();
        public frmSalarios()
        {
            InitializeComponent();
            CargarTabla();
            LlenarCombo(cmbModificarSalarioCargo, DataManager.GetInstance().ConsultaSQL("SELECT * FROM Cargo WHERE borradoLogico = 0"), "nombre", "id_cargo");
            LlenarCombo(cmbCargoPorcentaje, DataManager.GetInstance().ConsultaSQL("SELECT * FROM Cargo WHERE borradoLogico = 0"), "nombre", "id_cargo");
            LlenarCombo(cmbFiltroCargo, DataManager.GetInstance().ConsultaSQL("SELECT * FROM Cargo WHERE borradoLogico = 0"), "nombre", "id_cargo");

        }
        private void LlenarCombo(ComboBox cbo, Object source, string display, String value)
        {
            cbo.ValueMember = value;
            cbo.DisplayMember = display;
            cbo.DataSource = source;
            cbo.SelectedIndex = -1;
        }
        public void CargarTabla()
        {
            dgvSalarios.Rows.Clear();
            DataTable salarios = new DataTable();
            salarios = sal.getAllSalarios();
            for (int i = 0; i < salarios.Rows.Count; i++)
            {
                //crear metodo completar labels
                dgvSalarios.Rows.Add(salarios.Rows[i]["legajo"],salarios.Rows[i]["monto"], salarios.Rows[i]["fechaInicio"]);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if(txtLegajoColaboradorModificacion.Text == "")
            {
                MessageBox.Show("Debe ingresar un legajo para modificar un salario");
                return;
            }
            if(txtMontoModificacion.Text == "")
            {
                MessageBox.Show("Debe ingresar un monto para modificar un salario");
                return;
            }
            DataTable colaboradorAModificar = colaboradorModelo.BuscarColaborador(txtLegajoColaboradorModificacion.Text, "", "");
            if(colaboradorAModificar.Rows.Count > 0)
            {
                string respuesta = sal.modificarSalarioColaborador(int.Parse(txtLegajoColaboradorModificacion.Text), float.Parse(txtMontoModificacion.Text));
                MessageBox.Show(respuesta);
                CargarTabla();
                LimpiarCampos();
                return;
                
            }
            MessageBox.Show("El legajo del colaborador que solicita no existe o ha sido eliminado");
            LimpiarCampos();
        }
        private void LimpiarCampos()
        {
            txtLegajoColaboradorModificacion.Text = "";
            txtMontoModificacion.Text = "";
            cmbModificarSalarioCargo.SelectedIndex = -1;
            txtMontoModificarSalarioCargo.Text = "";
            txtApellidoBusqueda.Text = "";
            txtLegajoBusqueda.Text = "";
            txtPorcentaje.Text = "";
            cmbCargoPorcentaje.SelectedIndex = -1;
            cmbFiltroCargo.SelectedIndex = -1;
        }

        private void btnAplicar_Click(object sender, EventArgs e)
        {
            if(cmbFiltroCargo.SelectedIndex != -1)
            {
                dgvSalarios.Rows.Clear();
                DataTable salarios = new DataTable();
                salarios = sal.getAllSalariosPorCargo(int.Parse(cmbFiltroCargo.SelectedValue.ToString()));
                for (int i = 0; i < salarios.Rows.Count; i++)
                {
                    //crear metodo completar labels
                    dgvSalarios.Rows.Add(salarios.Rows[i]["legajo"], salarios.Rows[i]["monto"], salarios.Rows[i]["fechaInicio"]);
                }
                LimpiarCampos();
            }
        }


        private void btnExportar_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            excel.Application.Workbooks.Add(true);
            int icol = 0;
            int irow = 0;
            foreach (DataGridViewColumn col in dgvSalarios.Columns)
            {
                icol++;
                excel.Cells[1, icol] = col.Name;
                foreach (DataGridViewRow row in dgvSalarios.Rows)
                {
                    irow++;
                    excel.Cells[irow + 1, icol] = row.Cells[col.Name].Value;
                }
                irow = 0;
            }

            excel.Visible = true;
        }

        private void btnModificarSalariosCargo_Click(object sender, EventArgs e)
        {
            if(txtMontoModificarSalarioCargo.Text == "" || cmbModificarSalarioCargo.SelectedIndex == -1)
            {
                MessageBox.Show("Debe completar ambos campos para poder modificar");
                LimpiarCampos();
                return;
            }
            else
            {
                string mensaje = sal.modificarSalariosDeCargo(int.Parse(cmbModificarSalarioCargo.SelectedValue.ToString()), float.Parse(txtMontoModificarSalarioCargo.Text.ToString()));
                MessageBox.Show(mensaje);
                LimpiarCampos();
                CargarTabla();
            }
            
        }

        private void btnPorcentaje_Click(object sender, EventArgs e)
        {
            if(txtPorcentaje.Text == "" || cmbCargoPorcentaje.SelectedIndex == -1)
            {
                MessageBox.Show("Debe completar ambos campos para poder modificar");
                LimpiarCampos();
                return;
            }
            else
            {
                string mensaje = sal.modificarSalariosCargoPorcentaje(int.Parse(cmbCargoPorcentaje.SelectedValue.ToString()), float.Parse(txtPorcentaje.Text.ToString()));
                MessageBox.Show(mensaje);
                LimpiarCampos();
                CargarTabla();
            }
        }
    }
}
