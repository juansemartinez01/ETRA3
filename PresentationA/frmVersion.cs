using System;
using System.Net;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Windows.Forms;

namespace PresentationA
{
    public partial class frmVersion : frmHijo
    {
        public frmVersion()
        {
            InitializeComponent();

            lblVersion.Text = "Version Actual: " + new Version(Application.ProductVersion).ToString();
        }

        private async void botonPadre1_Click(object sender, EventArgs e)
        {
            try {
                var c = new WebClient();
                var s = c.DownloadString("https://github.com/PaezFrancisco/etraVersion/blob/main/version.txt");
                var versionActual = new Version(Application.ProductVersion);
                if(!s.Contains(versionActual.ToString()))
                {
                    //File.SetAttributes(@".//ETRA SOFTWARE.exe", FileAttributes.Normal);
                    //File.Delete(@".//ETRA SOFTWARE.exe");
                    string zippath = @".\Prueba.msi";
                    await c.DownloadFileTaskAsync("https://github.com/PaezFrancisco/etraVersion/blob/main/Setup.msi",zippath);


                    Process installer = new Process();
                    installer.StartInfo.FileName = zippath;
                    installer.StartInfo.Arguments = " /s /v\" /qn\"";
                    installer.Start();
                    installer.WaitForExit();
                    Process.GetCurrentProcess().Kill();
                    if (installer.ExitCode != 0)
                    {
                        //do something
                    }



                }
            }
            catch { MessageBox.Show("eror"); }
        }
    }
}
