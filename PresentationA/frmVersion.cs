using System;
using System.Net;
using System.Diagnostics;
using System.Windows.Forms;
using System.ComponentModel;
using System.IO;

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

        private void DesinstalarPrograma()
        {
            try
            {
                // Desinstalar el programa
                string uninstallArgs = "/x {F8BA5F45-8BBC-444A-B06C-30CE691DFDD9} /qn";
                Process.Start("msiexec.exe", uninstallArgs);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al desinstalar el programa y actualizar: " + ex.Message);
                // Manejar cualquier excepción que pueda ocurrir durante el proceso
            }
        }

        private void EjecutarInstaladorDescargado()
        {
            string setupPath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\Downloads\\Setup.msi";

            try
            {

                Process.Start(setupPath);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al abrir el instalador: " + ex.Message);
                // Manejar cualquier excepción que pueda ocurrir al abrir el instalador
            }
        }

        private async void botonPadre1_Click(object sender, EventArgs e)
        {
            string pathUpdate = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\Downloads\\Setup.msi";
            if (File.Exists(pathUpdate))
            {
                File.Delete(pathUpdate); // Eliminar el archivo existente
            }
            var web = new WebClient();
            web.DownloadFileCompleted += Web_DownloadFileCompleted;
            web.DownloadFileAsync(new System.Uri("https://github.com/PaezFrancisco/etraVersion/blob/main/Setup.msi?raw=true"), pathUpdate);
        }


        private void Web_DownloadFileCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e)
        {
            DesinstalarPrograma();
            EjecutarInstaladorDescargado();
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
            p.StartInfo.Verb = "runas";
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
