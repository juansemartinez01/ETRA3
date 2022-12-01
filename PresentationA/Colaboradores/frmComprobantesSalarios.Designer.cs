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
            this.label1 = new System.Windows.Forms.Label();
            this.btnGenerarOrdenFeriado = new System.Windows.Forms.Button();
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
            this.btnMinutoContable = new System.Windows.Forms.Button();
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
            this.dgvFeriados = new System.Windows.Forms.DataGridView();
            this.btnEliminarFeriado = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFeriados)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(194, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Legajo";
            // 
            // btnGenerarOrdenFeriado
            // 
            this.btnGenerarOrdenFeriado.Location = new System.Drawing.Point(57, 325);
            this.btnGenerarOrdenFeriado.Name = "btnGenerarOrdenFeriado";
            this.btnGenerarOrdenFeriado.Size = new System.Drawing.Size(170, 23);
            this.btnGenerarOrdenFeriado.TabIndex = 2;
            this.btnGenerarOrdenFeriado.Text = "Generar Comprobante";
            this.btnGenerarOrdenFeriado.UseVisualStyleBackColor = true;
            this.btnGenerarOrdenFeriado.Click += new System.EventHandler(this.btnGenerarOrdenFeriado_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(211, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Comprobantes feriados u otro bono del mes";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Monto bono";
            // 
            // chkFeriado
            // 
            this.chkFeriado.AutoSize = true;
            this.chkFeriado.Location = new System.Drawing.Point(57, 120);
            this.chkFeriado.Name = "chkFeriado";
            this.chkFeriado.Size = new System.Drawing.Size(73, 17);
            this.chkFeriado.TabIndex = 5;
            this.chkFeriado.Text = "Es feriado";
            this.chkFeriado.UseVisualStyleBackColor = true;
            this.chkFeriado.CheckedChanged += new System.EventHandler(this.chkFeriado_CheckedChanged);
            // 
            // chkBono
            // 
            this.chkBono.AutoSize = true;
            this.chkBono.Location = new System.Drawing.Point(57, 143);
            this.chkBono.Name = "chkBono";
            this.chkBono.Size = new System.Drawing.Size(73, 17);
            this.chkBono.TabIndex = 6;
            this.chkBono.Text = "Otro bono";
            this.chkBono.UseVisualStyleBackColor = true;
            this.chkBono.CheckedChanged += new System.EventHandler(this.chkBono_CheckedChanged);
            // 
            // txtMontoBono
            // 
            this.txtMontoBono.Location = new System.Drawing.Point(104, 173);
            this.txtMontoBono.Name = "txtMontoBono";
            this.txtMontoBono.Size = new System.Drawing.Size(100, 20);
            this.txtMontoBono.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(92, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Fecha feriado o o bono";
            // 
            // dtpFechaFeriado
            // 
            this.dtpFechaFeriado.Location = new System.Drawing.Point(95, 218);
            this.dtpFechaFeriado.Name = "dtpFechaFeriado";
            this.dtpFechaFeriado.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaFeriado.TabIndex = 9;
            // 
            // cmbDiaCompleto
            // 
            this.cmbDiaCompleto.FormattingEnabled = true;
            this.cmbDiaCompleto.Items.AddRange(new object[] {
            "Dia completo",
            "Medio dia"});
            this.cmbDiaCompleto.Location = new System.Drawing.Point(146, 120);
            this.cmbDiaCompleto.Name = "cmbDiaCompleto";
            this.cmbDiaCompleto.Size = new System.Drawing.Size(121, 21);
            this.cmbDiaCompleto.TabIndex = 10;
            this.cmbDiaCompleto.SelectedIndexChanged += new System.EventHandler(this.cmbDiaCompleto_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(434, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Anticipos a descontar";
            // 
            // cmbLegajo
            // 
            this.cmbLegajo.FormattingEnabled = true;
            this.cmbLegajo.Location = new System.Drawing.Point(239, 43);
            this.cmbLegajo.Name = "cmbLegajo";
            this.cmbLegajo.Size = new System.Drawing.Size(121, 21);
            this.cmbLegajo.TabIndex = 12;
            this.cmbLegajo.SelectedIndexChanged += new System.EventHandler(this.cmbLegajo_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(461, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Nombre:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(461, 46);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Apellido:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(514, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "label8";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(514, 46);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "label9";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(434, 120);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(118, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "Cuota cuenta corriente:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(445, 157);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(107, 13);
            this.label11.TabIndex = 18;
            this.label11.Text = "Anticipo a descontar:";
            // 
            // txtCuotaCtaCorriente
            // 
            this.txtCuotaCtaCorriente.Location = new System.Drawing.Point(558, 118);
            this.txtCuotaCtaCorriente.Name = "txtCuotaCtaCorriente";
            this.txtCuotaCtaCorriente.Size = new System.Drawing.Size(100, 20);
            this.txtCuotaCtaCorriente.TabIndex = 19;
            this.txtCuotaCtaCorriente.TextChanged += new System.EventHandler(this.txtCuotaCtaCorriente_TextChanged);
            // 
            // txtAnticipo
            // 
            this.txtAnticipo.Location = new System.Drawing.Point(558, 154);
            this.txtAnticipo.Name = "txtAnticipo";
            this.txtAnticipo.Size = new System.Drawing.Size(100, 20);
            this.txtAnticipo.TabIndex = 20;
            this.txtAnticipo.TextChanged += new System.EventHandler(this.txtAnticipo_TextChanged);
            // 
            // btnMinutoContable
            // 
            this.btnMinutoContable.Location = new System.Drawing.Point(558, 325);
            this.btnMinutoContable.Name = "btnMinutoContable";
            this.btnMinutoContable.Size = new System.Drawing.Size(170, 26);
            this.btnMinutoContable.TabIndex = 21;
            this.btnMinutoContable.Text = "Generar Minuto Contable";
            this.btnMinutoContable.UseVisualStyleBackColor = true;
            this.btnMinutoContable.Click += new System.EventHandler(this.btnMinutoContable_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(30, 281);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(63, 13);
            this.label12.TabIndex = 22;
            this.label12.Text = "Descripcion";
            // 
            // txtDescripcion1
            // 
            this.txtDescripcion1.Location = new System.Drawing.Point(106, 281);
            this.txtDescripcion1.Multiline = true;
            this.txtDescripcion1.Name = "txtDescripcion1";
            this.txtDescripcion1.Size = new System.Drawing.Size(198, 38);
            this.txtDescripcion1.TabIndex = 23;
            // 
            // txtDescripcion2
            // 
            this.txtDescripcion2.Location = new System.Drawing.Point(528, 256);
            this.txtDescripcion2.Multiline = true;
            this.txtDescripcion2.Name = "txtDescripcion2";
            this.txtDescripcion2.Size = new System.Drawing.Size(198, 38);
            this.txtDescripcion2.TabIndex = 24;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(445, 256);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(63, 13);
            this.label13.TabIndex = 25;
            this.label13.Text = "Descripcion";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(631, 20);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(74, 13);
            this.label14.TabIndex = 26;
            this.label14.Text = "Saldo Cuenta:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(711, 20);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(41, 13);
            this.label15.TabIndex = 27;
            this.label15.Text = "label15";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(29, 256);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(78, 13);
            this.label16.TabIndex = 28;
            this.label16.Text = "Monto Feriado:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(112, 256);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(41, 13);
            this.label17.TabIndex = 29;
            this.label17.Text = "label17";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(54, 15);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(179, 13);
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
            this.cmbMesGeneracion.Location = new System.Drawing.Point(239, 15);
            this.cmbMesGeneracion.Name = "cmbMesGeneracion";
            this.cmbMesGeneracion.Size = new System.Drawing.Size(121, 21);
            this.cmbMesGeneracion.TabIndex = 31;
            this.cmbMesGeneracion.SelectedIndexChanged += new System.EventHandler(this.cmbMesGeneracion_SelectedIndexChanged);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(441, 192);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(67, 13);
            this.label19.TabIndex = 32;
            this.label19.Text = "Sueldo neto:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(338, 218);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(170, 13);
            this.label20.TabIndex = 33;
            this.label20.Text = "Sueldo con descuentos y feriados:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(514, 192);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(41, 13);
            this.label21.TabIndex = 34;
            this.label21.Text = "label21";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(514, 218);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(41, 13);
            this.label22.TabIndex = 35;
            this.label22.Text = "label22";
            // 
            // dgvFeriados
            // 
            this.dgvFeriados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFeriados.Location = new System.Drawing.Point(64, 354);
            this.dgvFeriados.Name = "dgvFeriados";
            this.dgvFeriados.Size = new System.Drawing.Size(343, 88);
            this.dgvFeriados.TabIndex = 36;
            // 
            // btnEliminarFeriado
            // 
            this.btnEliminarFeriado.Location = new System.Drawing.Point(57, 462);
            this.btnEliminarFeriado.Name = "btnEliminarFeriado";
            this.btnEliminarFeriado.Size = new System.Drawing.Size(73, 23);
            this.btnEliminarFeriado.TabIndex = 37;
            this.btnEliminarFeriado.Text = "Eliminar";
            this.btnEliminarFeriado.UseVisualStyleBackColor = true;
            // 
            // frmComprobantesSalarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 497);
            this.Controls.Add(this.btnEliminarFeriado);
            this.Controls.Add(this.dgvFeriados);
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
            this.Controls.Add(this.btnMinutoContable);
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
            this.Controls.Add(this.btnGenerarOrdenFeriado);
            this.Controls.Add(this.label1);
            this.Name = "frmComprobantesSalarios";
            this.Text = "frmComprobantesSalarios";
            ((System.ComponentModel.ISupportInitialize)(this.dgvFeriados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGenerarOrdenFeriado;
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
        private System.Windows.Forms.Button btnMinutoContable;
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
        private System.Windows.Forms.DataGridView dgvFeriados;
        private System.Windows.Forms.Button btnEliminarFeriado;
    }
}