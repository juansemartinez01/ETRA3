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
        public frmDatosPersonales(DataTable colaborador )
        {
            InitializeComponent();
            completarLabels(this, colaborador, "lbl");

            var Lista = new List<DocumentosColaborador>();
            Lista = documentoColaborador.filtroDocumentosColaborador(5, (int)colaborador.Rows[0]["legajo"]);

            if (Lista.Count == 0)
            {
                pictureBox2.Image = null;
            }
            else
            {
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

                pictureBox2.Image = fotoPerfil;
                pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
                fotoPerfilArchivo.Close();

            }

                
        }
        
        private void bttnEliminarColaborador_Click(object sender, EventArgs e)
        {
            string mensaje = colaboradorModelo.EliminarColaborador(int.Parse(lbllegajo.Text));
            MessageBox.Show(mensaje);
            
        }
    }
}