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
            this.label6 = new System.Windows.Forms.Label();
            this.cmbEscolariazacion = new System.Windows.Forms.ComboBox();
            this.cmbParentezco = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dtpFechaNac = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbLegajo = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtObraSocial = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtProv = new System.Windows.Forms.TextBox();
            this.lblProv = new System.Windows.Forms.Label();
            this.txtLocalidad = new System.Windows.Forms.TextBox();
            this.txtDepto = new System.Windows.Forms.TextBox();
            this.lblLocali = new System.Windows.Forms.Label();
            this.txtPiso = new System.Windows.Forms.TextBox();
            this.txtNroCalle = new System.Windows.Forms.TextBox();
            this.lblPiso = new System.Windows.Forms.Label();
            this.txtCalle = new System.Windows.Forms.TextBox();
            this.lblCalle = new System.Windows.Forms.Label();
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
            this.btnCancelar.Location = new System.Drawing.Point(246, 748);
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
            this.btnGuardar.Location = new System.Drawing.Point(88, 748);
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
            this.lblError.Location = new System.Drawing.Point(32, 692);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(397, 60);
            this.lblError.TabIndex = 114;
            this.lblError.Text = "Error";
            this.lblError.Visible = false;
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
            // cmbEscolariazacion
            // 
            this.cmbEscolariazacion.FormattingEnabled = true;
            this.cmbEscolariazacion.Location = new System.Drawing.Point(179, 284);
            this.cmbEscolariazacion.Name = "cmbEscolariazacion";
            this.cmbEscolariazacion.Size = new System.Drawing.Size(264, 29);
            this.cmbEscolariazacion.TabIndex = 164;
            // 
            // cmbParentezco
            // 
            this.cmbParentezco.FormattingEnabled = true;
            this.cmbParentezco.Location = new System.Drawing.Point(179, 162);
            this.cmbParentezco.Name = "cmbParentezco";
            this.cmbParentezco.Size = new System.Drawing.Size(264, 29);
            this.cmbParentezco.TabIndex = 163;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 165);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 21);
            this.label8.TabIndex = 162;
            this.label8.Text = "Parentezco:";
            // 
            // dtpFechaNac
            // 
            this.dtpFechaNac.Location = new System.Drawing.Point(179, 219);
            this.dtpFechaNac.Name = "dtpFechaNac";
            this.dtpFechaNac.Size = new System.Drawing.Size(264, 27);
            this.dtpFechaNac.TabIndex = 159;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(15, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 58);
            this.label3.TabIndex = 161;
            this.label3.Text = "Fecha de Nacimiento:";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(15, 287);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 50);
            this.label4.TabIndex = 160;
            this.label4.Text = "Nivel de Escolarización:";
            // 
            // cmbLegajo
            // 
            this.cmbLegajo.FormattingEnabled = true;
            this.cmbLegajo.Location = new System.Drawing.Point(179, 59);
            this.cmbLegajo.Name = "cmbLegajo";
            this.cmbLegajo.Size = new System.Drawing.Size(264, 29);
            this.cmbLegajo.TabIndex = 153;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(15, 59);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(127, 50);
            this.label7.TabIndex = 158;
            this.label7.Text = "Legajo Colaborador:";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(316, 119);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(127, 27);
            this.txtApellido.TabIndex = 155;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(179, 119);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(127, 27);
            this.txtNombre.TabIndex = 154;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 21);
            this.label2.TabIndex = 156;
            this.label2.Text = "Nombre y Apellido:";
            // 
            // txtObraSocial
            // 
            this.txtObraSocial.Location = new System.Drawing.Point(177, 390);
            this.txtObraSocial.Name = "txtObraSocial";
            this.txtObraSocial.Size = new System.Drawing.Size(264, 27);
            this.txtObraSocial.TabIndex = 179;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 393);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 21);
            this.label1.TabIndex = 181;
            this.label1.Text = "Obra Social:";
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(177, 337);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(264, 27);
            this.txtDni.TabIndex = 178;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 340);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 21);
            this.label5.TabIndex = 180;
            this.label5.Text = "DNI:";
            // 
            // txtProv
            // 
            this.txtProv.Enabled = false;
            this.txtProv.Location = new System.Drawing.Point(177, 672);
            this.txtProv.Name = "txtProv";
            this.txtProv.Size = new System.Drawing.Size(264, 27);
            this.txtProv.TabIndex = 173;
            // 
            // lblProv
            // 
            this.lblProv.AutoSize = true;
            this.lblProv.Enabled = false;
            this.lblProv.Location = new System.Drawing.Point(33, 671);
            this.lblProv.Name = "lblProv";
            this.lblProv.Size = new System.Drawing.Size(85, 21);
            this.lblProv.TabIndex = 177;
            this.lblProv.Text = "Provincia:";
            // 
            // txtLocalidad
            // 
            this.txtLocalidad.Enabled = false;
            this.txtLocalidad.Location = new System.Drawing.Point(177, 629);
            this.txtLocalidad.Name = "txtLocalidad";
            this.txtLocalidad.Size = new System.Drawing.Size(264, 27);
            this.txtLocalidad.TabIndex = 172;
            // 
            // txtDepto
            // 
            this.txtDepto.Enabled = false;
            this.txtDepto.Location = new System.Drawing.Point(314, 577);
            this.txtDepto.Name = "txtDepto";
            this.txtDepto.Size = new System.Drawing.Size(127, 27);
            this.txtDepto.TabIndex = 171;
            // 
            // lblLocali
            // 
            this.lblLocali.AutoSize = true;
            this.lblLocali.Enabled = false;
            this.lblLocali.Location = new System.Drawing.Point(13, 632);
            this.lblLocali.Name = "lblLocali";
            this.lblLocali.Size = new System.Drawing.Size(91, 21);
            this.lblLocali.TabIndex = 176;
            this.lblLocali.Text = "Localidad:";
            // 
            // txtPiso
            // 
            this.txtPiso.Enabled = false;
            this.txtPiso.Location = new System.Drawing.Point(177, 577);
            this.txtPiso.Name = "txtPiso";
            this.txtPiso.Size = new System.Drawing.Size(127, 27);
            this.txtPiso.TabIndex = 170;
            // 
            // txtNroCalle
            // 
            this.txtNroCalle.Enabled = false;
            this.txtNroCalle.Location = new System.Drawing.Point(314, 525);
            this.txtNroCalle.Name = "txtNroCalle";
            this.txtNroCalle.Size = new System.Drawing.Size(127, 27);
            this.txtNroCalle.TabIndex = 169;
            // 
            // lblPiso
            // 
            this.lblPiso.Enabled = false;
            this.lblPiso.Location = new System.Drawing.Point(13, 570);
            this.lblPiso.Name = "lblPiso";
            this.lblPiso.Size = new System.Drawing.Size(158, 44);
            this.lblPiso.TabIndex = 175;
            this.lblPiso.Text = "Piso y Departamento:";
            // 
            // txtCalle
            // 
            this.txtCalle.Enabled = false;
            this.txtCalle.Location = new System.Drawing.Point(177, 525);
            this.txtCalle.Name = "txtCalle";
            this.txtCalle.Size = new System.Drawing.Size(127, 27);
            this.txtCalle.TabIndex = 168;
            // 
            // lblCalle
            // 
            this.lblCalle.AutoSize = true;
            this.lblCalle.Enabled = false;
            this.lblCalle.Location = new System.Drawing.Point(13, 528);
            this.lblCalle.Name = "lblCalle";
            this.lblCalle.Size = new System.Drawing.Size(130, 21);
            this.lblCalle.TabIndex = 174;
            this.lblCalle.Text = "Calle y número:";
            // 
            // frmTodosModificarFamiliar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 749);
            this.Controls.Add(this.txtObraSocial);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDni);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtProv);
            this.Controls.Add(this.lblProv);
            this.Controls.Add(this.txtLocalidad);
            this.Controls.Add(this.txtDepto);
            this.Controls.Add(this.lblLocali);
            this.Controls.Add(this.txtPiso);
            this.Controls.Add(this.txtNroCalle);
            this.Controls.Add(this.lblPiso);
            this.Controls.Add(this.txtCalle);
            this.Controls.Add(this.lblCalle);
            this.Controls.Add(this.cmbEscolariazacion);
            this.Controls.Add(this.cmbParentezco);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dtpFechaNac);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbLegajo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblError);
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
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbEscolariazacion;
        private System.Windows.Forms.ComboBox cmbParentezco;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtpFechaNac;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbLegajo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtObraSocial;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtProv;
        private System.Windows.Forms.Label lblProv;
        private System.Windows.Forms.TextBox txtLocalidad;
        private System.Windows.Forms.TextBox txtDepto;
        private System.Windows.Forms.Label lblLocali;
        private System.Windows.Forms.TextBox txtPiso;
        private System.Windows.Forms.TextBox txtNroCalle;
        private System.Windows.Forms.Label lblPiso;
        private System.Windows.Forms.TextBox txtCalle;
        private System.Windows.Forms.Label lblCalle;
    }
}