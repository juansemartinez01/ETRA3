using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using Domain;

namespace Presentation.Colaboradores
{
    public partial class frmCargaColab : frmHijo
    {
        DocumentosColaborador nuevoDocumento = new DocumentosColaborador();
        public frmCargaColab()
        {
            InitializeComponent();
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
                                    byte[] archivo = null;
                                    Stream MyStream = openFileDialog1.OpenFile();
                                    MemoryStream obj = new MemoryStream();
                                    MyStream.CopyTo(obj);
                                    archivo = obj.ToArray();

                                    //Agregamos los atributos del objeto DocumentosColaborador
                                    nuevoDocumento.Nombre = "FotoColaborador";
                                    nuevoDocumento.Documento = archivo;
                                    nuevoDocumento.Extension = openFileDialog1.SafeFileName;
                                    nuevoDocumento.Id_tipoMultimedia = 5;
                                    nuevoDocumento.LegajoColaborador = int.Parse(colaboradorModelo.BuscarLegajoUltimoColaborador());
                                    MessageBox.Show(nuevoDocumento.AgregarDocumento(nuevoDocumento.Nombre, nuevoDocumento.Documento, nuevoDocumento.Extension, nuevoDocumento.Id_tipoMultimedia, nuevoDocumento.LegajoColaborador));




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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = "C:\\Documentos";
            openFileDialog1.Filter = "Todos los archivos (*.*)|*.*";
            openFileDialog1.FilterIndex = 1;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {

            }
        }
    }
}
