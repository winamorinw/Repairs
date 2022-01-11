namespace Repairs
{
    partial class frmAddJobInRepairForAKT_F2
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
            this.txtBoxNamRab = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lbl_ID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoxLjudGod = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtBoxNamRab
            // 
            this.txtBoxNamRab.Location = new System.Drawing.Point(14, 26);
            this.txtBoxNamRab.MaxLength = 50;
            this.txtBoxNamRab.Name = "txtBoxNamRab";
            this.txtBoxNamRab.Size = new System.Drawing.Size(428, 20);
            this.txtBoxNamRab.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(252, 95);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Зберегти";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl_ID
            // 
            this.lbl_ID.AutoSize = true;
            this.lbl_ID.Location = new System.Drawing.Point(21, 100);
            this.lbl_ID.Name = "lbl_ID";
            this.lbl_ID.Size = new System.Drawing.Size(35, 13);
            this.lbl_ID.TabIndex = 4;
            this.lbl_ID.Text = "label1";
            this.lbl_ID.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(107, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Максимальна кіл-ть символів - 50";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(178, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Назва роботи";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(474, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Люд/год";
            // 
            // txtBoxLjudGod
            // 
            this.txtBoxLjudGod.Location = new System.Drawing.Point(450, 26);
            this.txtBoxLjudGod.MaxLength = 10;
            this.txtBoxLjudGod.Name = "txtBoxLjudGod";
            this.txtBoxLjudGod.Size = new System.Drawing.Size(106, 20);
            this.txtBoxLjudGod.TabIndex = 2;
            // 
            // frmAddJobInRepairForAKT_F2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 137);
            this.Controls.Add(this.txtBoxLjudGod);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_ID);
            this.Controls.Add(this.txtBoxNamRab);
            this.Controls.Add(this.button1);
            this.Name = "frmAddJobInRepairForAKT_F2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Додавання робот ";
            this.Load += new System.EventHandler(this.frmAddJobInRepairForAKT_F2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxNamRab;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbl_ID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBoxLjudGod;
    }
}