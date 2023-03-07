using System;
using System.Net;
using System.Diagnostics;
using System.Windows.Forms;
using System.ComponentModel;

namespace PresentationA
{
    public partial class frmVersion : frmHijo
    {
        public frmVersion()
        {
            InitializeComponent();
            lblVersion.Text = "Version actual: " + Application.ProductVersion.ToString();
            checkUpdate();
        }

        private void checkUpdate() 
        {
            var c = new WebClient();
            var newVersion = c.DownloadString("https://raw.githubusercontent.com/PaezFrancisco/etraVersion/main/version.txt");
            var oldVersion = Application.ProductVersion.ToString();

            string newVersionStr = newVersion.Replace(".", "");
            oldVersion = oldVersion.Replace(".", "");

            if (Convert.ToInt32(newVersionStr) > Convert.ToInt32(oldVersion))
            {
                ///Hay una nueva actualizacion
                lblTitulo.Text = "Hay una nueva version del sistema,.\r\n Desea actualizarlo?\r\n";
                lblNewVersion.Text = "Nueva Versión: " + newVersion;
                lblNewVersion.Visible = true;
                btnActualizar.Visible = true;
            }
            else
            {
                lblTitulo.Text = "El sistema está actualizado";
                btnActualizar.Visible = false;
                lblNewVersion.Visible = false;
            }


        }
        private async void botonPadre1_Click(object sender, EventArgs e)
        {
            string pathUpdate = Application.StartupPath + @".\Setup.msi";
            var web = new WebClient();
            web.DownloadFileCompleted += Web_DownloadFileCompleted;
            web.DownloadFileAsync(new System.Uri("https://github.com/PaezFrancisco/etraVersion/blob/main/Setup.msi?raw=true"), pathUpdate);
        }


        private void Web_DownloadFileCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e)
        {
            initiScript();
        }



        private void initiScript()
        {
            //string path = Application.StartupPath + @"C:\Program Files\MartinezPaezSoftware\ETRA\bat.bat";
            string path = Application.StartupPath + @".\bat.bat";
            Process p = new Process();
            p.StartInfo.FileName = path;
            p.StartInfo.Arguments = "";
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.RedirectStandardOutput = true;
            p.StartInfo.RedirectStandardError = true;
            p.StartInfo.CreateNoWindow = true; 
            p.Start();
            Environment.Exit(1);

        }

        private void frmVersion_Load(object sender, EventArgs e)
        {
            checkUpdate();
            lblVersion.Text = "Version actual: " + Application.ProductVersion.ToString();
        }
    }
}
