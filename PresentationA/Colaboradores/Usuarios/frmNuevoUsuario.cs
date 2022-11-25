using DomainA;
using System;
using System.Data;
using System.Windows.Forms;

namespace PresentationA.Colaboradores.Usuarios
{
    public partial class frmNuevoUsuario : frmHijo
    {

        UsuarioModelo usuarioModelo = new UsuarioModelo();
        ColaboradorModelo colaboradorModelo = new ColaboradorModelo();
        public frmNuevoUsuario()
        {
            InitializeComponent();
            LlenarCombo(cmblegajo, DataManager.GetInstance().ConsultaSQL("SELECT * FROM Colaborador WHERE borradoLogico = 0"), "legajo", "legajo");
            LlenarCombo(cmbperfil, DataManager.GetInstance().ConsultaSQL("SELECT * FROM Perfil WHERE borradoLogico = 0"), "nombre", "id_perfil");
            lblError.Visible= false;
        }
        private void LlenarCombo(ComboBox cbo, Object source, string display, String value)
        {
            cbo.ValueMember = value;
            cbo.DisplayMember = display;
            cbo.DataSource = source;
            cbo.SelectedIndex = -1;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string mail;
            if (cmblegajo.SelectedIndex == -1)
            {
                msgError("Debe seleccionar un colaborador.");
                return;
            }
            int legajo = (int)cmblegajo.SelectedValue;
            DataTable usuarioExiste = usuarioModelo.getAllUsuarios(legajo);
            if (usuarioExiste.Rows.Count > 0)
            {
                msgError("Este legajo ya tiene asignado un usuario con el perfil de " + usuarioExiste.Rows[0]["nombre"]);
                return;
            }
            if (cmbperfil.SelectedIndex == -1)
            {
                msgError("Debe seleccionar un perfil.");
                return;
            }
            if (txtContraseña.Text == "")
            {
                msgError("Debe asignar una contraseña");
                return;
            }
            string contraseña = txtContraseña.Text;
            //Gurdar nuevo usuario asociado a un colaborador
            string respuesta = usuarioModelo.crearNuevoUsuario((int)cmbperfil.SelectedValue, colaboradorModelo.BuscarColaborador(legajo.ToString(),"","").Rows[0]["mail"].ToString(), contraseña, (int)cmblegajo.SelectedValue) ;
            MessageBox.Show(respuesta);
            this.Close();
        }

        private void msgError(string msg)
        {
            lblError.Text = "      " + msg;
            lblError.Visible = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmblegajo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
