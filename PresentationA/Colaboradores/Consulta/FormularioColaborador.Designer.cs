namespace PresentationA
{
    partial class FormularioColaborador
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
            this.pnlBuscar = new System.Windows.Forms.Panel();
            this.dgvBusqueda = new PresentationA.Controls.DataGridPadre();
            this.legajo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBuscar = new PresentationA.Controls.BotonPadre();
            this.lblError = new System.Windows.Forms.Label();
            this.txtLegajo = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblLegajo = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.pnlFormulario = new System.Windows.Forms.Panel();
            this.pnlBotones = new System.Windows.Forms.Panel();
            this.btnModificar = new PresentationA.Controls.BotonPadre();
            this.btnCtaCte = new FontAwesome.Sharp.IconButton();
            this.btnHistorialSalarios = new FontAwesome.Sharp.IconButton();
            this.btnHistorialEventos = new FontAwesome.Sharp.IconButton();
            this.btnDatosGenerales = new FontAwesome.Sharp.IconButton();
            this.btnDatosPersonales = new FontAwesome.Sharp.IconButton();
            this.pnlBuscar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBusqueda)).BeginInit();
            this.pnlFormulario.SuspendLayout();
            this.pnlBotones.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBuscar
            // 
            this.pnlBuscar.Controls.Add(this.dgvBusqueda);
            this.pnlBuscar.Controls.Add(this.btnBuscar);
            this.pnlBuscar.Controls.Add(this.lblError);
            this.pnlBuscar.Controls.Add(this.txtLegajo);
            this.pnlBuscar.Controls.Add(this.txtNombre);
            this.pnlBuscar.Controls.Add(this.lblNombre);
            this.pnlBuscar.Controls.Add(this.lblLegajo);
            this.pnlBuscar.Controls.Add(this.txtApellido);
            this.pnlBuscar.Controls.Add(this.lblApellido);
            this.pnlBuscar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBuscar.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.pnlBuscar.Location = new System.Drawing.Point(0, 0);
            this.pnlBuscar.Name = "pnlBuscar";
            this.pnlBuscar.Size = new System.Drawing.Size(1000, 285);
            this.pnlBuscar.TabIndex = 2;
            // 
            // dgvBusqueda
            // 
            this.dgvBusqueda.AllowUserToAddRows = false;
            this.dgvBusqueda.AllowUserToDeleteRows = false;
            this.dgvBusqueda.AllowUserToOrderColumns = true;
            this.dgvBusqueda.AllowUserToResizeColumns = false;
            this.dgvBusqueda.AllowUserToResizeRows = false;
            this.dgvBusqueda.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvBusqueda.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBusqueda.BackgroundColor = System.Drawing.Color.White;
            this.dgvBusqueda.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvBusqueda.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(103)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(103)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBusqueda.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBusqueda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBusqueda.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.legajo,
            this.nombre,
            this.apellido});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(43)))), ((int)(((byte)(26)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBusqueda.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvBusqueda.EnableHeadersVisualStyles = false;
            this.dgvBusqueda.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.dgvBusqueda.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(103)))), ((int)(((byte)(34)))));
            this.dgvBusqueda.Location = new System.Drawing.Point(31, 109);
            this.dgvBusqueda.Name = "dgvBusqueda";
            this.dgvBusqueda.ReadOnly = true;
            this.dgvBusqueda.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(103)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(44)))), ((int)(((byte)(26)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBusqueda.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvBusqueda.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBusqueda.Size = new System.Drawing.Size(931, 149);
            this.dgvBusqueda.TabIndex = 20;
            this.dgvBusqueda.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBusqueda_CellContentDoubleClick);
            this.dgvBusqueda.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBusqueda_CellContentDoubleClick);
            this.dgvBusqueda.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBusqueda_CellContentDoubleClick);
            this.dgvBusqueda.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBusqueda_CellContentDoubleClick);
            this.dgvBusqueda.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvBusqueda_RowHeaderMouseClick);
            this.dgvBusqueda.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvBusqueda_RowHeaderMouseClick);
            // 
            // legajo
            // 
            this.legajo.HeaderText = "Legajo";
            this.legajo.Name = "legajo";
            this.legajo.ReadOnly = true;
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
            // btnBuscar
            // 
            this.btnBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(166)))), ((int)(((byte)(26)))));
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlassPlus;
            this.btnBuscar.IconColor = System.Drawing.Color.White;
            this.btnBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBuscar.IconSize = 30;
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.Location = new System.Drawing.Point(849, 55);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(113, 38);
            this.btnBuscar.TabIndex = 19;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.lblError.ForeColor = System.Drawing.Color.DimGray;
            this.lblError.Image = global::PresentationA.Properties.Resources.kisspng_exclamation_mark_clip_art_vector_graphics_computer_5ced29986ef952_9605616015590465524546__1___1_;
            this.lblError.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblError.Location = new System.Drawing.Point(27, 65);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(42, 20);
            this.lblError.TabIndex = 15;
            this.lblError.Text = "Error";
            this.lblError.Visible = false;
            // 
            // txtLegajo
            // 
            this.txtLegajo.Location = new System.Drawing.Point(120, 12);
            this.txtLegajo.Name = "txtLegajo";
            this.txtLegajo.Size = new System.Drawing.Size(100, 26);
            this.txtLegajo.TabIndex = 12;
            this.txtLegajo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLegajo_KeyPress);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(355, 15);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 26);
            this.txtNombre.TabIndex = 8;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.enter_keyPress);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(262, 12);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(72, 20);
            this.lblNombre.TabIndex = 7;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblLegajo
            // 
            this.lblLegajo.AutoSize = true;
            this.lblLegajo.Location = new System.Drawing.Point(27, 12);
            this.lblLegajo.Name = "lblLegajo";
            this.lblLegajo.Size = new System.Drawing.Size(63, 20);
            this.lblLegajo.TabIndex = 11;
            this.lblLegajo.Text = "Legajo:";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(623, 12);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(100, 26);
            this.txtApellido.TabIndex = 9;
            this.txtApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.enter_keyPress);
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(501, 12);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(73, 20);
            this.lblApellido.TabIndex = 10;
            this.lblApellido.Text = "Apellido:";
            // 
            // pnlFormulario
            // 
            this.pnlFormulario.Controls.Add(this.pnlBotones);
            this.pnlFormulario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFormulario.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.pnlFormulario.Location = new System.Drawing.Point(0, 285);
            this.pnlFormulario.Name = "pnlFormulario";
            this.pnlFormulario.Size = new System.Drawing.Size(1000, 597);
            this.pnlFormulario.TabIndex = 3;
            // 
            // pnlBotones
            // 
            this.pnlBotones.Controls.Add(this.btnModificar);
            this.pnlBotones.Controls.Add(this.btnCtaCte);
            this.pnlBotones.Controls.Add(this.btnHistorialSalarios);
            this.pnlBotones.Controls.Add(this.btnHistorialEventos);
            this.pnlBotones.Controls.Add(this.btnDatosGenerales);
            this.pnlBotones.Controls.Add(this.btnDatosPersonales);
            this.pnlBotones.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlBotones.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.pnlBotones.Location = new System.Drawing.Point(0, 0);
            this.pnlBotones.Name = "pnlBotones";
            this.pnlBotones.Size = new System.Drawing.Size(190, 597);
            this.pnlBotones.TabIndex = 0;
            // 
            // btnModificar
            // 
            this.btnModificar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(166)))), ((int)(((byte)(26)))));
            this.btnModificar.Enabled = false;
            this.btnModificar.FlatAppearance.BorderSize = 0;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnModificar.ForeColor = System.Drawing.Color.White;
            this.btnModificar.IconChar = FontAwesome.Sharp.IconChar.Pen;
            this.btnModificar.IconColor = System.Drawing.Color.White;
            this.btnModificar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnModificar.IconSize = 25;
            this.btnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificar.Location = new System.Drawing.Point(31, 545);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(125, 40);
            this.btnModificar.TabIndex = 1;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnCtaCte
            // 
            this.btnCtaCte.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCtaCte.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCtaCte.FlatAppearance.BorderSize = 0;
            this.btnCtaCte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCtaCte.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.btnCtaCte.ForeColor = System.Drawing.Color.Black;
            this.btnCtaCte.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnCtaCte.IconColor = System.Drawing.Color.Black;
            this.btnCtaCte.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCtaCte.Location = new System.Drawing.Point(0, 156);
            this.btnCtaCte.Name = "btnCtaCte";
            this.btnCtaCte.Padding = new System.Windows.Forms.Padding(5);
            this.btnCtaCte.Size = new System.Drawing.Size(190, 39);
            this.btnCtaCte.TabIndex = 3;
            this.btnCtaCte.Text = "Cuenta Corriente";
            this.btnCtaCte.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCtaCte.UseVisualStyleBackColor = true;
            this.btnCtaCte.Click += new System.EventHandler(this.btnCtaCte_Click);
            // 
            // btnHistorialSalarios
            // 
            this.btnHistorialSalarios.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHistorialSalarios.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnHistorialSalarios.FlatAppearance.BorderSize = 0;
            this.btnHistorialSalarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHistorialSalarios.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.btnHistorialSalarios.ForeColor = System.Drawing.Color.Black;
            this.btnHistorialSalarios.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnHistorialSalarios.IconColor = System.Drawing.Color.Black;
            this.btnHistorialSalarios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnHistorialSalarios.Location = new System.Drawing.Point(0, 117);
            this.btnHistorialSalarios.Name = "btnHistorialSalarios";
            this.btnHistorialSalarios.Padding = new System.Windows.Forms.Padding(5);
            this.btnHistorialSalarios.Size = new System.Drawing.Size(190, 39);
            this.btnHistorialSalarios.TabIndex = 2;
            this.btnHistorialSalarios.Text = "Historial Salarios";
            this.btnHistorialSalarios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHistorialSalarios.UseVisualStyleBackColor = true;
            this.btnHistorialSalarios.Click += new System.EventHandler(this.btnHistorialSalarios_Click);
            // 
            // btnHistorialEventos
            // 
            this.btnHistorialEventos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHistorialEventos.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnHistorialEventos.FlatAppearance.BorderSize = 0;
            this.btnHistorialEventos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHistorialEventos.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.btnHistorialEventos.ForeColor = System.Drawing.Color.Black;
            this.btnHistorialEventos.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnHistorialEventos.IconColor = System.Drawing.Color.Black;
            this.btnHistorialEventos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnHistorialEventos.Location = new System.Drawing.Point(0, 78);
            this.btnHistorialEventos.Name = "btnHistorialEventos";
            this.btnHistorialEventos.Padding = new System.Windows.Forms.Padding(5);
            this.btnHistorialEventos.Size = new System.Drawing.Size(190, 39);
            this.btnHistorialEventos.TabIndex = 1;
            this.btnHistorialEventos.Text = "Historial Eventos";
            this.btnHistorialEventos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHistorialEventos.UseVisualStyleBackColor = true;
            this.btnHistorialEventos.Click += new System.EventHandler(this.btnHistorial_Click);
            // 
            // btnDatosGenerales
            // 
            this.btnDatosGenerales.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDatosGenerales.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnDatosGenerales.FlatAppearance.BorderSize = 0;
            this.btnDatosGenerales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDatosGenerales.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.btnDatosGenerales.ForeColor = System.Drawing.Color.Black;
            this.btnDatosGenerales.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnDatosGenerales.IconColor = System.Drawing.Color.Black;
            this.btnDatosGenerales.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDatosGenerales.Location = new System.Drawing.Point(0, 39);
            this.btnDatosGenerales.Name = "btnDatosGenerales";
            this.btnDatosGenerales.Padding = new System.Windows.Forms.Padding(5);
            this.btnDatosGenerales.Size = new System.Drawing.Size(190, 39);
            this.btnDatosGenerales.TabIndex = 1;
            this.btnDatosGenerales.Text = "Datos Generales";
            this.btnDatosGenerales.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDatosGenerales.UseVisualStyleBackColor = true;
            this.btnDatosGenerales.Click += new System.EventHandler(this.btnDatosGenerales_Click);
            // 
            // btnDatosPersonales
            // 
            this.btnDatosPersonales.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDatosPersonales.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnDatosPersonales.FlatAppearance.BorderSize = 0;
            this.btnDatosPersonales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDatosPersonales.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.btnDatosPersonales.ForeColor = System.Drawing.Color.Black;
            this.btnDatosPersonales.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnDatosPersonales.IconColor = System.Drawing.Color.Black;
            this.btnDatosPersonales.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDatosPersonales.Location = new System.Drawing.Point(0, 0);
            this.btnDatosPersonales.Name = "btnDatosPersonales";
            this.btnDatosPersonales.Padding = new System.Windows.Forms.Padding(5);
            this.btnDatosPersonales.Size = new System.Drawing.Size(190, 39);
            this.btnDatosPersonales.TabIndex = 0;
            this.btnDatosPersonales.Text = "Datos Personales";
            this.btnDatosPersonales.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDatosPersonales.UseVisualStyleBackColor = true;
            this.btnDatosPersonales.Click += new System.EventHandler(this.btnDatosPersonales_Click);
            // 
            // FormularioColaborador
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1000, 882);
            this.Controls.Add(this.pnlFormulario);
            this.Controls.Add(this.pnlBuscar);
            this.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.Name = "FormularioColaborador";
            this.Text = "FormularioColaborador";
            this.pnlBuscar.ResumeLayout(false);
            this.pnlBuscar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBusqueda)).EndInit();
            this.pnlFormulario.ResumeLayout(false);
            this.pnlBotones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlBuscar;
        private System.Windows.Forms.TextBox txtLegajo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblLegajo;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Panel pnlFormulario;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Panel pnlBotones;
        private FontAwesome.Sharp.IconButton btnDatosPersonales;
        private FontAwesome.Sharp.IconButton btnHistorialEventos;
        private FontAwesome.Sharp.IconButton btnDatosGenerales;
        private FontAwesome.Sharp.IconButton btnHistorialSalarios;
        private Controls.BotonPadre btnBuscar;
        private Controls.DataGridPadre dgvBusqueda;
        private System.Windows.Forms.DataGridViewTextBoxColumn legajo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellido;
        private FontAwesome.Sharp.IconButton btnCtaCte;
        private Controls.BotonPadre btnModificar;
    }
}