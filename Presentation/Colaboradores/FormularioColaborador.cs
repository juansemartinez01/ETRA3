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
        
        public FormularioColaborador()
        {
            InitializeComponent();
            
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            
            ColaboradorModelo colaboradorModelo = new ColaboradorModelo();
            if(txtNombre.Text != "" || txtApellido.Text != "")
            {
                txtLegajo.Text = "0";
            }
            if(txtLegajo.Text == "")
            {
                txtLegajo.Text = "0";
            }
            
            string[] colaborador = colaboradorModelo.BuscarColaborador(int.Parse(txtLegajo.Text), txtNombre.Text.ToString(), txtApellido.Text.ToString());
            if(colaborador[0] == "")
            {
                MessageBox.Show("No se encontraron colaboradores con esos parametros.");
            }
            else
            {
                frmDatosPersonales frm = new frmDatosPersonales(colaborador) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                this.pnlFormulario.Controls.Add(frm);
                frm.Show();
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
        }

        private void datosPersonalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Abrir formulario de datos Personales
            openChildFormInPanel(new frmDatosPersonales());

        }

        private void datosGeneralesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new frmDatosGrales());
        }
    }
}
