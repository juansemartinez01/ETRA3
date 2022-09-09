using DomainA;
using System;
using System.Drawing.Printing;
using System.Windows.Forms.VisualStyles;

namespace PresentationA.Reports.Tardanzas
{
    public partial class frmTardanza : frmHijo
    {
        public frmTardanza()
        {
            InitializeComponent();
        }

        private void getReportTardanza(DateTime fechaInicio, DateTime fechaFin)
        {
            ReporteTardanza report = new ReporteTardanza();
            report.createReportTardanza(fechaInicio,fechaFin);
            tardanzaReportBindingSource.DataSource = report;
            tardanzaListingBindingSource.DataSource = report.tardanzaListing;
            this.reportViewer1.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            getReportTardanza(Convert.ToDateTime(dtpFechaInicio.Value), Convert.ToDateTime(dtpFechaFin.Value));
        }

        private void frmTardanza_Load(object sender, EventArgs e)
        {
            
        }
    }
}
