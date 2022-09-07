using System;
using System.Windows.Forms;
using DomainA;
namespace PresentationA.Reports
{
    public partial class frmSalXCargo : frmHijo
    {
        public frmSalXCargo()
        {
            InitializeComponent();
        }

        private void frmSalXCargo_Load(object sender, EventArgs e)
        {
            getSalXCargoReport();
            
        }
        private void getSalXCargoReport()
        {
            ReporteSalXCargo report = new ReporteSalXCargo();
            report.createReporteSalXCargo();
            reporteSalXCargoBindingSource.DataSource = report;
            salXCargoListingBindingSource.DataSource = report.salXCargoListing;

            this.reportViewer1.RefreshReport();
        }

    }
}
