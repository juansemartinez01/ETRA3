﻿namespace PresentationA.Colaboradores.TodosFamiliares
{
    partial class frmTodosAgregarFamiliar
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
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.ckbDirecc = new System.Windows.Forms.CheckBox();
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
            this.lblError = new System.Windows.Forms.Label();
            this.btnCancelar = new PresentationA.Controls.BotonPadre();
            this.btnGuardar = new PresentationA.Controls.BotonPadre();
            this.label6 = new System.Windows.Forms.Label();
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
            this.cmbLegajo = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(345, 119);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(127, 27);
            this.txtApellido.TabIndex = 3;
            this.txtApellido.TextChanged += new System.EventHandler(this.txt_TextChanged);
            // 
            // ckbDirecc
            // 
            this.ckbDirecc.AutoSize = true;
            this.ckbDirecc.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ckbDirecc.Checked = true;
            this.ckbDirecc.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbDirecc.Location = new System.Drawing.Point(43, 387);
            this.ckbDirecc.Name = "ckbDirecc";
            this.ckbDirecc.Size = new System.Drawing.Size(246, 25);
            this.ckbDirecc.TabIndex = 8;
            this.ckbDirecc.Text = "Usar dirección Colaborador:";
            this.ckbDirecc.UseVisualStyleBackColor = true;
            this.ckbDirecc.CheckedChanged += new System.EventHandler(this.ckbDirecc_CheckedChanged);
            // 
            // txtProv
            // 
            this.txtProv.Enabled = false;
            this.txtProv.Location = new System.Drawing.Point(208, 575);
            this.txtProv.Name = "txtProv";
            this.txtProv.Size = new System.Drawing.Size(264, 27);
            this.txtProv.TabIndex = 127;
            this.txtProv.TextChanged += new System.EventHandler(this.txt_TextChanged);
            // 
            // lblProv
            // 
            this.lblProv.AutoSize = true;
            this.lblProv.Enabled = false;
            this.lblProv.Location = new System.Drawing.Point(44, 578);
            this.lblProv.Name = "lblProv";
            this.lblProv.Size = new System.Drawing.Size(85, 21);
            this.lblProv.TabIndex = 138;
            this.lblProv.Text = "Provincia:";
            // 
            // txtLocalidad
            // 
            this.txtLocalidad.Enabled = false;
            this.txtLocalidad.Location = new System.Drawing.Point(208, 532);
            this.txtLocalidad.Name = "txtLocalidad";
            this.txtLocalidad.Size = new System.Drawing.Size(264, 27);
            this.txtLocalidad.TabIndex = 126;
            this.txtLocalidad.TextChanged += new System.EventHandler(this.txt_TextChanged);
            // 
            // txtDepto
            // 
            this.txtDepto.Enabled = false;
            this.txtDepto.Location = new System.Drawing.Point(345, 480);
            this.txtDepto.Name = "txtDepto";
            this.txtDepto.Size = new System.Drawing.Size(127, 27);
            this.txtDepto.TabIndex = 13;
            this.txtDepto.TextChanged += new System.EventHandler(this.txt_TextChanged);
            // 
            // lblLocali
            // 
            this.lblLocali.AutoSize = true;
            this.lblLocali.Enabled = false;
            this.lblLocali.Location = new System.Drawing.Point(44, 535);
            this.lblLocali.Name = "lblLocali";
            this.lblLocali.Size = new System.Drawing.Size(91, 21);
            this.lblLocali.TabIndex = 137;
            this.lblLocali.Text = "Localidad:";
            // 
            // txtPiso
            // 
            this.txtPiso.Enabled = false;
            this.txtPiso.Location = new System.Drawing.Point(208, 480);
            this.txtPiso.Name = "txtPiso";
            this.txtPiso.Size = new System.Drawing.Size(127, 27);
            this.txtPiso.TabIndex = 13;
            this.txtPiso.TextChanged += new System.EventHandler(this.txt_TextChanged);
            // 
            // txtNroCalle
            // 
            this.txtNroCalle.Enabled = false;
            this.txtNroCalle.Location = new System.Drawing.Point(345, 428);
            this.txtNroCalle.Name = "txtNroCalle";
            this.txtNroCalle.Size = new System.Drawing.Size(127, 27);
            this.txtNroCalle.TabIndex = 12;
            this.txtNroCalle.TextChanged += new System.EventHandler(this.txt_TextChanged);
            // 
            // lblPiso
            // 
            this.lblPiso.Enabled = false;
            this.lblPiso.Location = new System.Drawing.Point(44, 473);
            this.lblPiso.Name = "lblPiso";
            this.lblPiso.Size = new System.Drawing.Size(158, 44);
            this.lblPiso.TabIndex = 136;
            this.lblPiso.Text = "Piso y Departamento:";
            // 
            // txtCalle
            // 
            this.txtCalle.Enabled = false;
            this.txtCalle.Location = new System.Drawing.Point(208, 428);
            this.txtCalle.Name = "txtCalle";
            this.txtCalle.Size = new System.Drawing.Size(127, 27);
            this.txtCalle.TabIndex = 11;
            this.txtCalle.TextChanged += new System.EventHandler(this.txt_TextChanged);
            // 
            // lblCalle
            // 
            this.lblCalle.AutoSize = true;
            this.lblCalle.Enabled = false;
            this.lblCalle.Location = new System.Drawing.Point(44, 431);
            this.lblCalle.Name = "lblCalle";
            this.lblCalle.Size = new System.Drawing.Size(130, 21);
            this.lblCalle.TabIndex = 135;
            this.lblCalle.Text = "Calle y número:";
            // 
            // lblError
            // 
            this.lblError.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.lblError.ForeColor = System.Drawing.Color.DimGray;
            this.lblError.Image = global::PresentationA.Properties.Resources.kisspng_exclamation_mark_clip_art_vector_graphics_computer_5ced29986ef952_9605616015590465524546__1___1_;
            this.lblError.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblError.Location = new System.Drawing.Point(45, 627);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(427, 45);
            this.lblError.TabIndex = 134;
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
            this.btnCancelar.Location = new System.Drawing.Point(273, 688);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(131, 37);
            this.btnCancelar.TabIndex = 10;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click_1);
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
            this.btnGuardar.Location = new System.Drawing.Point(121, 688);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(123, 37);
            this.btnGuardar.TabIndex = 9;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(163, 9);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(187, 28);
            this.label6.TabIndex = 133;
            this.label6.Text = "Nuevo Familiar";
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(208, 337);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(264, 27);
            this.txtDni.TabIndex = 8;
            this.txtDni.TextChanged += new System.EventHandler(this.txt_TextChanged);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(208, 119);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(112, 27);
            this.txtNombre.TabIndex = 2;
            this.txtNombre.TextChanged += new System.EventHandler(this.txt_TextChanged);
            // 
            // dtpFechaNac
            // 
            this.dtpFechaNac.Location = new System.Drawing.Point(208, 216);
            this.dtpFechaNac.Name = "dtpFechaNac";
            this.dtpFechaNac.Size = new System.Drawing.Size(264, 27);
            this.dtpFechaNac.TabIndex = 5;
            this.dtpFechaNac.ValueChanged += new System.EventHandler(this.txt_TextChanged);
            // 
            // cmbEscolariazacion
            // 
            this.cmbEscolariazacion.FormattingEnabled = true;
            this.cmbEscolariazacion.Location = new System.Drawing.Point(208, 279);
            this.cmbEscolariazacion.Name = "cmbEscolariazacion";
            this.cmbEscolariazacion.Size = new System.Drawing.Size(264, 29);
            this.cmbEscolariazacion.TabIndex = 6;
            this.cmbEscolariazacion.SelectedIndexChanged += new System.EventHandler(this.txt_TextChanged);
            // 
            // cmbParentezco
            // 
            this.cmbParentezco.FormattingEnabled = true;
            this.cmbParentezco.Location = new System.Drawing.Point(208, 167);
            this.cmbParentezco.Name = "cmbParentezco";
            this.cmbParentezco.Size = new System.Drawing.Size(264, 29);
            this.cmbParentezco.TabIndex = 4;
            this.cmbParentezco.SelectedIndexChanged += new System.EventHandler(this.txt_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 340);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 21);
            this.label5.TabIndex = 132;
            this.label5.Text = "DNI:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 21);
            this.label4.TabIndex = 131;
            this.label4.Text = "Parentezco:";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(44, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 58);
            this.label3.TabIndex = 130;
            this.label3.Text = "Fecha de Nacimiento:";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(44, 279);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 50);
            this.label2.TabIndex = 129;
            this.label2.Text = "Nivel de Escolarización:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 21);
            this.label1.TabIndex = 128;
            this.label1.Text = "Nombre y Apellido:";
            // 
            // cmbLegajo
            // 
            this.cmbLegajo.FormattingEnabled = true;
            this.cmbLegajo.Location = new System.Drawing.Point(208, 59);
            this.cmbLegajo.Name = "cmbLegajo";
            this.cmbLegajo.Size = new System.Drawing.Size(264, 29);
            this.cmbLegajo.TabIndex = 1;
            this.cmbLegajo.SelectedIndexChanged += new System.EventHandler(this.txt_TextChanged);
            this.cmbLegajo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmb_KeyPress);
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(44, 59);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(127, 50);
            this.label7.TabIndex = 140;
            this.label7.Text = "Legajo Colaborador:";
            // 
            // frmTodosAgregarFamiliar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 749);
            this.Controls.Add(this.cmbLegajo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.ckbDirecc);
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
            this.Name = "frmTodosAgregarFamiliar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Familiar";
            this.Load += new System.EventHandler(this.frmTodosAgregarFamiliar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.CheckBox ckbDirecc;
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
        private System.Windows.Forms.Label lblError;
        private Controls.BotonPadre btnCancelar;
        private Controls.BotonPadre btnGuardar;
        private System.Windows.Forms.Label label6;
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
        private System.Windows.Forms.ComboBox cmbLegajo;
        private System.Windows.Forms.Label label7;
    }
}