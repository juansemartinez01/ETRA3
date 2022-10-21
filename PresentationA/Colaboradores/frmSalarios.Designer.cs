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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbFiltroCargo = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.btnExportar = new PresentationA.Controls.BotonPadre();
            this.btnAplicar = new PresentationA.Controls.BotonPadre();
            this.txtApellidoBusqueda = new System.Windows.Forms.TextBox();
            this.txtNombreBusqueda = new System.Windows.Forms.TextBox();
            this.txtMontoBusqueda = new System.Windows.Forms.TextBox();
            this.txtLegajoBusqueda = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnPorcentaje = new PresentationA.Controls.BotonPadre();
            this.cmbCargoPorcentaje = new System.Windows.Forms.ComboBox();
            this.txtPorcentaje = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnModificarSalariosCargo = new PresentationA.Controls.BotonPadre();
            this.txtMontoModificarSalarioCargo = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbModificarSalarioCargo = new System.Windows.Forms.ComboBox();
            this.botonPadre1 = new PresentationA.Controls.BotonPadre();
            this.txtMontoModificacion = new System.Windows.Forms.TextBox();
            this.txtLegajoColaboradorModificacion = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dgvSalarios = new PresentationA.Controls.DataGridPadre();
            this.legajo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalarios)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbFiltroCargo);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.btnExportar);
            this.groupBox1.Controls.Add(this.btnAplicar);
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
            this.groupBox1.Size = new System.Drawing.Size(1415, 180);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // cmbFiltroCargo
            // 
            this.cmbFiltroCargo.FormattingEnabled = true;
            this.cmbFiltroCargo.Location = new System.Drawing.Point(985, 85);
            this.cmbFiltroCargo.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cmbFiltroCargo.Name = "cmbFiltroCargo";
            this.cmbFiltroCargo.Size = new System.Drawing.Size(218, 31);
            this.cmbFiltroCargo.TabIndex = 24;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(898, 85);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(72, 23);
            this.label14.TabIndex = 24;
            this.label14.Text = "Cargo";
            // 
            // btnExportar
            // 
            this.btnExportar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(166)))), ((int)(((byte)(26)))));
            this.btnExportar.FlatAppearance.BorderSize = 0;
            this.btnExportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnExportar.ForeColor = System.Drawing.Color.White;
            this.btnExportar.IconChar = FontAwesome.Sharp.IconChar.FileExcel;
            this.btnExportar.IconColor = System.Drawing.Color.White;
            this.btnExportar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnExportar.IconSize = 30;
            this.btnExportar.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnExportar.Location = new System.Drawing.Point(620, 129);
            this.btnExportar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(212, 44);
            this.btnExportar.TabIndex = 11;
            this.btnExportar.Text = "Exportar a Excel";
            this.btnExportar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExportar.UseVisualStyleBackColor = false;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // btnAplicar
            // 
            this.btnAplicar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(166)))), ((int)(((byte)(26)))));
            this.btnAplicar.FlatAppearance.BorderSize = 0;
            this.btnAplicar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAplicar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnAplicar.ForeColor = System.Drawing.Color.White;
            this.btnAplicar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnAplicar.IconColor = System.Drawing.Color.Black;
            this.btnAplicar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAplicar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAplicar.Location = new System.Drawing.Point(31, 129);
            this.btnAplicar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAplicar.Name = "btnAplicar";
            this.btnAplicar.Size = new System.Drawing.Size(180, 44);
            this.btnAplicar.TabIndex = 10;
            this.btnAplicar.Text = "Aplicar";
            this.btnAplicar.UseVisualStyleBackColor = false;
            this.btnAplicar.Click += new System.EventHandler(this.btnAplicar_Click);
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
            this.txtMontoBusqueda.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMontoBusqueda_KeyPress);
            // 
            // txtLegajoBusqueda
            // 
            this.txtLegajoBusqueda.Location = new System.Drawing.Point(120, 22);
            this.txtLegajoBusqueda.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtLegajoBusqueda.Name = "txtLegajoBusqueda";
            this.txtLegajoBusqueda.Size = new System.Drawing.Size(286, 32);
            this.txtLegajoBusqueda.TabIndex = 4;
            this.txtLegajoBusqueda.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLegajoBusqueda_KeyPress);
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
            this.groupBox2.Controls.Add(this.btnPorcentaje);
            this.groupBox2.Controls.Add(this.cmbCargoPorcentaje);
            this.groupBox2.Controls.Add(this.txtPorcentaje);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.btnModificarSalariosCargo);
            this.groupBox2.Controls.Add(this.txtMontoModificarSalarioCargo);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.cmbModificarSalarioCargo);
            this.groupBox2.Controls.Add(this.botonPadre1);
            this.groupBox2.Controls.Add(this.txtMontoModificacion);
            this.groupBox2.Controls.Add(this.txtLegajoColaboradorModificacion);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(14, 525);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Size = new System.Drawing.Size(1414, 171);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Modificar";
            // 
            // btnPorcentaje
            // 
            this.btnPorcentaje.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(166)))), ((int)(((byte)(26)))));
            this.btnPorcentaje.FlatAppearance.BorderSize = 0;
            this.btnPorcentaje.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPorcentaje.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnPorcentaje.ForeColor = System.Drawing.Color.White;
            this.btnPorcentaje.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnPorcentaje.IconColor = System.Drawing.Color.Black;
            this.btnPorcentaje.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPorcentaje.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPorcentaje.Location = new System.Drawing.Point(1193, 104);
            this.btnPorcentaje.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnPorcentaje.Name = "btnPorcentaje";
            this.btnPorcentaje.Size = new System.Drawing.Size(180, 44);
            this.btnPorcentaje.TabIndex = 23;
            this.btnPorcentaje.Text = "Modificar";
            this.btnPorcentaje.UseVisualStyleBackColor = false;
            this.btnPorcentaje.Click += new System.EventHandler(this.btnPorcentaje_Click);
            // 
            // cmbCargoPorcentaje
            // 
            this.cmbCargoPorcentaje.FormattingEnabled = true;
            this.cmbCargoPorcentaje.Location = new System.Drawing.Point(1042, 49);
            this.cmbCargoPorcentaje.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cmbCargoPorcentaje.Name = "cmbCargoPorcentaje";
            this.cmbCargoPorcentaje.Size = new System.Drawing.Size(218, 31);
            this.cmbCargoPorcentaje.TabIndex = 22;
            // 
            // txtPorcentaje
            // 
            this.txtPorcentaje.Location = new System.Drawing.Point(1058, 108);
            this.txtPorcentaje.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtPorcentaje.Name = "txtPorcentaje";
            this.txtPorcentaje.Size = new System.Drawing.Size(106, 32);
            this.txtPorcentaje.TabIndex = 21;
            this.txtPorcentaje.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPorcentaje_KeyPress);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(944, 112);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(116, 23);
            this.label13.TabIndex = 20;
            this.label13.Text = "Porcentaje";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(959, 51);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(72, 23);
            this.label12.TabIndex = 19;
            this.label12.Text = "Cargo";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(959, 18);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(347, 23);
            this.label11.TabIndex = 18;
            this.label11.Text = "Modificar por porcentaje un cargo";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(482, 18);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(266, 23);
            this.label10.TabIndex = 17;
            this.label10.Text = "Modificar salario de cargo";
            // 
            // btnModificarSalariosCargo
            // 
            this.btnModificarSalariosCargo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(166)))), ((int)(((byte)(26)))));
            this.btnModificarSalariosCargo.FlatAppearance.BorderSize = 0;
            this.btnModificarSalariosCargo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarSalariosCargo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnModificarSalariosCargo.ForeColor = System.Drawing.Color.White;
            this.btnModificarSalariosCargo.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnModificarSalariosCargo.IconColor = System.Drawing.Color.Black;
            this.btnModificarSalariosCargo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnModificarSalariosCargo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificarSalariosCargo.Location = new System.Drawing.Point(756, 101);
            this.btnModificarSalariosCargo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnModificarSalariosCargo.Name = "btnModificarSalariosCargo";
            this.btnModificarSalariosCargo.Size = new System.Drawing.Size(180, 44);
            this.btnModificarSalariosCargo.TabIndex = 16;
            this.btnModificarSalariosCargo.Text = "Modificar";
            this.btnModificarSalariosCargo.UseVisualStyleBackColor = false;
            this.btnModificarSalariosCargo.Click += new System.EventHandler(this.btnModificarSalariosCargo_Click);
            // 
            // txtMontoModificarSalarioCargo
            // 
            this.txtMontoModificarSalarioCargo.Location = new System.Drawing.Point(530, 110);
            this.txtMontoModificarSalarioCargo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtMontoModificarSalarioCargo.Name = "txtMontoModificarSalarioCargo";
            this.txtMontoModificarSalarioCargo.Size = new System.Drawing.Size(218, 32);
            this.txtMontoModificarSalarioCargo.TabIndex = 15;
            this.txtMontoModificarSalarioCargo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMontoModificarSalarioCargo_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(456, 112);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 23);
            this.label9.TabIndex = 14;
            this.label9.Text = "Monto";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(452, 51);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 23);
            this.label1.TabIndex = 13;
            this.label1.Text = "Cargo";
            // 
            // cmbModificarSalarioCargo
            // 
            this.cmbModificarSalarioCargo.FormattingEnabled = true;
            this.cmbModificarSalarioCargo.Location = new System.Drawing.Point(530, 51);
            this.cmbModificarSalarioCargo.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cmbModificarSalarioCargo.Name = "cmbModificarSalarioCargo";
            this.cmbModificarSalarioCargo.Size = new System.Drawing.Size(218, 31);
            this.cmbModificarSalarioCargo.TabIndex = 12;
            // 
            // botonPadre1
            // 
            this.botonPadre1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(166)))), ((int)(((byte)(26)))));
            this.botonPadre1.FlatAppearance.BorderSize = 0;
            this.botonPadre1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonPadre1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.botonPadre1.ForeColor = System.Drawing.Color.White;
            this.botonPadre1.IconChar = FontAwesome.Sharp.IconChar.None;
            this.botonPadre1.IconColor = System.Drawing.Color.Black;
            this.botonPadre1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.botonPadre1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.botonPadre1.Location = new System.Drawing.Point(268, 104);
            this.botonPadre1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.botonPadre1.Name = "botonPadre1";
            this.botonPadre1.Size = new System.Drawing.Size(180, 44);
            this.botonPadre1.TabIndex = 11;
            this.botonPadre1.Text = "Modificar";
            this.botonPadre1.UseVisualStyleBackColor = false;
            this.botonPadre1.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // txtMontoModificacion
            // 
            this.txtMontoModificacion.Location = new System.Drawing.Point(120, 108);
            this.txtMontoModificacion.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtMontoModificacion.Name = "txtMontoModificacion";
            this.txtMontoModificacion.Size = new System.Drawing.Size(140, 32);
            this.txtMontoModificacion.TabIndex = 7;
            this.txtMontoModificacion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMontoModificacion_KeyPress);
            // 
            // txtLegajoColaboradorModificacion
            // 
            this.txtLegajoColaboradorModificacion.Location = new System.Drawing.Point(120, 49);
            this.txtLegajoColaboradorModificacion.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtLegajoColaboradorModificacion.Name = "txtLegajoColaboradorModificacion";
            this.txtLegajoColaboradorModificacion.Size = new System.Drawing.Size(140, 32);
            this.txtLegajoColaboradorModificacion.TabIndex = 6;
            this.txtLegajoColaboradorModificacion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLegajoColaboradorModificacion_KeyPress);
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
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(594, 14);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(156, 37);
            this.label8.TabIndex = 5;
            this.label8.Text = "SALARIOS";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
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
            this.legajo,
            this.nombre,
            this.apellido,
            this.monto,
            this.fechaInicio});
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
            this.dgvSalarios.Location = new System.Drawing.Point(14, 240);
            this.dgvSalarios.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
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
            this.dgvSalarios.Size = new System.Drawing.Size(1414, 278);
            this.dgvSalarios.TabIndex = 42;
            // 
            // legajo
            // 
            this.legajo.HeaderText = "Legajo";
            this.legajo.MinimumWidth = 6;
            this.legajo.Name = "legajo";
            this.legajo.ReadOnly = true;
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Nombre";
            this.nombre.MinimumWidth = 6;
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            // 
            // apellido
            // 
            this.apellido.HeaderText = "Apellido";
            this.apellido.MinimumWidth = 6;
            this.apellido.Name = "apellido";
            this.apellido.ReadOnly = true;
            // 
            // monto
            // 
            this.monto.HeaderText = "Monto";
            this.monto.MinimumWidth = 6;
            this.monto.Name = "monto";
            // 
            // fechaInicio
            // 
            this.fechaInicio.HeaderText = "Fecha";
            this.fechaInicio.MinimumWidth = 6;
            this.fechaInicio.Name = "fechaInicio";
            // 
            // frmSalarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1454, 709);
            this.Controls.Add(this.dgvSalarios);
            this.Controls.Add(this.label8);
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
        private System.Windows.Forms.TextBox txtApellidoBusqueda;
        private System.Windows.Forms.TextBox txtNombreBusqueda;
        private System.Windows.Forms.TextBox txtMontoBusqueda;
        private System.Windows.Forms.TextBox txtLegajoBusqueda;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtMontoModificacion;
        private System.Windows.Forms.TextBox txtLegajoColaboradorModificacion;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private Controls.BotonPadre btnAplicar;
        private Controls.BotonPadre btnExportar;
        private Controls.BotonPadre botonPadre1;
        private Controls.DataGridPadre dgvSalarios;
        private Controls.BotonPadre btnModificarSalariosCargo;
        private System.Windows.Forms.TextBox txtMontoModificarSalarioCargo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbModificarSalarioCargo;
        private System.Windows.Forms.ComboBox cmbFiltroCargo;
        private System.Windows.Forms.Label label14;
        private Controls.BotonPadre btnPorcentaje;
        private System.Windows.Forms.ComboBox cmbCargoPorcentaje;
        private System.Windows.Forms.TextBox txtPorcentaje;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridViewTextBoxColumn legajo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn monto;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaInicio;
    }
}