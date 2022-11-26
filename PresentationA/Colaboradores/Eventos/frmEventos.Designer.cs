namespace PresentationA.Colaboradores
{
    partial class frmEventos
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
            this.label2 = new System.Windows.Forms.Label();
            this.lblFechaFin = new System.Windows.Forms.Label();
            this.lblFechaInicio = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbTipoEvento = new System.Windows.Forms.ComboBox();
            this.cmbColaboradores = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnLimpiar = new PresentationA.Controls.BotonPadre();
            this.chkFiltroFecha = new System.Windows.Forms.CheckBox();
            this.btnAplicar = new PresentationA.Controls.BotonPadre();
            this.btnNuevoEvento = new PresentationA.Controls.BotonPadre();
            this.dgvEventos = new PresentationA.Controls.DataGridPadre();
            this.legajoColaborador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaFin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaRegistro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEventos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(389, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "EVENTOS";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 21);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Eventos:";
            // 
            // lblFechaFin
            // 
            this.lblFechaFin.AutoSize = true;
            this.lblFechaFin.Location = new System.Drawing.Point(392, 67);
            this.lblFechaFin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFechaFin.Name = "lblFechaFin";
            this.lblFechaFin.Size = new System.Drawing.Size(102, 22);
            this.lblFechaFin.TabIndex = 3;
            this.lblFechaFin.Text = "Fecha Fin:";
            // 
            // lblFechaInicio
            // 
            this.lblFechaInicio.AutoSize = true;
            this.lblFechaInicio.Location = new System.Drawing.Point(392, 21);
            this.lblFechaInicio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFechaInicio.Name = "lblFechaInicio";
            this.lblFechaInicio.Size = new System.Drawing.Size(155, 22);
            this.lblFechaInicio.TabIndex = 4;
            this.lblFechaInicio.Text = "Fecha de Inicio:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(35, 67);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(147, 22);
            this.label6.TabIndex = 6;
            this.label6.Text = "Colaboradores";
            // 
            // cmbTipoEvento
            // 
            this.cmbTipoEvento.FormattingEnabled = true;
            this.cmbTipoEvento.Location = new System.Drawing.Point(195, 18);
            this.cmbTipoEvento.Margin = new System.Windows.Forms.Padding(4);
            this.cmbTipoEvento.Name = "cmbTipoEvento";
            this.cmbTipoEvento.Size = new System.Drawing.Size(154, 30);
            this.cmbTipoEvento.TabIndex = 7;
            this.cmbTipoEvento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbTipoEvento_KeyPress);
            // 
            // cmbColaboradores
            // 
            this.cmbColaboradores.FormattingEnabled = true;
            this.cmbColaboradores.Location = new System.Drawing.Point(195, 64);
            this.cmbColaboradores.Margin = new System.Windows.Forms.Padding(4);
            this.cmbColaboradores.Name = "cmbColaboradores";
            this.cmbColaboradores.Size = new System.Drawing.Size(154, 30);
            this.cmbColaboradores.TabIndex = 8;
            this.cmbColaboradores.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbColaboradores_KeyPress);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(531, 18);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(286, 30);
            this.dateTimePicker1.TabIndex = 9;
            this.dateTimePicker1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dateTimePicker1_KeyPress);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(531, 62);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(286, 30);
            this.dateTimePicker2.TabIndex = 10;
            this.dateTimePicker2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dateTimePicker2_KeyPress);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnLimpiar);
            this.groupBox1.Controls.Add(this.chkFiltroFecha);
            this.groupBox1.Controls.Add(this.btnAplicar);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lblFechaFin);
            this.groupBox1.Controls.Add(this.dateTimePicker2);
            this.groupBox1.Controls.Add(this.lblFechaInicio);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cmbColaboradores);
            this.groupBox1.Controls.Add(this.cmbTipoEvento);
            this.groupBox1.Location = new System.Drawing.Point(28, 62);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1067, 185);
            this.groupBox1.TabIndex = 12;
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
            this.btnLimpiar.Location = new System.Drawing.Point(836, 103);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(150, 40);
            this.btnLimpiar.TabIndex = 13;
            this.btnLimpiar.Text = "Limpiar Filtro";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // chkFiltroFecha
            // 
            this.chkFiltroFecha.AutoSize = true;
            this.chkFiltroFecha.Location = new System.Drawing.Point(396, 112);
            this.chkFiltroFecha.Name = "chkFiltroFecha";
            this.chkFiltroFecha.Size = new System.Drawing.Size(203, 26);
            this.chkFiltroFecha.TabIndex = 12;
            this.chkFiltroFecha.Text = "Activar filtro fecha";
            this.chkFiltroFecha.UseVisualStyleBackColor = true;
            this.chkFiltroFecha.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
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
            this.btnAplicar.Location = new System.Drawing.Point(667, 102);
            this.btnAplicar.Name = "btnAplicar";
            this.btnAplicar.Size = new System.Drawing.Size(150, 40);
            this.btnAplicar.TabIndex = 11;
            this.btnAplicar.Text = "Aplicar";
            this.btnAplicar.UseVisualStyleBackColor = false;
            this.btnAplicar.Click += new System.EventHandler(this.btnAplicar_Click);
            // 
            // btnNuevoEvento
            // 
            this.btnNuevoEvento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnNuevoEvento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(166)))), ((int)(((byte)(26)))));
            this.btnNuevoEvento.FlatAppearance.BorderSize = 0;
            this.btnNuevoEvento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevoEvento.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnNuevoEvento.ForeColor = System.Drawing.Color.White;
            this.btnNuevoEvento.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.btnNuevoEvento.IconColor = System.Drawing.Color.White;
            this.btnNuevoEvento.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnNuevoEvento.IconSize = 30;
            this.btnNuevoEvento.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevoEvento.Location = new System.Drawing.Point(28, 520);
            this.btnNuevoEvento.Name = "btnNuevoEvento";
            this.btnNuevoEvento.Size = new System.Drawing.Size(165, 40);
            this.btnNuevoEvento.TabIndex = 17;
            this.btnNuevoEvento.Text = "Nuevo Evento";
            this.btnNuevoEvento.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNuevoEvento.UseVisualStyleBackColor = false;
            this.btnNuevoEvento.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvEventos
            // 
            this.dgvEventos.AllowUserToAddRows = false;
            this.dgvEventos.AllowUserToDeleteRows = false;
            this.dgvEventos.AllowUserToOrderColumns = true;
            this.dgvEventos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvEventos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEventos.BackgroundColor = System.Drawing.Color.White;
            this.dgvEventos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvEventos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(103)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(103)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEventos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvEventos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEventos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.legajoColaborador,
            this.nombre,
            this.descripcion,
            this.fechaInicio,
            this.fechaFin,
            this.fechaRegistro});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(43)))), ((int)(((byte)(26)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEventos.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvEventos.EnableHeadersVisualStyles = false;
            this.dgvEventos.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.dgvEventos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(103)))), ((int)(((byte)(34)))));
            this.dgvEventos.Location = new System.Drawing.Point(28, 265);
            this.dgvEventos.Name = "dgvEventos";
            this.dgvEventos.ReadOnly = true;
            this.dgvEventos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(103)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(43)))), ((int)(((byte)(26)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEventos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvEventos.RowHeadersWidth = 51;
            this.dgvEventos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEventos.Size = new System.Drawing.Size(1067, 224);
            this.dgvEventos.TabIndex = 45;
            // 
            // legajoColaborador
            // 
            this.legajoColaborador.HeaderText = "Legajo Colaborador";
            this.legajoColaborador.MinimumWidth = 8;
            this.legajoColaborador.Name = "legajoColaborador";
            this.legajoColaborador.ReadOnly = true;
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Evento";
            this.nombre.MinimumWidth = 8;
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            // 
            // descripcion
            // 
            this.descripcion.HeaderText = "Descripción";
            this.descripcion.MinimumWidth = 8;
            this.descripcion.Name = "descripcion";
            this.descripcion.ReadOnly = true;
            // 
            // fechaInicio
            // 
            this.fechaInicio.HeaderText = "Fecha de Inicio";
            this.fechaInicio.MinimumWidth = 8;
            this.fechaInicio.Name = "fechaInicio";
            this.fechaInicio.ReadOnly = true;
            // 
            // fechaFin
            // 
            this.fechaFin.HeaderText = "Fecha Fin";
            this.fechaFin.MinimumWidth = 8;
            this.fechaFin.Name = "fechaFin";
            this.fechaFin.ReadOnly = true;
            // 
            // fechaRegistro
            // 
            this.fechaRegistro.HeaderText = "Fecha de Registro";
            this.fechaRegistro.MinimumWidth = 8;
            this.fechaRegistro.Name = "fechaRegistro";
            this.fechaRegistro.ReadOnly = true;
            // 
            // frmEventos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1115, 585);
            this.Controls.Add(this.dgvEventos);
            this.Controls.Add(this.btnNuevoEvento);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MinimumSize = new System.Drawing.Size(959, 585);
            this.Name = "frmEventos";
            this.Text = "frmEventos";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEventos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblFechaFin;
        private System.Windows.Forms.Label lblFechaInicio;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbTipoEvento;
        private System.Windows.Forms.ComboBox cmbColaboradores;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private Controls.BotonPadre btnAplicar;
        private Controls.BotonPadre btnNuevoEvento;
        private Controls.DataGridPadre dgvEventos;
        private System.Windows.Forms.CheckBox chkFiltroFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn legajoColaborador;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaInicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaFin;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaRegistro;
        private Controls.BotonPadre btnLimpiar;
    }
}