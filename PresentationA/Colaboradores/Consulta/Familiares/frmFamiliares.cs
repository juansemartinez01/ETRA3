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
            //JUANSE: Metodo para cargar datagridview
            ViewState();
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;
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
            if(btnModificar.Text == "Guardar")
            {
                //JUANSE AGREGAR ACA METODO DE Guardar cambios

                txtnombre.Enabled = false;
                txtdni.Enabled = false;
                cmbParentezco.Enabled = false;
                dtpfechaNacimiento.Enabled = false;
                cmbescolarizacion.Enabled = false;


                btnModificar.Text = "Modificar";
                btnModificar.IconChar = FontAwesome.Sharp.IconChar.Pen;
                return;

            }
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
            btnEliminar.Enabled = true;
            DataGridViewRow filaSeleccionada = dgvFamiliares.Rows[indice];
            ViewState();
            DataTable familiar = new DataTable();
            foreach (DataGridViewColumn column in dgvFamiliares.Columns)
                familiar.Columns.Add(column.Name, column.CellType); //better to have cell type
            for (int i = 0; i < dgvFamiliares.SelectedRows.Count; i++)
            {
                familiar.Rows.Add();
                for (int j = 0; j < dgvFamiliares.Columns.Count; j++)
                {
                    familiar.Rows[i][j] = dgvFamiliares.SelectedRows[i].Cells[j].Value;
                }
                break;
            }
            completarLabels(this, familiar, "lbl");
            completarLabels(this, familiar, "txt");
            completarLabels(this, familiar, "dtp");
            //Completar combobox!!!!!
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            ModifyState();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (DialogResult.No == MessageBox.Show("Esta seguro que desea eliminar el colaborador?", "AVISO", MessageBoxButtons.YesNo))
            {
                return;
            }

            //JUANSE: eliminar familiar

        }
    }
}
