using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domain;

namespace Presentation
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void txtUser_Enter(object sender, EventArgs e)
        {
            if (txtUser.Text == "USUARIO")
            {
                txtUser.Text = "";
                txtUser.ForeColor = Color.Black;
                txtUser.Font = new Font(txtUser.Font, FontStyle.Bold);
            }

        }

        private void txtUser_Leave(object sender, EventArgs e)
        {
            if (txtUser.Text == "")
            {
                txtUser.Text = "USUARIO";
                txtUser.ForeColor = Color.DimGray;
                txtUser.Font = new Font(txtUser.Font, FontStyle.Regular);

            }
        }

        private void txtPass_Enter(object sender, EventArgs e)
        {
            txtPass.Text = "";
            txtPass.UseSystemPasswordChar = true;
        }

        private void txtPass_Leave(object sender, EventArgs e)
        {
            if (txtPass.Text == "")
            {
                txtPass.UseSystemPasswordChar = false;
                txtPass.Text = "CONTRASEÑA";
                txtPass.ForeColor = Color.DimGray;
            }
        }

        private void frmLogin_Click(object sender, EventArgs e)
        {
            txtUser_Leave(sender,e) ;
            txtPass_Leave(sender,e) ;
        }



        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUser.Text != "")
            {
                if (txtPass.Text != "")
                {
                    UsuarioModelo user = new UsuarioModelo();
                    var validLogin = user.LoginUser(txtUser.Text, txtPass.Text);
                    if (validLogin == true)
                    {
                        FormularioPrincipal mainMenu = new FormularioPrincipal();
                        mainMenu.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Usuario o contraseña incorrectos");
                    }
                }
                else
                {
                    MessageBox.Show("Ingrese contraseña.");
                }
            }
            else
            {
                MessageBox.Show("Ingrese Usuario.");
            }
        }

        private void txtPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                btnLogin_Click(sender, e);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            txtPass_Leave(sender, e);
            txtUser_Leave(sender, e);
        }
    }
}
