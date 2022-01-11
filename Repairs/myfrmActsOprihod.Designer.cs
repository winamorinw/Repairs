namespace Repairs
{
    partial class myfrmActsOprihod
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
            this.dgv_allActs = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgv_bu_Replace = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_doljChlen2 = new System.Windows.Forms.TextBox();
            this.txt_Fio_Chlen2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_doljChlen1 = new System.Windows.Forms.TextBox();
            this.txt_FIO_Chlen1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txt_dolj_pred = new System.Windows.Forms.TextBox();
            this.txt_FIO_Pred = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_PrintAct = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_allActs)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_bu_Replace)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgv_allActs);
            this.groupBox1.Location = new System.Drawing.Point(21, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(512, 218);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Список актов";
            // 
            // dgv_allActs
            // 
            this.dgv_allActs.AllowUserToAddRows = false;
            this.dgv_allActs.AllowUserToDeleteRows = false;
            this.dgv_allActs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_allActs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_allActs.Location = new System.Drawing.Point(3, 16);
            this.dgv_allActs.Name = "dgv_allActs";
            this.dgv_allActs.ReadOnly = true;
            this.dgv_allActs.Size = new System.Drawing.Size(506, 199);
            this.dgv_allActs.TabIndex = 0;
            this.dgv_allActs.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_allActs_CellContentClick);
            this.dgv_allActs.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_allActs_CellEnter);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgv_bu_Replace);
            this.groupBox3.Location = new System.Drawing.Point(24, 248);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1060, 220);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Список оприходуемых запчастей";
            // 
            // dgv_bu_Replace
            // 
            this.dgv_bu_Replace.AllowUserToAddRows = false;
            this.dgv_bu_Replace.AllowUserToDeleteRows = false;
            this.dgv_bu_Replace.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_bu_Replace.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_bu_Replace.Location = new System.Drawing.Point(3, 16);
            this.dgv_bu_Replace.Name = "dgv_bu_Replace";
            this.dgv_bu_Replace.ReadOnly = true;
            this.dgv_bu_Replace.Size = new System.Drawing.Size(1054, 201);
            this.dgv_bu_Replace.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_doljChlen2);
            this.groupBox2.Controls.Add(this.txt_Fio_Chlen2);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txt_doljChlen1);
            this.groupBox2.Controls.Add(this.txt_FIO_Chlen1);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(561, 89);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(523, 141);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Члены комиссии";
            // 
            // txt_doljChlen2
            // 
            this.txt_doljChlen2.BackColor = System.Drawing.SystemColors.Window;
            this.txt_doljChlen2.Location = new System.Drawing.Point(89, 104);
            this.txt_doljChlen2.Name = "txt_doljChlen2";
            this.txt_doljChlen2.ReadOnly = true;
            this.txt_doljChlen2.Size = new System.Drawing.Size(412, 20);
            this.txt_doljChlen2.TabIndex = 7;
            // 
            // txt_Fio_Chlen2
            // 
            this.txt_Fio_Chlen2.BackColor = System.Drawing.SystemColors.Window;
            this.txt_Fio_Chlen2.Location = new System.Drawing.Point(89, 79);
            this.txt_Fio_Chlen2.Name = "txt_Fio_Chlen2";
            this.txt_Fio_Chlen2.ReadOnly = true;
            this.txt_Fio_Chlen2.Size = new System.Drawing.Size(412, 20);
            this.txt_Fio_Chlen2.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Должность";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 86);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "ФИО";
            // 
            // txt_doljChlen1
            // 
            this.txt_doljChlen1.BackColor = System.Drawing.SystemColors.Window;
            this.txt_doljChlen1.Location = new System.Drawing.Point(89, 43);
            this.txt_doljChlen1.Name = "txt_doljChlen1";
            this.txt_doljChlen1.ReadOnly = true;
            this.txt_doljChlen1.Size = new System.Drawing.Size(412, 20);
            this.txt_doljChlen1.TabIndex = 3;
            // 
            // txt_FIO_Chlen1
            // 
            this.txt_FIO_Chlen1.BackColor = System.Drawing.SystemColors.Window;
            this.txt_FIO_Chlen1.Location = new System.Drawing.Point(89, 18);
            this.txt_FIO_Chlen1.Name = "txt_FIO_Chlen1";
            this.txt_FIO_Chlen1.ReadOnly = true;
            this.txt_FIO_Chlen1.Size = new System.Drawing.Size(412, 20);
            this.txt_FIO_Chlen1.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Должность";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "ФИО";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txt_dolj_pred);
            this.groupBox4.Controls.Add(this.txt_FIO_Pred);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Location = new System.Drawing.Point(561, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(523, 78);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Председатель комиссии";
            // 
            // txt_dolj_pred
            // 
            this.txt_dolj_pred.BackColor = System.Drawing.SystemColors.Window;
            this.txt_dolj_pred.Location = new System.Drawing.Point(89, 44);
            this.txt_dolj_pred.Name = "txt_dolj_pred";
            this.txt_dolj_pred.ReadOnly = true;
            this.txt_dolj_pred.Size = new System.Drawing.Size(412, 20);
            this.txt_dolj_pred.TabIndex = 3;
            // 
            // txt_FIO_Pred
            // 
            this.txt_FIO_Pred.BackColor = System.Drawing.SystemColors.Window;
            this.txt_FIO_Pred.Location = new System.Drawing.Point(89, 19);
            this.txt_FIO_Pred.Name = "txt_FIO_Pred";
            this.txt_FIO_Pred.ReadOnly = true;
            this.txt_FIO_Pred.Size = new System.Drawing.Size(412, 20);
            this.txt_FIO_Pred.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Должность";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ФИО";
            // 
            // btn_PrintAct
            // 
            this.btn_PrintAct.Location = new System.Drawing.Point(869, 485);
            this.btn_PrintAct.Name = "btn_PrintAct";
            this.btn_PrintAct.Size = new System.Drawing.Size(75, 23);
            this.btn_PrintAct.TabIndex = 5;
            this.btn_PrintAct.Text = "Печать";
            this.btn_PrintAct.UseVisualStyleBackColor = true;
            this.btn_PrintAct.Click += new System.EventHandler(this.button1_Click);
            // 
            // myfrmActsOprihod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1096, 534);
            this.Controls.Add(this.btn_PrintAct);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "myfrmActsOprihod";
            this.Text = "Список Актов";
            this.Load += new System.EventHandler(this.myfrmActsOprihod_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_allActs)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_bu_Replace)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgv_allActs;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgv_bu_Replace;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_doljChlen2;
        private System.Windows.Forms.TextBox txt_Fio_Chlen2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_doljChlen1;
        private System.Windows.Forms.TextBox txt_FIO_Chlen1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txt_dolj_pred;
        private System.Windows.Forms.TextBox txt_FIO_Pred;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_PrintAct;
    }
}