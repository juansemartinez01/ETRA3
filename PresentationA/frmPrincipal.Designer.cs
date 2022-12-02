namespace PresentationA
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.pnlPrincipal = new System.Windows.Forms.Panel();
            this.pnlReportes = new System.Windows.Forms.Panel();
            this.btnSalXCargo = new FontAwesome.Sharp.IconButton();
            this.btnTardanzas = new FontAwesome.Sharp.IconButton();
            this.btnReportes = new FontAwesome.Sharp.IconButton();
            this.pnlColaboradores = new System.Windows.Forms.Panel();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.btnUsuarios = new FontAwesome.Sharp.IconButton();
            this.btnAvisos = new FontAwesome.Sharp.IconButton();
            this.btnDocumentos = new FontAwesome.Sharp.IconButton();
            this.btnSalarios = new FontAwesome.Sharp.IconButton();
            this.btnEventos = new FontAwesome.Sharp.IconButton();
            this.btnAgregar = new FontAwesome.Sharp.IconButton();
            this.btnConsultar = new FontAwesome.Sharp.IconButton();
            this.btnColaboradores = new FontAwesome.Sharp.IconButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlChildForm = new System.Windows.Forms.Panel();
            this.pnlPrincipal.SuspendLayout();
            this.pnlReportes.SuspendLayout();
            this.pnlColaboradores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlPrincipal
            // 
            this.pnlPrincipal.AutoScroll = true;
            this.pnlPrincipal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(166)))), ((int)(((byte)(26)))));
            this.pnlPrincipal.Controls.Add(this.pnlReportes);
            this.pnlPrincipal.Controls.Add(this.btnReportes);
            this.pnlPrincipal.Controls.Add(this.pnlColaboradores);
            this.pnlPrincipal.Controls.Add(this.btnColaboradores);
            this.pnlPrincipal.Controls.Add(this.pictureBox1);
            this.pnlPrincipal.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlPrincipal.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.pnlPrincipal.Location = new System.Drawing.Point(0, 0);
            this.pnlPrincipal.Name = "pnlPrincipal";
            this.pnlPrincipal.Size = new System.Drawing.Size(200, 650);
            this.pnlPrincipal.TabIndex = 1;
            // 
            // pnlReportes
            // 
            this.pnlReportes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(160)))), ((int)(((byte)(85)))));
            this.pnlReportes.Controls.Add(this.btnSalXCargo);
            this.pnlReportes.Controls.Add(this.btnTardanzas);
            this.pnlReportes.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlReportes.Location = new System.Drawing.Point(0, 506);
            this.pnlReportes.Name = "pnlReportes";
            this.pnlReportes.Size = new System.Drawing.Size(200, 119);
            this.pnlReportes.TabIndex = 0;
            // 
            // btnSalXCargo
            // 
            this.btnSalXCargo.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSalXCargo.FlatAppearance.BorderSize = 0;
            this.btnSalXCargo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalXCargo.ForeColor = System.Drawing.Color.White;
            this.btnSalXCargo.IconChar = FontAwesome.Sharp.IconChar.ChartColumn;
            this.btnSalXCargo.IconColor = System.Drawing.Color.White;
            this.btnSalXCargo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSalXCargo.IconSize = 30;
            this.btnSalXCargo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalXCargo.Location = new System.Drawing.Point(0, 56);
            this.btnSalXCargo.Name = "btnSalXCargo";
            this.btnSalXCargo.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnSalXCargo.Size = new System.Drawing.Size(200, 56);
            this.btnSalXCargo.TabIndex = 3;
            this.btnSalXCargo.Text = "Salarios por Cargo";
            this.btnSalXCargo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalXCargo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSalXCargo.UseVisualStyleBackColor = true;
            this.btnSalXCargo.Click += new System.EventHandler(this.btnSalXCargo_Click);
            // 
            // btnTardanzas
            // 
            this.btnTardanzas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTardanzas.FlatAppearance.BorderSize = 0;
            this.btnTardanzas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTardanzas.ForeColor = System.Drawing.Color.White;
            this.btnTardanzas.IconChar = FontAwesome.Sharp.IconChar.ChartColumn;
            this.btnTardanzas.IconColor = System.Drawing.Color.White;
            this.btnTardanzas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTardanzas.IconSize = 30;
            this.btnTardanzas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTardanzas.Location = new System.Drawing.Point(0, 0);
            this.btnTardanzas.Name = "btnTardanzas";
            this.btnTardanzas.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnTardanzas.Size = new System.Drawing.Size(200, 56);
            this.btnTardanzas.TabIndex = 4;
            this.btnTardanzas.Text = "Tardanzas por Período";
            this.btnTardanzas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTardanzas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTardanzas.UseVisualStyleBackColor = true;
            this.btnTardanzas.Click += new System.EventHandler(this.btnTardanzas_Click);
            // 
            // btnReportes
            // 
            this.btnReportes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReportes.FlatAppearance.BorderSize = 0;
            this.btnReportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReportes.ForeColor = System.Drawing.Color.White;
            this.btnReportes.IconChar = FontAwesome.Sharp.IconChar.ChartSimple;
            this.btnReportes.IconColor = System.Drawing.Color.White;
            this.btnReportes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnReportes.IconSize = 30;
            this.btnReportes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReportes.Location = new System.Drawing.Point(0, 464);
            this.btnReportes.Name = "btnReportes";
            this.btnReportes.Size = new System.Drawing.Size(200, 42);
            this.btnReportes.TabIndex = 5;
            this.btnReportes.Text = "Reportes";
            this.btnReportes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReportes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReportes.UseVisualStyleBackColor = true;
            this.btnReportes.Click += new System.EventHandler(this.btnReportes_Click);
            // 
            // pnlColaboradores
            // 
            this.pnlColaboradores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(160)))), ((int)(((byte)(85)))));
            this.pnlColaboradores.Controls.Add(this.iconButton1);
            this.pnlColaboradores.Controls.Add(this.btnUsuarios);
            this.pnlColaboradores.Controls.Add(this.btnAvisos);
            this.pnlColaboradores.Controls.Add(this.btnDocumentos);
            this.pnlColaboradores.Controls.Add(this.btnSalarios);
            this.pnlColaboradores.Controls.Add(this.btnEventos);
            this.pnlColaboradores.Controls.Add(this.btnAgregar);
            this.pnlColaboradores.Controls.Add(this.btnConsultar);
            this.pnlColaboradores.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlColaboradores.Location = new System.Drawing.Point(0, 120);
            this.pnlColaboradores.Name = "pnlColaboradores";
            this.pnlColaboradores.Size = new System.Drawing.Size(200, 344);
            this.pnlColaboradores.TabIndex = 2;
            this.pnlColaboradores.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlColaboradores_Paint);
            // 
            // iconButton1
            // 
            this.iconButton1.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.ForeColor = System.Drawing.Color.White;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Book;
            this.iconButton1.IconColor = System.Drawing.Color.White;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 30;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.Location = new System.Drawing.Point(0, 294);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.iconButton1.Size = new System.Drawing.Size(200, 42);
            this.iconButton1.TabIndex = 8;
            this.iconButton1.Text = "Comprobantes";
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUsuarios.FlatAppearance.BorderSize = 0;
            this.btnUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsuarios.ForeColor = System.Drawing.Color.White;
            this.btnUsuarios.IconChar = FontAwesome.Sharp.IconChar.CircleUser;
            this.btnUsuarios.IconColor = System.Drawing.Color.White;
            this.btnUsuarios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnUsuarios.IconSize = 30;
            this.btnUsuarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsuarios.Location = new System.Drawing.Point(0, 252);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnUsuarios.Size = new System.Drawing.Size(200, 42);
            this.btnUsuarios.TabIndex = 7;
            this.btnUsuarios.Text = "Usuarios";
            this.btnUsuarios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsuarios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUsuarios.UseVisualStyleBackColor = true;
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            // 
            // btnAvisos
            // 
            this.btnAvisos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAvisos.FlatAppearance.BorderSize = 0;
            this.btnAvisos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAvisos.ForeColor = System.Drawing.Color.White;
            this.btnAvisos.IconChar = FontAwesome.Sharp.IconChar.Bell;
            this.btnAvisos.IconColor = System.Drawing.Color.White;
            this.btnAvisos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAvisos.IconSize = 30;
            this.btnAvisos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAvisos.Location = new System.Drawing.Point(0, 210);
            this.btnAvisos.Name = "btnAvisos";
            this.btnAvisos.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnAvisos.Size = new System.Drawing.Size(200, 42);
            this.btnAvisos.TabIndex = 6;
            this.btnAvisos.Text = "Avisos";
            this.btnAvisos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAvisos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAvisos.UseVisualStyleBackColor = true;
            this.btnAvisos.Click += new System.EventHandler(this.btnAvisos_Click);
            // 
            // btnDocumentos
            // 
            this.btnDocumentos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDocumentos.FlatAppearance.BorderSize = 0;
            this.btnDocumentos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDocumentos.ForeColor = System.Drawing.Color.White;
            this.btnDocumentos.IconChar = FontAwesome.Sharp.IconChar.File;
            this.btnDocumentos.IconColor = System.Drawing.Color.White;
            this.btnDocumentos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDocumentos.IconSize = 30;
            this.btnDocumentos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDocumentos.Location = new System.Drawing.Point(0, 168);
            this.btnDocumentos.Name = "btnDocumentos";
            this.btnDocumentos.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnDocumentos.Size = new System.Drawing.Size(200, 42);
            this.btnDocumentos.TabIndex = 5;
            this.btnDocumentos.Text = "Documentos";
            this.btnDocumentos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDocumentos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDocumentos.UseVisualStyleBackColor = true;
            this.btnDocumentos.Click += new System.EventHandler(this.btnDocumentos_Click);
            // 
            // btnSalarios
            // 
            this.btnSalarios.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSalarios.FlatAppearance.BorderSize = 0;
            this.btnSalarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalarios.ForeColor = System.Drawing.Color.White;
            this.btnSalarios.IconChar = FontAwesome.Sharp.IconChar.DollarSign;
            this.btnSalarios.IconColor = System.Drawing.Color.White;
            this.btnSalarios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSalarios.IconSize = 30;
            this.btnSalarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalarios.Location = new System.Drawing.Point(0, 126);
            this.btnSalarios.Name = "btnSalarios";
            this.btnSalarios.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnSalarios.Size = new System.Drawing.Size(200, 42);
            this.btnSalarios.TabIndex = 4;
            this.btnSalarios.Text = "Salarios";
            this.btnSalarios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalarios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSalarios.UseVisualStyleBackColor = true;
            this.btnSalarios.Click += new System.EventHandler(this.btnSalarios_Click);
            // 
            // btnEventos
            // 
            this.btnEventos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEventos.FlatAppearance.BorderSize = 0;
            this.btnEventos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEventos.ForeColor = System.Drawing.Color.White;
            this.btnEventos.IconChar = FontAwesome.Sharp.IconChar.ExclamationCircle;
            this.btnEventos.IconColor = System.Drawing.Color.White;
            this.btnEventos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEventos.IconSize = 30;
            this.btnEventos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEventos.Location = new System.Drawing.Point(0, 84);
            this.btnEventos.Name = "btnEventos";
            this.btnEventos.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnEventos.Size = new System.Drawing.Size(200, 42);
            this.btnEventos.TabIndex = 3;
            this.btnEventos.Text = "Eventos";
            this.btnEventos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEventos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEventos.UseVisualStyleBackColor = true;
            this.btnEventos.Click += new System.EventHandler(this.btnEventos_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.btnAgregar.IconColor = System.Drawing.Color.White;
            this.btnAgregar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAgregar.IconSize = 30;
            this.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregar.Location = new System.Drawing.Point(0, 42);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnAgregar.Size = new System.Drawing.Size(200, 42);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregarColab_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnConsultar.FlatAppearance.BorderSize = 0;
            this.btnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultar.ForeColor = System.Drawing.Color.White;
            this.btnConsultar.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnConsultar.IconColor = System.Drawing.Color.White;
            this.btnConsultar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnConsultar.IconSize = 30;
            this.btnConsultar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultar.Location = new System.Drawing.Point(0, 0);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnConsultar.Size = new System.Drawing.Size(200, 42);
            this.btnConsultar.TabIndex = 0;
            this.btnConsultar.Text = "Buscar";
            this.btnConsultar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // btnColaboradores
            // 
            this.btnColaboradores.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnColaboradores.FlatAppearance.BorderSize = 0;
            this.btnColaboradores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnColaboradores.ForeColor = System.Drawing.Color.White;
            this.btnColaboradores.IconChar = FontAwesome.Sharp.IconChar.PeopleGroup;
            this.btnColaboradores.IconColor = System.Drawing.Color.White;
            this.btnColaboradores.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnColaboradores.IconSize = 30;
            this.btnColaboradores.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnColaboradores.Location = new System.Drawing.Point(0, 78);
            this.btnColaboradores.Name = "btnColaboradores";
            this.btnColaboradores.Size = new System.Drawing.Size(200, 42);
            this.btnColaboradores.TabIndex = 3;
            this.btnColaboradores.Text = "Colaboradores";
            this.btnColaboradores.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnColaboradores.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnColaboradores.UseVisualStyleBackColor = true;
            this.btnColaboradores.Click += new System.EventHandler(this.btnColaboradores_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = global::PresentationA.Properties.Resources.logoLWS2;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 78);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pnlChildForm
            // 
            this.pnlChildForm.AutoScroll = true;
            this.pnlChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlChildForm.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.pnlChildForm.Location = new System.Drawing.Point(200, 0);
            this.pnlChildForm.Name = "pnlChildForm";
            this.pnlChildForm.Size = new System.Drawing.Size(751, 650);
            this.pnlChildForm.TabIndex = 2;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(951, 650);
            this.Controls.Add(this.pnlChildForm);
            this.Controls.Add(this.pnlPrincipal);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(800, 613);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPrincipal_FormClosing);
            this.pnlPrincipal.ResumeLayout(false);
            this.pnlReportes.ResumeLayout(false);
            this.pnlColaboradores.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlPrincipal;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnlColaboradores;
        private System.Windows.Forms.Panel pnlChildForm;
        private FontAwesome.Sharp.IconButton btnEventos;
        private FontAwesome.Sharp.IconButton btnAgregar;
        private FontAwesome.Sharp.IconButton btnConsultar;
        private FontAwesome.Sharp.IconButton btnColaboradores;
        private FontAwesome.Sharp.IconButton btnTardanzas;
        private FontAwesome.Sharp.IconButton btnSalXCargo;
        private FontAwesome.Sharp.IconButton btnReportes;
        private System.Windows.Forms.Panel pnlReportes;
        private FontAwesome.Sharp.IconButton btnSalarios;
        private FontAwesome.Sharp.IconButton btnDocumentos;
        private FontAwesome.Sharp.IconButton btnAvisos;
        private FontAwesome.Sharp.IconButton btnUsuarios;
        private FontAwesome.Sharp.IconButton iconButton1;
    }
}

