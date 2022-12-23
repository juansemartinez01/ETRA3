using DomainA;
using PresentationA.Colaboradores.Eventos;
using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;

namespace PresentationA.Colaboradores
{
    public partial class frmEventos : frmHijo
    {
        ColaboradorModelo colaboradorAbtracto = new ColaboradorModelo();
        EventosModelo objetoEvento = new EventosModelo();
        DataTable eventos;
        public frmEventos()
        {
            InitializeComponent();
            CargarDG();
            lblFechaFin.Enabled= false;
            lblFechaInicio.Enabled = false;
            dateTimePicker1.Enabled = false;
            dateTimePicker2.Enabled = false;
            LlenarCombo(cmbTipoEvento, DataManager.GetInstance().ConsultaSQL("SELECT * FROM TipoEvento WHERE borradoLogico = 0"), "nombre", "id_tipoEvento");
            
            LlenarCombo(cmbColaboradores, DataManager.GetInstance().ConsultaSQL("SELECT * FROM Colaborador WHERE borradoLogico = 0"), "legajo", "legajo");
            

        }

        private void CargarDG()
        {
            //string consulta = "SELECT H.legajoColaborador, T.nombre, E.descripcion, CONVERT(varchar,H.fechaInicio, 103),CONVERT(varchar,H.fechaFin, 103),CONVERT(varchar,H.fechaRegistro, 103) AS 'Fecha de Registro' FROM HistorialEvento H JOIN Evento E ON H.id_evento = E.id_evento JOIN TipoEvento T ON T.id_tipoEvento = E.id_tipoEvento WHERE H.borradoLogico = 0";

            //DataTable eventos = DataManager.GetInstance().ConsultaSQL(consulta);

            dgvEventos.Rows.Clear();
            DataTable eventosTabla = new DataTable();
            eventosTabla = objetoEvento.getAllEventos();
            for (int i = 0; i < eventosTabla.Rows.Count; i++)
                {
                    //crear metodo completar labels
                    dgvEventos.Rows.Add(eventosTabla.Rows[i]["legajo"], eventosTabla.Rows[i]["nombre"], eventosTabla.Rows[i]["descripcion"], eventosTabla.Rows[i]["fechaInicio"], eventosTabla.Rows[i]["fechaFin"], eventosTabla.Rows[i]["fechaRegistro"]);
                }
            dgvEventos.Sort(dgvEventos.Columns[0], ListSortDirection.Ascending);
        }
        private void LlenarCombo(ComboBox cbo, Object source, string display, String value)
        {
            cbo.ValueMember = value;
            cbo.DisplayMember = display;
            cbo.DataSource = source;
            cbo.SelectedIndex = -1;
        }

        private void btnAplicar_Click(object sender, EventArgs e)
        {
            try
            {
                string fechaInicio = dateTimePicker1.Value.ToString("yyyy/MM/dd");
                string fechaFin = dateTimePicker2.Value.ToString("yyyy/MM/dd");
                
                
             
                string consulta = "SELECT H.legajoColaborador AS 'Legajo Colaborador', T.nombre AS 'Nombre Evento', E.descripcion AS 'Descripcion', CONVERT(varchar,H.fechaInicio, 103) AS 'Fecha de Inicio',CONVERT(varchar,H.fechaFin, 103) AS 'Fecha Fin',CONVERT(varchar,H.fechaRegistro, 103) AS 'Fecha de Registro' FROM HistorialEvento H JOIN Evento E ON H.id_evento = E.id_evento JOIN TipoEvento T ON T.id_tipoEvento = E.id_tipoEvento WHERE H.borradoLogico = 0";
                if (chkFiltroFecha.Checked)
                {
                    consulta += " AND H.fechaInicio >= '" + fechaInicio + "' AND H.fechaFin <= '" + fechaFin + "'";
                }
                if (cmbColaboradores.SelectedIndex != -1 && cmbTipoEvento.SelectedIndex != -1)
                {
                    string tipoEventoSelecconado = cmbTipoEvento.SelectedValue.ToString();
                    string legajoColaboradorSelecconado = cmbColaboradores.SelectedValue.ToString();
                    consulta += " AND H.legajoColaborador =" + legajoColaboradorSelecconado + " AND T.id_tipoEvento =" + tipoEventoSelecconado;
                }
                if (cmbTipoEvento.SelectedIndex != -1 && cmbColaboradores.SelectedIndex == -1)
                {
                    string tipoEventoSelecconado = cmbTipoEvento.SelectedValue.ToString();
                    consulta += " AND T.id_tipoEvento =" + tipoEventoSelecconado;
                }
                if (cmbColaboradores.SelectedIndex != -1 && cmbTipoEvento.SelectedIndex == -1)
                {
                    string legajoColaboradorSelecconado = cmbColaboradores.SelectedValue.ToString();
                    consulta += " AND H.legajoColaborador =" + legajoColaboradorSelecconado;
                }

                DataTable tabla = DataManager.GetInstance().ConsultaSQL(consulta);
                dgvEventos.Rows.Clear();
                for (int i = 0; i < tabla.Rows.Count; i++)
                {
                    //crear metodo completar labels
                    dgvEventos.Rows.Add(tabla.Rows[i]["Legajo Colaborador"], tabla.Rows[i]["Nombre Evento"], tabla.Rows[i]["Descripcion"], tabla.Rows[i]["Fecha de Inicio"], tabla.Rows[i]["Fecha Fin"], tabla.Rows[i]["Fecha de Registro"]);
                }
                

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmNuevoEvento nuevo = new frmNuevoEvento();
            nuevo.ShowDialog();
            limpiarCampos();
            CargarDG();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (chkFiltroFecha.Checked)
            {
                lblFechaFin.Enabled = true;
                lblFechaInicio.Enabled = true;
                dateTimePicker1.Enabled = true;
                dateTimePicker2.Enabled = true;
            }
            else
            {
                lblFechaFin.Enabled = false;
                lblFechaInicio.Enabled = false;
                dateTimePicker1.Enabled = false;
                dateTimePicker2.Enabled = false;
            }
        }
        private void limpiarCampos()
        {
            cmbTipoEvento.SelectedIndex = -1;
            cmbColaboradores.SelectedIndex = -1;
            chkFiltroFecha.Checked = false;
        }

        private void cmbTipoEvento_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cmbColaboradores_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cmbTipoEvento2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cmbColaboradores2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void dateTimePicker1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void dateTimePicker2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiarCampos();
            CargarDG();
        }
    }
}
