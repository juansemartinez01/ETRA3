using DomainA;
using PresentationA.Colaboradores.Consulta.Familiares;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationA.Colaboradores.Consulta
{
    public partial class frmFamiliares : frmHijo
    {
        public frmFamiliares()
        {
            InitializeComponent();
            ViewState();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAgregarFam agregar = new frmAgregarFam();
            agregar.ShowDialog();
        }

        private void cmb_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void ViewState()
        {
            txtnombre.Enabled= false;
            txtdni.Enabled = false;
            cmbParentezco.Enabled = false;
            dtpfechaNacimiento.Enabled = false;
            cmbescolarizacion.Enabled = false;

            btnModificar.Visible = true;
            btnModificar.Text = "Modificar";
            btnModificar.IconChar = FontAwesome.Sharp.IconChar.Pen;

        }

        private void ModifyState()
        {
            txtnombre.Enabled = true;
            txtdni.Enabled = true;
            cmbParentezco.Enabled = true;
            dtpfechaNacimiento.Enabled = true;
            cmbescolarizacion.Enabled = true;
            btnEliminar.Enabled = false;


            btnModificar.Visible = true;
            btnModificar.Text = "Guardar";
            btnModificar.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
        }

        private void dgvFamiliares_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;
            //eventosModelo.FilaSeleccionadaHistorialEvento = indice;
            if (indice == -1)
            {
                btnEliminar.Enabled = false;
                btnModificar.Enabled = false;
                return;
            }
            //Utilizar metodo cargar labels, modificarlo para que envie el prefijo del nombre de la columna {lbl,txt}
            DataGridViewRow filaSeleccionada = dgvFamiliares.Rows[indice];
            //completarLabels(this, historial, "txt");
            ViewState();
            //cmbParentezco.SelectedValue = buscarIdConNombre(filaSeleccionada.Cells["parentezco"].Value.ToString(), "TipoEvento");
            //cmbescolarizacion.SelectedValue = buscarIdConNombre(filaSeleccionada.Cells["parentezco"].Value.ToString(), "TipoEvento");
            dtpfechaNacimiento.Text = filaSeleccionada.Cells["fechaNacimiento"].Value.ToString();
            txtdni.Text = filaSeleccionada.Cells["dni"].Value.ToString();
            txtnombre.Text = filaSeleccionada.Cells["nombre"].Value.ToString();
        }
    }
}
