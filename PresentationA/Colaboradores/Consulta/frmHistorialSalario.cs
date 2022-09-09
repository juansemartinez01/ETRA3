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

namespace PresentationA.Colaboradores.Consulta
{
    public partial class frmHistorialSalario : frmHijo
    {
        Salario sal = new Salario();
        public frmHistorialSalario(string legajo)
        {
            InitializeComponent();
            CargarDG(legajo);
            sal.legajoColaborador = int.Parse(legajo);
        }
        private void CargarDG(string legajo)
        {
            try
            {
                DataTable salarios = sal.obtenerSalarios(legajo);
                dgvSalarios.DataSource = salarios;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if(txtmonto.Text == "")
            {
                MessageBox.Show("Debe ingresar un monto.");
            }
            else
            {
                string respuesta = sal.modificarSalarioColaborador(sal.legajoColaborador, float.Parse(txtmonto.Text));
                MessageBox.Show(respuesta);
                CargarDG(sal.legajoColaborador.ToString());
            }
            
        }
    }
}
