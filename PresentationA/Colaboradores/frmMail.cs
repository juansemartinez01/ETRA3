using System;
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
            bool sent = false;
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
            sent = aviso.notificarAviso(id, txtSubject.Text, txtBody.Text);
            if (sent) { this.Close(); }
            else { msgError("Ocurrio un error al enviar el mensaje"); }
        }

        private void msgError(string msg)
        {
            lblError.Text = "      " + msg;
            lblError.Visible = true;
        }
    }
}
