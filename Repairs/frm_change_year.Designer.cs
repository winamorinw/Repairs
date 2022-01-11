namespace Repairs
{
    partial class frm_change_year
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
            this.text_year = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_ok = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // text_year
            // 
            this.text_year.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.text_year.ForeColor = System.Drawing.Color.Black;
            this.text_year.Location = new System.Drawing.Point(88, 64);
            this.text_year.Name = "text_year";
            this.text_year.Size = new System.Drawing.Size(73, 24);
            this.text_year.TabIndex = 1;
            this.text_year.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.text_year.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_year_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(81, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Оберіть рік";
            // 
            // button_ok
            // 
            this.button_ok.Location = new System.Drawing.Point(88, 111);
            this.button_ok.Name = "button_ok";
            this.button_ok.Size = new System.Drawing.Size(75, 23);
            this.button_ok.TabIndex = 2;
            this.button_ok.Text = "Ok";
            this.button_ok.UseVisualStyleBackColor = true;
            this.button_ok.Click += new System.EventHandler(this.button_ok_Click);
            // 
            // frm_change_year
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(249, 163);
            this.Controls.Add(this.button_ok);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.text_year);
            this.Name = "frm_change_year";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Вибір року";
            this.Load += new System.EventHandler(this.Frm_change_year_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox text_year;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_ok;
    }
}