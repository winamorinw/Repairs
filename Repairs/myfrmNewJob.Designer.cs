namespace Repairs
{
    partial class myfrmNewJob
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
            this.lbl_nameRepair = new System.Windows.Forms.Label();
            this.cbx_Job = new System.Windows.Forms.ComboBox();
            this.btn_saveJob = new System.Windows.Forms.Button();
            this.dgv_User = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_User)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_nameRepair
            // 
            this.lbl_nameRepair.AutoSize = true;
            this.lbl_nameRepair.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_nameRepair.Location = new System.Drawing.Point(29, 22);
            this.lbl_nameRepair.Name = "lbl_nameRepair";
            this.lbl_nameRepair.Size = new System.Drawing.Size(0, 19);
            this.lbl_nameRepair.TabIndex = 0;
            // 
            // cbx_Job
            // 
            this.cbx_Job.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbx_Job.FormattingEnabled = true;
            this.cbx_Job.Location = new System.Drawing.Point(12, 22);
            this.cbx_Job.Name = "cbx_Job";
            this.cbx_Job.Size = new System.Drawing.Size(595, 24);
            this.cbx_Job.TabIndex = 1;
            // 
            // btn_saveJob
            // 
            this.btn_saveJob.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_saveJob.Location = new System.Drawing.Point(12, 85);
            this.btn_saveJob.Name = "btn_saveJob";
            this.btn_saveJob.Size = new System.Drawing.Size(595, 45);
            this.btn_saveJob.TabIndex = 2;
            this.btn_saveJob.Text = "Добавить          +          Сохранить";
            this.btn_saveJob.UseVisualStyleBackColor = true;
            this.btn_saveJob.Click += new System.EventHandler(this.btn_saveJob_Click);
            // 
            // dgv_User
            // 
            this.dgv_User.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_User.Location = new System.Drawing.Point(556, 136);
            this.dgv_User.Name = "dgv_User";
            this.dgv_User.Size = new System.Drawing.Size(11, 10);
            this.dgv_User.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "label1";
            // 
            // myfrmNewJob
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 194);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_User);
            this.Controls.Add(this.btn_saveJob);
            this.Controls.Add(this.cbx_Job);
            this.Controls.Add(this.lbl_nameRepair);
            this.Location = new System.Drawing.Point(20, 20);
            this.Name = "myfrmNewJob";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ввод выполняемой работы";
            this.Load += new System.EventHandler(this.myfrmNewJob_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_User)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_nameRepair;
        private System.Windows.Forms.ComboBox cbx_Job;
        private System.Windows.Forms.Button btn_saveJob;
        private System.Windows.Forms.DataGridView dgv_User;
        private System.Windows.Forms.Label label1;
    }
}