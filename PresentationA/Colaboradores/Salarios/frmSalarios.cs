using DomainA;
using System;
using System.Data;
using System.Windows.Forms;
using PresentationA.Colaboradores.Salarios;

namespace PresentationA.Colaboradores
{
    public partial class frmSalarios : frmHijo
    {
        Salario sal = new Salario();
        ColaboradorModelo colaboradorModelo = new ColaboradorModelo();
        int auxiliar = 0;
        public frmSalarios()
        {
            InitializeComponent();
            lblLegajo.Text = "";
            btnModificar.Enabled = false;
            CargarTabla(1,"","",0,0);
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
            if(lblLegajo.Text == "")
            {
                MessageBox.Show("Debe ingresar un legajo para modificar un salario");
                return;
            }
            if(txtMontoModificacion.Text == "")
            {
                MessageBox.Show("Debe ingresar un monto para modificar un salario");
                return;
            }
            DataTable colaboradorAModificar = colaboradorModelo.BuscarColaborador(lblLegajo.Text, "", "");
            if(colaboradorAModificar.Rows.Count > 0)
            {
                string respuesta = sal.modificarSalarioColaborador(int.Parse(lblLegajo.Text), float.Parse(txtMontoModificacion.Text));
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
            
            txtMontoModificacion.Text = "";
            txtApellidoBusqueda.Text = "";
            txtLegajoBusqueda.Text = "";

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

        private void cmbFiltroCargo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cmbModificarSalarioCargo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cmbCargoPorcentaje_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            CargarTabla(1, "", "", 0, 0);
        }

        private void btnGenerarOrdenes_Click(object sender, EventArgs e)
        {
            if (txtDescripcionComprobante.Text == "")
            {
                MessageBox.Show("Debe ingresar una descripcion");
                return;
            }
            
            DataTable salarios = new DataTable();
            salarios = sal.getAllSalarios(1, "", "", 0, 0);
            MessageBox.Show("Por favor, a continuación, seleccione una carpeta para guardar los comprobantes");
            var folderBrowserDialog1 = new FolderBrowserDialog();
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result != DialogResult.OK) { return; }
            string folderName = folderBrowserDialog1.SelectedPath;
            //Este loop va a buscar todos los datos necesarios para cada comprobante, para cada colaborador que este en el data grid view!
            ComprobanteModelo orden = new ComprobanteModelo();
            foreach (DataGridViewRow row in dgvSalarios.Rows)
            {
                int legajoColaborador = Int32.Parse(row.Cells["legajo"].Value.ToString());
                DataTable colab = colaboradorModelo.BuscarColaborador(legajoColaborador.ToString(), row.Cells["nombre"].Value.ToString(), row.Cells["apellido"].Value.ToString());
                string nombreColaborador = row.Cells["nombre"].Value.ToString() + " " + row.Cells["apellido"].Value.ToString();
                float salarioColaborador = float.Parse(row.Cells["monto"].Value.ToString());
                //Aca iria el codigo que genere cada Orden de pago de cada colaborador, los datos que varian son los que estan arriba.

                string fileName = folderName + "\\OrdenDePago_" + nombreColaborador + "_" + DateTime.Now.ToString("yyyy-MM-dd") + ".pdf";
                MessageBox.Show(orden.generarOrden(nombreColaborador, colab.Rows[0]["nombreCalle"] + " " + colab.Rows[0]["numeroCalle"], salarioColaborador, fileName, "ORDEN DE PAGO", txtDescripcionComprobante.Text));

            }


        }

        private void botonPadre3_Click(object sender, EventArgs e)
        {
            frmModPorCargo modificar = new frmModPorCargo();
            modificar.ShowDialog();
        }

        private void dgvSalarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;
            if (indice == -1)
            {
                lblLegajo.Text = "";
                btnModificar.Enabled = false;
                return;
            }
            //Utilizar metodo cargar labels, modificarlo para que envie el prefijo del nombre de la columna {lbl,txt}
            DataGridViewRow filaSeleccionada = dgvSalarios.Rows[indice];
            lblLegajo.Text = filaSeleccionada.Cells["legajo"].Value.ToString();
            btnModificar.Enabled = true;
        }
    }
}
