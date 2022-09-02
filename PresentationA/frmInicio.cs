using System;

namespace PresentationA
{
    public partial class frmInicio : frmHijo
    {
        public frmInicio()
        {
            InitializeComponent();
        }
        private void fechaActual_Tick(object sender, EventArgs e)
        {
            lblFechaActual.Text = DateTime.Now.ToLongDateString();
        }
    }
}
