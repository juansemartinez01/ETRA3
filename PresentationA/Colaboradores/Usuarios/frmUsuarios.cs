using DomainA;
using FontAwesome.Sharp;
using PresentationA.Colaboradores.Usuarios;
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
            lblError.Visible = false;
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

            btnAgregar.Visible = true;

            btnModificar.Text = "Modificar";
            btnModificar.IconChar = IconChar.Pen;

            dgvUsuarios.Enabled = true;
            return;
        }
        private void AddState(IconButton sender)
        {
            sender.Text = "Guardar";
            sender.IconChar = IconChar.FloppyDisk;
            btnAgregar.Visible = false;
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
            frmNuevoUsuario nuevo = new frmNuevoUsuario();
            nuevo.ShowDialog();
            limpiarCampos();
            CargarTabla(1);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (btnModificar.Text == "Guardar")
            {
                // guardar nuevo valor
                if (cmblegajo.SelectedIndex == -1)
                {
                    msgError("Debe seleccionar un colaborador.");
                    return;
                }
                int legajo = (int)cmblegajo.SelectedValue;
                
                DataTable usuarioExiste = usuarioModelo.getAllUsuarios(legajo);
                if (usuarioExiste.Rows.Count == 0)
                {
                    msgError("Este legajo no tiene ningun perfil asociado, debe crear un nuevo usuario");
                    limpiarCampos();
                    return;
                }
                if (cmbperfil.SelectedIndex == -1)
                {
                    msgError("Debe seleccionar un perfil.");
                    return;
                }

                //Modificar usuario asociado a un colaborador
                
                string respuesta = usuarioModelo.modificarUsuario((int)cmbperfil.SelectedValue, colaboradorModelo.BuscarColaborador(legajo.ToString(), "", "").Rows[0]["mail"].ToString(), (int)cmblegajo.SelectedValue) ;
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
            lblError.Visible = false;
        }


        private void cmblegajo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void msgError(string msg)
        {
            lblError.Text = "      " + msg;
            lblError.Visible = true;
        }

    }
}
