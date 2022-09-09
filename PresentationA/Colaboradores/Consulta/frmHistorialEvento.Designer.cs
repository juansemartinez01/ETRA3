namespace PresentationA.Colaboradores.Consulta
{
    partial class frmHistorialEvento
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.RichTextBox();
            this.dgvEventos = new System.Windows.Forms.DataGridView();
            this.cmbTipoEvento = new System.Windows.Forms.ComboBox();
            this.dtpfechaInicio = new System.Windows.Forms.DateTimePicker();
            this.dtpfechaFin = new System.Windows.Forms.DateTimePicker();
            this.dtpfechaRegistro = new System.Windows.Forms.DateTimePicker();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.btnVerArchivo = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.btnModificar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbTipoMultimedia = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEventos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(15, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(295, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Historial de Eventos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 79);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tipo Evento:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 195);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(180, 22);
            this.label4.TabIndex = 4;
            this.label4.Text = "Fecha de Registro:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 156);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 22);
            this.label5.TabIndex = 5;
            this.label5.Text = "Fecha Fin:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 119);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(155, 22);
            this.label6.TabIndex = 6;
            this.label6.Text = "Fecha de Inicio:";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(13, 517);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(96, 27);
            this.btnAgregar.TabIndex = 8;
            this.btnAgregar.Text = "Confirmar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(292, 517);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(96, 27);
            this.btnEliminar.TabIndex = 9;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 240);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 22);
            this.label7.TabIndex = 11;
            this.label7.Text = "Descripción:";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescripcion.Location = new System.Drawing.Point(188, 240);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(196, 112);
            this.txtDescripcion.TabIndex = 17;
            this.txtDescripcion.Text = "";
            // 
            // dgvEventos
            // 
            this.dgvEventos.AllowUserToOrderColumns = true;
            this.dgvEventos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEventos.BackgroundColor = System.Drawing.Color.White;
            this.dgvEventos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEventos.Location = new System.Drawing.Point(421, 76);
            this.dgvEventos.Margin = new System.Windows.Forms.Padding(4);
            this.dgvEventos.Name = "dgvEventos";
            this.dgvEventos.ReadOnly = true;
            this.dgvEventos.RowHeadersWidth = 51;
            this.dgvEventos.RowTemplate.Height = 25;
            this.dgvEventos.Size = new System.Drawing.Size(530, 427);
            this.dgvEventos.TabIndex = 18;
            this.dgvEventos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEventos_CellClick);
            // 
            // cmbTipoEvento
            // 
            this.cmbTipoEvento.FormattingEnabled = true;
            this.cmbTipoEvento.Location = new System.Drawing.Point(188, 76);
            this.cmbTipoEvento.Name = "cmbTipoEvento";
            this.cmbTipoEvento.Size = new System.Drawing.Size(196, 30);
            this.cmbTipoEvento.TabIndex = 19;
            // 
            // dtpfechaInicio
            // 
            this.dtpfechaInicio.Location = new System.Drawing.Point(188, 119);
            this.dtpfechaInicio.Name = "dtpfechaInicio";
            this.dtpfechaInicio.Size = new System.Drawing.Size(200, 30);
            this.dtpfechaInicio.TabIndex = 20;
            // 
            // dtpfechaFin
            // 
            this.dtpfechaFin.Location = new System.Drawing.Point(188, 156);
            this.dtpfechaFin.Name = "dtpfechaFin";
            this.dtpfechaFin.Size = new System.Drawing.Size(200, 30);
            this.dtpfechaFin.TabIndex = 21;
            // 
            // dtpfechaRegistro
            // 
            this.dtpfechaRegistro.Location = new System.Drawing.Point(188, 195);
            this.dtpfechaRegistro.Name = "dtpfechaRegistro";
            this.dtpfechaRegistro.Size = new System.Drawing.Size(200, 30);
            this.dtpfechaRegistro.TabIndex = 22;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnVerArchivo
            // 
            this.btnVerArchivo.Enabled = false;
            this.btnVerArchivo.IconChar = FontAwesome.Sharp.IconChar.File;
            this.btnVerArchivo.IconColor = System.Drawing.Color.Black;
            this.btnVerArchivo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnVerArchivo.IconSize = 30;
            this.btnVerArchivo.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnVerArchivo.Location = new System.Drawing.Point(19, 359);
            this.btnVerArchivo.Name = "btnVerArchivo";
            this.btnVerArchivo.Size = new System.Drawing.Size(365, 44);
            this.btnVerArchivo.TabIndex = 24;
            this.btnVerArchivo.Text = "Ver Archivo";
            this.btnVerArchivo.UseVisualStyleBackColor = true;
            this.btnVerArchivo.Click += new System.EventHandler(this.btnVerArchivo_Click);
            // 
            // iconButton1
            // 
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.FileCirclePlus;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 40;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.iconButton1.Location = new System.Drawing.Point(20, 409);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(365, 44);
            this.iconButton1.TabIndex = 25;
            this.iconButton1.Text = "Agregar Archivo";
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(157, 517);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(4);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(96, 27);
            this.btnModificar.TabIndex = 7;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 465);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 22);
            this.label3.TabIndex = 26;
            this.label3.Text = "Tipo Evento:";
            // 
            // cmbTipoMultimedia
            // 
            this.cmbTipoMultimedia.FormattingEnabled = true;
            this.cmbTipoMultimedia.Location = new System.Drawing.Point(188, 462);
            this.cmbTipoMultimedia.Name = "cmbTipoMultimedia";
            this.cmbTipoMultimedia.Size = new System.Drawing.Size(196, 30);
            this.cmbTipoMultimedia.TabIndex = 27;
            // 
            // frmHistorialEvento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 599);
            this.Controls.Add(this.cmbTipoMultimedia);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.btnVerArchivo);
            this.Controls.Add(this.dtpfechaRegistro);
            this.Controls.Add(this.dtpfechaFin);
            this.Controls.Add(this.dtpfechaInicio);
            this.Controls.Add(this.cmbTipoEvento);
            this.Controls.Add(this.dgvEventos);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmHistorialEvento";
            this.Text = "frmHistorial";
            ((System.ComponentModel.ISupportInitialize)(this.dgvEventos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox txtDescripcion;
        private System.Windows.Forms.DataGridView dgvEventos;
        private System.Windows.Forms.ComboBox cmbTipoEvento;
        private System.Windows.Forms.DateTimePicker dtpfechaInicio;
        private System.Windows.Forms.DateTimePicker dtpfechaFin;
        private System.Windows.Forms.DateTimePicker dtpfechaRegistro;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private FontAwesome.Sharp.IconButton btnVerArchivo;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbTipoMultimedia;
    }
}