using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationA.Colaboradores
{
    public partial class frmModifcarColab : frmHijo
    {
        public frmModifcarColab(DataTable colaborador)
        {
            InitializeComponent();
            completarLabels(this, colaborador, "lbl");
            completarLabels(this, colaborador, "txt");
            
        }
    }
}
