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
            this.lblError = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtLegajo = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblLegajo = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.pnlFormulario = new System.Windows.Forms.Panel();
            this.pnlBotones = new System.Windows.Forms.Panel();
            this.btnHistorial = new FontAwesome.Sharp.IconButton();
            this.btnDatosGenerales = new FontAwesome.Sharp.IconButton();
            this.btnDatosPersonales = new FontAwesome.Sharp.IconButton();
            this.pnlBuscar.SuspendLayout();
            this.pnlFormulario.SuspendLayout();
            this.pnlBotones.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBuscar
            // 
            this.pnlBuscar.Controls.Add(this.lblError);
            this.pnlBuscar.Controls.Add(this.btnBuscar);
            this.pnlBuscar.Controls.Add(this.txtLegajo);
            this.pnlBuscar.Controls.Add(this.txtNombre);
            this.pnlBuscar.Controls.Add(this.lblNombre);
            this.pnlBuscar.Controls.Add(this.lblLegajo);
            this.pnlBuscar.Controls.Add(this.txtApellido);
            this.pnlBuscar.Controls.Add(this.lblApellido);
            this.pnlBuscar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBuscar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pnlBuscar.Location = new System.Drawing.Point(0, 0);
            this.pnlBuscar.Name = "pnlBuscar";
            this.pnlBuscar.Size = new System.Drawing.Size(800, 104);
            this.pnlBuscar.TabIndex = 2;
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblError.ForeColor = System.Drawing.Color.DimGray;
            this.lblError.Image = global::PresentationA.Properties.Resources.kisspng_exclamation_mark_clip_art_vector_graphics_computer_5ced29986ef952_9605616015590465524546__1___1_;
            this.lblError.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblError.Location = new System.Drawing.Point(37, 60);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(42, 20);
            this.lblError.TabIndex = 15;
            this.lblError.Text = "Error";
            this.lblError.Visible = false;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.Location = new System.Drawing.Point(673, 12);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(115, 27);
            this.btnBuscar.TabIndex = 13;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtLegajo
            // 
            this.txtLegajo.Location = new System.Drawing.Point(95, 12);
            this.txtLegajo.Name = "txtLegajo";
            this.txtLegajo.Size = new System.Drawing.Size(100, 26);
            this.txtLegajo.TabIndex = 12;
            this.txtLegajo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLegajo_KeyPress);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(299, 12);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 26);
            this.txtNombre.TabIndex = 8;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.enter_keyPress);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(221, 12);
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
            this.txtApellido.Location = new System.Drawing.Point(493, 12);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(100, 26);
            this.txtApellido.TabIndex = 9;
            this.txtApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.enter_keyPress);
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(413, 12);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(73, 20);
            this.lblApellido.TabIndex = 10;
            this.lblApellido.Text = "Apellido:";
            // 
            // pnlFormulario
            // 
            this.pnlFormulario.Controls.Add(this.pnlBotones);
            this.pnlFormulario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFormulario.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pnlFormulario.Location = new System.Drawing.Point(0, 104);
            this.pnlFormulario.Name = "pnlFormulario";
            this.pnlFormulario.Size = new System.Drawing.Size(800, 481);
            this.pnlFormulario.TabIndex = 3;
            // 
            // pnlBotones
            // 
            this.pnlBotones.Controls.Add(this.btnHistorial);
            this.pnlBotones.Controls.Add(this.btnDatosGenerales);
            this.pnlBotones.Controls.Add(this.btnDatosPersonales);
            this.pnlBotones.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBotones.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pnlBotones.Location = new System.Drawing.Point(0, 0);
            this.pnlBotones.Name = "pnlBotones";
            this.pnlBotones.Size = new System.Drawing.Size(800, 39);
            this.pnlBotones.TabIndex = 0;
            // 
            // btnHistorial
            // 
            this.btnHistorial.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnHistorial.FlatAppearance.BorderSize = 0;
            this.btnHistorial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHistorial.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnHistorial.ForeColor = System.Drawing.Color.Black;
            this.btnHistorial.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnHistorial.IconColor = System.Drawing.Color.Black;
            this.btnHistorial.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnHistorial.Location = new System.Drawing.Point(562, 3);
            this.btnHistorial.Name = "btnHistorial";
            this.btnHistorial.Size = new System.Drawing.Size(183, 30);
            this.btnHistorial.TabIndex = 1;
            this.btnHistorial.Text = "Historial";
            this.btnHistorial.UseVisualStyleBackColor = true;
            this.btnHistorial.Click += new System.EventHandler(this.btnHistorial_Click);
            // 
            // btnDatosGenerales
            // 
            this.btnDatosGenerales.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnDatosGenerales.FlatAppearance.BorderSize = 0;
            this.btnDatosGenerales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDatosGenerales.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDatosGenerales.ForeColor = System.Drawing.Color.Black;
            this.btnDatosGenerales.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnDatosGenerales.IconColor = System.Drawing.Color.Black;
            this.btnDatosGenerales.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDatosGenerales.Location = new System.Drawing.Point(299, 3);
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
            this.btnDatosPersonales.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDatosPersonales.ForeColor = System.Drawing.Color.Black;
            this.btnDatosPersonales.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnDatosPersonales.IconColor = System.Drawing.Color.Black;
            this.btnDatosPersonales.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDatosPersonales.Location = new System.Drawing.Point(12, 3);
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
            this.ClientSize = new System.Drawing.Size(800, 585);
            this.Controls.Add(this.pnlFormulario);
            this.Controls.Add(this.pnlBuscar);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "FormularioColaborador";
            this.Text = "FormularioColaborador";
            this.pnlBuscar.ResumeLayout(false);
            this.pnlBuscar.PerformLayout();
            this.pnlFormulario.ResumeLayout(false);
            this.pnlBotones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlBuscar;
        private System.Windows.Forms.Button btnBuscar;
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
        private FontAwesome.Sharp.IconButton btnHistorial;
        private FontAwesome.Sharp.IconButton btnDatosGenerales;
    }
}