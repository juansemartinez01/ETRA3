namespace PresentationA.Colaboradores
{
    partial class frmSalarios
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.txtApellidoBusqueda = new System.Windows.Forms.TextBox();
            this.txtNombreBusqueda = new System.Windows.Forms.TextBox();
            this.txtMontoBusqueda = new System.Windows.Forms.TextBox();
            this.txtLegajoBusqueda = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.txtMontoModificacion = new System.Windows.Forms.TextBox();
            this.txtLegajoColaboradorModificacion = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvSalarios = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalarios)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.iconButton1);
            this.groupBox1.Controls.Add(this.txtApellidoBusqueda);
            this.groupBox1.Controls.Add(this.txtNombreBusqueda);
            this.groupBox1.Controls.Add(this.txtMontoBusqueda);
            this.groupBox1.Controls.Add(this.txtLegajoBusqueda);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(14, 48);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(878, 180);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // iconButton1
            // 
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.Location = new System.Drawing.Point(31, 138);
            this.iconButton1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(210, 35);
            this.iconButton1.TabIndex = 8;
            this.iconButton1.Text = "Aplicar";
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // txtApellidoBusqueda
            // 
            this.txtApellidoBusqueda.Location = new System.Drawing.Point(546, 82);
            this.txtApellidoBusqueda.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtApellidoBusqueda.Name = "txtApellidoBusqueda";
            this.txtApellidoBusqueda.Size = new System.Drawing.Size(286, 32);
            this.txtApellidoBusqueda.TabIndex = 7;
            // 
            // txtNombreBusqueda
            // 
            this.txtNombreBusqueda.Location = new System.Drawing.Point(546, 22);
            this.txtNombreBusqueda.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtNombreBusqueda.Name = "txtNombreBusqueda";
            this.txtNombreBusqueda.Size = new System.Drawing.Size(286, 32);
            this.txtNombreBusqueda.TabIndex = 6;
            // 
            // txtMontoBusqueda
            // 
            this.txtMontoBusqueda.Location = new System.Drawing.Point(120, 82);
            this.txtMontoBusqueda.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtMontoBusqueda.Name = "txtMontoBusqueda";
            this.txtMontoBusqueda.Size = new System.Drawing.Size(286, 32);
            this.txtMontoBusqueda.TabIndex = 5;
            // 
            // txtLegajoBusqueda
            // 
            this.txtLegajoBusqueda.Location = new System.Drawing.Point(120, 22);
            this.txtLegajoBusqueda.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtLegajoBusqueda.Name = "txtLegajoBusqueda";
            this.txtLegajoBusqueda.Size = new System.Drawing.Size(286, 32);
            this.txtLegajoBusqueda.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 85);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 23);
            this.label5.TabIndex = 3;
            this.label5.Text = "Monto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(432, 85);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 23);
            this.label4.TabIndex = 2;
            this.label4.Text = "Apellido";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(432, 25);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 23);
            this.label3.TabIndex = 1;
            this.label3.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 25);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Legajo";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.iconButton2);
            this.groupBox2.Controls.Add(this.txtMontoModificacion);
            this.groupBox2.Controls.Add(this.txtLegajoColaboradorModificacion);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(14, 525);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Size = new System.Drawing.Size(877, 171);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Modificar";
            // 
            // iconButton2
            // 
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButton2.IconColor = System.Drawing.Color.Black;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.Location = new System.Drawing.Point(623, 108);
            this.iconButton2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(210, 35);
            this.iconButton2.TabIndex = 9;
            this.iconButton2.Text = "Modificar";
            this.iconButton2.UseVisualStyleBackColor = true;
            this.iconButton2.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // txtMontoModificacion
            // 
            this.txtMontoModificacion.Location = new System.Drawing.Point(120, 108);
            this.txtMontoModificacion.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtMontoModificacion.Name = "txtMontoModificacion";
            this.txtMontoModificacion.Size = new System.Drawing.Size(286, 32);
            this.txtMontoModificacion.TabIndex = 7;
            // 
            // txtLegajoColaboradorModificacion
            // 
            this.txtLegajoColaboradorModificacion.Location = new System.Drawing.Point(120, 49);
            this.txtLegajoColaboradorModificacion.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtLegajoColaboradorModificacion.Name = "txtLegajoColaboradorModificacion";
            this.txtLegajoColaboradorModificacion.Size = new System.Drawing.Size(286, 32);
            this.txtLegajoColaboradorModificacion.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 108);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 23);
            this.label7.TabIndex = 5;
            this.label7.Text = "Monto";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 49);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 23);
            this.label6.TabIndex = 4;
            this.label6.Text = "Legajo";
            // 
            // dgvSalarios
            // 
            this.dgvSalarios.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSalarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSalarios.BackgroundColor = System.Drawing.Color.White;
            this.dgvSalarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSalarios.Location = new System.Drawing.Point(14, 253);
            this.dgvSalarios.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.dgvSalarios.Name = "dgvSalarios";
            this.dgvSalarios.ReadOnly = true;
            this.dgvSalarios.RowHeadersWidth = 51;
            this.dgvSalarios.RowTemplate.Height = 25;
            this.dgvSalarios.Size = new System.Drawing.Size(877, 264);
            this.dgvSalarios.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(325, 14);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(156, 37);
            this.label8.TabIndex = 5;
            this.label8.Text = "SALARIOS";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // frmSalarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 709);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dgvSalarios);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "frmSalarios";
            this.Text = "frmSalarios";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.TextBox txtApellidoBusqueda;
        private System.Windows.Forms.TextBox txtNombreBusqueda;
        private System.Windows.Forms.TextBox txtMontoBusqueda;
        private System.Windows.Forms.TextBox txtLegajoBusqueda;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private FontAwesome.Sharp.IconButton iconButton2;
        private System.Windows.Forms.TextBox txtMontoModificacion;
        private System.Windows.Forms.TextBox txtLegajoColaboradorModificacion;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvSalarios;
        private System.Windows.Forms.Label label8;
    }
}