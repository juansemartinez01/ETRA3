namespace PresentationA.Colaboradores.Eventos
{
    partial class frmNuevoEvento
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
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbColaboradores2 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker4 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.cmbTipoEvento2 = new System.Windows.Forms.ComboBox();
            this.txtDescripcion = new System.Windows.Forms.RichTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnGuardar = new PresentationA.Controls.BotonPadre();
            this.btnCancelar = new PresentationA.Controls.BotonPadre();
            this.lblError = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAgregarArchivo = new PresentationA.Controls.BotonPadre();
            this.cmbTipoMultimedia = new System.Windows.Forms.ComboBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(167, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 30);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nuevo Evento";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 91);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(114, 21);
            this.label10.TabIndex = 27;
            this.label10.Text = "Colaborador:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 130);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 21);
            this.label8.TabIndex = 26;
            this.label8.Text = "Evento:";
            // 
            // cmbColaboradores2
            // 
            this.cmbColaboradores2.FormattingEnabled = true;
            this.cmbColaboradores2.Location = new System.Drawing.Point(172, 88);
            this.cmbColaboradores2.Margin = new System.Windows.Forms.Padding(4);
            this.cmbColaboradores2.Name = "cmbColaboradores2";
            this.cmbColaboradores2.Size = new System.Drawing.Size(286, 29);
            this.cmbColaboradores2.TabIndex = 25;
            this.cmbColaboradores2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmb_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 176);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(133, 21);
            this.label7.TabIndex = 24;
            this.label7.Text = "Fecha de Inicio:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 218);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 21);
            this.label5.TabIndex = 23;
            this.label5.Text = "Fecha Fin:";
            // 
            // dateTimePicker4
            // 
            this.dateTimePicker4.Location = new System.Drawing.Point(172, 171);
            this.dateTimePicker4.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker4.Name = "dateTimePicker4";
            this.dateTimePicker4.Size = new System.Drawing.Size(286, 27);
            this.dateTimePicker4.TabIndex = 22;
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.Location = new System.Drawing.Point(172, 213);
            this.dateTimePicker3.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(286, 27);
            this.dateTimePicker3.TabIndex = 21;
            // 
            // cmbTipoEvento2
            // 
            this.cmbTipoEvento2.FormattingEnabled = true;
            this.cmbTipoEvento2.Location = new System.Drawing.Point(172, 127);
            this.cmbTipoEvento2.Margin = new System.Windows.Forms.Padding(4);
            this.cmbTipoEvento2.Name = "cmbTipoEvento2";
            this.cmbTipoEvento2.Size = new System.Drawing.Size(286, 29);
            this.cmbTipoEvento2.TabIndex = 20;
            this.cmbTipoEvento2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmb_KeyPress);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(172, 276);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(286, 95);
            this.txtDescripcion.TabIndex = 28;
            this.txtDescripcion.Text = "";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 276);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(104, 21);
            this.label9.TabIndex = 29;
            this.label9.Text = "Descripción:";
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
            this.btnGuardar.Location = new System.Drawing.Point(92, 560);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(123, 37);
            this.btnGuardar.TabIndex = 99;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
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
            this.btnCancelar.Location = new System.Drawing.Point(258, 560);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(131, 37);
            this.btnCancelar.TabIndex = 100;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblError
            // 
            this.lblError.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.lblError.ForeColor = System.Drawing.Color.DimGray;
            this.lblError.Image = global::PresentationA.Properties.Resources.kisspng_exclamation_mark_clip_art_vector_graphics_computer_5ced29986ef952_9605616015590465524546__1___1_;
            this.lblError.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblError.Location = new System.Drawing.Point(16, 497);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(442, 52);
            this.lblError.TabIndex = 101;
            this.lblError.Text = "Error";
            this.lblError.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 390);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 21);
            this.label2.TabIndex = 102;
            this.label2.Text = "Tipo de Archivo:";
            // 
            // btnAgregarArchivo
            // 
            this.btnAgregarArchivo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(166)))), ((int)(((byte)(26)))));
            this.btnAgregarArchivo.FlatAppearance.BorderSize = 0;
            this.btnAgregarArchivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarArchivo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnAgregarArchivo.ForeColor = System.Drawing.Color.White;
            this.btnAgregarArchivo.IconChar = FontAwesome.Sharp.IconChar.FileUpload;
            this.btnAgregarArchivo.IconColor = System.Drawing.Color.White;
            this.btnAgregarArchivo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAgregarArchivo.IconSize = 30;
            this.btnAgregarArchivo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarArchivo.Location = new System.Drawing.Point(172, 433);
            this.btnAgregarArchivo.Margin = new System.Windows.Forms.Padding(0);
            this.btnAgregarArchivo.Name = "btnAgregarArchivo";
            this.btnAgregarArchivo.Size = new System.Drawing.Size(286, 40);
            this.btnAgregarArchivo.TabIndex = 103;
            this.btnAgregarArchivo.Text = "Agregar archivo";
            this.btnAgregarArchivo.UseVisualStyleBackColor = false;
            this.btnAgregarArchivo.Click += new System.EventHandler(this.btnAgregarArchivo_Click);
            // 
            // cmbTipoMultimedia
            // 
            this.cmbTipoMultimedia.FormattingEnabled = true;
            this.cmbTipoMultimedia.Location = new System.Drawing.Point(172, 387);
            this.cmbTipoMultimedia.Margin = new System.Windows.Forms.Padding(0);
            this.cmbTipoMultimedia.Name = "cmbTipoMultimedia";
            this.cmbTipoMultimedia.Size = new System.Drawing.Size(286, 29);
            this.cmbTipoMultimedia.TabIndex = 104;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // frmNuevoEvento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 609);
            this.Controls.Add(this.cmbTipoMultimedia);
            this.Controls.Add(this.btnAgregarArchivo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cmbColaboradores2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateTimePicker4);
            this.Controls.Add(this.dateTimePicker3);
            this.Controls.Add(this.cmbTipoEvento2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmNuevoEvento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nuevo Evento";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbColaboradores2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker4;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.Windows.Forms.ComboBox cmbTipoEvento2;
        private System.Windows.Forms.RichTextBox txtDescripcion;
        private System.Windows.Forms.Label label9;
        private Controls.BotonPadre btnGuardar;
        private Controls.BotonPadre btnCancelar;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Label label2;
        private Controls.BotonPadre btnAgregarArchivo;
        private System.Windows.Forms.ComboBox cmbTipoMultimedia;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}