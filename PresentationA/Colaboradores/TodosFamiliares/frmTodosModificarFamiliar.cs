using DomainA;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationA.Colaboradores.TodosFamiliares
{
    public partial class frmTodosModificarFamiliar : frmHijo
    {
        FamiliarColaboradorModelo familiarModificado = new FamiliarColaboradorModelo();
        bool hayCambios = false;
        public frmTodosModificarFamiliar(int idFamiliar)
        {
            
            InitializeComponent();
            familiarModificado.idFamiliar = idFamiliar;
            hayCambios = false;
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //familiarModificado.ModificarFamiliarColaborador();
            MessageBox.Show("Familiar modificado con exito!");
            this.Close();
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void txt_TextChanged(object sender, EventArgs e)
        {
            hayCambios = true;
        }

        private void frmTodosModificarFamiliar_FormClosing(object sender, FormClosingEventArgs e)
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

    }
}
