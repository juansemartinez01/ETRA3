using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Domain;

namespace Presentation
{
    public partial class FormularioLogin : Form
    {
        public FormularioLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtUsuario.Text != "")
            {
                if(txtContraseña.Text != "")
                {
                    UsuarioModelo user = new UsuarioModelo();
                    var validLogin = user.LoginUser(txtUsuario.Text, txtContraseña.Text);
                    if(validLogin == true)
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
    }
}
