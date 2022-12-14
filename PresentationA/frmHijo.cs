using System.Data;
using System.Net.Security;
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
            string atributo = columna.ToString();
            //string value = colaborador.Rows[0][atributo].ToString();
            var control = form.Controls.Find(prefijo + atributo, true);
            if (control.Length > 0)
            {
                control[0].Text = colaborador.Rows[0][atributo].ToString();
                    if (control[0].Text == "NULL")
                    {
                        control[0].Text = "No especifica";
                    }
            }
            else
            {
                continue;
            }

        }

    }
    }
}
