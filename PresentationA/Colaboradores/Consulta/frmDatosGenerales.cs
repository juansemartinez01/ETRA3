using System.Data;
using System.Windows.Forms;

namespace PresentationA.Colaboradores.Consulta
{
    public partial class frmDatosGenerales : frmHijo
    {
        public frmDatosGenerales(DataTable colaborador)
        {
            InitializeComponent();
            completarLabels(this, colaborador, "lbl");
        }

    }
}
