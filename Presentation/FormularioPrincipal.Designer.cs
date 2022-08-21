
namespace Presentation
{
    partial class FormularioPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormularioPrincipal));
            this.pnlSideMenu = new System.Windows.Forms.Panel();
            this.pnlColaboradores = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.btnAgregarColab = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnColaboradores = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlChildForm = new System.Windows.Forms.Panel();
            this.btnEventos = new System.Windows.Forms.Button();
            this.pnlSideMenu.SuspendLayout();
            this.pnlColaboradores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSideMenu
            // 
            this.pnlSideMenu.AutoScroll = true;
            this.pnlSideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(166)))), ((int)(((byte)(26)))));
            this.pnlSideMenu.Controls.Add(this.pnlColaboradores);
            this.pnlSideMenu.Controls.Add(this.btnColaboradores);
            this.pnlSideMenu.Controls.Add(this.pictureBox1);
            this.pnlSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSideMenu.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.pnlSideMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlSideMenu.Name = "pnlSideMenu";
            this.pnlSideMenu.Size = new System.Drawing.Size(200, 661);
            this.pnlSideMenu.TabIndex = 1;
            // 
            // pnlColaboradores
            // 
            this.pnlColaboradores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(160)))), ((int)(((byte)(85)))));
            this.pnlColaboradores.Controls.Add(this.btnEventos);
            this.pnlColaboradores.Controls.Add(this.button4);
            this.pnlColaboradores.Controls.Add(this.btnAgregarColab);
            this.pnlColaboradores.Controls.Add(this.btnConsultar);
            this.pnlColaboradores.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlColaboradores.Location = new System.Drawing.Point(0, 102);
            this.pnlColaboradores.Name = "pnlColaboradores";
            this.pnlColaboradores.Size = new System.Drawing.Size(200, 181);
            this.pnlColaboradores.TabIndex = 2;
            // 
            // button4
            // 
            this.button4.Dock = System.Windows.Forms.DockStyle.Top;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(0, 84);
            this.button4.Name = "button4";
            this.button4.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.button4.Size = new System.Drawing.Size(200, 42);
            this.button4.TabIndex = 2;
            this.button4.Text = "Reportes";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnAgregarColab
            // 
            this.btnAgregarColab.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAgregarColab.FlatAppearance.BorderSize = 0;
            this.btnAgregarColab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarColab.ForeColor = System.Drawing.Color.White;
            this.btnAgregarColab.Location = new System.Drawing.Point(0, 42);
            this.btnAgregarColab.Name = "btnAgregarColab";
            this.btnAgregarColab.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnAgregarColab.Size = new System.Drawing.Size(200, 42);
            this.btnAgregarColab.TabIndex = 1;
            this.btnAgregarColab.Text = "Agregar / Modificar";
            this.btnAgregarColab.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarColab.UseVisualStyleBackColor = true;
            this.btnAgregarColab.Click += new System.EventHandler(this.btnAgregarColab_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(160)))), ((int)(((byte)(85)))));
            this.btnConsultar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnConsultar.FlatAppearance.BorderSize = 0;
            this.btnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultar.ForeColor = System.Drawing.Color.White;
            this.btnConsultar.Location = new System.Drawing.Point(0, 0);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnConsultar.Size = new System.Drawing.Size(200, 42);
            this.btnConsultar.TabIndex = 0;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultar.UseVisualStyleBackColor = false;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // btnColaboradores
            // 
            this.btnColaboradores.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnColaboradores.FlatAppearance.BorderSize = 0;
            this.btnColaboradores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnColaboradores.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnColaboradores.ForeColor = System.Drawing.Color.White;
            this.btnColaboradores.Location = new System.Drawing.Point(0, 54);
            this.btnColaboradores.Name = "btnColaboradores";
            this.btnColaboradores.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnColaboradores.Size = new System.Drawing.Size(200, 48);
            this.btnColaboradores.TabIndex = 1;
            this.btnColaboradores.Text = "Colaboradores";
            this.btnColaboradores.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnColaboradores.UseVisualStyleBackColor = true;
            this.btnColaboradores.Click += new System.EventHandler(this.btnColaboradores_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = global::Presentation.Properties.Resources.logoLWS2;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 54);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pnlChildForm
            // 
            this.pnlChildForm.AutoScroll = true;
            this.pnlChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlChildForm.Location = new System.Drawing.Point(200, 0);
            this.pnlChildForm.MinimumSize = new System.Drawing.Size(800, 471);
            this.pnlChildForm.Name = "pnlChildForm";
            this.pnlChildForm.Size = new System.Drawing.Size(934, 661);
            this.pnlChildForm.TabIndex = 2;
            // 
            // btnEventos
            // 
            this.btnEventos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEventos.FlatAppearance.BorderSize = 0;
            this.btnEventos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEventos.ForeColor = System.Drawing.Color.White;
            this.btnEventos.Location = new System.Drawing.Point(0, 126);
            this.btnEventos.Name = "btnEventos";
            this.btnEventos.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnEventos.Size = new System.Drawing.Size(200, 42);
            this.btnEventos.TabIndex = 3;
            this.btnEventos.Text = "Eventos";
            this.btnEventos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEventos.UseVisualStyleBackColor = true;
            this.btnEventos.Click += new System.EventHandler(this.btnEventos_Click);
            // 
            // FormularioPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1134, 661);
            this.Controls.Add(this.pnlChildForm);
            this.Controls.Add(this.pnlSideMenu);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1150, 700);
            this.Name = "FormularioPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormularioPrincipal_FormClosing);
            this.pnlSideMenu.ResumeLayout(false);
            this.pnlColaboradores.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlSideMenu;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnlColaboradores;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnAgregarColab;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnColaboradores;
        private System.Windows.Forms.Panel pnlChildForm;
        private System.Windows.Forms.Button btnEventos;
    }
}

