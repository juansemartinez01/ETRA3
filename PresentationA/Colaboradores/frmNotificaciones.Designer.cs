namespace PresentationA.Colaboradores
{
    partial class frmNotificaciones
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
            this.dgvCumpleañosDelMes = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cumpleaños = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCumpleañosDelMes)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCumpleañosDelMes
            // 
            this.dgvCumpleañosDelMes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCumpleañosDelMes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Apellido,
            this.Cumpleaños});
            this.dgvCumpleañosDelMes.Location = new System.Drawing.Point(835, 73);
            this.dgvCumpleañosDelMes.Name = "dgvCumpleañosDelMes";
            this.dgvCumpleañosDelMes.RowHeadersWidth = 51;
            this.dgvCumpleañosDelMes.Size = new System.Drawing.Size(585, 292);
            this.dgvCumpleañosDelMes.TabIndex = 0;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            this.Nombre.Width = 125;
            // 
            // Apellido
            // 
            this.Apellido.HeaderText = "Apellido";
            this.Apellido.MinimumWidth = 6;
            this.Apellido.Name = "Apellido";
            this.Apellido.Width = 125;
            // 
            // Cumpleaños
            // 
            this.Cumpleaños.HeaderText = "Cumpleaños";
            this.Cumpleaños.MinimumWidth = 6;
            this.Cumpleaños.Name = "Cumpleaños";
            this.Cumpleaños.Width = 125;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(835, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cumpleaños de este mes";
            // 
            // frmNotificaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1455, 588);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvCumpleañosDelMes);
            this.Name = "frmNotificaciones";
            this.Text = "frmNotificaciones";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCumpleañosDelMes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCumpleañosDelMes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cumpleaños;
        private System.Windows.Forms.Label label1;
    }
}