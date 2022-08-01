
namespace Presentation
{
    partial class prueba
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.datosPersonaleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.datosGeneralesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.datosPersonaleToolStripMenuItem,
            this.datosGeneralesToolStripMenuItem,
            this.historialToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // datosPersonaleToolStripMenuItem
            // 
            this.datosPersonaleToolStripMenuItem.Name = "datosPersonaleToolStripMenuItem";
            this.datosPersonaleToolStripMenuItem.Size = new System.Drawing.Size(108, 20);
            this.datosPersonaleToolStripMenuItem.Text = "Datos Personales";
            this.datosPersonaleToolStripMenuItem.Click += new System.EventHandler(this.datosPersonaleToolStripMenuItem_Click);
            // 
            // datosGeneralesToolStripMenuItem
            // 
            this.datosGeneralesToolStripMenuItem.Name = "datosGeneralesToolStripMenuItem";
            this.datosGeneralesToolStripMenuItem.Size = new System.Drawing.Size(103, 20);
            this.datosGeneralesToolStripMenuItem.Text = "Datos Generales";
            // 
            // historialToolStripMenuItem
            // 
            this.historialToolStripMenuItem.Name = "historialToolStripMenuItem";
            this.historialToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.historialToolStripMenuItem.Text = "Historial";
            // 
            // prueba
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "prueba";
            this.Text = "prueba";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem datosPersonaleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem datosGeneralesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem historialToolStripMenuItem;
    }
}