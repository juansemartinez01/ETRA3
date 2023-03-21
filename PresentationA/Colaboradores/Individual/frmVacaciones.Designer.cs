namespace PresentationA.Colaboradores.Consulta
{
    partial class frmVacaciones
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
            this.dgvBusqueda = new System.Windows.Forms.DataGridView();
            this.nroSolicitud = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaSolicitud = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.desde = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hasta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantDias = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.diasDisponibles = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtpfechaRegistro = new System.Windows.Forms.DateTimePicker();
            this.cmbTipoEvento = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAgregar = new PresentationA.Controls.BotonPadre();
            this.botonPadre1 = new PresentationA.Controls.BotonPadre();
            this.botonPadre2 = new PresentationA.Controls.BotonPadre();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBusqueda)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBusqueda
            // 
            this.dgvBusqueda.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvBusqueda.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBusqueda.BackgroundColor = System.Drawing.Color.White;
            this.dgvBusqueda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBusqueda.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nroSolicitud,
            this.fechaSolicitud,
            this.desde,
            this.hasta,
            this.cantDias,
            this.estado,
            this.diasDisponibles});
            this.dgvBusqueda.Location = new System.Drawing.Point(515, 81);
            this.dgvBusqueda.Margin = new System.Windows.Forms.Padding(4);
            this.dgvBusqueda.Name = "dgvBusqueda";
            this.dgvBusqueda.ReadOnly = true;
            this.dgvBusqueda.RowHeadersWidth = 51;
            this.dgvBusqueda.RowTemplate.Height = 25;
            this.dgvBusqueda.Size = new System.Drawing.Size(687, 465);
            this.dgvBusqueda.TabIndex = 20;
            // 
            // nroSolicitud
            // 
            this.nroSolicitud.HeaderText = "Nº Solicitud";
            this.nroSolicitud.Name = "nroSolicitud";
            this.nroSolicitud.ReadOnly = true;
            // 
            // fechaSolicitud
            // 
            this.fechaSolicitud.HeaderText = "Fecha de Solicitud";
            this.fechaSolicitud.Name = "fechaSolicitud";
            this.fechaSolicitud.ReadOnly = true;
            // 
            // desde
            // 
            this.desde.HeaderText = "Desde";
            this.desde.Name = "desde";
            this.desde.ReadOnly = true;
            // 
            // hasta
            // 
            this.hasta.HeaderText = "Hasta";
            this.hasta.Name = "hasta";
            this.hasta.ReadOnly = true;
            // 
            // cantDias
            // 
            this.cantDias.HeaderText = "Cantidad de Días";
            this.cantDias.Name = "cantDias";
            this.cantDias.ReadOnly = true;
            // 
            // estado
            // 
            this.estado.HeaderText = "Estado";
            this.estado.Name = "estado";
            this.estado.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(13, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 28);
            this.label1.TabIndex = 21;
            this.label1.Text = "Vacaciones";
            // 
            // diasDisponibles
            // 
            this.diasDisponibles.HeaderText = "Dias Restantes Disponibles";
            this.diasDisponibles.Name = "diasDisponibles";
            this.diasDisponibles.ReadOnly = true;
            // 
            // dtpfechaRegistro
            // 
            this.dtpfechaRegistro.Location = new System.Drawing.Point(188, 137);
            this.dtpfechaRegistro.Name = "dtpfechaRegistro";
            this.dtpfechaRegistro.Size = new System.Drawing.Size(306, 27);
            this.dtpfechaRegistro.TabIndex = 34;
            // 
            // cmbTipoEvento
            // 
            this.cmbTipoEvento.FormattingEnabled = true;
            this.cmbTipoEvento.Location = new System.Drawing.Point(188, 81);
            this.cmbTipoEvento.Name = "cmbTipoEvento";
            this.cmbTipoEvento.Size = new System.Drawing.Size(306, 29);
            this.cmbTipoEvento.TabIndex = 33;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 137);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 21);
            this.label4.TabIndex = 32;
            this.label4.Text = "Fecha de Solicitud";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 84);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 21);
            this.label2.TabIndex = 31;
            this.label2.Text = "Estado:";
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(166)))), ((int)(((byte)(26)))));
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnAgregar.IconColor = System.Drawing.Color.Black;
            this.btnAgregar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregar.Location = new System.Drawing.Point(19, 204);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(185, 34);
            this.btnAgregar.TabIndex = 45;
            this.btnAgregar.Text = "Agregar Solicitud";
            this.btnAgregar.UseVisualStyleBackColor = false;
            // 
            // botonPadre1
            // 
            this.botonPadre1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(166)))), ((int)(((byte)(26)))));
            this.botonPadre1.FlatAppearance.BorderSize = 0;
            this.botonPadre1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonPadre1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.botonPadre1.ForeColor = System.Drawing.Color.White;
            this.botonPadre1.IconChar = FontAwesome.Sharp.IconChar.None;
            this.botonPadre1.IconColor = System.Drawing.Color.Black;
            this.botonPadre1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.botonPadre1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.botonPadre1.Location = new System.Drawing.Point(19, 265);
            this.botonPadre1.Name = "botonPadre1";
            this.botonPadre1.Size = new System.Drawing.Size(185, 34);
            this.botonPadre1.TabIndex = 46;
            this.botonPadre1.Text = "Modificar Solicitud";
            this.botonPadre1.UseVisualStyleBackColor = false;
            // 
            // botonPadre2
            // 
            this.botonPadre2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(166)))), ((int)(((byte)(26)))));
            this.botonPadre2.FlatAppearance.BorderSize = 0;
            this.botonPadre2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonPadre2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.botonPadre2.ForeColor = System.Drawing.Color.White;
            this.botonPadre2.IconChar = FontAwesome.Sharp.IconChar.None;
            this.botonPadre2.IconColor = System.Drawing.Color.Black;
            this.botonPadre2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.botonPadre2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.botonPadre2.Location = new System.Drawing.Point(17, 328);
            this.botonPadre2.Name = "botonPadre2";
            this.botonPadre2.Size = new System.Drawing.Size(185, 34);
            this.botonPadre2.TabIndex = 47;
            this.botonPadre2.Text = "Cancelar Solicitud";
            this.botonPadre2.UseVisualStyleBackColor = false;
            // 
            // frmVacaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1226, 601);
            this.Controls.Add(this.botonPadre2);
            this.Controls.Add(this.botonPadre1);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dtpfechaRegistro);
            this.Controls.Add(this.cmbTipoEvento);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvBusqueda);
            this.Name = "frmVacaciones";
            this.Text = "frmVacaciones";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBusqueda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBusqueda;
        private System.Windows.Forms.DataGridViewTextBoxColumn nroSolicitud;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaSolicitud;
        private System.Windows.Forms.DataGridViewTextBoxColumn desde;
        private System.Windows.Forms.DataGridViewTextBoxColumn hasta;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantDias;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn diasDisponibles;
        private System.Windows.Forms.DateTimePicker dtpfechaRegistro;
        private System.Windows.Forms.ComboBox cmbTipoEvento;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private Controls.BotonPadre btnAgregar;
        private Controls.BotonPadre botonPadre1;
        private Controls.BotonPadre botonPadre2;
    }
}