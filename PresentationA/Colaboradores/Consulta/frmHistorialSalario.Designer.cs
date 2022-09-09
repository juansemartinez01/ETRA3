namespace PresentationA.Colaboradores.Consulta
{
    partial class frmHistorialSalario
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
            this.dgvSalarios = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpfechaRegistro = new System.Windows.Forms.DateTimePicker();
            this.dtpfechaFin = new System.Windows.Forms.DateTimePicker();
            this.dtpfechaInicio = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtmonto = new System.Windows.Forms.TextBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalarios)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSalarios
            // 
            this.dgvSalarios.AllowUserToOrderColumns = true;
            this.dgvSalarios.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSalarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSalarios.BackgroundColor = System.Drawing.Color.White;
            this.dgvSalarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSalarios.Location = new System.Drawing.Point(527, 103);
            this.dgvSalarios.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.dgvSalarios.Name = "dgvSalarios";
            this.dgvSalarios.ReadOnly = true;
            this.dgvSalarios.RowHeadersWidth = 51;
            this.dgvSalarios.RowTemplate.Height = 25;
            this.dgvSalarios.Size = new System.Drawing.Size(544, 407);
            this.dgvSalarios.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(37, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(296, 37);
            this.label1.TabIndex = 20;
            this.label1.Text = "Historial de Salarios";
            // 
            // dtpfechaRegistro
            // 
            this.dtpfechaRegistro.Location = new System.Drawing.Point(246, 198);
            this.dtpfechaRegistro.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dtpfechaRegistro.Name = "dtpfechaRegistro";
            this.dtpfechaRegistro.Size = new System.Drawing.Size(239, 32);
            this.dtpfechaRegistro.TabIndex = 32;
            // 
            // dtpfechaFin
            // 
            this.dtpfechaFin.Location = new System.Drawing.Point(246, 151);
            this.dtpfechaFin.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dtpfechaFin.Name = "dtpfechaFin";
            this.dtpfechaFin.Size = new System.Drawing.Size(239, 32);
            this.dtpfechaFin.TabIndex = 31;
            // 
            // dtpfechaInicio
            // 
            this.dtpfechaInicio.Location = new System.Drawing.Point(246, 103);
            this.dtpfechaInicio.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dtpfechaInicio.Name = "dtpfechaInicio";
            this.dtpfechaInicio.Size = new System.Drawing.Size(239, 32);
            this.dtpfechaInicio.TabIndex = 30;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(38, 103);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(165, 23);
            this.label6.TabIndex = 26;
            this.label6.Text = "Fecha de Inicio:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 151);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 23);
            this.label5.TabIndex = 25;
            this.label5.Text = "Fecha Fin:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 198);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(191, 23);
            this.label4.TabIndex = 24;
            this.label4.Text = "Fecha de Registro:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 257);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 23);
            this.label3.TabIndex = 33;
            this.label3.Text = "Monto:";
            // 
            // txtmonto
            // 
            this.txtmonto.Location = new System.Drawing.Point(246, 254);
            this.txtmonto.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtmonto.Name = "txtmonto";
            this.txtmonto.Size = new System.Drawing.Size(239, 32);
            this.txtmonto.TabIndex = 34;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(371, 481);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(115, 30);
            this.btnEliminar.TabIndex = 37;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(43, 481);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(115, 30);
            this.btnAgregar.TabIndex = 36;
            this.btnAgregar.Text = "Confirmar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(210, 481);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(115, 30);
            this.btnModificar.TabIndex = 35;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            // 
            // frmHistorialSalario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1130, 686);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.txtmonto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpfechaRegistro);
            this.Controls.Add(this.dtpfechaFin);
            this.Controls.Add(this.dtpfechaInicio);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvSalarios);
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "frmHistorialSalario";
            this.Text = "frmHistorialSalario";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSalarios;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpfechaRegistro;
        private System.Windows.Forms.DateTimePicker dtpfechaFin;
        private System.Windows.Forms.DateTimePicker dtpfechaInicio;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtmonto;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnModificar;
    }
}