namespace Repairs
{
    partial class myfrmRedZhpz
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
            this.txt_Shpz = new System.Windows.Forms.TextBox();
            this.lbl_Inv = new System.Windows.Forms.Label();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.lbl_VedR = new System.Windows.Forms.Label();
            this.lbl_ID = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_Shpz
            // 
            this.txt_Shpz.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txt_Shpz.Location = new System.Drawing.Point(196, 102);
            this.txt_Shpz.Name = "txt_Shpz";
            this.txt_Shpz.Size = new System.Drawing.Size(101, 21);
            this.txt_Shpz.TabIndex = 1;
            // 
            // lbl_Inv
            // 
            this.lbl_Inv.AutoSize = true;
            this.lbl_Inv.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_Inv.Location = new System.Drawing.Point(33, 53);
            this.lbl_Inv.Name = "lbl_Inv";
            this.lbl_Inv.Size = new System.Drawing.Size(52, 17);
            this.lbl_Inv.TabIndex = 34;
            this.lbl_Inv.Text = "label8";
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_Name.Location = new System.Drawing.Point(120, 53);
            this.lbl_Name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(52, 17);
            this.lbl_Name.TabIndex = 33;
            this.lbl_Name.Text = "label1";
            // 
            // lbl_VedR
            // 
            this.lbl_VedR.AutoSize = true;
            this.lbl_VedR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_VedR.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbl_VedR.Location = new System.Drawing.Point(70, 13);
            this.lbl_VedR.Name = "lbl_VedR";
            this.lbl_VedR.Size = new System.Drawing.Size(59, 16);
            this.lbl_VedR.TabIndex = 32;
            this.lbl_VedR.Text = "label10";
            // 
            // lbl_ID
            // 
            this.lbl_ID.AutoSize = true;
            this.lbl_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_ID.ForeColor = System.Drawing.Color.Blue;
            this.lbl_ID.Location = new System.Drawing.Point(262, 13);
            this.lbl_ID.Name = "lbl_ID";
            this.lbl_ID.Size = new System.Drawing.Size(51, 16);
            this.lbl_ID.TabIndex = 31;
            this.lbl_ID.Text = "label9";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(206, 165);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 35;
            this.button1.Text = "Зберегти";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label1.Location = new System.Drawing.Point(160, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 15);
            this.label1.TabIndex = 36;
            this.label1.Text = "ШВЗ";
            // 
            // myfrmRedZhpz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 216);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbl_Inv);
            this.Controls.Add(this.lbl_Name);
            this.Controls.Add(this.lbl_VedR);
            this.Controls.Add(this.lbl_ID);
            this.Controls.Add(this.txt_Shpz);
            this.Name = "myfrmRedZhpz";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Редагування ШВЗ";
            this.Load += new System.EventHandler(this.myfrmRedZhpz_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Shpz;
        private System.Windows.Forms.Label lbl_Inv;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.Label lbl_VedR;
        private System.Windows.Forms.Label lbl_ID;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}