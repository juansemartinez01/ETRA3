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
            this.btnExportar = new PresentationA.Controls.BotonPadre();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAplicar = new PresentationA.Controls.BotonPadre();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbColaboradores = new System.Windows.Forms.ComboBox();
            this.cmbTipoEvento = new System.Windows.Forms.ComboBox();
            this.dgvDocumentos = new PresentationA.Controls.DataGridPadre();
            this.Numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Legajo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipodoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Evento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocumentos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(436, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "DOCUMENTOS";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnExportar);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnAplicar);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cmbColaboradores);
            this.groupBox1.Controls.Add(this.cmbTipoEvento);
            this.groupBox1.Location = new System.Drawing.Point(7, 67);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.groupBox1.Size = new System.Drawing.Size(1156, 174);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros";
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
            this.btnExportar.Location = new System.Drawing.Point(692, 123);
            this.btnExportar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(212, 44);
            this.btnExportar.TabIndex = 14;
            this.btnExportar.Text = "Exportar a Excel";
            this.btnExportar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExportar.UseVisualStyleBackColor = false;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(234, 70);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(184, 31);
            this.comboBox1.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 73);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 23);
            this.label3.TabIndex = 12;
            this.label3.Text = "Nombre:";
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
            this.btnAplicar.Location = new System.Drawing.Point(954, 123);
            this.btnAplicar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAplicar.Name = "btnAplicar";
            this.btnAplicar.Size = new System.Drawing.Size(180, 44);
            this.btnAplicar.TabIndex = 11;
            this.btnAplicar.Text = "Aplicar";
            this.btnAplicar.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(498, 73);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tipo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(498, 23);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(191, 23);
            this.label4.TabIndex = 4;
            this.label4.Text = "Fecha de Registro:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(692, 18);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(441, 32);
            this.dateTimePicker1.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(38, 23);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(159, 23);
            this.label6.TabIndex = 6;
            this.label6.Text = "Colaboradores";
            // 
            // cmbColaboradores
            // 
            this.cmbColaboradores.FormattingEnabled = true;
            this.cmbColaboradores.Location = new System.Drawing.Point(692, 70);
            this.cmbColaboradores.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cmbColaboradores.Name = "cmbColaboradores";
            this.cmbColaboradores.Size = new System.Drawing.Size(184, 31);
            this.cmbColaboradores.TabIndex = 8;
            // 
            // cmbTipoEvento
            // 
            this.cmbTipoEvento.FormattingEnabled = true;
            this.cmbTipoEvento.Location = new System.Drawing.Point(234, 20);
            this.cmbTipoEvento.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cmbTipoEvento.Name = "cmbTipoEvento";
            this.cmbTipoEvento.Size = new System.Drawing.Size(184, 31);
            this.cmbTipoEvento.TabIndex = 7;
            // 
            // dgvDocumentos
            // 
            this.dgvDocumentos.AllowUserToAddRows = false;
            this.dgvDocumentos.AllowUserToDeleteRows = false;
            this.dgvDocumentos.AllowUserToOrderColumns = true;
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
            this.dgvDocumentos.Location = new System.Drawing.Point(7, 249);
            this.dgvDocumentos.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvDocumentos.Name = "dgvDocumentos";
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
            this.dgvDocumentos.Size = new System.Drawing.Size(1156, 413);
            this.dgvDocumentos.TabIndex = 46;
            // 
            // Numero
            // 
            this.Numero.HeaderText = "Numero";
            this.Numero.MinimumWidth = 6;
            this.Numero.Name = "Numero";
            // 
            // Legajo
            // 
            this.Legajo.HeaderText = "Legajo";
            this.Legajo.MinimumWidth = 6;
            this.Legajo.Name = "Legajo";
            // 
            // Tipodoc
            // 
            this.Tipodoc.HeaderText = "Tipo doc";
            this.Tipodoc.MinimumWidth = 6;
            this.Tipodoc.Name = "Tipodoc";
            // 
            // Evento
            // 
            this.Evento.HeaderText = "Evento";
            this.Evento.MinimumWidth = 6;
            this.Evento.Name = "Evento";
            // 
            // frmDocumentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1170, 675);
            this.Controls.Add(this.dgvDocumentos);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "frmDocumentos";
            this.Text = "frmDocumentos";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocumentos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private Controls.BotonPadre btnAplicar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbColaboradores;
        private System.Windows.Forms.ComboBox cmbTipoEvento;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private Controls.DataGridPadre dgvDocumentos;
        private Controls.BotonPadre btnExportar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn Legajo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipodoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Evento;
    }
}