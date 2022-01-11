namespace Repairs
{
    partial class frmVhod
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVhod));
            this.linkLblVhod = new System.Windows.Forms.LinkLabel();
            this.linkLblEsc = new System.Windows.Forms.LinkLabel();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.lblPass = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cbxUser = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // linkLblVhod
            // 
            this.linkLblVhod.AutoSize = true;
            this.linkLblVhod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.linkLblVhod.Location = new System.Drawing.Point(104, 69);
            this.linkLblVhod.Name = "linkLblVhod";
            this.linkLblVhod.Size = new System.Drawing.Size(114, 20);
            this.linkLblVhod.TabIndex = 3;
            this.linkLblVhod.TabStop = true;
            this.linkLblVhod.Tag = "";
            this.linkLblVhod.Text = "ENTER - Вход";
            this.linkLblVhod.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLblVhod_LinkClicked);
            // 
            // linkLblEsc
            // 
            this.linkLblEsc.AutoSize = true;
            this.linkLblEsc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.linkLblEsc.LinkColor = System.Drawing.Color.MediumBlue;
            this.linkLblEsc.Location = new System.Drawing.Point(224, 69);
            this.linkLblEsc.Name = "linkLblEsc";
            this.linkLblEsc.Size = new System.Drawing.Size(104, 20);
            this.linkLblEsc.TabIndex = 4;
            this.linkLblEsc.TabStop = true;
            this.linkLblEsc.Tag = "";
            this.linkLblEsc.Text = "ESC - Выход";
            this.linkLblEsc.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLblEsc_LinkClicked);
            // 
            // txtPass
            // 
            this.txtPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtPass.Location = new System.Drawing.Point(179, 39);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(149, 26);
            this.txtPass.TabIndex = 2;
            this.txtPass.Tag = "";
            this.txtPass.UseSystemPasswordChar = true;
            this.txtPass.TextChanged += new System.EventHandler(this.txtPass_TextChanged);
            this.txtPass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KeyDown);
            this.txtPass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPass.Location = new System.Drawing.Point(102, 42);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(71, 20);
            this.lblPass.TabIndex = 35;
            this.lblPass.Text = "Пароль:";
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblLogin.Location = new System.Drawing.Point(114, 10);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(59, 20);
            this.lblLogin.TabIndex = 34;
            this.lblLogin.Text = "Логин:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(95, 93);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            // 
            // cbxUser
            // 
            this.cbxUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbxUser.FormattingEnabled = true;
            this.cbxUser.Location = new System.Drawing.Point(179, 10);
            this.cbxUser.Name = "cbxUser";
            this.cbxUser.Size = new System.Drawing.Size(149, 24);
            this.cbxUser.TabIndex = 1;
            this.cbxUser.Tag = "";
            // 
            // frmVhod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(337, 100);
            this.Controls.Add(this.cbxUser);
            this.Controls.Add(this.lblPass);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.linkLblVhod);
            this.Controls.Add(this.linkLblEsc);
            this.Controls.Add(this.txtPass);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmVhod";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Авторизация";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmVhod_FormClosing);
            this.Load += new System.EventHandler(this.frmVhod_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkLblVhod;
        private System.Windows.Forms.LinkLabel linkLblEsc;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.ComboBox cbxUser;
    }
}