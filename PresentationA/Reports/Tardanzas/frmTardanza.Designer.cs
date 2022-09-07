namespace PresentationA.Reports.Tardanzas
{
    partial class frmTardanza
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
            this.tardanzaReportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tardanzaListingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.dtpFechaFin = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.tardanzaReportBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tardanzaListingBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tardanzaReportBindingSource
            // 
            this.tardanzaReportBindingSource.DataSource = typeof(DomainA.ReporteTardanza);
            // 
            // tardanzaListingBindingSource
            // 
            this.tardanzaListingBindingSource.DataSource = typeof(DomainA.TardanzaListing);
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "tardanzaReport";
            reportDataSource1.Value = this.tardanzaReportBindingSource;
            reportDataSource2.Name = "tardanzaListing";
            reportDataSource2.Value = this.tardanzaListingBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "PresentationA.Reports.Tardanzas.rptTardanzas.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 98);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 352);
            this.reportViewer1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.dtpFechaFin);
            this.panel1.Controls.Add(this.dtpFechaInicio);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 100);
            this.panel1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(547, 47);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 27);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dtpFechaFin
            // 
            this.dtpFechaFin.Location = new System.Drawing.Point(301, 47);
            this.dtpFechaFin.Name = "dtpFechaFin";
            this.dtpFechaFin.Size = new System.Drawing.Size(200, 27);
            this.dtpFechaFin.TabIndex = 1;
            // 
            // dtpFechaInicio
            // 
            this.dtpFechaInicio.Location = new System.Drawing.Point(57, 47);
            this.dtpFechaInicio.Name = "dtpFechaInicio";
            this.dtpFechaInicio.Size = new System.Drawing.Size(200, 27);
            this.dtpFechaInicio.TabIndex = 0;
            // 
            // frmTardanza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmTardanza";
            this.Text = "frmTardanza";
            this.Load += new System.EventHandler(this.frmTardanza_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tardanzaReportBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tardanzaListingBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource tardanzaReportBindingSource;
        private System.Windows.Forms.BindingSource tardanzaListingBindingSource;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dtpFechaFin;
        private System.Windows.Forms.DateTimePicker dtpFechaInicio;
    }
}