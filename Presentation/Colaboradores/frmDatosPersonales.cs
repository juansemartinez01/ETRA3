using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Presentation
{
    public partial class frmDatosPersonales : frmHijo
    {
        public frmDatosPersonales(string[] colaborador)
        {
            InitializeComponent();
            
            lblLegajo.Text = colaborador[0];
            lblNombre.Text = colaborador[1];
            lblApellido.Text = colaborador[2];
                
            
        }
        public frmDatosPersonales()
        {
            InitializeComponent();


        }
    }
}
