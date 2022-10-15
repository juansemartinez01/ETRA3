using System;
using System.Drawing;
using System.Windows.Forms;
using DomainA;
using PresentationA.Colaboradores;

namespace PresentationA
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
            if (txtPass.Text == "CONTRASEÑA")
            {
                txtPass.Text = "";
                txtPass.UseSystemPasswordChar = true;
            }
            
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
            if (txtUser.Text != "USUARIO")
            {
                if (txtPass.Text != "CONTRASEÑA")
                {
                    UsuarioModelo user = new UsuarioModelo();
                    var validLogin = user.LoginUser(txtUser.Text, txtPass.Text);
                    if (validLogin == true)
                    {
                        frmPrincipal mainMenu = new frmPrincipal();
                        mainMenu.Show();
                        this.Hide();
                    }
                    else
                    {
                        msgError("Error: Usuario o contraseña incorrectos");
                        txtPass_Leave(sender,e);
                        txtUser_Leave(sender,e);
                    }
                }
                else
                {
                   msgError("Error: Por favor, ingrese una contraseña.");
                }
            }
            else
            {
                msgError("Error: Por favor, ingrese un Usuario.");
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
        private void msgError(string msg)
        {
            lblError.Text = "      " + msg;
            lblError.Visible = true;
        }

        private void lnkRecuperar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmRecupero rec = new frmRecupero();
            rec.ShowDialog();
        }
    }
}
