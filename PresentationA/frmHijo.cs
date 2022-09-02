using System.Data;
using System.Windows.Forms;

namespace PresentationA
{
    public partial class frmHijo : Form
    {
        public frmHijo()
        {
            InitializeComponent();
        }
    
    public void completarLabels(Form form, DataTable colaborador, string prefijo)
    {
        foreach (DataColumn columna in colaborador.Columns)
        {
            string value = columna.ToString();
            var control = form.Controls.Find(prefijo + value, true);
            if (control.Length > 0)
            {
                //Label ctrl = control[0] as Label;
                control[0].Text = colaborador.Rows[0][value].ToString();
            }
            else
            {
                continue;
            }

        }

    }
    }
}
