namespace Repairs
{
    partial class myfrm_add_uzel_rem
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
            this.cbx_uzel_rem = new System.Windows.Forms.ComboBox();
            this.btn_notsave = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbx_uzel_rem
            // 
            this.cbx_uzel_rem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cbx_uzel_rem.FormattingEnabled = true;
            this.cbx_uzel_rem.Location = new System.Drawing.Point(12, 21);
            this.cbx_uzel_rem.Name = "cbx_uzel_rem";
            this.cbx_uzel_rem.Size = new System.Drawing.Size(201, 24);
            this.cbx_uzel_rem.TabIndex = 85;
            // 
            // btn_notsave
            // 
            this.btn_notsave.Image = global::Repairs.Properties.Resources.No_entry;
            this.btn_notsave.Location = new System.Drawing.Point(286, 12);
            this.btn_notsave.Name = "btn_notsave";
            this.btn_notsave.Size = new System.Drawing.Size(43, 38);
            this.btn_notsave.TabIndex = 84;
            this.btn_notsave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_notsave.UseVisualStyleBackColor = true;
            this.btn_notsave.Click += new System.EventHandler(this.btn_notsave_Click);
            // 
            // btn_save
            // 
            this.btn_save.Image = global::Repairs.Properties.Resources.OK1;
            this.btn_save.Location = new System.Drawing.Point(239, 12);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(42, 38);
            this.btn_save.TabIndex = 83;
            this.btn_save.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // myfrm_add_uzel_rem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(332, 62);
            this.ControlBox = false;
            this.Controls.Add(this.cbx_uzel_rem);
            this.Controls.Add(this.btn_notsave);
            this.Controls.Add(this.btn_save);
            this.Name = "myfrm_add_uzel_rem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавление узла ремонта";
            this.Load += new System.EventHandler(this.myfrm_add_uzel_rem_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_notsave;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.ComboBox cbx_uzel_rem;
    }
}