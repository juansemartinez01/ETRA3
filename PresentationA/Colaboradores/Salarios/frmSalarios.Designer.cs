namespace PresentationA.Colaboradores
{
    partial class frmSalarios
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnLimpiar = new PresentationA.Controls.BotonPadre();
            this.cmbFiltroCargo = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.btnExportar = new PresentationA.Controls.BotonPadre();
            this.btnAplicar = new PresentationA.Controls.BotonPadre();
            this.txtApellidoBusqueda = new System.Windows.Forms.TextBox();
            this.txtNombreBusqueda = new System.Windows.Forms.TextBox();
            this.txtMontoBusqueda = new System.Windows.Forms.TextBox();
            this.txtLegajoBusqueda = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblLegajo = new System.Windows.Forms.Label();
            this.botonPadre3 = new PresentationA.Controls.BotonPadre();
            this.btnModificar = new PresentationA.Controls.BotonPadre();
            this.txtMontoModificacion = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dgvSalarios = new PresentationA.Controls.DataGridPadre();
            this.legajo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnGenerarOrdenes = new PresentationA.Controls.BotonPadre();
            this.txtDescripcionComprobante = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.pntOrden = new System.Drawing.Printing.PrintDocument();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalarios)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnLimpiar);
            this.groupBox1.Controls.Add(this.cmbFiltroCargo);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.btnExportar);
            this.groupBox1.Controls.Add(this.btnAplicar);
            this.groupBox1.Controls.Add(this.txtApellidoBusqueda);
            this.groupBox1.Controls.Add(this.txtNombreBusqueda);
            this.groupBox1.Controls.Add(this.txtMontoBusqueda);
            this.groupBox1.Controls.Add(this.txtLegajoBusqueda);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 44);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox1.Size = new System.Drawing.Size(1119, 163);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
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
            this.btnLimpiar.Location = new System.Drawing.Point(724, 63);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(178, 37);
            this.btnLimpiar.TabIndex = 25;
            this.btnLimpiar.Text = "Limpiar Filtro";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // cmbFiltroCargo
            // 
            this.cmbFiltroCargo.FormattingEnabled = true;
            this.cmbFiltroCargo.Location = new System.Drawing.Point(455, 116);
            this.cmbFiltroCargo.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cmbFiltroCargo.Name = "cmbFiltroCargo";
            this.cmbFiltroCargo.Size = new System.Drawing.Size(239, 29);
            this.cmbFiltroCargo.TabIndex = 24;
            this.cmbFiltroCargo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbFiltroCargo_KeyPress);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(360, 119);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(60, 21);
            this.label14.TabIndex = 24;
            this.label14.Text = "Cargo";
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
            this.btnExportar.Location = new System.Drawing.Point(724, 111);
            this.btnExportar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(178, 37);
            this.btnExportar.TabIndex = 11;
            this.btnExportar.Text = "Exportar a Excel";
            this.btnExportar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExportar.UseVisualStyleBackColor = false;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
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
            this.btnAplicar.Location = new System.Drawing.Point(726, 16);
            this.btnAplicar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnAplicar.Name = "btnAplicar";
            this.btnAplicar.Size = new System.Drawing.Size(178, 37);
            this.btnAplicar.TabIndex = 10;
            this.btnAplicar.Text = "Aplicar";
            this.btnAplicar.UseVisualStyleBackColor = false;
            this.btnAplicar.Click += new System.EventHandler(this.btnAplicar_Click);
            // 
            // txtApellidoBusqueda
            // 
            this.txtApellidoBusqueda.Location = new System.Drawing.Point(455, 68);
            this.txtApellidoBusqueda.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtApellidoBusqueda.Name = "txtApellidoBusqueda";
            this.txtApellidoBusqueda.Size = new System.Drawing.Size(239, 27);
            this.txtApellidoBusqueda.TabIndex = 7;
            // 
            // txtNombreBusqueda
            // 
            this.txtNombreBusqueda.Location = new System.Drawing.Point(455, 20);
            this.txtNombreBusqueda.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtNombreBusqueda.Name = "txtNombreBusqueda";
            this.txtNombreBusqueda.Size = new System.Drawing.Size(239, 27);
            this.txtNombreBusqueda.TabIndex = 6;
            // 
            // txtMontoBusqueda
            // 
            this.txtMontoBusqueda.Location = new System.Drawing.Point(100, 68);
            this.txtMontoBusqueda.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtMontoBusqueda.Name = "txtMontoBusqueda";
            this.txtMontoBusqueda.Size = new System.Drawing.Size(239, 27);
            this.txtMontoBusqueda.TabIndex = 5;
            this.txtMontoBusqueda.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMontoBusqueda_KeyPress);
            // 
            // txtLegajoBusqueda
            // 
            this.txtLegajoBusqueda.Location = new System.Drawing.Point(100, 20);
            this.txtLegajoBusqueda.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtLegajoBusqueda.Name = "txtLegajoBusqueda";
            this.txtLegajoBusqueda.Size = new System.Drawing.Size(239, 27);
            this.txtLegajoBusqueda.TabIndex = 4;
            this.txtLegajoBusqueda.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLegajoBusqueda_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 70);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 21);
            this.label5.TabIndex = 3;
            this.label5.Text = "Monto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(360, 70);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 21);
            this.label4.TabIndex = 2;
            this.label4.Text = "Apellido";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(360, 23);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 21);
            this.label3.TabIndex = 1;
            this.label3.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 23);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Legajo";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblLegajo);
            this.groupBox2.Controls.Add(this.botonPadre3);
            this.groupBox2.Controls.Add(this.btnModificar);
            this.groupBox2.Controls.Add(this.txtMontoModificacion);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Location = new System.Drawing.Point(12, 478);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox2.Size = new System.Drawing.Size(522, 203);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Modificar";
            // 
            // lblLegajo
            // 
            this.lblLegajo.AutoSize = true;
            this.lblLegajo.Location = new System.Drawing.Point(96, 48);
            this.lblLegajo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLegajo.Name = "lblLegajo";
            this.lblLegajo.Size = new System.Drawing.Size(58, 21);
            this.lblLegajo.TabIndex = 52;
            this.lblLegajo.Text = "legajo";
            // 
            // botonPadre3
            // 
            this.botonPadre3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(166)))), ((int)(((byte)(26)))));
            this.botonPadre3.FlatAppearance.BorderSize = 0;
            this.botonPadre3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonPadre3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.botonPadre3.ForeColor = System.Drawing.Color.White;
            this.botonPadre3.IconChar = FontAwesome.Sharp.IconChar.Pen;
            this.botonPadre3.IconColor = System.Drawing.Color.White;
            this.botonPadre3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.botonPadre3.IconSize = 30;
            this.botonPadre3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.botonPadre3.Location = new System.Drawing.Point(26, 148);
            this.botonPadre3.Margin = new System.Windows.Forms.Padding(0);
            this.botonPadre3.Name = "botonPadre3";
            this.botonPadre3.Size = new System.Drawing.Size(215, 37);
            this.botonPadre3.TabIndex = 51;
            this.botonPadre3.Text = "Modificar por Cargo";
            this.botonPadre3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.botonPadre3.UseVisualStyleBackColor = false;
            this.botonPadre3.Click += new System.EventHandler(this.botonPadre3_Click);
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
            this.btnModificar.Location = new System.Drawing.Point(26, 95);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(0);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(128, 37);
            this.btnModificar.TabIndex = 50;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // txtMontoModificacion
            // 
            this.txtMontoModificacion.Location = new System.Drawing.Point(318, 45);
            this.txtMontoModificacion.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtMontoModificacion.Name = "txtMontoModificacion";
            this.txtMontoModificacion.Size = new System.Drawing.Size(116, 27);
            this.txtMontoModificacion.TabIndex = 7;
            this.txtMontoModificacion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMontoModificacion_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(240, 45);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 21);
            this.label7.TabIndex = 5;
            this.label7.Text = "Monto";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(22, 45);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 21);
            this.label10.TabIndex = 4;
            this.label10.Text = "Legajo: ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(495, 14);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(124, 28);
            this.label8.TabIndex = 5;
            this.label8.Text = "SALARIOS";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dgvSalarios
            // 
            this.dgvSalarios.AllowUserToAddRows = false;
            this.dgvSalarios.AllowUserToDeleteRows = false;
            this.dgvSalarios.AllowUserToOrderColumns = true;
            this.dgvSalarios.AllowUserToResizeRows = false;
            this.dgvSalarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSalarios.BackgroundColor = System.Drawing.Color.White;
            this.dgvSalarios.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvSalarios.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(103)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(103)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSalarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSalarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSalarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.legajo,
            this.nombre,
            this.apellido,
            this.monto,
            this.fechaInicio});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(43)))), ((int)(((byte)(26)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSalarios.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSalarios.EnableHeadersVisualStyles = false;
            this.dgvSalarios.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.dgvSalarios.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(103)))), ((int)(((byte)(34)))));
            this.dgvSalarios.Location = new System.Drawing.Point(12, 219);
            this.dgvSalarios.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dgvSalarios.Name = "dgvSalarios";
            this.dgvSalarios.ReadOnly = true;
            this.dgvSalarios.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(103)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(43)))), ((int)(((byte)(26)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSalarios.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvSalarios.RowHeadersWidth = 51;
            this.dgvSalarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSalarios.Size = new System.Drawing.Size(1119, 254);
            this.dgvSalarios.TabIndex = 42;
            this.dgvSalarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSalarios_CellContentClick);
            this.dgvSalarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSalarios_CellContentClick);
            this.dgvSalarios.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSalarios_CellContentClick);
            this.dgvSalarios.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSalarios_CellContentClick);
            // 
            // legajo
            // 
            this.legajo.HeaderText = "Legajo";
            this.legajo.MinimumWidth = 6;
            this.legajo.Name = "legajo";
            this.legajo.ReadOnly = true;
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Nombre";
            this.nombre.MinimumWidth = 6;
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            // 
            // apellido
            // 
            this.apellido.HeaderText = "Apellido";
            this.apellido.MinimumWidth = 6;
            this.apellido.Name = "apellido";
            this.apellido.ReadOnly = true;
            // 
            // monto
            // 
            this.monto.HeaderText = "Monto";
            this.monto.MinimumWidth = 6;
            this.monto.Name = "monto";
            this.monto.ReadOnly = true;
            // 
            // fechaInicio
            // 
            this.fechaInicio.HeaderText = "Ultima vez modificado";
            this.fechaInicio.MinimumWidth = 6;
            this.fechaInicio.Name = "fechaInicio";
            this.fechaInicio.ReadOnly = true;
            // 
            // btnGenerarOrdenes
            // 
            this.btnGenerarOrdenes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(166)))), ((int)(((byte)(26)))));
            this.btnGenerarOrdenes.FlatAppearance.BorderSize = 0;
            this.btnGenerarOrdenes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerarOrdenes.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnGenerarOrdenes.ForeColor = System.Drawing.Color.White;
            this.btnGenerarOrdenes.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnGenerarOrdenes.IconColor = System.Drawing.Color.Black;
            this.btnGenerarOrdenes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGenerarOrdenes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGenerarOrdenes.Location = new System.Drawing.Point(897, 634);
            this.btnGenerarOrdenes.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnGenerarOrdenes.Name = "btnGenerarOrdenes";
            this.btnGenerarOrdenes.Size = new System.Drawing.Size(234, 47);
            this.btnGenerarOrdenes.TabIndex = 26;
            this.btnGenerarOrdenes.Text = "Generar ordenes de pago";
            this.btnGenerarOrdenes.UseVisualStyleBackColor = false;
            this.btnGenerarOrdenes.Click += new System.EventHandler(this.btnGenerarOrdenes_Click);
            // 
            // txtDescripcionComprobante
            // 
            this.txtDescripcionComprobante.Location = new System.Drawing.Point(558, 523);
            this.txtDescripcionComprobante.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtDescripcionComprobante.Multiline = true;
            this.txtDescripcionComprobante.Name = "txtDescripcionComprobante";
            this.txtDescripcionComprobante.Size = new System.Drawing.Size(281, 158);
            this.txtDescripcionComprobante.TabIndex = 24;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(554, 490);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(289, 21);
            this.label15.TabIndex = 24;
            this.label15.Text = "Descripcion para los comprobantes:";
            // 
            // frmSalarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1155, 692);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtDescripcionComprobante);
            this.Controls.Add(this.btnGenerarOrdenes);
            this.Controls.Add(this.dgvSalarios);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmSalarios";
            this.Text = " ";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtApellidoBusqueda;
        private System.Windows.Forms.TextBox txtNombreBusqueda;
        private System.Windows.Forms.TextBox txtMontoBusqueda;
        private System.Windows.Forms.TextBox txtLegajoBusqueda;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtMontoModificacion;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private Controls.BotonPadre btnAplicar;
        private Controls.BotonPadre btnExportar;
        private Controls.DataGridPadre dgvSalarios;
        private System.Windows.Forms.ComboBox cmbFiltroCargo;
        private System.Windows.Forms.Label label14;
        private Controls.BotonPadre btnLimpiar;
        private System.Windows.Forms.DataGridViewTextBoxColumn legajo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn monto;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaInicio;
        private Controls.BotonPadre btnGenerarOrdenes;
        private System.Windows.Forms.TextBox txtDescripcionComprobante;
        private System.Windows.Forms.Label label15;
        private System.Drawing.Printing.PrintDocument pntOrden;
        private Controls.BotonPadre botonPadre3;
        private Controls.BotonPadre btnModificar;
        private System.Windows.Forms.Label lblLegajo;
    }
}