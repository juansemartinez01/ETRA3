using DomainA;
using FontAwesome.Sharp;
using System;
using System.Data;
using System.Windows.Forms;

namespace PresentationA.Colaboradores
{
    public partial class frmUsuarios : frmHijo
    {
        UsuarioModelo usuarioModelo = new UsuarioModelo();
        ColaboradorModelo colaboradorModelo = new ColaboradorModelo();
        public frmUsuarios()
        {
            InitializeComponent();
            LlenarCombo(cmblegajo, DataManager.GetInstance().ConsultaSQL("SELECT * FROM Colaborador WHERE borradoLogico = 0"), "legajo", "legajo");
            LlenarCombo(cmbperfil, DataManager.GetInstance().ConsultaSQL("SELECT * FROM Perfil WHERE borradoLogico = 0"), "nombre", "id_perfil");
            CargarTabla(1);
            limpiarCampos();
        }
        private void LlenarCombo(ComboBox cbo, Object source, string display, String value)
        {
            cbo.ValueMember = value;
            cbo.DisplayMember = display;
            cbo.DataSource = source;
            cbo.SelectedIndex = -1;
        }
        public void CargarTabla(int legajo)
        {
            dgvUsuarios.Rows.Clear();
            DataTable usuarios = new DataTable();
            usuarios = usuarioModelo.getAllUsuarios(legajo);
            for (int i = 0; i < usuarios.Rows.Count; i++)
            {
                //crear metodo completar labels
                dgvUsuarios.Rows.Add(usuarios.Rows[i]["legajoColaborador"], usuarios.Rows[i]["nombre"]);
            }
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
            string mail;
            if (btnAgregar.Text == "Guardar")
            {
                // guardar nuevo valor
                if (cmblegajo.SelectedIndex == -1)
                {
                    MessageBox.Show("Debe seleccionar un colaborador.");
                    return;
                }
                int legajo = (int)cmblegajo.SelectedValue;
                bool existeUsuario = false;
                DataTable usuarioExiste = usuarioModelo.getAllUsuarios(legajo);
                if(usuarioExiste.Rows.Count > 0)
                {
                    MessageBox.Show("Este legajo ya tiene asignado un usaurio con el perfil de " + usuarioExiste.Rows[0]["nombre"]);
                    limpiarCampos();
                    return;
                }
                if (cmbperfil.SelectedIndex == -1)
                {
                    MessageBox.Show("Debe seleccionar un perfil.");
                    return;
                }
                if (chkMail.Checked)
                {
                    mail = txtMail.Text;
                }
                else
                {
                    mail = colaboradorModelo.buscarMailColaborador(int.Parse(cmblegajo.SelectedValue.ToString()));
                    if(mail == "No especifica")
                    {
                        MessageBox.Show("No se asigno ningun mail a este colaborador, debera especificarlo manualmente.");
                        chkMail.Checked = true;
                        txtMail.Enabled = true;
                    }
                }
                if(txtContraseña.Text == "")
                {
                    MessageBox.Show("Debe asignar una contraseña");
                    return;
                }
                string contraseña = txtContraseña.Text;
                //Gurdar nuevo usuario asociado a un colaborador
                string respuesta = usuarioModelo.crearNuevoUsuario((int)cmbperfil.SelectedValue, mail, contraseña, (int)cmblegajo.SelectedValue);
                MessageBox.Show(respuesta);
                limpiarCampos();
                CargarTabla(1);

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
            chkMail.Checked = true;
            if (btnModificar.Text == "Guardar")
            {
                // guardar nuevo valor
                if (cmblegajo.SelectedIndex == -1)
                {
                    MessageBox.Show("Debe seleccionar un colaborador.");
                    return;
                }
                int legajo = (int)cmblegajo.SelectedValue;
                
                DataTable usuarioExiste = usuarioModelo.getAllUsuarios(legajo);
                if (usuarioExiste.Rows.Count == 0)
                {
                    MessageBox.Show("Este legajo no tiene ningun perfil asociado, debe crear un nuevo usuario");
                    limpiarCampos();
                    return;
                }
                if (cmbperfil.SelectedIndex == -1)
                {
                    MessageBox.Show("Debe seleccionar un perfil.");
                    return;
                }
                if (txtContraseña.Text == "")
                {
                    MessageBox.Show("Debe asignar una contraseña");
                    return;
                }
                if (txtMail.Text == "")
                {
                    MessageBox.Show("Debe asignar un nuevo mail");
                    return;
                }
                string mail = txtMail.Text;
                string contraseña = txtContraseña.Text;
                //Modificar usuario asociado a un colaborador
                string respuesta = usuarioModelo.modificarUsuario((int)cmbperfil.SelectedValue, mail, contraseña, (int)cmblegajo.SelectedValue);
                MessageBox.Show(respuesta);
                limpiarCampos();
                CargarTabla(1);
                ViewState();
                return;
            }
            AddState(btnModificar);
        }
        public void limpiarCampos()
        {
            cmblegajo.SelectedIndex = -1;
            cmbperfil.SelectedIndex = -1;
            chkMail.Checked = false;
            txtMail.Enabled = false;
            txtMail.Text = "";
            txtContraseña.Text = "";
        }

        private void chkMail_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMail.Checked)
            {
                txtMail.Enabled = true;
            }
            else
            {
                txtMail.Enabled = false;
            }
        }

        private void cmblegajo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cmbperfil_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
