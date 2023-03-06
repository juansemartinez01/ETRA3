namespace PresentationA
{
    partial class frmVersion
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
            this.lblVersion = new System.Windows.Forms.Label();
            this.botonPadre1 = new PresentationA.Controls.BotonPadre();
            this.SuspendLayout();
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Location = new System.Drawing.Point(29, 34);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(127, 21);
            this.lblVersion.TabIndex = 0;
            this.lblVersion.Text = "Version Actual:";
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
            this.botonPadre1.Location = new System.Drawing.Point(224, 109);
            this.botonPadre1.Name = "botonPadre1";
            this.botonPadre1.Size = new System.Drawing.Size(235, 37);
            this.botonPadre1.TabIndex = 1;
            this.botonPadre1.Text = "Buscar Actualizaciones";
            this.botonPadre1.UseVisualStyleBackColor = false;
            this.botonPadre1.Click += new System.EventHandler(this.botonPadre1_Click);
            // 
            // frmVersion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.botonPadre1);
            this.Controls.Add(this.lblVersion);
            this.Name = "frmVersion";
            this.Text = "frmVersion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblVersion;
        private Controls.BotonPadre botonPadre1;
    }
}