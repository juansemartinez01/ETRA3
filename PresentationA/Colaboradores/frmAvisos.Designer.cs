namespace PresentationA.Colaboradores
{
    partial class frmAvisos
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
            this.label2 = new System.Windows.Forms.Label();
            this.btnEliminar = new PresentationA.Controls.BotonPadre();
            this.btnModificar = new PresentationA.Controls.BotonPadre();
            this.btnAgregar = new PresentationA.Controls.BotonPadre();
            this.dtpfechaOcurrencia = new System.Windows.Forms.DateTimePicker();
            this.cmbTipoAviso = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpfechaNotificacion = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLegajos = new System.Windows.Forms.TextBox();
            this.lblCargo = new System.Windows.Forms.Label();
            this.cmbCargo = new System.Windows.Forms.ComboBox();
            this.chkCargo = new System.Windows.Forms.CheckBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.dtpfechaNotifiaciónFiltro = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpfechaCargaFiltro = new System.Windows.Forms.DateTimePicker();
            this.chkFiltroFecha = new System.Windows.Forms.CheckBox();
            this.cmbTipoAvisoFiltro = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnAplicar = new PresentationA.Controls.BotonPadre();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.dtpfechaOcurrenciaFiltro = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.cmbCargoFiltro = new System.Windows.Forms.ComboBox();
            this.cmbColaborador = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvAvisos = new PresentationA.Controls.DataGridPadre();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.legajoColaborador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaOcurrencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaCarga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaNotificacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAvisos)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(27, 25);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 28);
            this.label2.TabIndex = 3;
            this.label2.Text = "Avisos";
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(166)))), ((int)(((byte)(26)))));
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.IconChar = FontAwesome.Sharp.IconChar.XmarkCircle;
            this.btnEliminar.IconColor = System.Drawing.Color.White;
            this.btnEliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEliminar.IconSize = 30;
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar.Location = new System.Drawing.Point(372, 679);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(122, 37);
            this.btnEliminar.TabIndex = 50;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEliminar.UseVisualStyleBackColor = false;
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(166)))), ((int)(((byte)(26)))));
            this.btnModificar.FlatAppearance.BorderSize = 0;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnModificar.ForeColor = System.Drawing.Color.White;
            this.btnModificar.IconChar = FontAwesome.Sharp.IconChar.Pen;
            this.btnModificar.IconColor = System.Drawing.Color.White;
            this.btnModificar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnModificar.IconSize = 30;
            this.btnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificar.Location = new System.Drawing.Point(192, 679);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(122, 37);
            this.btnModificar.TabIndex = 49;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnModificar.UseVisualStyleBackColor = false;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(166)))), ((int)(((byte)(26)))));
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.btnAgregar.IconColor = System.Drawing.Color.White;
            this.btnAgregar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAgregar.IconSize = 30;
            this.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregar.Location = new System.Drawing.Point(19, 679);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(122, 37);
            this.btnAgregar.TabIndex = 48;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // dtpfechaOcurrencia
            // 
            this.dtpfechaOcurrencia.Location = new System.Drawing.Point(672, 111);
            this.dtpfechaOcurrencia.Name = "dtpfechaOcurrencia";
            this.dtpfechaOcurrencia.Size = new System.Drawing.Size(476, 27);
            this.dtpfechaOcurrencia.TabIndex = 56;
            // 
            // cmbTipoAviso
            // 
            this.cmbTipoAviso.FormattingEnabled = true;
            this.cmbTipoAviso.Location = new System.Drawing.Point(672, 63);
            this.cmbTipoAviso.Name = "cmbTipoAviso";
            this.cmbTipoAviso.Size = new System.Drawing.Size(475, 29);
            this.cmbTipoAviso.TabIndex = 55;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(558, 113);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 21);
            this.label6.TabIndex = 52;
            this.label6.Text = "Fecha:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(557, 63);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 21);
            this.label1.TabIndex = 51;
            this.label1.Text = "Tipo Aviso:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 8);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 42);
            this.label3.TabIndex = 57;
            this.label3.Text = "Legajos\r\nColaboradores:";
            // 
            // dtpfechaNotificacion
            // 
            this.dtpfechaNotificacion.Location = new System.Drawing.Point(778, 152);
            this.dtpfechaNotificacion.Name = "dtpfechaNotificacion";
            this.dtpfechaNotificacion.Size = new System.Drawing.Size(369, 27);
            this.dtpfechaNotificacion.TabIndex = 60;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(557, 157);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(186, 21);
            this.label4.TabIndex = 59;
            this.label4.Text = "Fecha de Notificación:";
            // 
            // txtLegajos
            // 
            this.txtLegajos.Location = new System.Drawing.Point(160, 12);
            this.txtLegajos.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtLegajos.Multiline = true;
            this.txtLegajos.Name = "txtLegajos";
            this.txtLegajos.Size = new System.Drawing.Size(336, 81);
            this.txtLegajos.TabIndex = 64;
            this.txtLegajos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLegajos_KeyPress);
            // 
            // lblCargo
            // 
            this.lblCargo.AutoSize = true;
            this.lblCargo.Location = new System.Drawing.Point(557, 12);
            this.lblCargo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Size = new System.Drawing.Size(64, 21);
            this.lblCargo.TabIndex = 65;
            this.lblCargo.Text = "Cargo:";
            // 
            // cmbCargo
            // 
            this.cmbCargo.FormattingEnabled = true;
            this.cmbCargo.Location = new System.Drawing.Point(628, 9);
            this.cmbCargo.Name = "cmbCargo";
            this.cmbCargo.Size = new System.Drawing.Size(302, 29);
            this.cmbCargo.TabIndex = 66;
            // 
            // chkCargo
            // 
            this.chkCargo.AutoSize = true;
            this.chkCargo.Location = new System.Drawing.Point(949, 11);
            this.chkCargo.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.chkCargo.Name = "chkCargo";
            this.chkCargo.Size = new System.Drawing.Size(205, 25);
            this.chkCargo.TabIndex = 67;
            this.chkCargo.Text = "Notificar todo el cargo";
            this.chkCargo.UseVisualStyleBackColor = true;
            this.chkCargo.CheckedChanged += new System.EventHandler(this.chkCargo_CheckedChanged);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(160, 113);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(336, 81);
            this.txtDescripcion.TabIndex = 68;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(4, 139);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(104, 21);
            this.label9.TabIndex = 69;
            this.label9.Text = "Descripcion:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.label8.Location = new System.Drawing.Point(12, 50);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 51);
            this.label8.TabIndex = 70;
            this.label8.Text = "Debe escrbirlos \r\nseparados por\r\nuna coma";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.dtpfechaNotifiaciónFiltro);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.dtpfechaCargaFiltro);
            this.groupBox1.Controls.Add(this.chkFiltroFecha);
            this.groupBox1.Controls.Add(this.cmbTipoAvisoFiltro);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.btnAplicar);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.dtpfechaOcurrenciaFiltro);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.cmbCargoFiltro);
            this.groupBox1.Controls.Add(this.cmbColaborador);
            this.groupBox1.Location = new System.Drawing.Point(4, 57);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1160, 215);
            this.groupBox1.TabIndex = 71;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(415, 112);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(186, 21);
            this.label13.TabIndex = 18;
            this.label13.Text = "Fecha de Notificación:";
            // 
            // dtpfechaNotifiaciónFiltro
            // 
            this.dtpfechaNotifiaciónFiltro.Location = new System.Drawing.Point(623, 110);
            this.dtpfechaNotifiaciónFiltro.Margin = new System.Windows.Forms.Padding(4);
            this.dtpfechaNotifiaciónFiltro.Name = "dtpfechaNotifiaciónFiltro";
            this.dtpfechaNotifiaciónFiltro.Size = new System.Drawing.Size(368, 27);
            this.dtpfechaNotifiaciónFiltro.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(415, 24);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 21);
            this.label5.TabIndex = 16;
            this.label5.Text = "Fecha:";
            // 
            // dtpfechaCargaFiltro
            // 
            this.dtpfechaCargaFiltro.Location = new System.Drawing.Point(623, 61);
            this.dtpfechaCargaFiltro.Margin = new System.Windows.Forms.Padding(4);
            this.dtpfechaCargaFiltro.Name = "dtpfechaCargaFiltro";
            this.dtpfechaCargaFiltro.Size = new System.Drawing.Size(368, 27);
            this.dtpfechaCargaFiltro.TabIndex = 17;
            // 
            // chkFiltroFecha
            // 
            this.chkFiltroFecha.AutoSize = true;
            this.chkFiltroFecha.Location = new System.Drawing.Point(419, 159);
            this.chkFiltroFecha.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.chkFiltroFecha.Name = "chkFiltroFecha";
            this.chkFiltroFecha.Size = new System.Drawing.Size(115, 25);
            this.chkFiltroFecha.TabIndex = 15;
            this.chkFiltroFecha.Text = "Filtro fecha";
            this.chkFiltroFecha.UseVisualStyleBackColor = true;
            // 
            // cmbTipoAvisoFiltro
            // 
            this.cmbTipoAvisoFiltro.FormattingEnabled = true;
            this.cmbTipoAvisoFiltro.Location = new System.Drawing.Point(160, 64);
            this.cmbTipoAvisoFiltro.Margin = new System.Windows.Forms.Padding(4);
            this.cmbTipoAvisoFiltro.Name = "cmbTipoAvisoFiltro";
            this.cmbTipoAvisoFiltro.Size = new System.Drawing.Size(189, 29);
            this.cmbTipoAvisoFiltro.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(32, 72);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 21);
            this.label7.TabIndex = 12;
            this.label7.Text = "Tipo Aviso:";
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
            this.btnAplicar.Location = new System.Drawing.Point(841, 159);
            this.btnAplicar.Name = "btnAplicar";
            this.btnAplicar.Size = new System.Drawing.Size(150, 40);
            this.btnAplicar.TabIndex = 11;
            this.btnAplicar.Text = "Aplicar";
            this.btnAplicar.UseVisualStyleBackColor = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(32, 116);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 21);
            this.label10.TabIndex = 2;
            this.label10.Text = "Cargo:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(415, 67);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(143, 21);
            this.label11.TabIndex = 4;
            this.label11.Text = "Fecha de Carga:";
            // 
            // dtpfechaOcurrenciaFiltro
            // 
            this.dtpfechaOcurrenciaFiltro.Location = new System.Drawing.Point(623, 21);
            this.dtpfechaOcurrenciaFiltro.Margin = new System.Windows.Forms.Padding(4);
            this.dtpfechaOcurrenciaFiltro.Name = "dtpfechaOcurrenciaFiltro";
            this.dtpfechaOcurrenciaFiltro.Size = new System.Drawing.Size(368, 27);
            this.dtpfechaOcurrenciaFiltro.TabIndex = 9;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(32, 21);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(126, 21);
            this.label12.TabIndex = 6;
            this.label12.Text = "Colaboradores";
            // 
            // cmbCargoFiltro
            // 
            this.cmbCargoFiltro.FormattingEnabled = true;
            this.cmbCargoFiltro.Location = new System.Drawing.Point(160, 113);
            this.cmbCargoFiltro.Margin = new System.Windows.Forms.Padding(4);
            this.cmbCargoFiltro.Name = "cmbCargoFiltro";
            this.cmbCargoFiltro.Size = new System.Drawing.Size(189, 29);
            this.cmbCargoFiltro.TabIndex = 8;
            // 
            // cmbColaborador
            // 
            this.cmbColaborador.FormattingEnabled = true;
            this.cmbColaborador.Location = new System.Drawing.Point(160, 18);
            this.cmbColaborador.Margin = new System.Windows.Forms.Padding(4);
            this.cmbColaborador.Name = "cmbColaborador";
            this.cmbColaborador.Size = new System.Drawing.Size(189, 29);
            this.cmbColaborador.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.txtLegajos);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.cmbTipoAviso);
            this.panel1.Controls.Add(this.txtDescripcion);
            this.panel1.Controls.Add(this.dtpfechaOcurrencia);
            this.panel1.Controls.Add(this.chkCargo);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cmbCargo);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.lblCargo);
            this.panel1.Controls.Add(this.dtpfechaNotificacion);
            this.panel1.Location = new System.Drawing.Point(4, 468);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1162, 205);
            this.panel1.TabIndex = 72;
            // 
            // dgvAvisos
            // 
            this.dgvAvisos.AllowUserToAddRows = false;
            this.dgvAvisos.AllowUserToDeleteRows = false;
            this.dgvAvisos.AllowUserToOrderColumns = true;
            this.dgvAvisos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAvisos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAvisos.BackgroundColor = System.Drawing.Color.White;
            this.dgvAvisos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvAvisos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(103)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(103)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAvisos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAvisos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAvisos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombre,
            this.legajoColaborador,
            this.fechaOcurrencia,
            this.descripcion,
            this.fechaCarga,
            this.fechaNotificacion});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(43)))), ((int)(((byte)(26)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAvisos.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAvisos.EnableHeadersVisualStyles = false;
            this.dgvAvisos.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.dgvAvisos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(103)))), ((int)(((byte)(34)))));
            this.dgvAvisos.Location = new System.Drawing.Point(4, 279);
            this.dgvAvisos.Name = "dgvAvisos";
            this.dgvAvisos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(103)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(43)))), ((int)(((byte)(26)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAvisos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvAvisos.RowHeadersWidth = 51;
            this.dgvAvisos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAvisos.Size = new System.Drawing.Size(1160, 183);
            this.dgvAvisos.TabIndex = 73;
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Tipo de Aviso";
            this.nombre.MinimumWidth = 6;
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            // 
            // legajoColaborador
            // 
            this.legajoColaborador.HeaderText = "Legajo";
            this.legajoColaborador.MinimumWidth = 6;
            this.legajoColaborador.Name = "legajoColaborador";
            this.legajoColaborador.ReadOnly = true;
            // 
            // fechaOcurrencia
            // 
            this.fechaOcurrencia.HeaderText = "Fecha";
            this.fechaOcurrencia.MinimumWidth = 6;
            this.fechaOcurrencia.Name = "fechaOcurrencia";
            this.fechaOcurrencia.ReadOnly = true;
            // 
            // descripcion
            // 
            this.descripcion.HeaderText = "Descripción";
            this.descripcion.Name = "descripcion";
            // 
            // fechaCarga
            // 
            this.fechaCarga.HeaderText = "Fecha de Carga";
            this.fechaCarga.Name = "fechaCarga";
            // 
            // fechaNotificacion
            // 
            this.fechaNotificacion.HeaderText = "Fecha de Notificación";
            this.fechaNotificacion.Name = "fechaNotificacion";
            // 
            // frmAvisos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 737);
            this.Controls.Add(this.dgvAvisos);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmAvisos";
            this.Text = "frmNotificaciones";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAvisos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private Controls.BotonPadre btnEliminar;
        private Controls.BotonPadre btnModificar;
        private Controls.BotonPadre btnAgregar;
        private System.Windows.Forms.DateTimePicker dtpfechaOcurrencia;
        private System.Windows.Forms.ComboBox cmbTipoAviso;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpfechaNotificacion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtLegajos;
        private System.Windows.Forms.Label lblCargo;
        private System.Windows.Forms.ComboBox cmbCargo;
        private System.Windows.Forms.CheckBox chkCargo;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkFiltroFecha;
        private System.Windows.Forms.ComboBox cmbTipoAvisoFiltro;
        private System.Windows.Forms.Label label7;
        private Controls.BotonPadre btnAplicar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dtpfechaOcurrenciaFiltro;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cmbCargoFiltro;
        private System.Windows.Forms.ComboBox cmbColaborador;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker dtpfechaNotifiaciónFiltro;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpfechaCargaFiltro;
        private Controls.DataGridPadre dgvAvisos;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn legajoColaborador;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaOcurrencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaCarga;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaNotificacion;
    }
}