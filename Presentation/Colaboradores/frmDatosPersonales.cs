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

namespace Presentation
{
    public partial class frmDatosPersonales : frmHijo
    {
        ColaboradorModelo colaboradorModelo = new ColaboradorModelo();
        DocumentosColaborador documentoColaborador = new DocumentosColaborador();
        public frmDatosPersonales(string[] colaborador )
        {
            InitializeComponent();
            //Hay que arreglar este error de cuando busco 2 veces un colaborador

            //pictureBox2.Image = Image.FromFile("C: \\Users\\juans\\Pictures\\asdfasdfasdfasdf.PNG");



            lblLegajo.Text = colaborador[0];
            lblNombre.Text = colaborador[1];
            lblApellido.Text = colaborador[2];
            
            

            
            
            
            var Lista = new List<DocumentosColaborador>();
            Lista = documentoColaborador.filtroDocumentosColaborador(5, int.Parse(colaborador[0]));

            if (Lista.Count == 0)
            {
                pictureBox2.Image = null;
            }
            else
            {
                string direccion = AppDomain.CurrentDomain.BaseDirectory;
                string carpeta = direccion + "/temp/";
                string ubicacionCompleta = carpeta + Lista[0].Extension;
                Stream fotoPerfilArchivo = File.OpenRead(ubicacionCompleta);
                Image fotoPerfil = Image.FromStream(fotoPerfilArchivo);

                pictureBox2.Image = fotoPerfil;
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

            }

                
                
                
            
        

        }
        public frmDatosPersonales()
        {
            InitializeComponent();


        }

        private void bttnEliminarColaborador_Click(object sender, EventArgs e)
        {
            string mensaje = colaboradorModelo.EliminarColaborador(int.Parse(lblLegajo.Text));
            MessageBox.Show(mensaje);
        }
    }
}
