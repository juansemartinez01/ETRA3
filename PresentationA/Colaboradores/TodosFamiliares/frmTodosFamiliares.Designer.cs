namespace PresentationA.Colaboradores
{
    partial class frmTodosFamiliares
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
            this.label6 = new System.Windows.Forms.Label();
            this.btnEliminar = new PresentationA.Controls.BotonPadre();
            this.btnModificar = new PresentationA.Controls.BotonPadre();
            this.btnAgregar = new PresentationA.Controls.BotonPadre();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnLimpiar = new PresentationA.Controls.BotonPadre();
            this.btnExportar = new PresentationA.Controls.BotonPadre();
            this.btnAplicar = new PresentationA.Controls.BotonPadre();
            this.txtLegajoBusqueda = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dgvFamiliares = new PresentationA.Controls.DataGridPadre();
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
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFamiliares)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(13, 9);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 28);
            this.label6.TabIndex = 72;
            this.label6.Text = "Familiares";
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
            this.btnEliminar.Location = new System.Drawing.Point(311, 498);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(0);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(122, 37);
            this.btnEliminar.TabIndex = 75;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
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
            this.btnModificar.Location = new System.Drawing.Point(172, 498);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(0);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(122, 37);
            this.btnModificar.TabIndex = 74;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click_1);
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
            this.btnAgregar.Location = new System.Drawing.Point(39, 498);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(0);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(122, 37);
            this.btnAgregar.TabIndex = 73;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnLimpiar);
            this.groupBox1.Controls.Add(this.btnExportar);
            this.groupBox1.Controls.Add(this.btnAplicar);
            this.groupBox1.Controls.Add(this.txtLegajoBusqueda);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Location = new System.Drawing.Point(33, 45);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox1.Size = new System.Drawing.Size(997, 74);
            this.groupBox1.TabIndex = 77;
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
            this.btnLimpiar.Location = new System.Drawing.Point(619, 20);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(178, 37);
            this.btnLimpiar.TabIndex = 25;
            this.btnLimpiar.Text = "Limpiar Filtro";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
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
            this.btnExportar.Location = new System.Drawing.Point(810, 20);
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
            this.btnAplicar.Location = new System.Drawing.Point(426, 20);
            this.btnAplicar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnAplicar.Name = "btnAplicar";
            this.btnAplicar.Size = new System.Drawing.Size(178, 37);
            this.btnAplicar.TabIndex = 10;
            this.btnAplicar.Text = "Aplicar";
            this.btnAplicar.UseVisualStyleBackColor = false;
            this.btnAplicar.Click += new System.EventHandler(this.btnAplicar_Click);
            // 
            // txtLegajoBusqueda
            // 
            this.txtLegajoBusqueda.Location = new System.Drawing.Point(189, 25);
            this.txtLegajoBusqueda.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtLegajoBusqueda.Name = "txtLegajoBusqueda";
            this.txtLegajoBusqueda.Size = new System.Drawing.Size(189, 27);
            this.txtLegajoBusqueda.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(4, 28);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(166, 21);
            this.label10.TabIndex = 0;
            this.label10.Text = "Legajo Colaborador";
            // 
            // dgvFamiliares
            // 
            this.dgvFamiliares.AllowUserToAddRows = false;
            this.dgvFamiliares.AllowUserToDeleteRows = false;
            this.dgvFamiliares.AllowUserToOrderColumns = true;
            this.dgvFamiliares.AllowUserToResizeRows = false;
            this.dgvFamiliares.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
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
            this.dgvFamiliares.Location = new System.Drawing.Point(33, 136);
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
            this.dgvFamiliares.Size = new System.Drawing.Size(997, 341);
            this.dgvFamiliares.TabIndex = 129;
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
            // frmTodosFamiliares
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1038, 567);
            this.Controls.Add(this.dgvFamiliares);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.label6);
            this.MinimumSize = new System.Drawing.Size(0, 567);
            this.Name = "frmTodosFamiliares";
            this.Text = "frmFamiliares";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFamiliares)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private Controls.BotonPadre btnEliminar;
        private Controls.BotonPadre btnModificar;
        private Controls.BotonPadre btnAgregar;
        private System.Windows.Forms.GroupBox groupBox1;
        private Controls.BotonPadre btnLimpiar;
        private Controls.BotonPadre btnExportar;
        private Controls.BotonPadre btnAplicar;
        private System.Windows.Forms.TextBox txtLegajoBusqueda;
        private System.Windows.Forms.Label label10;
        private Controls.DataGridPadre dgvFamiliares;
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