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
            DataTable salarios = new DataTable();
            salarios = usuarioModelo.getAllUsuarios(legajo);
            for (int i = 0; i < salarios.Rows.Count; i++)
            {
                //crear metodo completar labels
                dgvUsuarios.Rows.Add(salarios.Rows[i]["legajoColaborador"], salarios.Rows[i]["nombre"]);
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
    }
}
