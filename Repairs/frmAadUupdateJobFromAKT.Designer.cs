namespace Repairs
{
    partial class frmAadUupdateJobFromAKT
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
            this.button1 = new System.Windows.Forms.Button();
            this.lbl_ID = new System.Windows.Forms.Label();
            this.txtBox = new System.Windows.Forms.TextBox();
            this.lbl_id_repair = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(223, 124);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Зберегти";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl_ID
            // 
            this.lbl_ID.AutoSize = true;
            this.lbl_ID.Location = new System.Drawing.Point(31, 9);
            this.lbl_ID.Name = "lbl_ID";
            this.lbl_ID.Size = new System.Drawing.Size(35, 13);
            this.lbl_ID.TabIndex = 2;
            this.lbl_ID.Text = "label1";
            this.lbl_ID.Visible = false;
            // 
            // txtBox
            // 
            this.txtBox.Location = new System.Drawing.Point(49, 56);
            this.txtBox.Name = "txtBox";
            this.txtBox.Size = new System.Drawing.Size(428, 20);
            this.txtBox.TabIndex = 1;
            // 
            // lbl_id_repair
            // 
            this.lbl_id_repair.AutoSize = true;
            this.lbl_id_repair.Location = new System.Drawing.Point(31, 124);
            this.lbl_id_repair.Name = "lbl_id_repair";
            this.lbl_id_repair.Size = new System.Drawing.Size(35, 13);
            this.lbl_id_repair.TabIndex = 3;
            this.lbl_id_repair.Text = "label1";
            this.lbl_id_repair.Visible = false;
            // 
            // frmAadUupdateJobFromAKT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 201);
            this.Controls.Add(this.lbl_id_repair);
            this.Controls.Add(this.txtBox);
            this.Controls.Add(this.lbl_ID);
            this.Controls.Add(this.button1);
            this.Name = "frmAadUupdateJobFromAKT";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Роботи по  АКТу";
            this.Load += new System.EventHandler(this.frmAadUupdateJobFromAKT_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbl_ID;
        private System.Windows.Forms.TextBox txtBox;
        private System.Windows.Forms.Label lbl_id_repair;
    }
}