namespace PresentationA.Colaboradores.Consulta.Familiares
{
    partial class frmAgregarFam
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
            this.lblError = new System.Windows.Forms.Label();
            this.btnCancelar = new PresentationA.Controls.BotonPadre();
            this.btnGuardar = new PresentationA.Controls.BotonPadre();
            this.txtCalle = new System.Windows.Forms.TextBox();
            this.lblCalle = new System.Windows.Forms.Label();
            this.txtNroCalle = new System.Windows.Forms.TextBox();
            this.lblPiso = new System.Windows.Forms.Label();
            this.txtPiso = new System.Windows.Forms.TextBox();
            this.txtDepto = new System.Windows.Forms.TextBox();
            this.lblLocali = new System.Windows.Forms.Label();
            this.txtLocalidad = new System.Windows.Forms.TextBox();
            this.txtProv = new System.Windows.Forms.TextBox();
            this.lblProv = new System.Windows.Forms.Label();
            this.chkDirecc = new System.Windows.Forms.CheckBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtObraSocial = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.chkTrabaja = new System.Windows.Forms.CheckBox();
            this.chkAportes = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(190, 277);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(264, 27);
            this.txtDni.TabIndex = 6;
            this.txtDni.TextChanged += new System.EventHandler(this.txt_TextChanged);
            this.txtDni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(190, 59);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(112, 27);
            this.txtNombre.TabIndex = 1;
            this.txtNombre.TextChanged += new System.EventHandler(this.txt_TextChanged);
            // 
            // dtpFechaNac
            // 
            this.dtpFechaNac.Location = new System.Drawing.Point(190, 156);
            this.dtpFechaNac.Name = "dtpFechaNac";
            this.dtpFechaNac.Size = new System.Drawing.Size(264, 27);
            this.dtpFechaNac.TabIndex = 4;
            this.dtpFechaNac.ValueChanged += new System.EventHandler(this.txt_TextChanged);
            // 
            // cmbEscolariazacion
            // 
            this.cmbEscolariazacion.FormattingEnabled = true;
            this.cmbEscolariazacion.Location = new System.Drawing.Point(190, 219);
            this.cmbEscolariazacion.Name = "cmbEscolariazacion";
            this.cmbEscolariazacion.Size = new System.Drawing.Size(264, 29);
            this.cmbEscolariazacion.TabIndex = 5;
            this.cmbEscolariazacion.SelectedIndexChanged += new System.EventHandler(this.txt_TextChanged);
            this.cmbEscolariazacion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmb_KeyPress);
            // 
            // cmbParentezco
            // 
            this.cmbParentezco.FormattingEnabled = true;
            this.cmbParentezco.Location = new System.Drawing.Point(190, 107);
            this.cmbParentezco.Name = "cmbParentezco";
            this.cmbParentezco.Size = new System.Drawing.Size(264, 29);
            this.cmbParentezco.TabIndex = 3;
            this.cmbParentezco.SelectedIndexChanged += new System.EventHandler(this.txt_TextChanged);
            this.cmbParentezco.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmb_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 280);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 21);
            this.label5.TabIndex = 65;
            this.label5.Text = "DNI:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 21);
            this.label4.TabIndex = 64;
            this.label4.Text = "Parentezco:";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(26, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 58);
            this.label3.TabIndex = 63;
            this.label3.Text = "Fecha de Nacimiento:";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(26, 219);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 50);
            this.label2.TabIndex = 62;
            this.label2.Text = "Nivel de Escolarización:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 21);
            this.label1.TabIndex = 61;
            this.label1.Text = "Nombre y Apellido:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(140, 9);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(187, 28);
            this.label6.TabIndex = 71;
            this.label6.Text = "Nuevo Familiar";
            // 
            // lblError
            // 
            this.lblError.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.lblError.ForeColor = System.Drawing.Color.DimGray;
            this.lblError.Image = global::PresentationA.Properties.Resources.kisspng_exclamation_mark_clip_art_vector_graphics_computer_5ced29986ef952_9605616015590465524546__1___1_;
            this.lblError.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblError.Location = new System.Drawing.Point(27, 706);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(427, 45);
            this.lblError.TabIndex = 103;
            this.lblError.Text = "Error";
            this.lblError.Visible = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(166)))), ((int)(((byte)(26)))));
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.IconChar = FontAwesome.Sharp.IconChar.XmarkCircle;
            this.btnCancelar.IconColor = System.Drawing.Color.White;
            this.btnCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCancelar.IconSize = 30;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(255, 767);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(131, 37);
            this.btnCancelar.TabIndex = 12;
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
            this.btnGuardar.IconSize = 30;
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(103, 767);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(123, 37);
            this.btnGuardar.TabIndex = 11;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtCalle
            // 
            this.txtCalle.Enabled = false;
            this.txtCalle.Location = new System.Drawing.Point(190, 478);
            this.txtCalle.Name = "txtCalle";
            this.txtCalle.Size = new System.Drawing.Size(127, 27);
            this.txtCalle.TabIndex = 10;
            // 
            // lblCalle
            // 
            this.lblCalle.AutoSize = true;
            this.lblCalle.Enabled = false;
            this.lblCalle.Location = new System.Drawing.Point(26, 481);
            this.lblCalle.Name = "lblCalle";
            this.lblCalle.Size = new System.Drawing.Size(130, 21);
            this.lblCalle.TabIndex = 104;
            this.lblCalle.Text = "Calle y número:";
            // 
            // txtNroCalle
            // 
            this.txtNroCalle.Enabled = false;
            this.txtNroCalle.Location = new System.Drawing.Point(327, 478);
            this.txtNroCalle.Name = "txtNroCalle";
            this.txtNroCalle.Size = new System.Drawing.Size(127, 27);
            this.txtNroCalle.TabIndex = 11;
            // 
            // lblPiso
            // 
            this.lblPiso.Enabled = false;
            this.lblPiso.Location = new System.Drawing.Point(26, 523);
            this.lblPiso.Name = "lblPiso";
            this.lblPiso.Size = new System.Drawing.Size(158, 44);
            this.lblPiso.TabIndex = 106;
            this.lblPiso.Text = "Piso y Departamento:";
            // 
            // txtPiso
            // 
            this.txtPiso.Enabled = false;
            this.txtPiso.Location = new System.Drawing.Point(190, 530);
            this.txtPiso.Name = "txtPiso";
            this.txtPiso.Size = new System.Drawing.Size(127, 27);
            this.txtPiso.TabIndex = 12;
            // 
            // txtDepto
            // 
            this.txtDepto.Enabled = false;
            this.txtDepto.Location = new System.Drawing.Point(327, 530);
            this.txtDepto.Name = "txtDepto";
            this.txtDepto.Size = new System.Drawing.Size(127, 27);
            this.txtDepto.TabIndex = 13;
            // 
            // lblLocali
            // 
            this.lblLocali.AutoSize = true;
            this.lblLocali.Enabled = false;
            this.lblLocali.Location = new System.Drawing.Point(26, 585);
            this.lblLocali.Name = "lblLocali";
            this.lblLocali.Size = new System.Drawing.Size(91, 21);
            this.lblLocali.TabIndex = 109;
            this.lblLocali.Text = "Localidad:";
            // 
            // txtLocalidad
            // 
            this.txtLocalidad.Enabled = false;
            this.txtLocalidad.Location = new System.Drawing.Point(190, 582);
            this.txtLocalidad.Name = "txtLocalidad";
            this.txtLocalidad.Size = new System.Drawing.Size(264, 27);
            this.txtLocalidad.TabIndex = 14;
            // 
            // txtProv
            // 
            this.txtProv.Enabled = false;
            this.txtProv.Location = new System.Drawing.Point(190, 625);
            this.txtProv.Name = "txtProv";
            this.txtProv.Size = new System.Drawing.Size(264, 27);
            this.txtProv.TabIndex = 15;
            // 
            // lblProv
            // 
            this.lblProv.AutoSize = true;
            this.lblProv.Enabled = false;
            this.lblProv.Location = new System.Drawing.Point(26, 628);
            this.lblProv.Name = "lblProv";
            this.lblProv.Size = new System.Drawing.Size(85, 21);
            this.lblProv.TabIndex = 112;
            this.lblProv.Text = "Provincia:";
            // 
            // chkDirecc
            // 
            this.chkDirecc.AutoSize = true;
            this.chkDirecc.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkDirecc.Checked = true;
            this.chkDirecc.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkDirecc.Location = new System.Drawing.Point(27, 427);
            this.chkDirecc.Name = "chkDirecc";
            this.chkDirecc.Size = new System.Drawing.Size(246, 25);
            this.chkDirecc.TabIndex = 10;
            this.chkDirecc.Text = "Usar dirección Colaborador:";
            this.chkDirecc.UseVisualStyleBackColor = true;
            this.chkDirecc.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(327, 59);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(127, 27);
            this.txtApellido.TabIndex = 2;
            // 
            // txtObraSocial
            // 
            this.txtObraSocial.Location = new System.Drawing.Point(190, 330);
            this.txtObraSocial.Name = "txtObraSocial";
            this.txtObraSocial.Size = new System.Drawing.Size(264, 27);
            this.txtObraSocial.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 333);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 21);
            this.label7.TabIndex = 114;
            this.label7.Text = "Obra Social:";
            // 
            // chkTrabaja
            // 
            this.chkTrabaja.AutoSize = true;
            this.chkTrabaja.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkTrabaja.Checked = true;
            this.chkTrabaja.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkTrabaja.Location = new System.Drawing.Point(27, 376);
            this.chkTrabaja.Name = "chkTrabaja";
            this.chkTrabaja.Size = new System.Drawing.Size(98, 25);
            this.chkTrabaja.TabIndex = 8;
            this.chkTrabaja.Text = "Trabaja?";
            this.chkTrabaja.UseVisualStyleBackColor = true;
            // 
            // chkAportes
            // 
            this.chkAportes.AutoSize = true;
            this.chkAportes.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkAportes.Checked = true;
            this.chkAportes.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAportes.Location = new System.Drawing.Point(190, 376);
            this.chkAportes.Name = "chkAportes";
            this.chkAportes.Size = new System.Drawing.Size(157, 25);
            this.chkAportes.TabIndex = 9;
            this.chkAportes.Text = "Realiza aportes?";
            this.chkAportes.UseVisualStyleBackColor = true;
            // 
            // frmAgregarFam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 823);
            this.Controls.Add(this.chkAportes);
            this.Controls.Add(this.chkTrabaja);
            this.Controls.Add(this.txtObraSocial);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.chkDirecc);
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
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.label6);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(482, 513);
            this.Name = "frmAgregarFam";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nuevo Familiar";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmAgregarFam_FormClosing);
            this.Load += new System.EventHandler(this.frmAgregarFam_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
        private System.Windows.Forms.Label lblError;
        private Controls.BotonPadre btnCancelar;
        private Controls.BotonPadre btnGuardar;
        private System.Windows.Forms.TextBox txtCalle;
        private System.Windows.Forms.Label lblCalle;
        private System.Windows.Forms.TextBox txtNroCalle;
        private System.Windows.Forms.Label lblPiso;
        private System.Windows.Forms.TextBox txtPiso;
        private System.Windows.Forms.TextBox txtDepto;
        private System.Windows.Forms.Label lblLocali;
        private System.Windows.Forms.TextBox txtLocalidad;
        private System.Windows.Forms.TextBox txtProv;
        private System.Windows.Forms.Label lblProv;
        private System.Windows.Forms.CheckBox chkDirecc;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtObraSocial;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox chkTrabaja;
        private System.Windows.Forms.CheckBox chkAportes;
    }
}