using DomainA;
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
    public partial class frmSalarios : frmHijo
    {
        Salario sal = new Salario();
        public frmSalarios()
        {
            InitializeComponent();
            CargarTabla();

        }
        public void CargarTabla()
        {
            dgvSalarios.DataSource = sal.getAllSalarios();
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {

        }
    }
}
