using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Presentation
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
