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
            this.pnlBuscar = new System.Windows.Forms.Panel();
            this.dgvBusqueda = new System.Windows.Forms.DataGridView();
            this.legajo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblError = new System.Windows.Forms.Label();
            this.btnBuscar = new FontAwesome.Sharp.IconButton();
            this.txtLegajo = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblLegajo = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.pnlFormulario = new System.Windows.Forms.Panel();
            this.pnlBotones = new System.Windows.Forms.Panel();
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
            this.pnlBuscar.Controls.Add(this.lblError);
            this.pnlBuscar.Controls.Add(this.btnBuscar);
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
            this.dgvBusqueda.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvBusqueda.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBusqueda.BackgroundColor = System.Drawing.Color.White;
            this.dgvBusqueda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBusqueda.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.legajo,
            this.nombre,
            this.apellido});
            this.dgvBusqueda.Location = new System.Drawing.Point(4, 100);
            this.dgvBusqueda.Margin = new System.Windows.Forms.Padding(4);
            this.dgvBusqueda.Name = "dgvBusqueda";
            this.dgvBusqueda.ReadOnly = true;
            this.dgvBusqueda.RowHeadersWidth = 51;
            this.dgvBusqueda.RowTemplate.Height = 25;
            this.dgvBusqueda.Size = new System.Drawing.Size(989, 160);
            this.dgvBusqueda.TabIndex = 18;
            this.dgvBusqueda.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBusqueda_CellContentDoubleClick);
            this.dgvBusqueda.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBusqueda_CellContentDoubleClick);
            this.dgvBusqueda.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBusqueda_CellContentDoubleClick);
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
            // btnBuscar
            // 
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnBuscar.IconColor = System.Drawing.Color.Black;
            this.btnBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBuscar.Location = new System.Drawing.Point(746, 10);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(242, 28);
            this.btnBuscar.TabIndex = 16;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
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
            this.pnlFormulario.Size = new System.Drawing.Size(1000, 300);
            this.pnlFormulario.TabIndex = 3;
            // 
            // pnlBotones
            // 
            this.pnlBotones.Controls.Add(this.btnHistorialSalarios);
            this.pnlBotones.Controls.Add(this.btnHistorialEventos);
            this.pnlBotones.Controls.Add(this.btnDatosGenerales);
            this.pnlBotones.Controls.Add(this.btnDatosPersonales);
            this.pnlBotones.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBotones.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.pnlBotones.Location = new System.Drawing.Point(0, 0);
            this.pnlBotones.Name = "pnlBotones";
            this.pnlBotones.Size = new System.Drawing.Size(1000, 39);
            this.pnlBotones.TabIndex = 0;
            // 
            // btnHistorialSalarios
            // 
            this.btnHistorialSalarios.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnHistorialSalarios.FlatAppearance.BorderSize = 0;
            this.btnHistorialSalarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHistorialSalarios.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.btnHistorialSalarios.ForeColor = System.Drawing.Color.Black;
            this.btnHistorialSalarios.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnHistorialSalarios.IconColor = System.Drawing.Color.Black;
            this.btnHistorialSalarios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnHistorialSalarios.Location = new System.Drawing.Point(779, 3);
            this.btnHistorialSalarios.Name = "btnHistorialSalarios";
            this.btnHistorialSalarios.Size = new System.Drawing.Size(183, 30);
            this.btnHistorialSalarios.TabIndex = 2;
            this.btnHistorialSalarios.Text = "Historial Salarios";
            this.btnHistorialSalarios.UseVisualStyleBackColor = true;
            this.btnHistorialSalarios.Click += new System.EventHandler(this.btnHistorialSalarios_Click);
            // 
            // btnHistorialEventos
            // 
            this.btnHistorialEventos.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnHistorialEventos.FlatAppearance.BorderSize = 0;
            this.btnHistorialEventos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHistorialEventos.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.btnHistorialEventos.ForeColor = System.Drawing.Color.Black;
            this.btnHistorialEventos.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnHistorialEventos.IconColor = System.Drawing.Color.Black;
            this.btnHistorialEventos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnHistorialEventos.Location = new System.Drawing.Point(517, 3);
            this.btnHistorialEventos.Name = "btnHistorialEventos";
            this.btnHistorialEventos.Size = new System.Drawing.Size(183, 30);
            this.btnHistorialEventos.TabIndex = 1;
            this.btnHistorialEventos.Text = "Historial Eventos";
            this.btnHistorialEventos.UseVisualStyleBackColor = true;
            this.btnHistorialEventos.Click += new System.EventHandler(this.btnHistorial_Click);
            // 
            // btnDatosGenerales
            // 
            this.btnDatosGenerales.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnDatosGenerales.FlatAppearance.BorderSize = 0;
            this.btnDatosGenerales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDatosGenerales.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.btnDatosGenerales.ForeColor = System.Drawing.Color.Black;
            this.btnDatosGenerales.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnDatosGenerales.IconColor = System.Drawing.Color.Black;
            this.btnDatosGenerales.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDatosGenerales.Location = new System.Drawing.Point(243, 3);
            this.btnDatosGenerales.Name = "btnDatosGenerales";
            this.btnDatosGenerales.Size = new System.Drawing.Size(183, 30);
            this.btnDatosGenerales.TabIndex = 1;
            this.btnDatosGenerales.Text = "Datos Generales";
            this.btnDatosGenerales.UseVisualStyleBackColor = true;
            this.btnDatosGenerales.Click += new System.EventHandler(this.btnDatosGenerales_Click);
            // 
            // btnDatosPersonales
            // 
            this.btnDatosPersonales.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnDatosPersonales.FlatAppearance.BorderSize = 0;
            this.btnDatosPersonales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDatosPersonales.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.btnDatosPersonales.ForeColor = System.Drawing.Color.Black;
            this.btnDatosPersonales.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnDatosPersonales.IconColor = System.Drawing.Color.Black;
            this.btnDatosPersonales.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDatosPersonales.Location = new System.Drawing.Point(6, 3);
            this.btnDatosPersonales.Name = "btnDatosPersonales";
            this.btnDatosPersonales.Size = new System.Drawing.Size(183, 30);
            this.btnDatosPersonales.TabIndex = 0;
            this.btnDatosPersonales.Text = "Datos Personales";
            this.btnDatosPersonales.UseVisualStyleBackColor = true;
            this.btnDatosPersonales.Click += new System.EventHandler(this.btnDatosPersonales_Click);
            // 
            // FormularioColaborador
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1000, 585);
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
        private FontAwesome.Sharp.IconButton btnBuscar;
        private System.Windows.Forms.DataGridView dgvBusqueda;
        private System.Windows.Forms.DataGridViewTextBoxColumn legajo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellido;
    }
}