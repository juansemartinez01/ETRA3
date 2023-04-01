namespace PresentationA.Colaboradores.Consulta
{
    partial class frmFamiliares
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
            this.btnEliminar = new PresentationA.Controls.BotonPadre();
            this.btnModificar = new PresentationA.Controls.BotonPadre();
            this.btnAgregar = new PresentationA.Controls.BotonPadre();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbParentezco = new System.Windows.Forms.ComboBox();
            this.cmbescolarizacion = new System.Windows.Forms.ComboBox();
            this.dtpfechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.txtdni = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtprovincia = new System.Windows.Forms.TextBox();
            this.lblProv = new System.Windows.Forms.Label();
            this.txtlocalidad = new System.Windows.Forms.TextBox();
            this.txtdepartamento = new System.Windows.Forms.TextBox();
            this.lblLocali = new System.Windows.Forms.Label();
            this.txtpiso = new System.Windows.Forms.TextBox();
            this.txtnumerocalle = new System.Windows.Forms.TextBox();
            this.lblPiso = new System.Windows.Forms.Label();
            this.txtnombrecalle = new System.Windows.Forms.TextBox();
            this.lblCalle = new System.Windows.Forms.Label();
            this.txtobraSocial = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dgvFamiliares = new PresentationA.Controls.DataGridPadre();
            this.chktrabaja = new System.Windows.Forms.CheckBox();
            this.chkaportes = new System.Windows.Forms.CheckBox();
            this.txtapellido = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.idFamiliar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.parentezco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.escolarizacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaNacimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.obraSocial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trabaja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aportes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreCalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroCalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.piso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.localidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.provincia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFamiliares)).BeginInit();
            this.SuspendLayout();
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
            this.btnEliminar.Location = new System.Drawing.Point(311, 594);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(0);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(122, 37);
            this.btnEliminar.TabIndex = 50;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
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
            this.btnModificar.Location = new System.Drawing.Point(172, 594);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(0);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(122, 37);
            this.btnModificar.TabIndex = 49;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
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
            this.btnAgregar.Location = new System.Drawing.Point(39, 594);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(0);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(122, 37);
            this.btnAgregar.TabIndex = 48;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 21);
            this.label1.TabIndex = 51;
            this.label1.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(35, 275);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 50);
            this.label2.TabIndex = 52;
            this.label2.Text = "Nivel de Escolarización:";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(35, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 58);
            this.label3.TabIndex = 53;
            this.label3.Text = "Fecha de Nacimiento:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 21);
            this.label4.TabIndex = 54;
            this.label4.Text = "Parentezco:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 328);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 21);
            this.label5.TabIndex = 55;
            this.label5.Text = "DNI:";
            // 
            // cmbParentezco
            // 
            this.cmbParentezco.FormattingEnabled = true;
            this.cmbParentezco.Location = new System.Drawing.Point(199, 156);
            this.cmbParentezco.Name = "cmbParentezco";
            this.cmbParentezco.Size = new System.Drawing.Size(234, 29);
            this.cmbParentezco.TabIndex = 2;
            this.cmbParentezco.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmb_KeyPress);
            // 
            // cmbescolarizacion
            // 
            this.cmbescolarizacion.FormattingEnabled = true;
            this.cmbescolarizacion.Location = new System.Drawing.Point(199, 275);
            this.cmbescolarizacion.Name = "cmbescolarizacion";
            this.cmbescolarizacion.Size = new System.Drawing.Size(234, 29);
            this.cmbescolarizacion.TabIndex = 4;
            this.cmbescolarizacion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmb_KeyPress);
            // 
            // dtpfechaNacimiento
            // 
            this.dtpfechaNacimiento.Location = new System.Drawing.Point(199, 220);
            this.dtpfechaNacimiento.Name = "dtpfechaNacimiento";
            this.dtpfechaNacimiento.Size = new System.Drawing.Size(234, 27);
            this.dtpfechaNacimiento.TabIndex = 3;
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(199, 54);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(234, 27);
            this.txtnombre.TabIndex = 1;
            // 
            // txtdni
            // 
            this.txtdni.Location = new System.Drawing.Point(199, 325);
            this.txtdni.Name = "txtdni";
            this.txtdni.Size = new System.Drawing.Size(234, 27);
            this.txtdni.TabIndex = 5;
            this.txtdni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(13, 9);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 28);
            this.label6.TabIndex = 61;
            this.label6.Text = "Familiares";
            // 
            // txtprovincia
            // 
            this.txtprovincia.Enabled = false;
            this.txtprovincia.Location = new System.Drawing.Point(640, 325);
            this.txtprovincia.Name = "txtprovincia";
            this.txtprovincia.Size = new System.Drawing.Size(264, 27);
            this.txtprovincia.TabIndex = 118;
            // 
            // lblProv
            // 
            this.lblProv.AutoSize = true;
            this.lblProv.Location = new System.Drawing.Point(476, 328);
            this.lblProv.Name = "lblProv";
            this.lblProv.Size = new System.Drawing.Size(85, 21);
            this.lblProv.TabIndex = 122;
            this.lblProv.Text = "Provincia:";
            // 
            // txtlocalidad
            // 
            this.txtlocalidad.Enabled = false;
            this.txtlocalidad.Location = new System.Drawing.Point(640, 272);
            this.txtlocalidad.Name = "txtlocalidad";
            this.txtlocalidad.Size = new System.Drawing.Size(264, 27);
            this.txtlocalidad.TabIndex = 117;
            // 
            // txtdepartamento
            // 
            this.txtdepartamento.Enabled = false;
            this.txtdepartamento.Location = new System.Drawing.Point(777, 220);
            this.txtdepartamento.Name = "txtdepartamento";
            this.txtdepartamento.Size = new System.Drawing.Size(127, 27);
            this.txtdepartamento.TabIndex = 116;
            // 
            // lblLocali
            // 
            this.lblLocali.AutoSize = true;
            this.lblLocali.Location = new System.Drawing.Point(476, 275);
            this.lblLocali.Name = "lblLocali";
            this.lblLocali.Size = new System.Drawing.Size(91, 21);
            this.lblLocali.TabIndex = 121;
            this.lblLocali.Text = "Localidad:";
            // 
            // txtpiso
            // 
            this.txtpiso.Enabled = false;
            this.txtpiso.Location = new System.Drawing.Point(640, 220);
            this.txtpiso.Name = "txtpiso";
            this.txtpiso.Size = new System.Drawing.Size(127, 27);
            this.txtpiso.TabIndex = 115;
            // 
            // txtnumerocalle
            // 
            this.txtnumerocalle.Enabled = false;
            this.txtnumerocalle.Location = new System.Drawing.Point(777, 156);
            this.txtnumerocalle.Name = "txtnumerocalle";
            this.txtnumerocalle.Size = new System.Drawing.Size(127, 27);
            this.txtnumerocalle.TabIndex = 114;
            // 
            // lblPiso
            // 
            this.lblPiso.Location = new System.Drawing.Point(476, 208);
            this.lblPiso.Name = "lblPiso";
            this.lblPiso.Size = new System.Drawing.Size(158, 44);
            this.lblPiso.TabIndex = 120;
            this.lblPiso.Text = "Piso y Departamento:";
            // 
            // txtnombrecalle
            // 
            this.txtnombrecalle.Enabled = false;
            this.txtnombrecalle.Location = new System.Drawing.Point(640, 156);
            this.txtnombrecalle.Name = "txtnombrecalle";
            this.txtnombrecalle.Size = new System.Drawing.Size(127, 27);
            this.txtnombrecalle.TabIndex = 113;
            // 
            // lblCalle
            // 
            this.lblCalle.AutoSize = true;
            this.lblCalle.Location = new System.Drawing.Point(476, 159);
            this.lblCalle.Name = "lblCalle";
            this.lblCalle.Size = new System.Drawing.Size(130, 21);
            this.lblCalle.TabIndex = 119;
            this.lblCalle.Text = "Calle y número:";
            // 
            // txtobraSocial
            // 
            this.txtobraSocial.Location = new System.Drawing.Point(640, 54);
            this.txtobraSocial.Name = "txtobraSocial";
            this.txtobraSocial.Size = new System.Drawing.Size(264, 27);
            this.txtobraSocial.TabIndex = 126;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(476, 57);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 21);
            this.label8.TabIndex = 127;
            this.label8.Text = "Obra Social:";
            // 
            // dgvFamiliares
            // 
            this.dgvFamiliares.AllowUserToAddRows = false;
            this.dgvFamiliares.AllowUserToDeleteRows = false;
            this.dgvFamiliares.AllowUserToOrderColumns = true;
            this.dgvFamiliares.AllowUserToResizeRows = false;
            this.dgvFamiliares.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvFamiliares.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFamiliares.BackgroundColor = System.Drawing.Color.White;
            this.dgvFamiliares.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvFamiliares.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(103)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(103)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFamiliares.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvFamiliares.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFamiliares.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idFamiliar,
            this.nombre,
            this.apellido,
            this.parentezco,
            this.escolarizacion,
            this.fechaNacimiento,
            this.dni,
            this.obraSocial,
            this.trabaja,
            this.aportes,
            this.nombreCalle,
            this.numeroCalle,
            this.piso,
            this.departamento,
            this.localidad,
            this.provincia});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(43)))), ((int)(((byte)(26)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvFamiliares.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvFamiliares.EnableHeadersVisualStyles = false;
            this.dgvFamiliares.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.dgvFamiliares.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(103)))), ((int)(((byte)(34)))));
            this.dgvFamiliares.Location = new System.Drawing.Point(39, 378);
            this.dgvFamiliares.MinimumSize = new System.Drawing.Size(858, 187);
            this.dgvFamiliares.Name = "dgvFamiliares";
            this.dgvFamiliares.ReadOnly = true;
            this.dgvFamiliares.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(103)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(43)))), ((int)(((byte)(26)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFamiliares.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvFamiliares.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFamiliares.Size = new System.Drawing.Size(895, 193);
            this.dgvFamiliares.TabIndex = 128;
            this.dgvFamiliares.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFamiliares_CellContentClick);
            this.dgvFamiliares.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFamiliares_CellContentClick);
            this.dgvFamiliares.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFamiliares_CellContentClick);
            // 
            // chktrabaja
            // 
            this.chktrabaja.AutoSize = true;
            this.chktrabaja.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chktrabaja.Checked = true;
            this.chktrabaja.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chktrabaja.Location = new System.Drawing.Point(480, 113);
            this.chktrabaja.Name = "chktrabaja";
            this.chktrabaja.Size = new System.Drawing.Size(89, 25);
            this.chktrabaja.TabIndex = 129;
            this.chktrabaja.Text = "Trabaja";
            this.chktrabaja.UseVisualStyleBackColor = true;
            // 
            // chkaportes
            // 
            this.chkaportes.AutoSize = true;
            this.chkaportes.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkaportes.Checked = true;
            this.chkaportes.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkaportes.Location = new System.Drawing.Point(640, 113);
            this.chkaportes.Name = "chkaportes";
            this.chkaportes.Size = new System.Drawing.Size(91, 25);
            this.chkaportes.TabIndex = 130;
            this.chkaportes.Text = "Aportes";
            this.chkaportes.UseVisualStyleBackColor = true;
            // 
            // txtapellido
            // 
            this.txtapellido.Location = new System.Drawing.Point(199, 110);
            this.txtapellido.Name = "txtapellido";
            this.txtapellido.Size = new System.Drawing.Size(234, 27);
            this.txtapellido.TabIndex = 131;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(35, 113);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 21);
            this.label7.TabIndex = 132;
            this.label7.Text = "Apellido:";
            // 
            // idFamiliar
            // 
            this.idFamiliar.HeaderText = "idFamiliar";
            this.idFamiliar.Name = "idFamiliar";
            this.idFamiliar.ReadOnly = true;
            this.idFamiliar.Visible = false;
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            // 
            // apellido
            // 
            this.apellido.HeaderText = "Apellido";
            this.apellido.Name = "apellido";
            this.apellido.ReadOnly = true;
            // 
            // parentezco
            // 
            this.parentezco.HeaderText = "Parentezco";
            this.parentezco.Name = "parentezco";
            this.parentezco.ReadOnly = true;
            // 
            // escolarizacion
            // 
            this.escolarizacion.HeaderText = "Escolarización";
            this.escolarizacion.Name = "escolarizacion";
            this.escolarizacion.ReadOnly = true;
            // 
            // fechaNacimiento
            // 
            this.fechaNacimiento.HeaderText = "Fecha de Nacimiento";
            this.fechaNacimiento.Name = "fechaNacimiento";
            this.fechaNacimiento.ReadOnly = true;
            // 
            // dni
            // 
            this.dni.HeaderText = "DNI";
            this.dni.Name = "dni";
            this.dni.ReadOnly = true;
            // 
            // obraSocial
            // 
            this.obraSocial.HeaderText = "Obra Social";
            this.obraSocial.Name = "obraSocial";
            this.obraSocial.ReadOnly = true;
            // 
            // trabaja
            // 
            this.trabaja.HeaderText = "Trabaja";
            this.trabaja.Name = "trabaja";
            this.trabaja.ReadOnly = true;
            // 
            // aportes
            // 
            this.aportes.HeaderText = "Aportes";
            this.aportes.Name = "aportes";
            this.aportes.ReadOnly = true;
            // 
            // nombreCalle
            // 
            this.nombreCalle.HeaderText = "Calle";
            this.nombreCalle.Name = "nombreCalle";
            this.nombreCalle.ReadOnly = true;
            // 
            // numeroCalle
            // 
            this.numeroCalle.HeaderText = "Altura";
            this.numeroCalle.Name = "numeroCalle";
            this.numeroCalle.ReadOnly = true;
            // 
            // piso
            // 
            this.piso.HeaderText = "piso";
            this.piso.Name = "piso";
            this.piso.ReadOnly = true;
            this.piso.Visible = false;
            // 
            // departamento
            // 
            this.departamento.HeaderText = "departamento";
            this.departamento.Name = "departamento";
            this.departamento.ReadOnly = true;
            this.departamento.Visible = false;
            // 
            // localidad
            // 
            this.localidad.HeaderText = "Localidad";
            this.localidad.Name = "localidad";
            this.localidad.ReadOnly = true;
            // 
            // provincia
            // 
            this.provincia.HeaderText = "Provincia";
            this.provincia.Name = "provincia";
            this.provincia.ReadOnly = true;
            // 
            // frmFamiliares
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(961, 647);
            this.Controls.Add(this.txtapellido);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.chkaportes);
            this.Controls.Add(this.chktrabaja);
            this.Controls.Add(this.dgvFamiliares);
            this.Controls.Add(this.txtobraSocial);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtprovincia);
            this.Controls.Add(this.lblProv);
            this.Controls.Add(this.txtlocalidad);
            this.Controls.Add(this.txtdepartamento);
            this.Controls.Add(this.lblLocali);
            this.Controls.Add(this.txtpiso);
            this.Controls.Add(this.txtnumerocalle);
            this.Controls.Add(this.lblPiso);
            this.Controls.Add(this.txtnombrecalle);
            this.Controls.Add(this.lblCalle);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtdni);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.dtpfechaNacimiento);
            this.Controls.Add(this.cmbescolarizacion);
            this.Controls.Add(this.cmbParentezco);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAgregar);
            this.Name = "frmFamiliares";
            this.Text = "frmFamiliares";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmb_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFamiliares)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Controls.BotonPadre btnEliminar;
        private Controls.BotonPadre btnModificar;
        private Controls.BotonPadre btnAgregar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbParentezco;
        private System.Windows.Forms.ComboBox cmbescolarizacion;
        private System.Windows.Forms.DateTimePicker dtpfechaNacimiento;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.TextBox txtdni;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtprovincia;
        private System.Windows.Forms.Label lblProv;
        private System.Windows.Forms.TextBox txtlocalidad;
        private System.Windows.Forms.TextBox txtdepartamento;
        private System.Windows.Forms.Label lblLocali;
        private System.Windows.Forms.TextBox txtpiso;
        private System.Windows.Forms.TextBox txtnumerocalle;
        private System.Windows.Forms.Label lblPiso;
        private System.Windows.Forms.TextBox txtnombrecalle;
        private System.Windows.Forms.Label lblCalle;
        private System.Windows.Forms.TextBox txtobraSocial;
        private System.Windows.Forms.Label label8;
        private Controls.DataGridPadre dgvFamiliares;
        private System.Windows.Forms.CheckBox chktrabaja;
        private System.Windows.Forms.CheckBox chkaportes;
        private System.Windows.Forms.TextBox txtapellido;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn idFamiliar;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn parentezco;
        private System.Windows.Forms.DataGridViewTextBoxColumn escolarizacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaNacimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn dni;
        private System.Windows.Forms.DataGridViewTextBoxColumn obraSocial;
        private System.Windows.Forms.DataGridViewTextBoxColumn trabaja;
        private System.Windows.Forms.DataGridViewTextBoxColumn aportes;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreCalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroCalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn piso;
        private System.Windows.Forms.DataGridViewTextBoxColumn departamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn localidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn provincia;
    }
}