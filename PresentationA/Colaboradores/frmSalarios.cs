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

        }
        public void CargarTabla()
        {
            DataTable salarios = sal.getAllSalarios();
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
        }

        private void btnAplicar_Click(object sender, EventArgs e)
        {
            if(txtLegajoBusqueda.Text != "")
            {

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
    }
}
