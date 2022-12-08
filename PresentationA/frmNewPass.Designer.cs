namespace PresentationA
{
    partial class frmNewPass
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
            this.btnConfirmar = new PresentationA.Controls.BotonPadre();
            this.lblError = new System.Windows.Forms.Label();
            this.txtNew = new System.Windows.Forms.TextBox();
            this.txtConfirm = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(370, 30);
            this.label1.TabIndex = 4;
            this.label1.Text = "Establecer Nueva Contraseña";
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(166)))), ((int)(((byte)(26)))));
            this.btnConfirmar.FlatAppearance.BorderSize = 0;
            this.btnConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnConfirmar.ForeColor = System.Drawing.Color.White;
            this.btnConfirmar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnConfirmar.IconColor = System.Drawing.Color.Black;
            this.btnConfirmar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnConfirmar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfirmar.Location = new System.Drawing.Point(123, 322);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(150, 40);
            this.btnConfirmar.TabIndex = 8;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = false;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // lblError
            // 
            this.lblError.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.lblError.ForeColor = System.Drawing.Color.DimGray;
            this.lblError.Image = global::PresentationA.Properties.Resources.kisspng_exclamation_mark_clip_art_vector_graphics_computer_5ced29986ef952_9605616015590465524546__1___1_;
            this.lblError.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblError.Location = new System.Drawing.Point(29, 237);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(358, 76);
            this.lblError.TabIndex = 9;
            this.lblError.Text = "Error";
            this.lblError.Visible = false;
            // 
            // txtNew
            // 
            this.txtNew.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNew.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtNew.ForeColor = System.Drawing.Color.DimGray;
            this.txtNew.Location = new System.Drawing.Point(32, 111);
            this.txtNew.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNew.Name = "txtNew";
            this.txtNew.Size = new System.Drawing.Size(208, 20);
            this.txtNew.TabIndex = 10;
            this.txtNew.Text = "NUEVA CONTRASEÑA";
            this.txtNew.Click += new System.EventHandler(this.txtNew_Enter);
            this.txtNew.Enter += new System.EventHandler(this.txtNew_Enter);
            this.txtNew.Leave += new System.EventHandler(this.txtNew_Leave);
            // 
            // txtConfirm
            // 
            this.txtConfirm.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtConfirm.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtConfirm.ForeColor = System.Drawing.Color.DimGray;
            this.txtConfirm.Location = new System.Drawing.Point(32, 177);
            this.txtConfirm.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtConfirm.Name = "txtConfirm";
            this.txtConfirm.Size = new System.Drawing.Size(257, 20);
            this.txtConfirm.TabIndex = 11;
            this.txtConfirm.Text = "REPITA SU NUEVA CONTRASEÑA";
            this.txtConfirm.Click += new System.EventHandler(this.txtConfirm_Enter);
            this.txtConfirm.Enter += new System.EventHandler(this.txtConfirm_Enter);
            this.txtConfirm.Leave += new System.EventHandler(this.txtConfirm_Leave);
            // 
            // frmNewPass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 374);
            this.Controls.Add(this.txtConfirm);
            this.Controls.Add(this.txtNew);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmNewPass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nueva Contraseña";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private Controls.BotonPadre btnConfirmar;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.TextBox txtNew;
        private System.Windows.Forms.TextBox txtConfirm;
    }
}