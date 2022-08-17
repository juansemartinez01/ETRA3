using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Presentation
{
    public partial class frmHijo : Form
    {
        public frmHijo()
        {
            InitializeComponent();
        }

        
        public void completarLabels(Form form, DataTable colaborador)
        {
            foreach (DataColumn columna in colaborador.Columns)
            {
                string value = columna.ToString();
                var control = form.Controls.Find("lbl" + value, true);
                if (control.Length > 0)
                {
                    Label ctrl = control[0] as Label;
                    ctrl.Text = colaborador.Rows[0][value].ToString();
                }
                else
                {
                    continue;
                }

            }
           
        }
    }
}
