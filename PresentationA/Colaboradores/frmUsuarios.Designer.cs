namespace PresentationA.Colaboradores
{
    partial class frmUsuarios
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvUsuarios = new PresentationA.Controls.DataGridPadre();
            this.legajo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perfil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAgregar = new PresentationA.Controls.BotonPadre();
            this.btnModificar = new PresentationA.Controls.BotonPadre();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbperfil = new System.Windows.Forms.ComboBox();
            this.cmblegajo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.chkMail = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.AllowUserToAddRows = false;
            this.dgvUsuarios.AllowUserToDeleteRows = false;
            this.dgvUsuarios.AllowUserToOrderColumns = true;
            this.dgvUsuarios.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUsuarios.BackgroundColor = System.Drawing.Color.White;
            this.dgvUsuarios.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvUsuarios.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(103)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(103)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUsuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.legajo,
            this.perfil});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 12F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(43)))), ((int)(((byte)(26)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvUsuarios.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvUsuarios.EnableHeadersVisualStyles = false;
            this.dgvUsuarios.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.dgvUsuarios.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(103)))), ((int)(((byte)(34)))));
            this.dgvUsuarios.Location = new System.Drawing.Point(507, 103);
            this.dgvUsuarios.Margin = new System.Windows.Forms.Padding(4);
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.ReadOnly = true;
            this.dgvUsuarios.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(103)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 12F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(43)))), ((int)(((byte)(26)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUsuarios.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvUsuarios.RowHeadersWidth = 62;
            this.dgvUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsuarios.Size = new System.Drawing.Size(468, 460);
            this.dgvUsuarios.TabIndex = 1;
            this.dgvUsuarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsuarios_CellClick);
            this.dgvUsuarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsuarios_CellClick);
            this.dgvUsuarios.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsuarios_CellClick);
            this.dgvUsuarios.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsuarios_CellClick);
            // 
            // legajo
            // 
            this.legajo.HeaderText = "Legajo";
            this.legajo.MinimumWidth = 8;
            this.legajo.Name = "legajo";
            this.legajo.ReadOnly = true;
            // 
            // perfil
            // 
            this.perfil.HeaderText = "Perfil";
            this.perfil.MinimumWidth = 8;
            this.perfil.Name = "perfil";
            this.perfil.ReadOnly = true;
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
            this.btnAgregar.Location = new System.Drawing.Point(36, 510);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(171, 53);
            this.btnAgregar.TabIndex = 46;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(166)))), ((int)(((byte)(26)))));
            this.btnModificar.FlatAppearance.BorderSize = 0;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnModificar.ForeColor = System.Drawing.Color.White;
            this.btnModificar.IconChar = FontAwesome.Sharp.IconChar.Pen;
            this.btnModificar.IconColor = System.Drawing.Color.White;
            this.btnModificar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnModificar.IconSize = 30;
            this.btnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificar.Location = new System.Drawing.Point(249, 510);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(4);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(171, 53);
            this.btnModificar.TabIndex = 47;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(29, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 43);
            this.label1.TabIndex = 48;
            this.label1.Text = "Usuarios";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 107);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 30);
            this.label3.TabIndex = 50;
            this.label3.Text = "Legajo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 184);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 30);
            this.label4.TabIndex = 51;
            this.label4.Text = "Perfil:";
            // 
            // cmbperfil
            // 
            this.cmbperfil.FormattingEnabled = true;
            this.cmbperfil.Location = new System.Drawing.Point(150, 180);
            this.cmbperfil.Margin = new System.Windows.Forms.Padding(4);
            this.cmbperfil.Name = "cmbperfil";
            this.cmbperfil.Size = new System.Drawing.Size(270, 38);
            this.cmbperfil.TabIndex = 52;
            this.cmbperfil.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbperfil_KeyPress);
            // 
            // cmblegajo
            // 
            this.cmblegajo.FormattingEnabled = true;
            this.cmblegajo.Location = new System.Drawing.Point(150, 103);
            this.cmblegajo.Margin = new System.Windows.Forms.Padding(4);
            this.cmblegajo.Name = "cmblegajo";
            this.cmblegajo.Size = new System.Drawing.Size(270, 38);
            this.cmblegajo.TabIndex = 53;
            this.cmblegajo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmblegajo_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 404);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 30);
            this.label2.TabIndex = 54;
            this.label2.Text = "Contraseña";
            // 
            // txtContraseña
            // 
            this.txtContraseña.Location = new System.Drawing.Point(208, 404);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(212, 37);
            this.txtContraseña.TabIndex = 55;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 343);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 30);
            this.label5.TabIndex = 56;
            this.label5.Text = "Mail";
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(117, 336);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(303, 37);
            this.txtMail.TabIndex = 57;
            // 
            // chkMail
            // 
            this.chkMail.AutoSize = true;
            this.chkMail.Location = new System.Drawing.Point(36, 296);
            this.chkMail.Name = "chkMail";
            this.chkMail.Size = new System.Drawing.Size(275, 34);
            this.chkMail.TabIndex = 58;
            this.chkMail.Text = "Ingresar mail nuevo";
            this.chkMail.UseVisualStyleBackColor = true;
            this.chkMail.CheckedChanged += new System.EventHandler(this.chkMail_CheckedChanged);
            // 
            // frmUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1042, 612);
            this.Controls.Add(this.chkMail);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmblegajo);
            this.Controls.Add(this.cmbperfil);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dgvUsuarios);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MinimumSize = new System.Drawing.Size(1023, 353);
            this.Name = "frmUsuarios";
            this.Text = "frmUsuarios";
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Controls.DataGridPadre dgvUsuarios;
        private Controls.BotonPadre btnAgregar;
        private Controls.BotonPadre btnModificar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbperfil;
        private System.Windows.Forms.ComboBox cmblegajo;
        private System.Windows.Forms.DataGridViewTextBoxColumn legajo;
        private System.Windows.Forms.DataGridViewTextBoxColumn perfil;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.CheckBox chkMail;
    }
}