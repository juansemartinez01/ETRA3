using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Presentation.Colaboradores
{
    public partial class frmDatosGrales : frmHijo
    {
        public frmDatosGrales(DataTable colaborador)
        {
            InitializeComponent();
            completarLabels(this, colaborador);
        }

        


}
}
