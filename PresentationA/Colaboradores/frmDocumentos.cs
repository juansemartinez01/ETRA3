﻿using DomainA;
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
    public partial class frmDocumentos : frmHijo
    {
        DocumentosColaborador documentosColaborador = new DocumentosColaborador();
        public frmDocumentos()
        {
            InitializeComponent();
            cargarTabla(0, 0, 0,DateTime.Now,false);
            limpiarCampos();
            LlenarCombo(cmbColaborador, DataManager.GetInstance().ConsultaSQL("SELECT * FROM Colaborador WHERE borradoLogico = 0"), "legajo", "legajo");
            LlenarCombo(cmbTipoEvento, DataManager.GetInstance().ConsultaSQL("SELECT * FROM TipoEvento WHERE borradoLogico = 0"), "nombre", "id_tipoEvento");
            LlenarCombo(cmbTipoDocumento, DataManager.GetInstance().ConsultaSQL("SELECT * FROM TipoMultimedia WHERE borradoLogico = 0"), "nombre", "id_tipoMultimedia");

        }
        private void LlenarCombo(ComboBox cbo, Object source, string display, String value)
        {
            cbo.ValueMember = value;
            cbo.DisplayMember = display;
            cbo.DataSource = source;
            cbo.SelectedIndex = -1;
        }
        private void btnExportar_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            excel.Application.Workbooks.Add(true);
            int icol = 0;
            int irow = 0;
            foreach (DataGridViewColumn col in dgvDocumentos.Columns)
            {
                icol++;
                excel.Cells[1, icol] = col.Name;
                foreach (DataGridViewRow row in dgvDocumentos.Rows)
                {
                    irow++;
                    excel.Cells[irow + 1, icol] = row.Cells[col.Name].Value;
                }
                irow = 0;
            }

            excel.Visible = true;
        
        }
        private void cargarTabla(int legajo,int tipoDocumento,int tipoEvento,DateTime fecha,bool aplicarFecha)
        {
            try
            {
                dgvDocumentos.Rows.Clear();
                DataTable documentos = new DataTable();
                documentos = documentosColaborador.getAllDocumentos(legajo, tipoDocumento, tipoEvento, fecha, aplicarFecha);
                for (int i = 0; i < documentos.Rows.Count; i++)
                {
                    //crear metodo completar labels
                    dgvDocumentos.Rows.Add(documentos.Rows[i]["Numero"], documentos.Rows[i]["Legajo"], documentos.Rows[i]["Tipo doc"], documentos.Rows[i]["Evento"]);
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAplicar_Click(object sender, EventArgs e)
        {
            int legajo = 0;
            int tipoEvento = 0;
            int tipoDocumento = 0;
            DateTime fecha = DateTime.Now;
            bool aplicarFecha = false;
            if (chkFiltroFecha.Checked)
            {
                fecha = dtpFechaRegistro.Value.Date;
                aplicarFecha = true;
            }
            if(cmbColaborador.SelectedIndex != -1)
            {
                legajo = int.Parse(cmbColaborador.SelectedValue.ToString());
            }
            if(cmbTipoDocumento.SelectedIndex != -1)
            {
                tipoDocumento = int.Parse(cmbTipoDocumento.SelectedValue.ToString());    
            }
            if(cmbTipoEvento.SelectedIndex != -1)
            {
                tipoEvento = int.Parse(cmbTipoEvento.SelectedValue.ToString());
            }
            cargarTabla(legajo,tipoDocumento,tipoEvento,fecha,aplicarFecha);
            limpiarCampos();


        }
        private void limpiarCampos()
        {
            cmbColaborador.SelectedIndex = -1;
            cmbTipoEvento.SelectedIndex = -1;
            cmbTipoDocumento.SelectedIndex = -1;
            chkFiltroFecha.Checked = false;
            dtpFechaRegistro.Enabled = false;

        }

        private void chkFiltroFecha_CheckedChanged(object sender, EventArgs e)
        {
            if (chkFiltroFecha.Checked)
            {
                dtpFechaRegistro.Enabled = true;
            }
            else
            {
                dtpFechaRegistro.Enabled = false;
            }
        }
    }
}
