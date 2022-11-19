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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpfechaFin = new System.Windows.Forms.DateTimePicker();
            this.dtpfechaInicio = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtmonto = new System.Windows.Forms.TextBox();
            this.dgvSalarios = new PresentationA.Controls.DataGridPadre();
            this.monto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaDeInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaFin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAgregar = new PresentationA.Controls.BotonPadre();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalarios)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(31, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 28);
            this.label1.TabIndex = 20;
            this.label1.Text = "Historial de Salarios";
            // 
            // dtpfechaFin
            // 
            this.dtpfechaFin.Location = new System.Drawing.Point(205, 138);
            this.dtpfechaFin.Name = "dtpfechaFin";
            this.dtpfechaFin.Size = new System.Drawing.Size(200, 27);
            this.dtpfechaFin.TabIndex = 31;
            // 
            // dtpfechaInicio
            // 
            this.dtpfechaInicio.Location = new System.Drawing.Point(205, 94);
            this.dtpfechaInicio.Name = "dtpfechaInicio";
            this.dtpfechaInicio.Size = new System.Drawing.Size(200, 27);
            this.dtpfechaInicio.TabIndex = 30;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 94);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 21);
            this.label6.TabIndex = 26;
            this.label6.Text = "Fecha de Inicio:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(77, 138);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 21);
            this.label5.TabIndex = 25;
            this.label5.Text = "Fecha Fin:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(102, 240);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 21);
            this.label3.TabIndex = 33;
            this.label3.Text = "Monto:";
            // 
            // txtmonto
            // 
            this.txtmonto.Location = new System.Drawing.Point(205, 240);
            this.txtmonto.Name = "txtmonto";
            this.txtmonto.Size = new System.Drawing.Size(200, 27);
            this.txtmonto.TabIndex = 34;
            this.txtmonto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtmonto_KeyPress);
            // 
            // dgvSalarios
            // 
            this.dgvSalarios.AllowUserToAddRows = false;
            this.dgvSalarios.AllowUserToDeleteRows = false;
            this.dgvSalarios.AllowUserToOrderColumns = true;
            this.dgvSalarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSalarios.BackgroundColor = System.Drawing.Color.White;
            this.dgvSalarios.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvSalarios.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(103)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(103)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSalarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSalarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSalarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.monto,
            this.fechaDeInicio,
            this.fechaFin});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(43)))), ((int)(((byte)(26)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSalarios.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSalarios.EnableHeadersVisualStyles = false;
            this.dgvSalarios.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.dgvSalarios.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(103)))), ((int)(((byte)(34)))));
            this.dgvSalarios.Location = new System.Drawing.Point(532, 94);
            this.dgvSalarios.Name = "dgvSalarios";
            this.dgvSalarios.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(103)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(43)))), ((int)(((byte)(26)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSalarios.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvSalarios.RowHeadersWidth = 51;
            this.dgvSalarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSalarios.Size = new System.Drawing.Size(453, 326);
            this.dgvSalarios.TabIndex = 41;
            this.dgvSalarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSalarios_CellClick);
            this.dgvSalarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSalarios_CellClick);
            this.dgvSalarios.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSalarios_CellClick);
            this.dgvSalarios.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSalarios_CellClick);
            // 
            // monto
            // 
            this.monto.HeaderText = "Monto";
            this.monto.MinimumWidth = 6;
            this.monto.Name = "monto";
            this.monto.ReadOnly = true;
            // 
            // fechaDeInicio
            // 
            this.fechaDeInicio.HeaderText = "Fecha de Inicio";
            this.fechaDeInicio.MinimumWidth = 6;
            this.fechaDeInicio.Name = "fechaDeInicio";
            this.fechaDeInicio.ReadOnly = true;
            // 
            // fechaFin
            // 
            this.fechaFin.HeaderText = "Fecha Fin";
            this.fechaFin.MinimumWidth = 6;
            this.fechaFin.Name = "fechaFin";
            this.fechaFin.ReadOnly = true;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(166)))), ((int)(((byte)(26)))));
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.btnAgregar.IconColor = System.Drawing.Color.White;
            this.btnAgregar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAgregar.IconSize = 30;
            this.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregar.Location = new System.Drawing.Point(282, 383);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(122, 37);
            this.btnAgregar.TabIndex = 48;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // frmHistorialSalario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1136, 562);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dgvSalarios);
            this.Controls.Add(this.txtmonto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpfechaFin);
            this.Controls.Add(this.dtpfechaInicio);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Name = "frmHistorialSalario";
            this.Text = "frmHistorialSalario";
            this.Load += new System.EventHandler(this.frmHistorialSalario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpfechaFin;
        private System.Windows.Forms.DateTimePicker dtpfechaInicio;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtmonto;
        private Controls.DataGridPadre dgvSalarios;
        private System.Windows.Forms.DataGridViewTextBoxColumn monto;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDeInicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaFin;
        private Controls.BotonPadre btnAgregar;
    }
}