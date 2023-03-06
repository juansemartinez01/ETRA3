namespace PresentationA.Colaboradores.Consulta
{
    partial class frmCtaCte
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
            this.txtDepositar = new System.Windows.Forms.TextBox();
            this.btnDepositar = new PresentationA.Controls.BotonPadre();
            this.label5 = new System.Windows.Forms.Label();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblFondoMaximoPermitido = new System.Windows.Forms.Label();
            this.dgvCtaCte = new PresentationA.Controls.DataGridPadre();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.montoMoviento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaIncio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnRetirar = new PresentationA.Controls.BotonPadre();
            this.txtRetirar = new System.Windows.Forms.TextBox();
            this.lblError = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnExportar = new PresentationA.Controls.BotonPadre();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCtaCte)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(13, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 28);
            this.label1.TabIndex = 20;
            this.label1.Text = "Cuenta Corriente";
            // 
            // txtDepositar
            // 
            this.txtDepositar.Location = new System.Drawing.Point(181, 85);
            this.txtDepositar.Name = "txtDepositar";
            this.txtDepositar.Size = new System.Drawing.Size(185, 27);
            this.txtDepositar.TabIndex = 34;
            this.txtDepositar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMontoMovimiento_KeyPress);
            // 
            // btnDepositar
            // 
            this.btnDepositar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(166)))), ((int)(((byte)(26)))));
            this.btnDepositar.FlatAppearance.BorderSize = 0;
            this.btnDepositar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDepositar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnDepositar.ForeColor = System.Drawing.Color.White;
            this.btnDepositar.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnDepositar.IconColor = System.Drawing.Color.White;
            this.btnDepositar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDepositar.IconSize = 30;
            this.btnDepositar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDepositar.Location = new System.Drawing.Point(387, 81);
            this.btnDepositar.Name = "btnDepositar";
            this.btnDepositar.Size = new System.Drawing.Size(132, 34);
            this.btnDepositar.TabIndex = 44;
            this.btnDepositar.Text = "Depositar";
            this.btnDepositar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDepositar.UseVisualStyleBackColor = false;
            this.btnDepositar.Click += new System.EventHandler(this.btnDepositar_Click);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(562, 89);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(162, 21);
            this.label5.TabIndex = 49;
            this.label5.Text = "Saldo de la cuenta:";
            // 
            // lblSaldo
            // 
            this.lblSaldo.Location = new System.Drawing.Point(794, 89);
            this.lblSaldo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(129, 21);
            this.lblSaldo.TabIndex = 50;
            this.lblSaldo.Text = "saldo";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(559, 144);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(208, 21);
            this.label4.TabIndex = 51;
            this.label4.Text = "Fondo maximo permitido:";
            // 
            // lblFondoMaximoPermitido
            // 
            this.lblFondoMaximoPermitido.Location = new System.Drawing.Point(794, 144);
            this.lblFondoMaximoPermitido.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFondoMaximoPermitido.Name = "lblFondoMaximoPermitido";
            this.lblFondoMaximoPermitido.Size = new System.Drawing.Size(129, 21);
            this.lblFondoMaximoPermitido.TabIndex = 52;
            this.lblFondoMaximoPermitido.Text = "label6";
            // 
            // dgvCtaCte
            // 
            this.dgvCtaCte.AllowUserToAddRows = false;
            this.dgvCtaCte.AllowUserToDeleteRows = false;
            this.dgvCtaCte.AllowUserToOrderColumns = true;
            this.dgvCtaCte.AllowUserToResizeRows = false;
            this.dgvCtaCte.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCtaCte.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCtaCte.BackgroundColor = System.Drawing.Color.White;
            this.dgvCtaCte.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvCtaCte.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(103)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(103)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCtaCte.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCtaCte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCtaCte.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.nombre,
            this.montoMoviento,
            this.fechaIncio,
            this.descripcion});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(43)))), ((int)(((byte)(26)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCtaCte.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCtaCte.EnableHeadersVisualStyles = false;
            this.dgvCtaCte.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.dgvCtaCte.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(103)))), ((int)(((byte)(34)))));
            this.dgvCtaCte.Location = new System.Drawing.Point(18, 268);
            this.dgvCtaCte.Name = "dgvCtaCte";
            this.dgvCtaCte.ReadOnly = true;
            this.dgvCtaCte.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(103)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(43)))), ((int)(((byte)(26)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCtaCte.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCtaCte.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCtaCte.Size = new System.Drawing.Size(911, 152);
            this.dgvCtaCte.TabIndex = 53;
            this.dgvCtaCte.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCtaCte_CellContentClick);
            this.dgvCtaCte.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCtaCte_CellContentClick);
            this.dgvCtaCte.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBusqueda_CellContentClick);
            // 
            // id
            // 
            this.id.HeaderText = "numeroMov";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Tipo de Movimiento";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            // 
            // montoMoviento
            // 
            this.montoMoviento.HeaderText = "Monto";
            this.montoMoviento.Name = "montoMoviento";
            this.montoMoviento.ReadOnly = true;
            // 
            // fechaIncio
            // 
            this.fechaIncio.HeaderText = "Fecha de Registro";
            this.fechaIncio.Name = "fechaIncio";
            this.fechaIncio.ReadOnly = true;
            // 
            // descripcion
            // 
            this.descripcion.HeaderText = "Desc.";
            this.descripcion.Name = "descripcion";
            this.descripcion.ReadOnly = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 88);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 21);
            this.label3.TabIndex = 54;
            this.label3.Text = "Monto a Depositar:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 151);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 21);
            this.label6.TabIndex = 57;
            this.label6.Text = "Monto a Retirar:";
            // 
            // btnRetirar
            // 
            this.btnRetirar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(166)))), ((int)(((byte)(26)))));
            this.btnRetirar.FlatAppearance.BorderSize = 0;
            this.btnRetirar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRetirar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnRetirar.ForeColor = System.Drawing.Color.White;
            this.btnRetirar.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.btnRetirar.IconColor = System.Drawing.Color.White;
            this.btnRetirar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRetirar.IconSize = 30;
            this.btnRetirar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRetirar.Location = new System.Drawing.Point(387, 144);
            this.btnRetirar.Name = "btnRetirar";
            this.btnRetirar.Size = new System.Drawing.Size(132, 34);
            this.btnRetirar.TabIndex = 56;
            this.btnRetirar.Text = "Retirar";
            this.btnRetirar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRetirar.UseVisualStyleBackColor = false;
            this.btnRetirar.Click += new System.EventHandler(this.btnRetirar_Click);
            // 
            // txtRetirar
            // 
            this.txtRetirar.Location = new System.Drawing.Point(181, 148);
            this.txtRetirar.Name = "txtRetirar";
            this.txtRetirar.Size = new System.Drawing.Size(185, 27);
            this.txtRetirar.TabIndex = 55;
            this.txtRetirar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMontoMovimiento_KeyPress);
            // 
            // lblError
            // 
            this.lblError.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.lblError.ForeColor = System.Drawing.Color.DimGray;
            this.lblError.Image = global::PresentationA.Properties.Resources.kisspng_exclamation_mark_clip_art_vector_graphics_computer_5ced29986ef952_9605616015590465524546__1___1_;
            this.lblError.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblError.Location = new System.Drawing.Point(559, 199);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(364, 48);
            this.lblError.TabIndex = 58;
            this.lblError.Text = "Error";
            this.lblError.Visible = false;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(181, 199);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(338, 48);
            this.txtDescripcion.TabIndex = 59;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 199);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 21);
            this.label2.TabIndex = 60;
            this.label2.Text = "Descripcion:";
            // 
            // btnExportar
            // 
            this.btnExportar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
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
            this.btnExportar.Location = new System.Drawing.Point(18, 441);
            this.btnExportar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(238, 39);
            this.btnExportar.TabIndex = 61;
            this.btnExportar.Text = "Exportar a Excel";
            this.btnExportar.UseVisualStyleBackColor = false;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // frmCtaCte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(941, 503);
            this.Controls.Add(this.btnExportar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnRetirar);
            this.Controls.Add(this.txtRetirar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvCtaCte);
            this.Controls.Add(this.lblFondoMaximoPermitido);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblSaldo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnDepositar);
            this.Controls.Add(this.txtDepositar);
            this.Controls.Add(this.label1);
            this.Name = "frmCtaCte";
            this.Text = "frmCtaCorriente";
            this.Load += new System.EventHandler(this.frmCtaCte_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCtaCte)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDepositar;
        private Controls.BotonPadre btnDepositar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblSaldo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblFondoMaximoPermitido;
        private Controls.DataGridPadre dgvCtaCte;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn montoMoviento;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaIncio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private Controls.BotonPadre btnRetirar;
        private System.Windows.Forms.TextBox txtRetirar;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private Controls.BotonPadre btnExportar;
    }
}