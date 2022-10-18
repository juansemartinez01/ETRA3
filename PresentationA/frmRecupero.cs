using System;
using System.Collections.Generic;
using System.Drawing;
using DomainA;


namespace PresentationA
{
    public partial class frmRecupero : frmHijo
    {
        string codigo;
        public frmRecupero()
        {
            InitializeComponent();
            lblInfo.Text = "Te vamos a enviar un código para " + "\r\n" + "recuperar tu contraseña.";
            txtCode.Visible = false;
            btnValidar.Visible = false;
            lblError.Visible = false;
        }
        private void msgError(string msg)
        {
            lblError.Text = "      " + msg;
            lblError.Visible = true;
        }
        private void txtMail_Enter(object sender, EventArgs e)
        {
            if (txtMail.Text == "INGRESE AQUÍ SU MAIL")
            {
                txtMail.Text = "";
                txtMail.ForeColor = Color.Black;
                txtMail.Font = new System.Drawing.Font(txtMail.Font, FontStyle.Bold);
            }
        }
        private void txtMail_Leave(object sender, EventArgs e)
        {
            if (txtMail.Text == "")
            {
                txtMail.Text = "INGRESE AQUÍ SU MAIL";
                txtMail.ForeColor = Color.DimGray;
                txtMail.Font = new System.Drawing.Font(txtMail.Font, FontStyle.Regular);

            }
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            var user = new UsuarioModelo();
            List<string> result = user.recoverPassword(txtMail.Text);
            msgError(result[0]);
            if (result.Count == 2)
            {
                btnEnviar.Text = "Enviar nuevo código";
                btnValidar.Visible = true;
                txtCode.Visible = true;
                codigo = result[1];
            }
        }

        private void frmRecupero_Click(object sender, EventArgs e)
        {
            txtMail_Leave(sender, e);
        }

        private void txtCode_Leave(object sender, EventArgs e)
        {
            if (txtCode.Text == "")
            {
                txtCode.Text = "INGRESE AQUÍ SU CÓDIGO";
                txtCode.ForeColor = Color.DimGray;
                txtCode.Font = new System.Drawing.Font(txtMail.Font, FontStyle.Regular);

            }
        }

        private void txtCode_Enter(object sender, EventArgs e)
        {
            if (txtCode.Text == "INGRESE AQUÍ SU CÓDIGO")
            {
                txtCode.Text = "";
                txtCode.ForeColor = Color.Black;
                txtCode.Font = new System.Drawing.Font(txtMail.Font, FontStyle.Bold);
            }
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            if(txtCode.Text == "" || txtCode.Text == "INGRESE AQUÍ SU CÓDIGO")
            {
                msgError("Debe ingresar un codigo");
                return;
            }
            if(txtCode.Text == codigo)
            {
                this.Hide();
                frmNewPass newpass = new frmNewPass(txtMail.Text);
                newpass.ShowDialog();
            }
            else
            {
                msgError("Código Inválido");
            }
        }
    }
}
