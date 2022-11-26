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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEliminar = new PresentationA.Controls.BotonPadre();
            this.btnAgregar = new PresentationA.Controls.BotonPadre();
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
            this.btnNotificar = new PresentationA.Controls.BotonPadre();
            this.dgvAvisos = new PresentationA.Controls.DataGridPadre();
            this.id_aviso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.legajoColaborador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaOcurrencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaCarga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaNotificacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaUltimaNotificacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnLimpiar = new PresentationA.Controls.BotonPadre();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAvisos)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(33, 28);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 37);
            this.label2.TabIndex = 3;
            this.label2.Text = "Avisos";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
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
            this.btnEliminar.Location = new System.Drawing.Point(363, 567);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(141, 44);
            this.btnEliminar.TabIndex = 50;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
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
            this.btnAgregar.Location = new System.Drawing.Point(13, 567);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(141, 44);
            this.btnAgregar.TabIndex = 48;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnLimpiar);
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
            this.groupBox1.Location = new System.Drawing.Point(5, 62);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.groupBox1.Size = new System.Drawing.Size(1201, 235);
            this.groupBox1.TabIndex = 71;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(498, 123);
            this.label13.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(231, 23);
            this.label13.TabIndex = 18;
            this.label13.Text = "Fecha de Notificación:";
            // 
            // dtpfechaNotifiaciónFiltro
            // 
            this.dtpfechaNotifiaciónFiltro.Location = new System.Drawing.Point(747, 120);
            this.dtpfechaNotifiaciónFiltro.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.dtpfechaNotifiaciónFiltro.Name = "dtpfechaNotifiaciónFiltro";
            this.dtpfechaNotifiaciónFiltro.Size = new System.Drawing.Size(441, 32);
            this.dtpfechaNotifiaciónFiltro.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(498, 26);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 23);
            this.label5.TabIndex = 16;
            this.label5.Text = "Fecha:";
            // 
            // dtpfechaCargaFiltro
            // 
            this.dtpfechaCargaFiltro.Location = new System.Drawing.Point(747, 67);
            this.dtpfechaCargaFiltro.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.dtpfechaCargaFiltro.Name = "dtpfechaCargaFiltro";
            this.dtpfechaCargaFiltro.Size = new System.Drawing.Size(441, 32);
            this.dtpfechaCargaFiltro.TabIndex = 17;
            // 
            // chkFiltroFecha
            // 
            this.chkFiltroFecha.AutoSize = true;
            this.chkFiltroFecha.Location = new System.Drawing.Point(503, 174);
            this.chkFiltroFecha.Name = "chkFiltroFecha";
            this.chkFiltroFecha.Size = new System.Drawing.Size(140, 27);
            this.chkFiltroFecha.TabIndex = 15;
            this.chkFiltroFecha.Text = "Filtro fecha";
            this.chkFiltroFecha.UseVisualStyleBackColor = true;
            this.chkFiltroFecha.CheckedChanged += new System.EventHandler(this.chkFiltroFecha_CheckedChanged);
            // 
            // cmbTipoAvisoFiltro
            // 
            this.cmbTipoAvisoFiltro.FormattingEnabled = true;
            this.cmbTipoAvisoFiltro.Location = new System.Drawing.Point(192, 70);
            this.cmbTipoAvisoFiltro.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.cmbTipoAvisoFiltro.Name = "cmbTipoAvisoFiltro";
            this.cmbTipoAvisoFiltro.Size = new System.Drawing.Size(226, 31);
            this.cmbTipoAvisoFiltro.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(39, 79);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 23);
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
            this.btnAplicar.Location = new System.Drawing.Point(747, 174);
            this.btnAplicar.Name = "btnAplicar";
            this.btnAplicar.Size = new System.Drawing.Size(180, 44);
            this.btnAplicar.TabIndex = 11;
            this.btnAplicar.Text = "Aplicar";
            this.btnAplicar.UseVisualStyleBackColor = false;
            this.btnAplicar.Click += new System.EventHandler(this.btnAplicar_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(39, 127);
            this.label10.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 23);
            this.label10.TabIndex = 2;
            this.label10.Text = "Cargo:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(498, 74);
            this.label11.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(179, 23);
            this.label11.TabIndex = 4;
            this.label11.Text = "Fecha de Carga:";
            // 
            // dtpfechaOcurrenciaFiltro
            // 
            this.dtpfechaOcurrenciaFiltro.Location = new System.Drawing.Point(747, 23);
            this.dtpfechaOcurrenciaFiltro.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.dtpfechaOcurrenciaFiltro.Name = "dtpfechaOcurrenciaFiltro";
            this.dtpfechaOcurrenciaFiltro.Size = new System.Drawing.Size(441, 32);
            this.dtpfechaOcurrenciaFiltro.TabIndex = 9;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(39, 23);
            this.label12.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(159, 23);
            this.label12.TabIndex = 6;
            this.label12.Text = "Colaboradores";
            // 
            // cmbCargoFiltro
            // 
            this.cmbCargoFiltro.FormattingEnabled = true;
            this.cmbCargoFiltro.Location = new System.Drawing.Point(192, 123);
            this.cmbCargoFiltro.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.cmbCargoFiltro.Name = "cmbCargoFiltro";
            this.cmbCargoFiltro.Size = new System.Drawing.Size(226, 31);
            this.cmbCargoFiltro.TabIndex = 8;
            // 
            // cmbColaborador
            // 
            this.cmbColaborador.FormattingEnabled = true;
            this.cmbColaborador.Location = new System.Drawing.Point(192, 20);
            this.cmbColaborador.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.cmbColaborador.Name = "cmbColaborador";
            this.cmbColaborador.Size = new System.Drawing.Size(226, 31);
            this.cmbColaborador.TabIndex = 7;
            // 
            // btnNotificar
            // 
            this.btnNotificar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnNotificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(166)))), ((int)(((byte)(26)))));
            this.btnNotificar.FlatAppearance.BorderSize = 0;
            this.btnNotificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNotificar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnNotificar.ForeColor = System.Drawing.Color.White;
            this.btnNotificar.IconChar = FontAwesome.Sharp.IconChar.Bell;
            this.btnNotificar.IconColor = System.Drawing.Color.White;
            this.btnNotificar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnNotificar.IconSize = 30;
            this.btnNotificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNotificar.Location = new System.Drawing.Point(191, 567);
            this.btnNotificar.Name = "btnNotificar";
            this.btnNotificar.Size = new System.Drawing.Size(141, 44);
            this.btnNotificar.TabIndex = 74;
            this.btnNotificar.Text = "Notificar";
            this.btnNotificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNotificar.UseVisualStyleBackColor = false;
            this.btnNotificar.Click += new System.EventHandler(this.btnNotificar_Click);
            // 
            // dgvAvisos
            // 
            this.dgvAvisos.AllowUserToAddRows = false;
            this.dgvAvisos.AllowUserToDeleteRows = false;
            this.dgvAvisos.AllowUserToOrderColumns = true;
            this.dgvAvisos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAvisos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAvisos.BackgroundColor = System.Drawing.Color.White;
            this.dgvAvisos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvAvisos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(103)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(103)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAvisos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvAvisos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAvisos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_aviso,
            this.nombre,
            this.legajoColaborador,
            this.fechaOcurrencia,
            this.descripcion,
            this.fechaCarga,
            this.fechaNotificacion,
            this.fechaUltimaNotificacion});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 12F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(43)))), ((int)(((byte)(26)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAvisos.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvAvisos.EnableHeadersVisualStyles = false;
            this.dgvAvisos.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.dgvAvisos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(103)))), ((int)(((byte)(34)))));
            this.dgvAvisos.Location = new System.Drawing.Point(3, 306);
            this.dgvAvisos.Name = "dgvAvisos";
            this.dgvAvisos.ReadOnly = true;
            this.dgvAvisos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(103)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 12F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(43)))), ((int)(((byte)(26)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAvisos.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvAvisos.RowHeadersWidth = 51;
            this.dgvAvisos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAvisos.Size = new System.Drawing.Size(1203, 255);
            this.dgvAvisos.TabIndex = 73;
            this.dgvAvisos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAvisos_CellContentClick);
            this.dgvAvisos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAvisos_CellContentClick);
            this.dgvAvisos.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAvisos_CellContentClick);
            this.dgvAvisos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAvisos_CellContentClick);
            // 
            // id_aviso
            // 
            this.id_aviso.HeaderText = "id_aviso";
            this.id_aviso.MinimumWidth = 8;
            this.id_aviso.Name = "id_aviso";
            this.id_aviso.ReadOnly = true;
            this.id_aviso.Visible = false;
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
            this.descripcion.MinimumWidth = 6;
            this.descripcion.Name = "descripcion";
            this.descripcion.ReadOnly = true;
            // 
            // fechaCarga
            // 
            this.fechaCarga.HeaderText = "Fecha de Carga";
            this.fechaCarga.MinimumWidth = 6;
            this.fechaCarga.Name = "fechaCarga";
            this.fechaCarga.ReadOnly = true;
            // 
            // fechaNotificacion
            // 
            this.fechaNotificacion.HeaderText = "Fecha de Notificación";
            this.fechaNotificacion.MinimumWidth = 6;
            this.fechaNotificacion.Name = "fechaNotificacion";
            this.fechaNotificacion.ReadOnly = true;
            // 
            // fechaUltimaNotificacion
            // 
            this.fechaUltimaNotificacion.HeaderText = "Ultima Notificación";
            this.fechaUltimaNotificacion.MinimumWidth = 8;
            this.fechaUltimaNotificacion.Name = "fechaUltimaNotificacion";
            this.fechaUltimaNotificacion.ReadOnly = true;
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
            this.btnLimpiar.Location = new System.Drawing.Point(971, 174);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(180, 44);
            this.btnLimpiar.TabIndex = 20;
            this.btnLimpiar.Text = "Limpiar Filtro";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // frmAvisos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1230, 649);
            this.Controls.Add(this.btnNotificar);
            this.Controls.Add(this.dgvAvisos);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAgregar);
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "frmAvisos";
            this.Text = "frmNotificaciones";
            this.Load += new System.EventHandler(this.frmAvisos_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAvisos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private Controls.BotonPadre btnEliminar;
        private Controls.BotonPadre btnAgregar;
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
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker dtpfechaNotifiaciónFiltro;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpfechaCargaFiltro;
        private Controls.DataGridPadre dgvAvisos;
        private Controls.BotonPadre btnNotificar;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_aviso;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn legajoColaborador;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaOcurrencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaCarga;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaNotificacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaUltimaNotificacion;
        private Controls.BotonPadre btnLimpiar;
    }
}