namespace PresentationA.Colaboradores
{
    partial class frmDocumentos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnLimpiar = new PresentationA.Controls.BotonPadre();
            this.chkFiltroFecha = new System.Windows.Forms.CheckBox();
            this.cmbTipoEvento = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAplicar = new PresentationA.Controls.BotonPadre();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpFechaRegistro = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbTipoDocumento = new System.Windows.Forms.ComboBox();
            this.cmbColaborador = new System.Windows.Forms.ComboBox();
            this.btnVerArchivo = new PresentationA.Controls.BotonPadre();
            this.btnExportar = new PresentationA.Controls.BotonPadre();
            this.dgvDocumentos = new PresentationA.Controls.DataGridPadre();
            this.Numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Legajo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipodoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Evento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocumentos)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(469, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "DOCUMENTOS";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnLimpiar);
            this.groupBox1.Controls.Add(this.chkFiltroFecha);
            this.groupBox1.Controls.Add(this.cmbTipoEvento);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnAplicar);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dtpFechaRegistro);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cmbTipoDocumento);
            this.groupBox1.Controls.Add(this.cmbColaborador);
            this.groupBox1.Location = new System.Drawing.Point(6, 61);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(1128, 159);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(166)))), ((int)(((byte)(26)))));
            this.btnLimpiar.FlatAppearance.BorderSize = 0;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnLimpiar.ForeColor = System.Drawing.Color.White;
            this.btnLimpiar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnLimpiar.IconColor = System.Drawing.Color.Black;
            this.btnLimpiar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLimpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpiar.Location = new System.Drawing.Point(952, 112);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(129, 40);
            this.btnLimpiar.TabIndex = 50;
            this.btnLimpiar.Text = "Limpiar Filtro";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // chkFiltroFecha
            // 
            this.chkFiltroFecha.Location = new System.Drawing.Point(952, 23);
            this.chkFiltroFecha.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.chkFiltroFecha.Name = "chkFiltroFecha";
            this.chkFiltroFecha.Size = new System.Drawing.Size(129, 30);
            this.chkFiltroFecha.TabIndex = 15;
            this.chkFiltroFecha.Text = "Filtro fecha";
            this.chkFiltroFecha.UseVisualStyleBackColor = true;
            this.chkFiltroFecha.CheckedChanged += new System.EventHandler(this.chkFiltroFecha_CheckedChanged);
            // 
            // cmbTipoEvento
            // 
            this.cmbTipoEvento.FormattingEnabled = true;
            this.cmbTipoEvento.Location = new System.Drawing.Point(195, 64);
            this.cmbTipoEvento.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbTipoEvento.Name = "cmbTipoEvento";
            this.cmbTipoEvento.Size = new System.Drawing.Size(154, 29);
            this.cmbTipoEvento.TabIndex = 13;
            this.cmbTipoEvento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbTipoEvento_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 68);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 21);
            this.label3.TabIndex = 12;
            this.label3.Text = "Tipo evento:";
            // 
            // btnAplicar
            // 
            this.btnAplicar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(166)))), ((int)(((byte)(26)))));
            this.btnAplicar.FlatAppearance.BorderSize = 0;
            this.btnAplicar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAplicar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnAplicar.ForeColor = System.Drawing.Color.White;
            this.btnAplicar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnAplicar.IconColor = System.Drawing.Color.Black;
            this.btnAplicar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAplicar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAplicar.Location = new System.Drawing.Point(795, 112);
            this.btnAplicar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnAplicar.Name = "btnAplicar";
            this.btnAplicar.Size = new System.Drawing.Size(117, 40);
            this.btnAplicar.TabIndex = 11;
            this.btnAplicar.Text = "Aplicar";
            this.btnAplicar.UseVisualStyleBackColor = false;
            this.btnAplicar.Click += new System.EventHandler(this.btnAplicar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(415, 68);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tipo documento:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(415, 27);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 21);
            this.label4.TabIndex = 4;
            this.label4.Text = "Fecha de Registro:";
            // 
            // dtpFechaRegistro
            // 
            this.dtpFechaRegistro.Location = new System.Drawing.Point(577, 22);
            this.dtpFechaRegistro.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpFechaRegistro.Name = "dtpFechaRegistro";
            this.dtpFechaRegistro.Size = new System.Drawing.Size(302, 27);
            this.dtpFechaRegistro.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 27);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 21);
            this.label6.TabIndex = 6;
            this.label6.Text = "Colaboradores:";
            // 
            // cmbTipoDocumento
            // 
            this.cmbTipoDocumento.FormattingEnabled = true;
            this.cmbTipoDocumento.Location = new System.Drawing.Point(578, 64);
            this.cmbTipoDocumento.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbTipoDocumento.Name = "cmbTipoDocumento";
            this.cmbTipoDocumento.Size = new System.Drawing.Size(301, 29);
            this.cmbTipoDocumento.TabIndex = 8;
            // 
            // cmbColaborador
            // 
            this.cmbColaborador.FormattingEnabled = true;
            this.cmbColaborador.Location = new System.Drawing.Point(195, 24);
            this.cmbColaborador.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbColaborador.Name = "cmbColaborador";
            this.cmbColaborador.Size = new System.Drawing.Size(154, 29);
            this.cmbColaborador.TabIndex = 7;
            this.cmbColaborador.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbColaborador_KeyPress);
            // 
            // btnVerArchivo
            // 
            this.btnVerArchivo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(166)))), ((int)(((byte)(26)))));
            this.btnVerArchivo.FlatAppearance.BorderSize = 0;
            this.btnVerArchivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerArchivo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnVerArchivo.ForeColor = System.Drawing.Color.White;
            this.btnVerArchivo.IconChar = FontAwesome.Sharp.IconChar.File;
            this.btnVerArchivo.IconColor = System.Drawing.Color.White;
            this.btnVerArchivo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnVerArchivo.IconSize = 25;
            this.btnVerArchivo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVerArchivo.Location = new System.Drawing.Point(11, 3);
            this.btnVerArchivo.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnVerArchivo.Name = "btnVerArchivo";
            this.btnVerArchivo.Size = new System.Drawing.Size(252, 43);
            this.btnVerArchivo.TabIndex = 49;
            this.btnVerArchivo.Text = "Ver Archivo";
            this.btnVerArchivo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVerArchivo.UseVisualStyleBackColor = false;
            this.btnVerArchivo.Click += new System.EventHandler(this.btnVerArchivo_Click);
            // 
            // btnExportar
            // 
            this.btnExportar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(166)))), ((int)(((byte)(26)))));
            this.btnExportar.FlatAppearance.BorderSize = 0;
            this.btnExportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnExportar.ForeColor = System.Drawing.Color.White;
            this.btnExportar.IconChar = FontAwesome.Sharp.IconChar.FileExcel;
            this.btnExportar.IconColor = System.Drawing.Color.White;
            this.btnExportar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnExportar.IconSize = 30;
            this.btnExportar.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnExportar.Location = new System.Drawing.Point(302, 3);
            this.btnExportar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(238, 39);
            this.btnExportar.TabIndex = 14;
            this.btnExportar.Text = "Exportar a Excel";
            this.btnExportar.UseVisualStyleBackColor = false;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // dgvDocumentos
            // 
            this.dgvDocumentos.AllowUserToAddRows = false;
            this.dgvDocumentos.AllowUserToDeleteRows = false;
            this.dgvDocumentos.AllowUserToOrderColumns = true;
            this.dgvDocumentos.AllowUserToResizeRows = false;
            this.dgvDocumentos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDocumentos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDocumentos.BackgroundColor = System.Drawing.Color.White;
            this.dgvDocumentos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvDocumentos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(103)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(103)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDocumentos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDocumentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDocumentos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Numero,
            this.Legajo,
            this.Tipodoc,
            this.Evento});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(43)))), ((int)(((byte)(26)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDocumentos.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDocumentos.EnableHeadersVisualStyles = false;
            this.dgvDocumentos.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.dgvDocumentos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(103)))), ((int)(((byte)(34)))));
            this.dgvDocumentos.Location = new System.Drawing.Point(6, 226);
            this.dgvDocumentos.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dgvDocumentos.Name = "dgvDocumentos";
            this.dgvDocumentos.ReadOnly = true;
            this.dgvDocumentos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(103)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(43)))), ((int)(((byte)(26)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDocumentos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDocumentos.RowHeadersWidth = 51;
            this.dgvDocumentos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDocumentos.Size = new System.Drawing.Size(1126, 323);
            this.dgvDocumentos.TabIndex = 46;
            this.dgvDocumentos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDocumentos_CellContentClick);
            this.dgvDocumentos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDocumentos_CellContentClick);
            this.dgvDocumentos.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDocumentos_CellContentClick);
            this.dgvDocumentos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDocumentos_CellContentClick);
            // 
            // Numero
            // 
            this.Numero.HeaderText = "Numero";
            this.Numero.MinimumWidth = 6;
            this.Numero.Name = "Numero";
            this.Numero.ReadOnly = true;
            // 
            // Legajo
            // 
            this.Legajo.HeaderText = "Legajo";
            this.Legajo.MinimumWidth = 6;
            this.Legajo.Name = "Legajo";
            this.Legajo.ReadOnly = true;
            // 
            // Tipodoc
            // 
            this.Tipodoc.HeaderText = "Tipo doc";
            this.Tipodoc.MinimumWidth = 6;
            this.Tipodoc.Name = "Tipodoc";
            this.Tipodoc.ReadOnly = true;
            // 
            // Evento
            // 
            this.Evento.HeaderText = "Evento";
            this.Evento.MinimumWidth = 6;
            this.Evento.Name = "Evento";
            this.Evento.ReadOnly = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnVerArchivo);
            this.panel1.Controls.Add(this.btnExportar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 555);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1144, 61);
            this.panel1.TabIndex = 47;
            // 
            // frmDocumentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1144, 616);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvDocumentos);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmDocumentos";
            this.Text = "frmDocumentos";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocumentos)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private Controls.BotonPadre btnAplicar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpFechaRegistro;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbTipoDocumento;
        private System.Windows.Forms.ComboBox cmbColaborador;
        private System.Windows.Forms.ComboBox cmbTipoEvento;
        private System.Windows.Forms.Label label3;
        private Controls.DataGridPadre dgvDocumentos;
        private Controls.BotonPadre btnExportar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn Legajo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipodoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Evento;
        private System.Windows.Forms.CheckBox chkFiltroFecha;
        private Controls.BotonPadre btnVerArchivo;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private Controls.BotonPadre btnLimpiar;
        private System.Windows.Forms.Panel panel1;
    }
}