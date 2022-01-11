namespace Repairs
{
    partial class myfrmSelectMol
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgv_AllMol = new System.Windows.Forms.DataGridView();
            this.btn_SaveMol = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_AllMol)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgv_AllMol);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(894, 387);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Подотчетные лица";
            // 
            // dgv_AllMol
            // 
            this.dgv_AllMol.AllowUserToAddRows = false;
            this.dgv_AllMol.AllowUserToDeleteRows = false;
            this.dgv_AllMol.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_AllMol.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_AllMol.Location = new System.Drawing.Point(3, 19);
            this.dgv_AllMol.Name = "dgv_AllMol";
            this.dgv_AllMol.ReadOnly = true;
            this.dgv_AllMol.Size = new System.Drawing.Size(888, 365);
            this.dgv_AllMol.TabIndex = 0;
            this.dgv_AllMol.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_AllMol_CellContentClick);
            this.dgv_AllMol.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_AllMol_CellEnter);
            // 
            // btn_SaveMol
            // 
            this.btn_SaveMol.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_SaveMol.Location = new System.Drawing.Point(456, 405);
            this.btn_SaveMol.Name = "btn_SaveMol";
            this.btn_SaveMol.Size = new System.Drawing.Size(447, 54);
            this.btn_SaveMol.TabIndex = 1;
            this.btn_SaveMol.Text = "Сохранить";
            this.btn_SaveMol.UseVisualStyleBackColor = true;
            this.btn_SaveMol.Click += new System.EventHandler(this.button1_Click);
            // 
            // myfrmSelectMol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 480);
            this.Controls.Add(this.btn_SaveMol);
            this.Controls.Add(this.groupBox1);
            this.Name = "myfrmSelectMol";
            this.Text = "Выбор подотчетного лица";
            this.Load += new System.EventHandler(this.myfrmSelectMol_Load_1);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_AllMol)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgv_AllMol;
        private System.Windows.Forms.Button btn_SaveMol;
    }
}