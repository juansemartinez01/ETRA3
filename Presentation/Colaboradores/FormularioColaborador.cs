using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Domain;
using Presentation.Colaboradores;

namespace Presentation
{
    public partial class FormularioColaborador : frmHijo
    {
        public DataTable colaborador = new DataTable();
        public FormularioColaborador()
        {
            InitializeComponent();
            changeMenu(false);

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            
            ColaboradorModelo colaboradorModelo = new ColaboradorModelo();
            if (txtLegajo.Text != "")
            {
                colaborador = colaboradorModelo.BuscarColaborador(int.Parse(txtLegajo.Text), txtNombre.Text.ToString(), txtApellido.Text.ToString());
            }
            else
            {
                if (txtNombre.Text != "" || txtApellido.Text != "")
                {
                    //txtLegajo.Text = "0";
                    colaborador = colaboradorModelo.BuscarColaborador(0, txtNombre.Text.ToString(), txtApellido.Text.ToString());
                }
                else
                {
                    msgError("Error: Debe ingresar al menos un parámetro");
                    changeMenu(false);
                    return;
                }
            }
            
            if (colaborador.Rows.Count == 0) 
            {
                msgError("Error: No se encontraron colaboradores con esos parametros.");
                changeMenu(false);

            }
            else
            {

                //datosPersonalesToolStripMenuItem.BackColor = Color.FromArgb(250, 166, 26);

                openChildFormInPanel(new frmDatosPersonales(colaborador));
            }

        }

        private void txtLegajo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
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
            changeMenu(true);
        }

        private void datosPersonalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Abrir formulario de datos Personales
            openChildFormInPanel(new frmDatosPersonales(colaborador));

        }

        private void datosGeneralesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new frmDatosGrales(colaborador));
        }

        private void historialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new frmHistorial(colaborador.Rows[0]["legajo"].ToString()));
        }
        private void msgError(string msg)
        {
            lblError.Text = "      " + msg;
            lblError.Visible = true;
        }
        private void changeMenu(bool value)
        {
            datosPersonalesToolStripMenuItem.Enabled = value;
            datosGeneralesToolStripMenuItem.Enabled = value;
            historialToolStripMenuItem.Enabled = value;
            this.pnlFormulario.Visible = value;
        }
        
    }
}
