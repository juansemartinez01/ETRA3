using System;
using System.Windows;
using DomainA;

namespace PresentationA.Colaboradores
{
    public partial class frmMail : frmHijo
    {
        AvisosModelo aviso = new AvisosModelo();
        int id;
        public frmMail(int idAviso)
        {
            InitializeComponent();
            id = idAviso;
            lblError.Text = "";
            lblError.Visible = false;
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            string resultado;
            if(txtSubject.Text == "")
            {
                msgError("Debe ingresar un Asunto");
                return;
            }
            if (txtBody.Text == "")
            {
                msgError("Debe ingresar un Cuerpo");
                return ;
            }
            resultado = aviso.notificarAviso(id, txtSubject.Text, txtBody.Text);
            MessageBox.Show(resultado);
            this.Close();
        }

        private void msgError(string msg)
        {
            lblError.Text = "      " + msg;
            lblError.Visible = true;
        }
    }
}
