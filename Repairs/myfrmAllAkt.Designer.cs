namespace Repairs
{
    partial class myfrmAllAkt
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
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txt_SearchInv = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgv_os_usl = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_DrukAktF2 = new System.Windows.Forms.Button();
            this.btn_procenti_akt = new System.Windows.Forms.Button();
            this.btn_UpdateShpz = new System.Windows.Forms.Button();
            this.groupBox5.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_os_usl)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.PeachPuff;
            this.groupBox5.Controls.Add(this.txt_SearchInv);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox5.Location = new System.Drawing.Point(12, 12);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(143, 49);
            this.groupBox5.TabIndex = 17;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Пошук за інв. №";
            // 
            // txt_SearchInv
            // 
            this.txt_SearchInv.Location = new System.Drawing.Point(6, 22);
            this.txt_SearchInv.Name = "txt_SearchInv";
            this.txt_SearchInv.Size = new System.Drawing.Size(131, 21);
            this.txt_SearchInv.TabIndex = 0;
            this.txt_SearchInv.TextChanged += new System.EventHandler(this.txt_SearchInv_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgv_os_usl);
            this.groupBox1.Location = new System.Drawing.Point(12, 67);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1110, 479);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            // 
            // dgv_os_usl
            // 
            this.dgv_os_usl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_os_usl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_os_usl.Location = new System.Drawing.Point(3, 16);
            this.dgv_os_usl.Name = "dgv_os_usl";
            this.dgv_os_usl.Size = new System.Drawing.Size(1104, 460);
            this.dgv_os_usl.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(286, 35);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 23);
            this.button1.TabIndex = 32;
            this.button1.Text = "Роботи по  АКТу(ф2)";
            this.button1.UseMnemonic = false;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_DrukAktF2
            // 
            this.btn_DrukAktF2.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btn_DrukAktF2.Location = new System.Drawing.Point(417, 12);
            this.btn_DrukAktF2.Name = "btn_DrukAktF2";
            this.btn_DrukAktF2.Size = new System.Drawing.Size(152, 23);
            this.btn_DrukAktF2.TabIndex = 31;
            this.btn_DrukAktF2.Text = "Друк АКТа (Ф2)";
            this.btn_DrukAktF2.UseVisualStyleBackColor = true;
            this.btn_DrukAktF2.Click += new System.EventHandler(this.btn_DrukAktF2_Click);
            // 
            // btn_procenti_akt
            // 
            this.btn_procenti_akt.Location = new System.Drawing.Point(286, 12);
            this.btn_procenti_akt.Name = "btn_procenti_akt";
            this.btn_procenti_akt.Size = new System.Drawing.Size(122, 23);
            this.btn_procenti_akt.TabIndex = 30;
            this.btn_procenti_akt.Text = "% по АКТу(ф2)";
            this.btn_procenti_akt.UseMnemonic = false;
            this.btn_procenti_akt.UseVisualStyleBackColor = true;
            this.btn_procenti_akt.Click += new System.EventHandler(this.btn_procenti_akt_Click);
            // 
            // btn_UpdateShpz
            // 
            this.btn_UpdateShpz.Location = new System.Drawing.Point(174, 16);
            this.btn_UpdateShpz.Name = "btn_UpdateShpz";
            this.btn_UpdateShpz.Size = new System.Drawing.Size(94, 39);
            this.btn_UpdateShpz.TabIndex = 33;
            this.btn_UpdateShpz.Text = "Редагувати ШВЗ";
            this.btn_UpdateShpz.UseVisualStyleBackColor = true;
            this.btn_UpdateShpz.Click += new System.EventHandler(this.btn_UpdateVedRes_Click);
            // 
            // myfrmAllAkt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1134, 558);
            this.Controls.Add(this.btn_UpdateShpz);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_DrukAktF2);
            this.Controls.Add(this.btn_procenti_akt);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox5);
            this.Name = "myfrmAllAkt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Акти по послугам";
            this.Load += new System.EventHandler(this.myfrmAllAkt_Load);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_os_usl)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox txt_SearchInv;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgv_os_usl;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_DrukAktF2;
        private System.Windows.Forms.Button btn_procenti_akt;
        private System.Windows.Forms.Button btn_UpdateShpz;
    }
}