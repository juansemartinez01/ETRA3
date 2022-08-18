using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Domain;

namespace Presentation.Colaboradores
{
    public partial class frmHistorial : frmHijo
    {
        Eventos obje = new Eventos();
        public frmHistorial(string legajo)
        {
            InitializeComponent();
            CargarDG(legajo);
            
        }
        private void CargarDG(string legajo)
        {
            try
            {
                DataTable tabla = obje.obtenerEventos(legajo);
                dgvEventos.DataSource = tabla;
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
            txttipoEvento.Text = filaSeleccionada.Cells["Nombre"].Value.ToString();
            txtfechaInicio.Text = filaSeleccionada.Cells["Fecha de Inicio"].Value.ToString();
            txtfechaFin.Text = filaSeleccionada.Cells["Fecha Fin"].Value.ToString();
            txtfechaRegistro.Text = filaSeleccionada.Cells["Fecha de registro"].Value.ToString();
            txtdescripcion.Text = filaSeleccionada.Cells["Descripcion"].Value.ToString();

        }
    }
}
