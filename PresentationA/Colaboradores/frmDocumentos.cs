using DomainA;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;

namespace PresentationA.Colaboradores
{
    public partial class frmDocumentos : frmHijo
    {
        DocumentosColaborador documentosColaborador = new DocumentosColaborador();
        Eventos eventosModelo = new Eventos();
        public frmDocumentos()
        {
            InitializeComponent();
            cargarTabla(0, 0, 0,"",false);
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
        private void cargarTabla(int legajo,int tipoDocumento,int tipoEvento,string fecha,bool aplicarFecha)
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
            string fecha = "";
            bool aplicarFecha = false;
            if (chkFiltroFecha.Checked)
            {
                fecha = dtpFechaRegistro.Value.ToString("yyyy/MM/dd");
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

        private void btnVerArchivo_Click(object sender, EventArgs e)
        {
            if(eventosModelo.FilaSeleccionadaHistorialEvento == -1)
            {
                MessageBox.Show("Debe seleccionar un archivo.");
                return;
            }
            DataGridViewRow filaSeleccionada = dgvDocumentos.Rows[eventosModelo.FilaSeleccionadaHistorialEvento];
            int idDocumento = int.Parse(filaSeleccionada.Cells["Numero"].Value.ToString());
            var Lista = new List<DocumentosColaborador>();
            Lista = documentosColaborador.filtroDocumentosId(idDocumento);
            if (Lista.Count == 0)
            {
                MessageBox.Show("No hay ningun archivo asociado a este evento");
                return;
            }

            string direccion = AppDomain.CurrentDomain.BaseDirectory;
            string carpeta = direccion + "/temp/";
            string ubicacionCompleta = carpeta + Lista[0].Extension;

            if (!Directory.Exists(carpeta))
            {
                Directory.CreateDirectory(carpeta);
            }
            if (File.Exists(ubicacionCompleta))
            {

                File.Delete(ubicacionCompleta);
            }
            File.WriteAllBytes(ubicacionCompleta, Lista[0].Documento);

            Stream archivo = File.OpenRead(ubicacionCompleta);

            Process.Start(ubicacionCompleta);


            archivo.Close();
        }
        



        private void dgvDocumentos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            int indice = e.RowIndex;
            eventosModelo.FilaSeleccionadaHistorialEvento = indice;


        }

        private void cmbColaborador_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cmbTipoEvento_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
