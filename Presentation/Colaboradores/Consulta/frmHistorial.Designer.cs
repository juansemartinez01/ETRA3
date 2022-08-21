
namespace Presentation.Colaboradores
{
    partial class frmHistorial
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
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.txtfechaInicio = new System.Windows.Forms.TextBox();
            this.txtfechaFin = new System.Windows.Forms.TextBox();
            this.txtfechaRegistro = new System.Windows.Forms.TextBox();
            this.txtdescripcion = new System.Windows.Forms.RichTextBox();
            this.dgvEventos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEventos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Historial de Eventos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Evento:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Fecha de Registro:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Fecha Fin:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 101);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "Fecha de Inicio:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(106, 360);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Modificar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 360);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Agregar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(201, 360);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 9;
            this.button3.Text = "Eliminar";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Archivos asociados:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 233);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 17);
            this.label7.TabIndex = 11;
            this.label7.Text = "Descripción:";
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(146, 67);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(153, 22);
            this.txtnombre.TabIndex = 12;
            // 
            // txtfechaInicio
            // 
            this.txtfechaInicio.Location = new System.Drawing.Point(146, 101);
            this.txtfechaInicio.Name = "txtfechaInicio";
            this.txtfechaInicio.Size = new System.Drawing.Size(153, 22);
            this.txtfechaInicio.TabIndex = 13;
            // 
            // txtfechaFin
            // 
            this.txtfechaFin.Location = new System.Drawing.Point(146, 133);
            this.txtfechaFin.Name = "txtfechaFin";
            this.txtfechaFin.Size = new System.Drawing.Size(153, 22);
            this.txtfechaFin.TabIndex = 14;
            // 
            // txtfechaRegistro
            // 
            this.txtfechaRegistro.Location = new System.Drawing.Point(146, 161);
            this.txtfechaRegistro.Name = "txtfechaRegistro";
            this.txtfechaRegistro.Size = new System.Drawing.Size(153, 22);
            this.txtfechaRegistro.TabIndex = 15;
            // 
            // txtdescripcion
            // 
            this.txtdescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtdescripcion.Location = new System.Drawing.Point(146, 233);
            this.txtdescripcion.Name = "txtdescripcion";
            this.txtdescripcion.Size = new System.Drawing.Size(153, 96);
            this.txtdescripcion.TabIndex = 17;
            this.txtdescripcion.Text = "";
            // 
            // dgvEventos
            // 
            this.dgvEventos.AllowUserToOrderColumns = true;
            this.dgvEventos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvEventos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEventos.BackgroundColor = System.Drawing.Color.White;
            this.dgvEventos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEventos.Location = new System.Drawing.Point(364, 67);
            this.dgvEventos.Name = "dgvEventos";
            this.dgvEventos.ReadOnly = true;
            this.dgvEventos.RowTemplate.Height = 25;
            this.dgvEventos.Size = new System.Drawing.Size(424, 316);
            this.dgvEventos.TabIndex = 18;
            this.dgvEventos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEventos_CellClick);
            // 
            // frmHistorial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvEventos);
            this.Controls.Add(this.txtdescripcion);
            this.Controls.Add(this.txtfechaRegistro);
            this.Controls.Add(this.txtfechaFin);
            this.Controls.Add(this.txtfechaInicio);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "frmHistorial";
            this.Text = "frmHistorial";
            ((System.ComponentModel.ISupportInitialize)(this.dgvEventos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.TextBox txtfechaInicio;
        private System.Windows.Forms.TextBox txtfechaFin;
        private System.Windows.Forms.TextBox txtfechaRegistro;
        private System.Windows.Forms.RichTextBox txtdescripcion;
        private System.Windows.Forms.DataGridView dgvEventos;
    }
}