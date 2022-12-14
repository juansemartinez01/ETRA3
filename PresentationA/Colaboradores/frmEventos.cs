using DomainA;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace PresentationA.Colaboradores
{
    public partial class frmEventos : frmHijo
    {
        ColaboradorModelo colaboradorAbtracto = new ColaboradorModelo();
        Eventos objetoEvento = new Eventos();
        DataTable eventos;
        public frmEventos()
        {
            InitializeComponent();
            CargarDG();
            dateTimePicker1.Enabled = false;
            dateTimePicker2.Enabled = false;
            LlenarCombo(cmbTipoEvento, DataManager.GetInstance().ConsultaSQL("SELECT * FROM TipoEvento WHERE borradoLogico = 0"), "nombre", "id_tipoEvento");
            LlenarCombo(cmbTipoEvento2, DataManager.GetInstance().ConsultaSQL("SELECT * FROM TipoEvento WHERE borradoLogico = 0"), "nombre", "id_tipoEvento");
            LlenarCombo(cmbColaboradores, DataManager.GetInstance().ConsultaSQL("SELECT * FROM Colaborador WHERE borradoLogico = 0"), "legajo", "legajo");
            LlenarCombo(cmbColaboradores2, DataManager.GetInstance().ConsultaSQL("SELECT * FROM Colaborador WHERE borradoLogico = 0"), "legajo", "legajo");

        }

        private void CargarDG()
        {
            try
            {
                string consulta = "SELECT H.legajoColaborador AS 'Legajo Colaborador', T.nombre AS 'Nombre Evento', E.descripcion AS 'Descripcion', CONVERT(varchar,H.fechaInicio, 103) AS 'Fecha de Inicio',CONVERT(varchar,H.fechaFin, 103) AS 'Fecha Fin',CONVERT(varchar,H.fechaRegistro, 103) AS 'Fecha de Registro' FROM HistorialEvento H JOIN Evento E ON H.id_evento = E.id_evento JOIN TipoEvento T ON T.id_tipoEvento = E.id_tipoEvento WHERE H.borradoLogico = 0";
                DataTable tabla = DataManager.GetInstance().ConsultaSQL(consulta);
                dgvEventos.DataSource = tabla;
                /*
                eventos = objetoEvento.getAllEventos();
                for (int i = 0; i < eventos.Rows.Count; i++)
                {
                    //crear metodo completar labels
                    dgvEventos.Rows.Add(eventos.Rows[i]["Legajo Colaborador"],eventos.Rows[i]["Tipo"], eventos.Rows[i]["Descripción"], eventos.Rows[i]["Fecha de Inicio"], eventos.Rows[i]["Fecha Fin"], eventos.Rows[i]["Fecha de Registro"]);
                }
                */

            }
            catch (Exception ex)
            {
                throw ex;
            }
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
                dgvEventos.DataSource = tabla;
                limpiarCampos();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cmbTipoEvento2.SelectedIndex != -1)
            {

                if (cmbColaboradores2.SelectedIndex != -1)
                {


                    string respuesta = objetoEvento.InsertarEventos((int)cmbTipoEvento2.SelectedValue, (int)cmbColaboradores2.SelectedValue, txtDescripcion.Text.ToString(), dateTimePicker3.Value.Date, dateTimePicker4.Value.Date);
                    MessageBox.Show(respuesta);
                    CargarDG();
                }
                else
                {
                    MessageBox.Show("Debe seleccionar un colaborador asosciado");
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un tipo de evento");
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (chkFiltroFecha.Checked)
            {
                dateTimePicker1.Enabled = true;
                dateTimePicker2.Enabled = true;
            }
            else
            {
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
    }
}
