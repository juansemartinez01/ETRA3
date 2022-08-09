using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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

                                    string mensajeArchivoAgregado = agregarArchivoColaborador(colaboradorModelo);
                                    MessageBox.Show(mensajeArchivoAgregado);

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

        public string agregarArchivoColaborador(ColaboradorModelo colaboradorModelo)
        {
            byte[] archivo = null;
            using(Stream MyStream = openFileDialog1.OpenFile())
            {
                using (MemoryStream obj = new MemoryStream())
                {
                    MyStream.CopyTo(obj);
                    archivo = obj.ToArray();
                }
            }
            
            
            
            
            

            //Agregamos los atributos del objeto DocumentosColaborador
            nuevoDocumento.Nombre = "FotoColaborador";
            nuevoDocumento.Documento = archivo;
            nuevoDocumento.Extension = openFileDialog1.SafeFileName;
            nuevoDocumento.Id_tipoMultimedia = 5;
            nuevoDocumento.LegajoColaborador = int.Parse(colaboradorModelo.BuscarLegajoUltimoColaborador());
            MessageBox.Show(nuevoDocumento.AgregarDocumento(nuevoDocumento.Nombre, nuevoDocumento.Documento, nuevoDocumento.Extension, nuevoDocumento.Id_tipoMultimedia, nuevoDocumento.LegajoColaborador));

            //Parte para ver la imagen
            var Lista = new List<DocumentosColaborador>();
            Lista = nuevoDocumento.filtroDocumentosColaborador(nuevoDocumento.Id_tipoMultimedia, nuevoDocumento.LegajoColaborador);
           
            string direccion = AppDomain.CurrentDomain.BaseDirectory;
                string carpeta = direccion + "/temp/";
                string ubicacionCompleta = carpeta + Lista[0].Extension;
            Stream fotoPerfilArchivo = File.OpenRead(ubicacionCompleta);
            Image fotoPerfil = Image.FromStream(fotoPerfilArchivo);

            pictureBox1.Image = fotoPerfil;
            fotoPerfilArchivo.Close();
            if (!Directory.Exists(carpeta))
                {
                    Directory.CreateDirectory(carpeta);
                }
                if (File.Exists(ubicacionCompleta))
                {
                    
                    File.Delete(ubicacionCompleta);
                }
                File.WriteAllBytes(ubicacionCompleta, Lista[0].Documento);

            

            








            return "Archivo agregado con exito";
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
