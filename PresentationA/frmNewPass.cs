using System;
using System.Drawing;
using System.Windows;
using DomainA;


namespace PresentationA
{
    public partial class frmNewPass : frmHijo
    {
        public string userName;
        public frmNewPass(string user)
        {
            InitializeComponent();
            lblError.Visible = false;
            userName = user;
        }
        private void txtNew_Enter(object sender, EventArgs e)
        {
            if (txtNew.Text == "NUEVA CONTRASEÑA")
            {
                txtNew.Text = "";
                txtNew.ForeColor = Color.Black;
                txtNew.Font = new System.Drawing.Font(txtNew.Font, System.Drawing.FontStyle.Bold);
            }
        }
        private void txtNew_Leave(object sender, EventArgs e)
        {
            if (txtNew.Text == "")
            {
                txtNew.Text = "NUEVA CONTRASEÑA";
                txtNew.ForeColor = Color.DimGray;
                txtNew.Font = new System.Drawing.Font(txtNew.Font, System.Drawing.FontStyle.Regular);
            }
        }
        private void txtConfirm_Enter(object sender, EventArgs e)
        {
            if (txtConfirm.Text == "REPITA SU NUEVA CONTRASEÑA")
            {
                txtConfirm.Text = "";
                txtConfirm.ForeColor = Color.Black;
                txtConfirm.Font = new System.Drawing.Font(txtConfirm.Font, System.Drawing.FontStyle.Bold);
            }
        }
        private void txtConfirm_Leave(object sender, EventArgs e)
        {
            if (txtConfirm.Text == "")
            {
                txtConfirm.Text = "REPITA SU NUEVA CONTRASEÑA";
                txtConfirm.ForeColor = Color.DimGray;
                txtConfirm.Font = new System.Drawing.Font(txtConfirm.Font, System.Drawing.FontStyle.Regular);
            }
        }
        private void msgError(string msg)
        {
            lblError.Text = "      " + msg;
            lblError.Visible = true;
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (txtConfirm.Text != txtNew.Text)
            {
                msgError("Las contraseñas son diferentes");
                return;
            }
            else
            {
                // las contraseñas son iguales
                UsuarioModelo user = new UsuarioModelo();
                string result = user.updatePassword(userName, txtConfirm.Text);
                if (result == "")
                {
                    MessageBox.Show("Contraseña actualizada con exito");
                    this.Close();
                    return;
                }
                
            }
        }
    }
}
