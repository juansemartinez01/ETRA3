using FontAwesome.Sharp;
using System;
using System.Windows.Forms;

namespace PresentationA.Colaboradores
{
    public partial class frmUsuarios : frmHijo
    {
        public frmUsuarios()
        {
            InitializeComponent();
        }
        private void ViewState()
        {
            cmblegajo.Enabled = false;
            cmbperfil.Enabled = false;

            cmblegajo.Text = null;
            cmbperfil.Text = null;

            btnAgregar.Text = "Agregar";
            btnAgregar.IconChar = IconChar.PlusCircle;

            btnModificar.Text = "Agregar";
            btnModificar.IconChar = IconChar.Pen;

            dgvUsuarios.Enabled = true;
            return;
        }
        private void AddState(IconButton sender)
        {
            
            sender.Text = "Guardar";
            sender.IconChar = IconChar.FloppyDisk;
            if(sender == btnAgregar) { btnModificar.Enabled = false; }
            else { btnAgregar.Enabled = false; }
            cmblegajo.Enabled = true;
            cmbperfil.Enabled = true;
            dgvUsuarios.Enabled = false;
            return;
        }

        private void dgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;
            //salarioModelo.FilaSeleccionadaHistorialEvento = indice;
            if (indice == -1)
            {
                return;
            }
            //Utilizar metodo cargar labels, modificarlo para que envie el prefijo del nombre de la columna {lbl,txt}
            DataGridViewRow filaSeleccionada = dgvUsuarios.Rows[indice];
            //completarLabels(this, historial, "txt");
            
            cmblegajo.Text = filaSeleccionada.Cells["legajo"].Value.ToString();
            cmbperfil.Text = filaSeleccionada.Cells["perfil"].Value.ToString();
            ViewState();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            if (btnAgregar.Text == "Guardar")
            {
                // guardar nuevo valor
                if (cmblegajo.SelectedIndex == -1)
                {
                    MessageBox.Show("Debe seleccionar un colaborador.");
                    return;
                }
                if (cmbperfil.SelectedIndex == -1)
                {
                    MessageBox.Show("Debe seleccionar un perfil.");
                    return;
                }
                //Gurdar nuevo usuario asociado a un colaborador
                ViewState();
                return;
            }
            AddState(btnAgregar);
        }

        private void CargarDG(string legajo)
        {
            try
            {
                dgvUsuarios.Rows.Clear();
                //Traer data, metodo en usuario
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (btnModificar.Text == "Guardar")
            {
                // guardar nuevo valor
                if (cmblegajo.SelectedIndex == -1)
                {
                    MessageBox.Show("Debe seleccionar un colaborador.");
                    return;
                }
                if (cmbperfil.SelectedIndex == -1)
                {
                    MessageBox.Show("Debe seleccionar un perfil.");
                    return;
                }
                //Modificar usuario asociado a un colaborador
                ViewState();
                return;
            }
            AddState(btnModificar);
        }
    }
}
