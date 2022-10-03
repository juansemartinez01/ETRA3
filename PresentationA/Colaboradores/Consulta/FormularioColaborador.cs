using System;
using System.Data;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;
using DomainA;
using FontAwesome.Sharp;
using PresentationA.Colaboradores.Consulta;

namespace PresentationA
{
    public partial class FormularioColaborador : frmHijo
    {
        
        public DataTable colaborador = new DataTable();
        public DataTable colaboradores = new DataTable();
        private IconButton botonSeleccionado;
        private Panel bordeInferior;

        public FormularioColaborador()
        {
            InitializeComponent();
            dgvBusqueda.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(242, 103, 34);
            dgvBusqueda.EnableHeadersVisualStyles = false;
            bordeInferior = new Panel();
            bordeInferior.Size = new Size(183, 2);
            pnlBotones.Controls.Add(bordeInferior);
            pnlBotones.Enabled = false;
        }

        private void ActivateButton(object button)
        {
            if (button != null)
            {
                DisableButton();
                botonSeleccionado = (IconButton)button;
                botonSeleccionado.ForeColor = Color.FromArgb(250, 166, 26);
                botonSeleccionado.Font = new Font(botonSeleccionado.Font.Name, botonSeleccionado.Font.Size, FontStyle.Bold);
                //botonSeleccionado.IconColor = Color.Red;

                bordeInferior.BackColor = Color.FromArgb(250, 166, 26);
                bordeInferior.Location = new Point(botonSeleccionado.Location.X, 28);
                bordeInferior.Visible = true;
                bordeInferior.BringToFront();
            }
        }
        private void DisableButton()
        {
            if (botonSeleccionado != null)
            {
                botonSeleccionado.ForeColor = Color.Black;
                botonSeleccionado.Font = new Font(botonSeleccionado.Font.Name, botonSeleccionado.Font.Size, FontStyle.Regular);

            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            
            ColaboradorModelo colaboradorModelo = new ColaboradorModelo();
            dgvBusqueda.Rows.Clear();
            colaboradores = colaboradorModelo.BuscarColaborador(txtLegajo.Text.ToString(), txtNombre.Text.ToString(), txtApellido.Text.ToString());
            //if (txtLegajo.Text != "" || txtNombre.Text != "" || txtApellido.Text != "")
            //{
            //    colaboradores = colaboradorModelo.BuscarColaborador(txtLegajo.Text, txtNombre.Text.ToString(), txtApellido.Text.ToString());
            //}
            //else
            //{
            //    msgError("Error: Debe ingresar al menos un parámetro", true);
            //    return;
                
            //}

            if (colaboradores.Rows.Count == 0)
            {
                msgError("Error: No se encontraron colaboradores con esos parametros.", true);
                dgvBusqueda.Rows.Clear();
                //changeMenu(false);

            }
            else
            {

                msgError("", false);
                pnlBotones.Enabled = true;
                //btnDatosPersonales_Click(btnDatosPersonales, e);
                colaborador = colaboradores.Clone();

                for (int i = 0; i < colaboradores.Rows.Count; i++)
                {
                    dgvBusqueda.Rows.Add(colaboradores.Rows[i]["legajo"], colaboradores.Rows[i]["nombre"], colaboradores.Rows[i]["apellido"]);
                }
                //dgvBusqueda.DataSource = colaboradores;  
                
            }

        }

        private void txtLegajo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;

            }
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                btnBuscar_Click(sender, e);
            }

        }

        private void enter_keyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                btnBuscar_Click(sender, e);
            }
        }
        private Form activeForm = null;
        private void openChildFormInPanel(Form childForm)
        {

            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            childForm.TopMost = true;
            this.pnlFormulario.Controls.Add(childForm);
            pnlFormulario.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            //changeMenu(true);
        }


        private void msgError(string msg, bool esVisible)
        {
            lblError.Text = "      " + msg;
            lblError.Visible = esVisible;
        }

        private void btnDatosPersonales_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            openChildFormInPanel(new frmDatosPersonales(colaborador));
        }

        private void btnDatosGenerales_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            openChildFormInPanel(new frmDatosGenerales(colaborador));
        }

        private void btnHistorial_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            openChildFormInPanel(new frmHistorialEvento(colaborador.Rows[0]["legajo"].ToString()));
        }

        private void btnHistorialSalarios_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            openChildFormInPanel(new frmHistorialSalario(colaborador.Rows[0]["legajo"].ToString()));
        }


        private void dgvBusqueda_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
            colaborador.Clear();
            colaborador.ImportRow(colaboradores.Rows[dgvBusqueda.CurrentRow.Index]);
            btnDatosPersonales_Click(btnDatosPersonales, e);
        }
        //private void changeMenu(bool value)
        //{
        //    datosPersonalesToolStripMenuItem.Enabled = value;
        //    datosGeneralesToolStripMenuItem.Enabled = value;
        //    historialToolStripMenuItem.Enabled = value;
        //    this.pnlFormulario.Visible = value;
        //}

    }
}
