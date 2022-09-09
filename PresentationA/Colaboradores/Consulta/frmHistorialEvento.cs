using System;
using System.Data;
using System.Windows.Forms;
using DomainA;


namespace PresentationA.Colaboradores.Consulta
{
    public partial class frmHistorialEvento : frmHijo
    {
        Eventos obje = new Eventos();
        DataTable historial;
        public frmHistorialEvento(string legajo)
        {
            InitializeComponent();
            CargarDG(legajo);
            btnEliminar.Enabled = false;
            btnModificar.Enabled = false;

        }
        private void CargarDG(string legajo)
        {
            try
            {
                historial = obje.obtenerEventos(legajo);
                dgvEventos.DataSource = historial;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void dgvEventos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;
            if (indice == -1)
            {
                return;
            }
            //Utilizar metodo cargar labels, modificarlo para que envie el prefijo del nombre de la columna {lbl,txt}
            DataGridViewRow filaSeleccionada = dgvEventos.Rows[indice];
            //completarLabels(this, historial, "txt");
            cmbnombre.Text = filaSeleccionada.Cells["Nombre"].Value.ToString();
            dtpfechaInicio.Text = filaSeleccionada.Cells["Fecha de Inicio"].Value.ToString();
            dtpfechaFin.Text = filaSeleccionada.Cells["Fecha Fin"].Value.ToString();
            dtpfechaRegistro.Text = filaSeleccionada.Cells["Fecha de registro"].Value.ToString();
            txtdescripcion.Text = filaSeleccionada.Cells["Descripción"].Value.ToString();

        }

        private void iconButton2_Click(object sender, EventArgs e)
        {

        }
    }
}
