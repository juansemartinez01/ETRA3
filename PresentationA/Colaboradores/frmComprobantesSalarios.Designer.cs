namespace PresentationA.Colaboradores
{
    partial class frmComprobantesSalarios
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.chkFeriado = new System.Windows.Forms.CheckBox();
            this.chkBono = new System.Windows.Forms.CheckBox();
            this.txtMontoBono = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpFechaFeriado = new System.Windows.Forms.DateTimePicker();
            this.cmbDiaCompleto = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbLegajo = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtCuotaCtaCorriente = new System.Windows.Forms.TextBox();
            this.txtAnticipo = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtDescripcion1 = new System.Windows.Forms.TextBox();
            this.txtDescripcion2 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.cmbMesGeneracion = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.pntOrden = new System.Drawing.Printing.PrintDocument();
            this.pntMinuta = new System.Drawing.Printing.PrintDocument();
            this.btnGenerarOrdenFeriado = new PresentationA.Controls.BotonPadre();
            this.btnMinutoContable = new PresentationA.Controls.BotonPadre();
            this.btnEliminarFeriado = new PresentationA.Controls.BotonPadre();
            this.dgvFeriados = new PresentationA.Controls.DataGridPadre();
            this.id_evento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFeriados)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(323, 74);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Legajo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 110);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(352, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Comprobantes feriados u otro bono del mes";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 284);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Monto bono";
            // 
            // chkFeriado
            // 
            this.chkFeriado.AutoSize = true;
            this.chkFeriado.Location = new System.Drawing.Point(95, 194);
            this.chkFeriado.Margin = new System.Windows.Forms.Padding(5);
            this.chkFeriado.Name = "chkFeriado";
            this.chkFeriado.Size = new System.Drawing.Size(103, 25);
            this.chkFeriado.TabIndex = 5;
            this.chkFeriado.Text = "Es feriado";
            this.chkFeriado.UseVisualStyleBackColor = true;
            this.chkFeriado.CheckedChanged += new System.EventHandler(this.chkFeriado_CheckedChanged);
            // 
            // chkBono
            // 
            this.chkBono.AutoSize = true;
            this.chkBono.Location = new System.Drawing.Point(95, 231);
            this.chkBono.Margin = new System.Windows.Forms.Padding(5);
            this.chkBono.Name = "chkBono";
            this.chkBono.Size = new System.Drawing.Size(110, 25);
            this.chkBono.TabIndex = 6;
            this.chkBono.Text = "Otro bono";
            this.chkBono.UseVisualStyleBackColor = true;
            this.chkBono.CheckedChanged += new System.EventHandler(this.chkBono_CheckedChanged);
            // 
            // txtMontoBono
            // 
            this.txtMontoBono.Location = new System.Drawing.Point(173, 279);
            this.txtMontoBono.Margin = new System.Windows.Forms.Padding(5);
            this.txtMontoBono.Name = "txtMontoBono";
            this.txtMontoBono.Size = new System.Drawing.Size(164, 27);
            this.txtMontoBono.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(153, 326);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(191, 21);
            this.label4.TabIndex = 8;
            this.label4.Text = "Fecha feriado o o bono";
            // 
            // dtpFechaFeriado
            // 
            this.dtpFechaFeriado.Location = new System.Drawing.Point(158, 352);
            this.dtpFechaFeriado.Margin = new System.Windows.Forms.Padding(5);
            this.dtpFechaFeriado.Name = "dtpFechaFeriado";
            this.dtpFechaFeriado.Size = new System.Drawing.Size(331, 27);
            this.dtpFechaFeriado.TabIndex = 9;
            // 
            // cmbDiaCompleto
            // 
            this.cmbDiaCompleto.FormattingEnabled = true;
            this.cmbDiaCompleto.Items.AddRange(new object[] {
            "Dia completo",
            "Medio dia"});
            this.cmbDiaCompleto.Location = new System.Drawing.Point(243, 194);
            this.cmbDiaCompleto.Margin = new System.Windows.Forms.Padding(5);
            this.cmbDiaCompleto.Name = "cmbDiaCompleto";
            this.cmbDiaCompleto.Size = new System.Drawing.Size(199, 29);
            this.cmbDiaCompleto.TabIndex = 10;
            this.cmbDiaCompleto.SelectedIndexChanged += new System.EventHandler(this.cmbDiaCompleto_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(723, 110);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(182, 21);
            this.label5.TabIndex = 11;
            this.label5.Text = "Anticipos a descontar";
            // 
            // cmbLegajo
            // 
            this.cmbLegajo.FormattingEnabled = true;
            this.cmbLegajo.Location = new System.Drawing.Point(398, 69);
            this.cmbLegajo.Margin = new System.Windows.Forms.Padding(5);
            this.cmbLegajo.Name = "cmbLegajo";
            this.cmbLegajo.Size = new System.Drawing.Size(199, 29);
            this.cmbLegajo.TabIndex = 12;
            this.cmbLegajo.SelectedIndexChanged += new System.EventHandler(this.cmbLegajo_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(768, 32);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 21);
            this.label6.TabIndex = 13;
            this.label6.Text = "Nombre:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(768, 74);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 21);
            this.label7.TabIndex = 14;
            this.label7.Text = "Apellido:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(857, 32);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 21);
            this.label8.TabIndex = 15;
            this.label8.Text = "label8";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(857, 74);
            this.label9.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 21);
            this.label9.TabIndex = 16;
            this.label9.Text = "label9";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(723, 194);
            this.label10.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(201, 21);
            this.label10.TabIndex = 17;
            this.label10.Text = "Cuota cuenta corriente:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(742, 254);
            this.label11.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(180, 21);
            this.label11.TabIndex = 18;
            this.label11.Text = "Anticipo a descontar:";
            // 
            // txtCuotaCtaCorriente
            // 
            this.txtCuotaCtaCorriente.Location = new System.Drawing.Point(930, 191);
            this.txtCuotaCtaCorriente.Margin = new System.Windows.Forms.Padding(5);
            this.txtCuotaCtaCorriente.Name = "txtCuotaCtaCorriente";
            this.txtCuotaCtaCorriente.Size = new System.Drawing.Size(164, 27);
            this.txtCuotaCtaCorriente.TabIndex = 19;
            this.txtCuotaCtaCorriente.TextChanged += new System.EventHandler(this.txtCuotaCtaCorriente_TextChanged);
            // 
            // txtAnticipo
            // 
            this.txtAnticipo.Location = new System.Drawing.Point(930, 249);
            this.txtAnticipo.Margin = new System.Windows.Forms.Padding(5);
            this.txtAnticipo.Name = "txtAnticipo";
            this.txtAnticipo.Size = new System.Drawing.Size(164, 27);
            this.txtAnticipo.TabIndex = 20;
            this.txtAnticipo.TextChanged += new System.EventHandler(this.txtAnticipo_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(50, 454);
            this.label12.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(100, 21);
            this.label12.TabIndex = 22;
            this.label12.Text = "Descripcion";
            // 
            // txtDescripcion1
            // 
            this.txtDescripcion1.Location = new System.Drawing.Point(177, 454);
            this.txtDescripcion1.Margin = new System.Windows.Forms.Padding(5);
            this.txtDescripcion1.Multiline = true;
            this.txtDescripcion1.Name = "txtDescripcion1";
            this.txtDescripcion1.Size = new System.Drawing.Size(327, 59);
            this.txtDescripcion1.TabIndex = 23;
            // 
            // txtDescripcion2
            // 
            this.txtDescripcion2.Location = new System.Drawing.Point(880, 414);
            this.txtDescripcion2.Margin = new System.Windows.Forms.Padding(5);
            this.txtDescripcion2.Multiline = true;
            this.txtDescripcion2.Name = "txtDescripcion2";
            this.txtDescripcion2.Size = new System.Drawing.Size(327, 59);
            this.txtDescripcion2.TabIndex = 24;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(742, 414);
            this.label13.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(100, 21);
            this.label13.TabIndex = 25;
            this.label13.Text = "Descripcion";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(1052, 32);
            this.label14.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(122, 21);
            this.label14.TabIndex = 26;
            this.label14.Text = "Saldo Cuenta:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(1185, 32);
            this.label15.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(66, 21);
            this.label15.TabIndex = 27;
            this.label15.Text = "label15";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(48, 414);
            this.label16.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(128, 21);
            this.label16.TabIndex = 28;
            this.label16.Text = "Monto Feriado:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(187, 414);
            this.label17.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(66, 21);
            this.label17.TabIndex = 29;
            this.label17.Text = "label17";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(90, 24);
            this.label18.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(296, 21);
            this.label18.TabIndex = 30;
            this.label18.Text = "Mes para generar los comprobantes:";
            // 
            // cmbMesGeneracion
            // 
            this.cmbMesGeneracion.FormattingEnabled = true;
            this.cmbMesGeneracion.Items.AddRange(new object[] {
            "Enero",
            "Febrero",
            "Marzo",
            "Abril",
            "Mayo",
            "Junio",
            "Julio",
            "Agosto",
            "Septiembre",
            "Octubre",
            "Noviembre",
            "Diciembre"});
            this.cmbMesGeneracion.Location = new System.Drawing.Point(398, 24);
            this.cmbMesGeneracion.Margin = new System.Windows.Forms.Padding(5);
            this.cmbMesGeneracion.Name = "cmbMesGeneracion";
            this.cmbMesGeneracion.Size = new System.Drawing.Size(199, 29);
            this.cmbMesGeneracion.TabIndex = 31;
            this.cmbMesGeneracion.SelectedIndexChanged += new System.EventHandler(this.cmbMesGeneracion_SelectedIndexChanged);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(735, 310);
            this.label19.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(107, 21);
            this.label19.TabIndex = 32;
            this.label19.Text = "Sueldo neto:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(563, 352);
            this.label20.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(271, 21);
            this.label20.TabIndex = 33;
            this.label20.Text = "Sueldo con descuentos y feriados:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(857, 310);
            this.label21.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(66, 21);
            this.label21.TabIndex = 34;
            this.label21.Text = "label21";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(857, 352);
            this.label22.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(66, 21);
            this.label22.TabIndex = 35;
            this.label22.Text = "label22";
            // 
            // pntOrden
            // 
            this.pntOrden.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printOrden);
            // 
            // pntMinuta
            // 
            this.pntMinuta.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printMinuta);
            // 
            // btnGenerarOrdenFeriado
            // 
            this.btnGenerarOrdenFeriado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(166)))), ((int)(((byte)(26)))));
            this.btnGenerarOrdenFeriado.FlatAppearance.BorderSize = 0;
            this.btnGenerarOrdenFeriado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerarOrdenFeriado.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnGenerarOrdenFeriado.ForeColor = System.Drawing.Color.White;
            this.btnGenerarOrdenFeriado.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnGenerarOrdenFeriado.IconColor = System.Drawing.Color.Black;
            this.btnGenerarOrdenFeriado.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGenerarOrdenFeriado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGenerarOrdenFeriado.Location = new System.Drawing.Point(107, 525);
            this.btnGenerarOrdenFeriado.Name = "btnGenerarOrdenFeriado";
            this.btnGenerarOrdenFeriado.Size = new System.Drawing.Size(278, 39);
            this.btnGenerarOrdenFeriado.TabIndex = 38;
            this.btnGenerarOrdenFeriado.Text = "Generar Orden de Feriado";
            this.btnGenerarOrdenFeriado.UseVisualStyleBackColor = false;
            this.btnGenerarOrdenFeriado.Click += new System.EventHandler(this.btnGenerarOrdenFeriado_Click);
            // 
            // btnMinutoContable
            // 
            this.btnMinutoContable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(166)))), ((int)(((byte)(26)))));
            this.btnMinutoContable.FlatAppearance.BorderSize = 0;
            this.btnMinutoContable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinutoContable.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnMinutoContable.ForeColor = System.Drawing.Color.White;
            this.btnMinutoContable.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnMinutoContable.IconColor = System.Drawing.Color.Black;
            this.btnMinutoContable.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMinutoContable.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMinutoContable.Location = new System.Drawing.Point(919, 597);
            this.btnMinutoContable.Name = "btnMinutoContable";
            this.btnMinutoContable.Size = new System.Drawing.Size(294, 48);
            this.btnMinutoContable.TabIndex = 39;
            this.btnMinutoContable.Text = "Generar Minuto Contable";
            this.btnMinutoContable.UseVisualStyleBackColor = false;
            this.btnMinutoContable.Click += new System.EventHandler(this.btnMinutoContable_Click);
            // 
            // btnEliminarFeriado
            // 
            this.btnEliminarFeriado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(166)))), ((int)(((byte)(26)))));
            this.btnEliminarFeriado.FlatAppearance.BorderSize = 0;
            this.btnEliminarFeriado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarFeriado.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnEliminarFeriado.ForeColor = System.Drawing.Color.White;
            this.btnEliminarFeriado.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnEliminarFeriado.IconColor = System.Drawing.Color.Black;
            this.btnEliminarFeriado.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEliminarFeriado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminarFeriado.Location = new System.Drawing.Point(107, 741);
            this.btnEliminarFeriado.Name = "btnEliminarFeriado";
            this.btnEliminarFeriado.Size = new System.Drawing.Size(212, 39);
            this.btnEliminarFeriado.TabIndex = 40;
            this.btnEliminarFeriado.Text = "Eliminar";
            this.btnEliminarFeriado.UseVisualStyleBackColor = false;
            this.btnEliminarFeriado.Click += new System.EventHandler(this.btnEliminarFeriado_Click);
            // 
            // dgvFeriados
            // 
            this.dgvFeriados.AllowUserToAddRows = false;
            this.dgvFeriados.AllowUserToDeleteRows = false;
            this.dgvFeriados.AllowUserToOrderColumns = true;
            this.dgvFeriados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFeriados.BackgroundColor = System.Drawing.Color.White;
            this.dgvFeriados.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvFeriados.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(103)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(103)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFeriados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvFeriados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFeriados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_evento,
            this.nombre,
            this.fechaInicio,
            this.monto});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(43)))), ((int)(((byte)(26)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvFeriados.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvFeriados.EnableHeadersVisualStyles = false;
            this.dgvFeriados.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.dgvFeriados.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(103)))), ((int)(((byte)(34)))));
            this.dgvFeriados.Location = new System.Drawing.Point(56, 570);
            this.dgvFeriados.Name = "dgvFeriados";
            this.dgvFeriados.ReadOnly = true;
            this.dgvFeriados.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(103)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(43)))), ((int)(((byte)(26)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFeriados.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvFeriados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFeriados.Size = new System.Drawing.Size(448, 150);
            this.dgvFeriados.TabIndex = 41;
            // 
            // id_evento
            // 
            this.id_evento.HeaderText = "id_evento";
            this.id_evento.Name = "id_evento";
            this.id_evento.ReadOnly = true;
            this.id_evento.Visible = false;
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Tipo de Evento";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            // 
            // fechaInicio
            // 
            this.fechaInicio.HeaderText = "Fecha";
            this.fechaInicio.Name = "fechaInicio";
            this.fechaInicio.ReadOnly = true;
            // 
            // monto
            // 
            this.monto.HeaderText = "Monto";
            this.monto.Name = "monto";
            this.monto.ReadOnly = true;
            // 
            // frmComprobantesSalarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1333, 803);
            this.Controls.Add(this.dgvFeriados);
            this.Controls.Add(this.btnEliminarFeriado);
            this.Controls.Add(this.btnMinutoContable);
            this.Controls.Add(this.btnGenerarOrdenFeriado);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.cmbMesGeneracion);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtDescripcion2);
            this.Controls.Add(this.txtDescripcion1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtAnticipo);
            this.Controls.Add(this.txtCuotaCtaCorriente);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbLegajo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbDiaCompleto);
            this.Controls.Add(this.dtpFechaFeriado);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMontoBono);
            this.Controls.Add(this.chkBono);
            this.Controls.Add(this.chkFeriado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "frmComprobantesSalarios";
            this.Text = "frmComprobantesSalarios";
            ((System.ComponentModel.ISupportInitialize)(this.dgvFeriados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chkFeriado;
        private System.Windows.Forms.CheckBox chkBono;
        private System.Windows.Forms.TextBox txtMontoBono;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpFechaFeriado;
        private System.Windows.Forms.ComboBox cmbDiaCompleto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbLegajo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtCuotaCtaCorriente;
        private System.Windows.Forms.TextBox txtAnticipo;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtDescripcion1;
        private System.Windows.Forms.TextBox txtDescripcion2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox cmbMesGeneracion;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Drawing.Printing.PrintDocument pntOrden;
        private System.Drawing.Printing.PrintDocument pntMinuta;
        private Controls.BotonPadre btnGenerarOrdenFeriado;
        private Controls.BotonPadre btnMinutoContable;
        private Controls.BotonPadre btnEliminarFeriado;
        private Controls.DataGridPadre dgvFeriados;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_evento;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaInicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn monto;
    }
}