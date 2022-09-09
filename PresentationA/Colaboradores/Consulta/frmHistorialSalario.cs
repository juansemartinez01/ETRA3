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

        private void dgvSalarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;
            //sal.FilaSeleccionadaHistorialEvento = indice;
            if (indice == -1)
            {
                return;
            }
            //Utilizar metodo cargar labels, modificarlo para que envie el prefijo del nombre de la columna {lbl,txt}
            DataGridViewRow filaSeleccionada = dgvSalarios.Rows[indice];
            //completarLabels(this, historial, "txt");
            txtmonto.Text = filaSeleccionada.Cells["Monto"].Value.ToString();
            dtpfechaInicio.Text = filaSeleccionada.Cells["Fecha de Inicio"].Value.ToString();
            dtpfechaFin.Text = filaSeleccionada.Cells["Fecha de Fin"].Value.ToString();

        }
    }
}
