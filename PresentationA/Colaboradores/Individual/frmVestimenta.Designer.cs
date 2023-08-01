namespace PresentationA.Colaboradores.Individual
{
    partial class frmVestimenta
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
            this.txtPantalon = new System.Windows.Forms.NumericUpDown();
            this.txtCalzado = new System.Windows.Forms.NumericUpDown();
            this.lblError = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRemera = new System.Windows.Forms.TextBox();
            this.cmbSucursal = new System.Windows.Forms.ComboBox();
            this.cmbArea = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtBuzo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCancelar = new PresentationA.Controls.BotonPadre();
            this.btnGuardar = new PresentationA.Controls.BotonPadre();
            ((System.ComponentModel.ISupportInitialize)(this.txtPantalon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCalzado)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPantalon
            // 
            this.txtPantalon.Enabled = false;
            this.txtPantalon.Location = new System.Drawing.Point(187, 166);
            this.txtPantalon.Name = "txtPantalon";
            this.txtPantalon.Size = new System.Drawing.Size(137, 27);
            this.txtPantalon.TabIndex = 3;
            // 
            // txtCalzado
            // 
            this.txtCalzado.Enabled = false;
            this.txtCalzado.Location = new System.Drawing.Point(187, 292);
            this.txtCalzado.Name = "txtCalzado";
            this.txtCalzado.Size = new System.Drawing.Size(137, 27);
            this.txtCalzado.TabIndex = 6;
            // 
            // lblError
            // 
            this.lblError.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.lblError.ForeColor = System.Drawing.Color.DimGray;
            this.lblError.Image = global::PresentationA.Properties.Resources.kisspng_exclamation_mark_clip_art_vector_graphics_computer_5ced29986ef952_9605616015590465524546__1___1_;
            this.lblError.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblError.Location = new System.Drawing.Point(24, 357);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(300, 45);
            this.lblError.TabIndex = 188;
            this.lblError.Text = "Error";
            this.lblError.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 294);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 21);
            this.label6.TabIndex = 187;
            this.label6.Text = "Calzado:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 253);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 21);
            this.label3.TabIndex = 186;
            this.label3.Text = "Remera:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 212);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 21);
            this.label1.TabIndex = 185;
            this.label1.Text = "Buzo/Campera:";
            // 
            // txtRemera
            // 
            this.txtRemera.Enabled = false;
            this.txtRemera.Location = new System.Drawing.Point(187, 250);
            this.txtRemera.Name = "txtRemera";
            this.txtRemera.Size = new System.Drawing.Size(137, 27);
            this.txtRemera.TabIndex = 5;
            this.txtRemera.TextChanged += new System.EventHandler(this.txtRemera_TextChanged);
            // 
            // cmbSucursal
            // 
            this.cmbSucursal.Enabled = false;
            this.cmbSucursal.FormattingEnabled = true;
            this.cmbSucursal.Location = new System.Drawing.Point(187, 69);
            this.cmbSucursal.Name = "cmbSucursal";
            this.cmbSucursal.Size = new System.Drawing.Size(137, 29);
            this.cmbSucursal.TabIndex = 1;
            // 
            // cmbArea
            // 
            this.cmbArea.Enabled = false;
            this.cmbArea.FormattingEnabled = true;
            this.cmbArea.Location = new System.Drawing.Point(187, 120);
            this.cmbArea.Name = "cmbArea";
            this.cmbArea.Size = new System.Drawing.Size(137, 29);
            this.cmbArea.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 123);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 21);
            this.label8.TabIndex = 184;
            this.label8.Text = "Area:";
            // 
            // txtBuzo
            // 
            this.txtBuzo.Enabled = false;
            this.txtBuzo.Location = new System.Drawing.Point(187, 209);
            this.txtBuzo.Name = "txtBuzo";
            this.txtBuzo.Size = new System.Drawing.Size(137, 27);
            this.txtBuzo.TabIndex = 4;
            this.txtBuzo.TextChanged += new System.EventHandler(this.txtBuzo_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 21);
            this.label2.TabIndex = 183;
            this.label2.Text = "Pantalon:";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(23, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 26);
            this.label4.TabIndex = 182;
            this.label4.Text = "Sucursal";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(17, 9);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 28);
            this.label5.TabIndex = 189;
            this.label5.Text = "VESTIMENTA";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
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
            this.btnCancelar.Location = new System.Drawing.Point(187, 424);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(131, 37);
            this.btnCancelar.TabIndex = 191;
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
            this.btnGuardar.IconChar = FontAwesome.Sharp.IconChar.Pen;
            this.btnGuardar.IconColor = System.Drawing.Color.White;
            this.btnGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGuardar.IconSize = 30;
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(33, 424);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(123, 37);
            this.btnGuardar.TabIndex = 190;
            this.btnGuardar.Text = "Modificar";
            this.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // frmVestimenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 520);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPantalon);
            this.Controls.Add(this.txtCalzado);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtRemera);
            this.Controls.Add(this.cmbSucursal);
            this.Controls.Add(this.cmbArea);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtBuzo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Name = "frmVestimenta";
            this.Text = "frmVestimenta";
            ((System.ComponentModel.ISupportInitialize)(this.txtPantalon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCalzado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown txtPantalon;
        private System.Windows.Forms.NumericUpDown txtCalzado;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRemera;
        private System.Windows.Forms.ComboBox cmbSucursal;
        private System.Windows.Forms.ComboBox cmbArea;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtBuzo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private Controls.BotonPadre btnCancelar;
        private Controls.BotonPadre btnGuardar;
    }
}