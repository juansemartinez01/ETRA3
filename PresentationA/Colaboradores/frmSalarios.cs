using DomainA;
using System;
using System.Data;
using System.Drawing.Printing;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;


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
            string descripcionComprobantes = txtDescripcionComprobante.Text;
            
            DataTable salarios = new DataTable();
            salarios = sal.getAllSalarios(1, "", "", 0, 0);

            //Este loop va a buscar todos los datos necesarios para cada comprobante, para cada colaborador
            //for (int i = 0; i < salarios.Rows.Count; i++)
            //{
            //    int legajoColaborador = (int)salarios.Rows[i]["legajo"];
            //    string nombreColaborador = salarios.Rows[i]["nombre"].ToString();
            //    string apellidoColaborador = salarios.Rows[i]["apellido"].ToString();
            //    float salarioColaborador = (float)salarios.Rows[i]["monto"];
            //    //Aca iria el codigo que genere cada Orden de pago de cada colaborador, los datos que varian son los que estan arriba.

            //}
            for (int i = 0; i < dgvSalarios.RowCount; i++) 
            {
                if (auxiliar >= dgvSalarios.RowCount) { auxiliar = 0; break; }
                pntOrden = new PrintDocument();
                PrinterSettings ps = new PrinterSettings();
                pntOrden.PrinterSettings = ps;
                pntOrden.PrintPage += printOrden;
                pntOrden.Print();
                auxiliar += 1;
            }
            
        }
        private void printOrden(object sender, PrintPageEventArgs e)
        {
            Font font = new Font("Arial", 11);
            int ancho = 800;
            int y = 70;
            Bitmap original = (Bitmap)Image.FromFile("Resources/ETRA_Isologotipo-01.png");
            Bitmap resized = new Bitmap(original, new Size(original.Width / 20, original.Height / 20));
            //string direccion = row["nombreCalle"].ToString() + " " + colaborador.Rows[0]["numeroCalle"].ToString();
            e.Graphics.DrawImage(resized, 10, 0);
            e.Graphics.DrawString("ETRA DISTRIBUCIONES S.R.L. EN FORMACIÓN", font, Brushes.Black, new RectangleF(resized.Size.Width + 10, 0, ancho, 30));
            e.Graphics.DrawString("Las Heras 555 - Río Tercero - CÓRDOBA", font, Brushes.Black, new RectangleF(resized.Size.Width + 10, 30, ancho, 30));
            e.Graphics.DrawString("C.U.I.T.: 30-71605992-4", font, Brushes.Black, new RectangleF(resized.Size.Width + 10, 60, ancho, 30));
            e.Graphics.DrawString("Ing. Brutos: 282470888", font, Brushes.Black, new RectangleF(460, 60, ancho, 30));

            e.Graphics.DrawRectangle(new Pen(Color.Black), 10, y + 10, ancho, 90);
            e.Graphics.DrawString("ORDEN DE PAGO Nº: ", font, Brushes.Black, new RectangleF(460, y + 20, ancho, 30));
            e.Graphics.DrawString("Original", font, Brushes.Black, new RectangleF(10, y + 20, ancho, 30));
            e.Graphics.DrawString("Colaborador: " + dgvSalarios.Rows[auxiliar].Cells["nombre"].Value.ToString() + " " + dgvSalarios.Rows[auxiliar].Cells["apellido"].Value.ToString(), font, Brushes.Black, new RectangleF(10, y + 50, ancho, 30));
            e.Graphics.DrawString("Dir: ", font, Brushes.Black, new RectangleF(10, y + 80, ancho, 30));
            e.Graphics.DrawString("Fecha: " + DateTime.Now.ToString(), font, Brushes.Black, new RectangleF(460, y + 50, ancho, 30)); ;

            e.Graphics.DrawString("Saldo Cta Cte: " + label15.Text, font, Brushes.Black, new RectangleF(10, y + 110, ancho, 30));

            e.Graphics.DrawRectangle(new Pen(Color.Black), 10, y + 130, ancho, 20);
            e.Graphics.DrawString("Cuenta", font, Brushes.Black, new RectangleF(10, y + 130, ancho, 30));
            e.Graphics.DrawString("001 - CAJA ADMIN", font, Brushes.Black, new RectangleF(10, y + 160, ancho, 30));
            e.Graphics.DrawString("Debe", font, Brushes.Black, new RectangleF(460, y + 130, ancho, 30));
            e.Graphics.DrawString(dgvSalarios.Rows[auxiliar].Cells["monto"].Value.ToString(), font, Brushes.Black, new RectangleF(460, y + 160, ancho, 30));
            e.Graphics.DrawString("Haber", font, Brushes.Black, new RectangleF(610, y + 130, ancho, 30));
            e.Graphics.DrawString("0,00", font, Brushes.Black, new RectangleF(610, y + 160, ancho, 30));

            e.Graphics.DrawRectangle(new Pen(Color.Black), 10, y + 250, ancho, 20);
            e.Graphics.DrawString("TOTAL: $" + dgvSalarios.Rows[auxiliar].Cells["monto"].Value.ToString(), font, Brushes.Black, new RectangleF(610, y + 250, ancho, 30));

            e.Graphics.DrawString("Notas: ", font, Brushes.Black, new RectangleF(10, y + 300, ancho, 30));
            e.Graphics.DrawString("Recibí conforme de ETRA DISTRIBUCIONES S.R.L. EN FORMACIÓN EL IMPORTE EN PESOS:__________ ", font, Brushes.Black, new RectangleF(10, y + 330, ancho + 100, 50));

            e.Graphics.DrawString("___________________", font, Brushes.Black, new RectangleF(10, y + 390, ancho, 30));
            e.Graphics.DrawString("FIRMA", font, Brushes.Black, new RectangleF(10, y + 420, ancho, 30));

            e.Graphics.DrawString("___________________", font, Brushes.Black, new RectangleF(260, y + 390, ancho, 30));
            e.Graphics.DrawString("ACLARACIÓN", font, Brushes.Black, new RectangleF(260, y + 420, ancho, 30));

            e.Graphics.DrawString("___________________", font, Brushes.Black, new RectangleF(510, y + 390, ancho, 30));
            e.Graphics.DrawString("TIPO Y NRO DE DOC.", font, Brushes.Black, new RectangleF(510, y + 420, ancho, 30));


        }
    }
}
