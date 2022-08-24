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
            openFileDialog1.InitialDirectory = "no seleccionado";
            LlenarCombo(cmbEstados, DataManager.GetInstance().ConsultaSQL("SELECT * FROM EstadoColaborador WHERE borradoLogico = 0"), "nombre", "id_estado");
            LlenarCombo(cmbPuesto, DataManager.GetInstance().ConsultaSQL("SELECT * FROM Cargo WHERE borradoLogico = 0"), "nombre", "id_cargo");
            LlenarCombo(cmbProvincias, DataManager.GetInstance().ConsultaSQL("SELECT * FROM Cargo WHERE borradoLogico = 0"), "nombre", "id_cargo");


        }
        private void LlenarCombo(ComboBox cbo, Object source, string display, String value)
        {
            cbo.ValueMember = value;
            cbo.DisplayMember = display;
            cbo.DataSource = source;
            cbo.SelectedIndex = -1;
        }



        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            string provincia;
            string departamento;
            string localidad;
            if(cmbProvincias.SelectedIndex == -1)
            {
                provincia = "Cordoba";
            }
            else
            {
                provincia = "Cordoba";
            }
            if (txtLocalidad.Text != "")
            {
                localidad = txtLocalidad.Text.ToString();
            }
            else
            {
                localidad = "NULL";
            }
            if (txtNombre.Text != "")
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
                                    
                                    

                                        if (cmbPuesto.SelectedIndex != -1)
                                        {
                                            int piso;
                                            if (txtPiso.Text != "")
                                            {
                                                piso = int.Parse(txtPiso.Text.ToString());
                                                if (txtDepto.Text != "")
                                                {
                                                    departamento = txtDepto.Text.ToString();
                                                    ColaboradorModelo colaboradorModelo = new ColaboradorModelo();
                                                    var cadenaRespuesta = colaboradorModelo.CrearColaborador(txtNombre.Text, txtApellido.Text, int.Parse(txtDni.Text), txtCuit.Text, txtCalle.Text, int.Parse(txtNroCalle.Text), (int)cmbPuesto.SelectedValue, piso, departamento, localidad, provincia);
                                                    if (openFileDialog1.InitialDirectory != "no seleccionado")
                                                    {

                                                        agregarArchivoColaborador(colaboradorModelo);
                                                    }
                                                    MessageBox.Show(cadenaRespuesta);
                                                }
                                                else
                                                {
                                                    MessageBox.Show("Debe asignarle un departamento al colaborador(A,B,C...)");
                                                }
                                            }
                                            else
                                            {
                                                piso = 0;
                                                departamento = "NULL";
                                                ColaboradorModelo colaboradorModelo = new ColaboradorModelo();
                                                var cadenaRespuesta = colaboradorModelo.CrearColaborador(txtNombre.Text, txtApellido.Text, int.Parse(txtDni.Text), txtCuit.Text, txtCalle.Text, int.Parse(txtNroCalle.Text), (int)cmbPuesto.SelectedValue, piso, departamento, localidad, provincia);
                                                if (openFileDialog1.InitialDirectory != "no seleccionado")
                                                {

                                                    agregarArchivoColaborador(colaboradorModelo);
                                                }
                                                MessageBox.Show(cadenaRespuesta);
                                            }
                                        }
                                        else
                                        {
                                            MessageBox.Show("Debe asignarle un puesto al colaborador");
                                        }
                                    
                                    


                                    
                                    

                                    
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

        

        public void agregarArchivoColaborador(ColaboradorModelo colaboradorModelo)
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
            string variableMuerta = nuevoDocumento.AgregarDocumento(nuevoDocumento.Nombre, nuevoDocumento.Documento, nuevoDocumento.Extension, nuevoDocumento.Id_tipoMultimedia, nuevoDocumento.LegajoColaborador);

            //Parte para ver la imagen
            var Lista = new List<DocumentosColaborador>();
            Lista = nuevoDocumento.filtroDocumentosColaborador(nuevoDocumento.Id_tipoMultimedia, nuevoDocumento.LegajoColaborador);
           
            string direccion = AppDomain.CurrentDomain.BaseDirectory;
                string carpeta = direccion + "/temp/";
                string ubicacionCompleta = carpeta + Lista[0].Extension;
            
            if (!Directory.Exists(carpeta))
                {
                    Directory.CreateDirectory(carpeta);
                }
                if (File.Exists(ubicacionCompleta))
                {
                    
                    File.Delete(ubicacionCompleta);
                }
            File.WriteAllBytes(ubicacionCompleta, Lista[0].Documento);

            Stream fotoPerfilArchivo = File.OpenRead(ubicacionCompleta);
            Image fotoPerfil = Image.FromStream(fotoPerfilArchivo);

            pictureBox1.Image = fotoPerfil;
            fotoPerfilArchivo.Close();












        }
        

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = "C:\\Documentos";
            openFileDialog1.Filter = "Todos los archivos (*.*)|*.*";
            openFileDialog1.FilterIndex = 1;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {

            }
            Stream fotoPerfilArchivo = openFileDialog1.OpenFile();
            Image fotoPerfil = Image.FromStream(fotoPerfilArchivo);

            pictureBox1.Image = fotoPerfil;
            fotoPerfilArchivo.Close();
        }
        
    }
}
