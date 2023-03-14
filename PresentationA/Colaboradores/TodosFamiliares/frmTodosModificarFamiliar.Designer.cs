namespace PresentationA.Colaboradores.TodosFamiliares
{
    partial class frmTodosModificarFamiliar
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
            this.btnCancelar = new PresentationA.Controls.BotonPadre();
            this.btnGuardar = new PresentationA.Controls.BotonPadre();
            this.lblError = new System.Windows.Forms.Label();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.dtpFechaNac = new System.Windows.Forms.DateTimePicker();
            this.cmbEscolariazacion = new System.Windows.Forms.ComboBox();
            this.cmbParentezco = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(166)))), ((int)(((byte)(26)))));
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.IconChar = FontAwesome.Sharp.IconChar.X;
            this.btnCancelar.IconColor = System.Drawing.Color.White;
            this.btnCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCancelar.IconSize = 25;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(231, 426);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(118, 35);
            this.btnCancelar.TabIndex = 95;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(166)))), ((int)(((byte)(26)))));
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.btnGuardar.IconColor = System.Drawing.Color.White;
            this.btnGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGuardar.IconSize = 25;
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(73, 426);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(118, 35);
            this.btnGuardar.TabIndex = 94;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // lblError
            // 
            this.lblError.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.lblError.ForeColor = System.Drawing.Color.DimGray;
            this.lblError.Image = global::PresentationA.Properties.Resources.kisspng_exclamation_mark_clip_art_vector_graphics_computer_5ced29986ef952_9605616015590465524546__1___1_;
            this.lblError.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblError.Location = new System.Drawing.Point(48, 369);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(397, 45);
            this.lblError.TabIndex = 114;
            this.lblError.Text = "Error";
            this.lblError.Visible = false;
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(211, 313);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(234, 27);
            this.txtDni.TabIndex = 113;
            this.txtDni.TextChanged += new System.EventHandler(this.txt_TextChanged);
            this.txtDni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textDni_KeyPress);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(211, 61);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(234, 27);
            this.txtNombre.TabIndex = 112;
            this.txtNombre.TextChanged += new System.EventHandler(this.txt_TextChanged);
            // 
            // dtpFechaNac
            // 
            this.dtpFechaNac.Location = new System.Drawing.Point(211, 173);
            this.dtpFechaNac.Name = "dtpFechaNac";
            this.dtpFechaNac.Size = new System.Drawing.Size(234, 27);
            this.dtpFechaNac.TabIndex = 111;
            this.dtpFechaNac.ValueChanged += new System.EventHandler(this.txt_TextChanged);
            // 
            // cmbEscolariazacion
            // 
            this.cmbEscolariazacion.FormattingEnabled = true;
            this.cmbEscolariazacion.Location = new System.Drawing.Point(211, 246);
            this.cmbEscolariazacion.Name = "cmbEscolariazacion";
            this.cmbEscolariazacion.Size = new System.Drawing.Size(234, 29);
            this.cmbEscolariazacion.TabIndex = 110;
            this.cmbEscolariazacion.SelectedIndexChanged += new System.EventHandler(this.txt_TextChanged);
            // 
            // cmbParentezco
            // 
            this.cmbParentezco.FormattingEnabled = true;
            this.cmbParentezco.Location = new System.Drawing.Point(211, 121);
            this.cmbParentezco.Name = "cmbParentezco";
            this.cmbParentezco.Size = new System.Drawing.Size(234, 29);
            this.cmbParentezco.TabIndex = 109;
            this.cmbParentezco.SelectedIndexChanged += new System.EventHandler(this.txt_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(47, 316);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 21);
            this.label5.TabIndex = 108;
            this.label5.Text = "DNI:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 21);
            this.label4.TabIndex = 107;
            this.label4.Text = "Parentezco:";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(47, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 58);
            this.label3.TabIndex = 106;
            this.label3.Text = "Fecha de Nacimiento:";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(47, 246);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 50);
            this.label2.TabIndex = 105;
            this.label2.Text = "Nivel de Escolarización:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 21);
            this.label1.TabIndex = 104;
            this.label1.Text = "Nombre:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(121, 9);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(223, 28);
            this.label6.TabIndex = 115;
            this.label6.Text = "Modificar Familiar";
            // 
            // frmTodosModificarFamiliar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 474);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.txtDni);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.dtpFechaNac);
            this.Controls.Add(this.cmbEscolariazacion);
            this.Controls.Add(this.cmbParentezco);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmTodosModificarFamiliar";
            this.Text = "Modificar Familiar";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmTodosModificarFamiliar_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controls.BotonPadre btnCancelar;
        private Controls.BotonPadre btnGuardar;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.DateTimePicker dtpFechaNac;
        private System.Windows.Forms.ComboBox cmbEscolariazacion;
        private System.Windows.Forms.ComboBox cmbParentezco;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
    }
}