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
            this.dgvBusqueda = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbTipoMovimiento = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMontoMovimiento = new System.Windows.Forms.TextBox();
            this.btnEliminar = new PresentationA.Controls.BotonPadre();
            this.btnAgregar = new PresentationA.Controls.BotonPadre();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.btnVerArchivo = new FontAwesome.Sharp.IconButton();
            this.label5 = new System.Windows.Forms.Label();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblFondoMaximoPermitido = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBusqueda)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBusqueda
            // 
            this.dgvBusqueda.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBusqueda.BackgroundColor = System.Drawing.Color.White;
            this.dgvBusqueda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBusqueda.Location = new System.Drawing.Point(708, 73);
            this.dgvBusqueda.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.dgvBusqueda.Name = "dgvBusqueda";
            this.dgvBusqueda.ReadOnly = true;
            this.dgvBusqueda.RowHeadersWidth = 51;
            this.dgvBusqueda.RowTemplate.Height = 25;
            this.dgvBusqueda.Size = new System.Drawing.Size(738, 532);
            this.dgvBusqueda.TabIndex = 19;
            this.dgvBusqueda.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBusqueda_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(16, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 37);
            this.label1.TabIndex = 20;
            this.label1.Text = "Cuenta Corriente";
            // 
            // cmbTipoMovimiento
            // 
            this.cmbTipoMovimiento.FormattingEnabled = true;
            this.cmbTipoMovimiento.Location = new System.Drawing.Point(292, 83);
            this.cmbTipoMovimiento.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmbTipoMovimiento.Name = "cmbTipoMovimiento";
            this.cmbTipoMovimiento.Size = new System.Drawing.Size(366, 31);
            this.cmbTipoMovimiento.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 92);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(205, 23);
            this.label2.TabIndex = 23;
            this.label2.Text = "Tipo de Movimiento:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 204);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(236, 23);
            this.label3.TabIndex = 33;
            this.label3.Text = "Monto del movimiento:";
            // 
            // txtMontoMovimiento
            // 
            this.txtMontoMovimiento.Location = new System.Drawing.Point(292, 200);
            this.txtMontoMovimiento.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtMontoMovimiento.Name = "txtMontoMovimiento";
            this.txtMontoMovimiento.Size = new System.Drawing.Size(366, 32);
            this.txtMontoMovimiento.TabIndex = 34;
            this.txtMontoMovimiento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMontoMovimiento_KeyPress);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(166)))), ((int)(((byte)(26)))));
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnEliminar.IconColor = System.Drawing.Color.Black;
            this.btnEliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar.Location = new System.Drawing.Point(425, 568);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(162, 37);
            this.btnEliminar.TabIndex = 46;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(166)))), ((int)(((byte)(26)))));
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnAgregar.IconColor = System.Drawing.Color.Black;
            this.btnAgregar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregar.Location = new System.Drawing.Point(14, 568);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(158, 37);
            this.btnAgregar.TabIndex = 44;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // iconButton1
            // 
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.FileCirclePlus;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 40;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.iconButton1.Location = new System.Drawing.Point(224, 479);
            this.iconButton1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(367, 48);
            this.iconButton1.TabIndex = 48;
            this.iconButton1.Text = "Agregar Archivo";
            this.iconButton1.UseVisualStyleBackColor = true;
            // 
            // btnVerArchivo
            // 
            this.btnVerArchivo.Enabled = false;
            this.btnVerArchivo.IconChar = FontAwesome.Sharp.IconChar.File;
            this.btnVerArchivo.IconColor = System.Drawing.Color.Black;
            this.btnVerArchivo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnVerArchivo.IconSize = 30;
            this.btnVerArchivo.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnVerArchivo.Location = new System.Drawing.Point(224, 424);
            this.btnVerArchivo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnVerArchivo.Name = "btnVerArchivo";
            this.btnVerArchivo.Size = new System.Drawing.Size(367, 48);
            this.btnVerArchivo.TabIndex = 47;
            this.btnVerArchivo.Text = "Ver Archivo";
            this.btnVerArchivo.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 304);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(206, 23);
            this.label5.TabIndex = 49;
            this.label5.Text = "Saldo de la cuenta:";
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.Location = new System.Drawing.Point(334, 322);
            this.lblSaldo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(0, 23);
            this.lblSaldo.TabIndex = 50;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 365);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(259, 23);
            this.label4.TabIndex = 51;
            this.label4.Text = "Fondo maximo permitido:";
            // 
            // lblFondoMaximoPermitido
            // 
            this.lblFondoMaximoPermitido.AutoSize = true;
            this.lblFondoMaximoPermitido.Location = new System.Drawing.Point(334, 365);
            this.lblFondoMaximoPermitido.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFondoMaximoPermitido.Name = "lblFondoMaximoPermitido";
            this.lblFondoMaximoPermitido.Size = new System.Drawing.Size(72, 23);
            this.lblFondoMaximoPermitido.TabIndex = 52;
            this.lblFondoMaximoPermitido.Text = "label6";
            // 
            // frmCtaCte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1514, 633);
            this.Controls.Add(this.lblFondoMaximoPermitido);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblSaldo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.btnVerArchivo);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtMontoMovimiento);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbTipoMovimiento);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvBusqueda);
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "frmCtaCte";
            this.Text = "frmCtaCorriente";
            this.Load += new System.EventHandler(this.frmCtaCte_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBusqueda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBusqueda;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbTipoMovimiento;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMontoMovimiento;
        private Controls.BotonPadre btnEliminar;
        private Controls.BotonPadre btnAgregar;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton btnVerArchivo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblSaldo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblFondoMaximoPermitido;
    }
}