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
            CargarTabla(1,"","",0,0);
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
        public void CargarTabla(int legajo,string nombre,string apellido, float monto, int cargo)
        {
            dgvSalarios.Rows.Clear();
            DataTable salarios = new DataTable();
            salarios = sal.getAllSalarios(legajo,nombre,apellido,monto,cargo);
            for (int i = 0; i < salarios.Rows.Count; i++)
            {
                //crear metodo completar labels
                dgvSalarios.Rows.Add(salarios.Rows[i]["legajo"], salarios.Rows[i]["nombre"], salarios.Rows[i]["apellido"], salarios.Rows[i]["monto"], salarios.Rows[i]["fechaInicio"]);
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
                CargarTabla(1, "", "", 0, 0);
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
            txtMontoBusqueda.Text = "";
            txtNombreBusqueda.Text = "";
        }

        private void btnAplicar_Click(object sender, EventArgs e)
        {
            int legajo = 1;
            string nombre = "";
            string apellido = "";
            float monto = 0;
            int cargo = 0;
            if(txtLegajoBusqueda.Text != "")
            {
                legajo = int.Parse(txtLegajoBusqueda.Text);
            }
            if(txtNombreBusqueda.Text != "")
            {
                nombre = txtNombreBusqueda.Text;
            }
            if(txtApellidoBusqueda.Text != "")
            {
                apellido = txtApellidoBusqueda.Text;
            }
            if(txtMontoBusqueda.Text != "")
            {
                monto = float.Parse(txtMontoBusqueda.Text);
            }
            if(cmbFiltroCargo.SelectedIndex != -1)
            {
                cargo = int.Parse(cmbFiltroCargo.SelectedValue.ToString());
            }
            CargarTabla(legajo,nombre, apellido, monto, cargo);
            LimpiarCampos();
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
                CargarTabla(1,"","",0,0);
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
                CargarTabla(1, "", "", 0, 0);
            }
        }

        private void txtLegajoBusqueda_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void txtMontoBusqueda_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void txtLegajoColaboradorModificacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void txtMontoModificarSalarioCargo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void txtPorcentaje_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void txtMontoModificacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }
        }
    }
}
