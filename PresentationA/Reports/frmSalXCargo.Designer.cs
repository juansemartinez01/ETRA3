namespace PresentationA.Reports
{
    partial class frmSalXCargo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reporteSalXCargoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.salXCargoListingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.reporteSalXCargoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salXCargoListingBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reporteSalXCargoBindingSource
            // 
            this.reporteSalXCargoBindingSource.DataSource = typeof(DomainA.ReporteSalXCargo);
            // 
            // salXCargoListingBindingSource
            // 
            this.salXCargoListingBindingSource.DataSource = typeof(DomainA.SalXCargoListing);
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.reporteSalXCargoBindingSource;
            reportDataSource2.Name = "DataSet2";
            reportDataSource2.Value = this.salXCargoListingBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "PresentationA.Reports.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Margin = new System.Windows.Forms.Padding(5);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1333, 727);
            this.reportViewer1.TabIndex = 0;
            // 
            // frmSalXCargo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1333, 727);
            this.Controls.Add(this.reportViewer1);
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "frmSalXCargo";
            this.Text = "frmSalXCargo";
            this.Load += new System.EventHandler(this.frmSalXCargo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.reporteSalXCargoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salXCargoListingBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource reporteSalXCargoBindingSource;
        private System.Windows.Forms.BindingSource salXCargoListingBindingSource;
    }
}