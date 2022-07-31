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
    public partial class FormularioColaborador : Form
    {
        public FormularioColaborador()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtNombre.Text != "")
            {
                ColaboradorModelo colaboradorModelo = new ColaboradorModelo();
                MessageBox.Show(colaboradorModelo.BuscarColaborador(txtNombre.Text));
            }
            else
            {
                MessageBox.Show("Ingrese un nombre.");
            }
        }
    }
}
