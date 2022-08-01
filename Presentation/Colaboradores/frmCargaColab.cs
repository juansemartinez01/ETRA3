using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Presentation.Colaboradores
{
    public partial class frmCargaColab : frmHijo
    {
        public frmCargaColab()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (ofdFotoPerfil.ShowDialog() == DialogResult.OK)
            {
                lblFotoPerfil.Text = ofdFotoPerfil.FileName;
            }
        }
    }
}
