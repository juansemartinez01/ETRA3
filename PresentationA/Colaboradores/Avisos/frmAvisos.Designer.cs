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
            this.btnAgregar = new PresentationA.Controls.BotonPadre();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnLimpiar = new PresentationA.Controls.BotonPadre();
            this.label13 = new System.Windows.Forms.Label();
            this.dtpfechaNotifiaciónFiltro = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpfechaCargaFiltro = new System.Windows.Forms.DateTimePicker();
            this.chkFiltroFecha = new System.Windows.Forms.CheckBox();
            this.cmbTipoAvisoFiltro = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnAplicar = new PresentationA.Controls.BotonPadre();
            this.label11 = new System.Windows.Forms.Label();
            this.dtpfechaOcurrenciaFiltro = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
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
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAvisos)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(28, 26);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 28);
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
            this.btnEliminar.Location = new System.Drawing.Point(302, 518);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(118, 40);
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
            this.btnAgregar.Location = new System.Drawing.Point(11, 518);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(118, 40);
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
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.dtpfechaOcurrenciaFiltro);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.cmbColaborador);
            this.groupBox1.Location = new System.Drawing.Point(4, 57);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(1001, 215);
            this.groupBox1.TabIndex = 71;
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
            this.btnLimpiar.Location = new System.Drawing.Point(809, 159);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(150, 40);
            this.btnLimpiar.TabIndex = 20;
            this.btnLimpiar.Text = "Limpiar Filtro";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
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
            this.dtpfechaNotifiaciónFiltro.Location = new System.Drawing.Point(622, 110);
            this.dtpfechaNotifiaciónFiltro.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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
            this.dtpfechaCargaFiltro.Location = new System.Drawing.Point(622, 61);
            this.dtpfechaCargaFiltro.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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
            this.chkFiltroFecha.CheckedChanged += new System.EventHandler(this.chkFiltroFecha_CheckedChanged);
            // 
            // cmbTipoAvisoFiltro
            // 
            this.cmbTipoAvisoFiltro.FormattingEnabled = true;
            this.cmbTipoAvisoFiltro.Location = new System.Drawing.Point(160, 64);
            this.cmbTipoAvisoFiltro.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbTipoAvisoFiltro.Name = "cmbTipoAvisoFiltro";
            this.cmbTipoAvisoFiltro.Size = new System.Drawing.Size(189, 29);
            this.cmbTipoAvisoFiltro.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 68);
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
            this.btnAplicar.Location = new System.Drawing.Point(622, 159);
            this.btnAplicar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnAplicar.Name = "btnAplicar";
            this.btnAplicar.Size = new System.Drawing.Size(150, 40);
            this.btnAplicar.TabIndex = 11;
            this.btnAplicar.Text = "Aplicar";
            this.btnAplicar.UseVisualStyleBackColor = false;
            this.btnAplicar.Click += new System.EventHandler(this.btnAplicar_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(415, 68);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(143, 21);
            this.label11.TabIndex = 4;
            this.label11.Text = "Fecha de Carga:";
            // 
            // dtpfechaOcurrenciaFiltro
            // 
            this.dtpfechaOcurrenciaFiltro.Location = new System.Drawing.Point(622, 21);
            this.dtpfechaOcurrenciaFiltro.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpfechaOcurrenciaFiltro.Name = "dtpfechaOcurrenciaFiltro";
            this.dtpfechaOcurrenciaFiltro.Size = new System.Drawing.Size(368, 27);
            this.dtpfechaOcurrenciaFiltro.TabIndex = 9;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(8, 24);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(130, 21);
            this.label12.TabIndex = 6;
            this.label12.Text = "Colaboradores:";
            // 
            // cmbColaborador
            // 
            this.cmbColaborador.FormattingEnabled = true;
            this.cmbColaborador.Location = new System.Drawing.Point(160, 18);
            this.cmbColaborador.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbColaborador.Name = "cmbColaborador";
            this.cmbColaborador.Size = new System.Drawing.Size(189, 29);
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
            this.btnNotificar.Location = new System.Drawing.Point(159, 518);
            this.btnNotificar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnNotificar.Name = "btnNotificar";
            this.btnNotificar.Size = new System.Drawing.Size(118, 40);
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
            this.dgvAvisos.AllowUserToResizeRows = false;
            this.dgvAvisos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
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
            this.id_aviso,
            this.nombre,
            this.legajoColaborador,
            this.fechaOcurrencia,
            this.descripcion,
            this.fechaCarga,
            this.fechaNotificacion,
            this.fechaUltimaNotificacion});
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
            this.dgvAvisos.Location = new System.Drawing.Point(2, 279);
            this.dgvAvisos.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dgvAvisos.Name = "dgvAvisos";
            this.dgvAvisos.ReadOnly = true;
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
            this.dgvAvisos.Size = new System.Drawing.Size(1002, 233);
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
            // frmAvisos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 593);
            this.Controls.Add(this.btnNotificar);
            this.Controls.Add(this.dgvAvisos);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAgregar);
            this.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
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
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dtpfechaOcurrenciaFiltro;
        private System.Windows.Forms.Label label12;
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