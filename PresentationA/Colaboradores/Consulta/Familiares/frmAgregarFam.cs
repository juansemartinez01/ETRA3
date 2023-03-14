using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationA.Colaboradores.Consulta.Familiares
{
    public partial class frmAgregarFam : frmHijo
    {
        bool hayCambios = false;
        public frmAgregarFam()
        {
            InitializeComponent();
            hayCambios = false;
        }
        private void msgError(string msg)
        {
            lblError.Text = "      " + msg;
            lblError.Visible = true;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void cmb_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //Juanse: metodo guardar cambios
            MessageBox.Show("Familiar guardado con exito!");
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAgregarFam_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (hayCambios == true)
            {
                if (DialogResult.No == MessageBox.Show("Esta seguro que desea descartar los cambios?", "AVISO", MessageBoxButtons.YesNo))
                {
                    e.Cancel = true;
                    return;
                }
            }
        }

        private void txt_TextChanged(object sender, EventArgs e)
        {
            hayCambios= true;
        }
    }
}
