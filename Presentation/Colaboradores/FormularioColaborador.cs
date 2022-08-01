using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Domain;

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

        private void datosPersonalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Abrir formulario de datos Personales
            frmDatosPersonales frm = new frmDatosPersonales(){ Dock = DockStyle.Fill, TopLevel = false,TopMost = true };
            this.pnlFormulario.Controls.Add(frm);
            frm.Show();
        }
    }
}
