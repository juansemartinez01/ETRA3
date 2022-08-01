using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Domain;

namespace Presentation.Colaboradores
{
    public partial class frmCargaColab : frmHijo
    {
        public frmCargaColab()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (ofdFotoPerfil.ShowDialog() == DialogResult.OK)
            {
                lblFotoPerfil.Text = ofdFotoPerfil.FileName;
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if(txtNombre.Text != "")
            {
                if(txtApellido.Text != "")
                {
                    if(txtDni.Text != "")
                    {
                        if (txtCuit.Text != "")
                        {
                            if (txtCalle.Text != "")
                            {
                                if (txtNroCalle.Text != "")
                                {
                                    ColaboradorModelo colaboradorModelo = new ColaboradorModelo();
                                    var cadenaRespuesta = colaboradorModelo.CrearColaborador(txtNombre.Text, txtApellido.Text, int.Parse(txtDni.Text), int.Parse(txtCuit.Text), txtCalle.Text, int.Parse(txtNroCalle.Text));
                                    MessageBox.Show(cadenaRespuesta);
                                }
                                else
                                {
                                    MessageBox.Show("Debe completar el numero de la calle.");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Debe completar la calle.");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Debe completar el CUIT/CUIL");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Debe completar el DNI");
                    }
                }
                else
                {
                    MessageBox.Show("Debe completar el apellido");
                }
            }
            else
            {
                MessageBox.Show("Debe completar el nombre");
            }
        }
    }
}
