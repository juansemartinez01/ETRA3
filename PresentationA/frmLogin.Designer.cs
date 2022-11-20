
namespace PresentationA
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lnkRecuperar = new System.Windows.Forms.LinkLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblError = new System.Windows.Forms.Label();
            this.botonPadre1 = new PresentationA.Controls.BotonPadre();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtUser
            // 
            this.txtUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUser.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtUser.ForeColor = System.Drawing.Color.DimGray;
            this.txtUser.Location = new System.Drawing.Point(307, 133);
            this.txtUser.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(524, 20);
            this.txtUser.TabIndex = 1;
            this.txtUser.Text = "USUARIO";
            this.txtUser.Click += new System.EventHandler(this.txtUser_Enter);
            this.txtUser.Enter += new System.EventHandler(this.txtUser_Enter);
            this.txtUser.Leave += new System.EventHandler(this.txtUser_Leave);
            // 
            // txtPass
            // 
            this.txtPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPass.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtPass.ForeColor = System.Drawing.Color.DimGray;
            this.txtPass.Location = new System.Drawing.Point(307, 212);
            this.txtPass.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(524, 20);
            this.txtPass.TabIndex = 2;
            this.txtPass.Text = "CONTRASEÑA";
            this.txtPass.Click += new System.EventHandler(this.txtPass_Enter);
            this.txtPass.Enter += new System.EventHandler(this.txtPass_Enter);
            this.txtPass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPass_KeyPress);
            this.txtPass.Leave += new System.EventHandler(this.txtPass_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F);
            this.label1.Location = new System.Drawing.Point(505, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 33);
            this.label1.TabIndex = 3;
            this.label1.Text = "LOGIN";
            // 
            // lnkRecuperar
            // 
            this.lnkRecuperar.AutoSize = true;
            this.lnkRecuperar.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.lnkRecuperar.Location = new System.Drawing.Point(473, 368);
            this.lnkRecuperar.Name = "lnkRecuperar";
            this.lnkRecuperar.Size = new System.Drawing.Size(173, 17);
            this.lnkRecuperar.TabIndex = 0;
            this.lnkRecuperar.TabStop = true;
            this.lnkRecuperar.Text = "Ha olvidado la contraseña?";
            this.lnkRecuperar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkRecuperar_LinkClicked);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(166)))), ((int)(((byte)(26)))));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(233, 406);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::PresentationA.Properties.Resources.logoLWS2;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(233, 406);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.lblError.ForeColor = System.Drawing.Color.DimGray;
            this.lblError.Image = global::PresentationA.Properties.Resources.kisspng_exclamation_mark_clip_art_vector_graphics_computer_5ced29986ef952_9605616015590465524546__1___1_;
            this.lblError.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblError.Location = new System.Drawing.Point(307, 262);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(34, 17);
            this.lblError.TabIndex = 4;
            this.lblError.Text = "Error";
            this.lblError.Visible = false;
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
            this.botonPadre1.Location = new System.Drawing.Point(307, 305);
            this.botonPadre1.Name = "botonPadre1";
            this.botonPadre1.Size = new System.Drawing.Size(524, 40);
            this.botonPadre1.TabIndex = 5;
            this.botonPadre1.Text = "Iniciar Sesion";
            this.botonPadre1.UseVisualStyleBackColor = false;
            this.botonPadre1.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // frmLogin
            // 
            this.AcceptButton = this.botonPadre1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(910, 406);
            this.Controls.Add(this.botonPadre1);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.lnkRecuperar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "  ";
            this.Click += new System.EventHandler(this.frmLogin_Click);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel lnkRecuperar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblError;
        private Controls.BotonPadre botonPadre1;
    }
}