namespace Repairs
{
    partial class myfrmJobsForAKT
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
            this.components = new System.ComponentModel.Container();
            this.repairsDataSet4 = new Repairs.RepairsDataSet4();
            this.jobsFromAktF2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.jobs_FromAktF2TableAdapter = new Repairs.RepairsDataSet4TableAdapters.Jobs_FromAktF2TableAdapter();
            this.lbl_Inv = new System.Windows.Forms.Label();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.lbl_VedR = new System.Windows.Forms.Label();
            this.lbl_ID = new System.Windows.Forms.Label();
            this.btn_insert = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dgv_JobFromAKT = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.repairsDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobsFromAktF2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_JobFromAKT)).BeginInit();
            this.SuspendLayout();
            // 
            // repairsDataSet4
            // 
            this.repairsDataSet4.DataSetName = "RepairsDataSet4";
            this.repairsDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // jobsFromAktF2BindingSource
            // 
            this.jobsFromAktF2BindingSource.DataMember = "Jobs_FromAktF2";
            this.jobsFromAktF2BindingSource.DataSource = this.repairsDataSet4;
            // 
            // jobs_FromAktF2TableAdapter
            // 
            this.jobs_FromAktF2TableAdapter.ClearBeforeFill = true;
            // 
            // lbl_Inv
            // 
            this.lbl_Inv.AutoSize = true;
            this.lbl_Inv.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_Inv.Location = new System.Drawing.Point(8, 44);
            this.lbl_Inv.Name = "lbl_Inv";
            this.lbl_Inv.Size = new System.Drawing.Size(52, 17);
            this.lbl_Inv.TabIndex = 30;
            this.lbl_Inv.Text = "label8";
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_Name.Location = new System.Drawing.Point(67, 44);
            this.lbl_Name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(52, 17);
            this.lbl_Name.TabIndex = 29;
            this.lbl_Name.Text = "label1";
            // 
            // lbl_VedR
            // 
            this.lbl_VedR.AutoSize = true;
            this.lbl_VedR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_VedR.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbl_VedR.Location = new System.Drawing.Point(45, 9);
            this.lbl_VedR.Name = "lbl_VedR";
            this.lbl_VedR.Size = new System.Drawing.Size(59, 16);
            this.lbl_VedR.TabIndex = 28;
            this.lbl_VedR.Text = "label10";
            // 
            // lbl_ID
            // 
            this.lbl_ID.AutoSize = true;
            this.lbl_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_ID.ForeColor = System.Drawing.Color.Blue;
            this.lbl_ID.Location = new System.Drawing.Point(237, 9);
            this.lbl_ID.Name = "lbl_ID";
            this.lbl_ID.Size = new System.Drawing.Size(51, 16);
            this.lbl_ID.TabIndex = 27;
            this.lbl_ID.Text = "label9";
            // 
            // btn_insert
            // 
            this.btn_insert.Location = new System.Drawing.Point(68, 519);
            this.btn_insert.Name = "btn_insert";
            this.btn_insert.Size = new System.Drawing.Size(91, 23);
            this.btn_insert.TabIndex = 31;
            this.btn_insert.Text = "Додати роботу";
            this.btn_insert.UseVisualStyleBackColor = true;
            this.btn_insert.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(165, 519);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(98, 23);
            this.button2.TabIndex = 32;
            this.button2.Text = "Вилучити роботу";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dgv_JobFromAKT
            // 
            this.dgv_JobFromAKT.AllowUserToAddRows = false;
            this.dgv_JobFromAKT.AllowUserToDeleteRows = false;
            this.dgv_JobFromAKT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_JobFromAKT.Location = new System.Drawing.Point(14, 82);
            this.dgv_JobFromAKT.Name = "dgv_JobFromAKT";
            this.dgv_JobFromAKT.ReadOnly = true;
            this.dgv_JobFromAKT.Size = new System.Drawing.Size(433, 390);
            this.dgv_JobFromAKT.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(328, 518);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 23);
            this.button1.TabIndex = 33;
            this.button1.Text = "Редагувати л/г";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button3
            // 
            this.button3.ForeColor = System.Drawing.Color.Maroon;
            this.button3.Location = new System.Drawing.Point(14, 473);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(185, 23);
            this.button3.TabIndex = 34;
            this.button3.Text = "Перетянути роботи(оновити)";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // myfrmJobsForAKT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 554);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgv_JobFromAKT);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_insert);
            this.Controls.Add(this.lbl_Inv);
            this.Controls.Add(this.lbl_Name);
            this.Controls.Add(this.lbl_VedR);
            this.Controls.Add(this.lbl_ID);
            this.Name = "myfrmJobsForAKT";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Роботи по АКТу (форма2)";
            this.Load += new System.EventHandler(this.myfrmJobsForAKT_Load);
            ((System.ComponentModel.ISupportInitialize)(this.repairsDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobsFromAktF2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_JobFromAKT)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RepairsDataSet4 repairsDataSet4;
        private System.Windows.Forms.BindingSource jobsFromAktF2BindingSource;
        private RepairsDataSet4TableAdapters.Jobs_FromAktF2TableAdapter jobs_FromAktF2TableAdapter;
        private System.Windows.Forms.Label lbl_Inv;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.Label lbl_VedR;
        private System.Windows.Forms.Label lbl_ID;
        private System.Windows.Forms.Button btn_insert;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dgv_JobFromAKT;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
    }
}