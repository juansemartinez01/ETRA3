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
    public partial class frmDocumentos : frmHijo
    {
        DocumentosColaborador documentosColaborador = new DocumentosColaborador();
        public frmDocumentos()
        {
            InitializeComponent();
            cargarTabla(0, 0, 0);
            
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
        private void cargarTabla(int legajo,int tipoDocumento,int tipoEvento)
        {
            try
            {
                dgvDocumentos.Rows.Clear();
                DataTable documentos = new DataTable();
                documentos = documentosColaborador.getAllDocumentos(legajo, tipoDocumento, tipoEvento);
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

    }
}
