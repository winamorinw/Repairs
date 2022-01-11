namespace Repairs
{
    partial class myfrmAddNewRepair
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtp_datein = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.cbx_plan = new System.Windows.Forms.CheckBox();
            this.cbx_cehIn = new System.Windows.Forms.ComboBox();
            this.cbx_cehTo = new System.Windows.Forms.ComboBox();
            this.txt_invNum = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_SaveRepair = new System.Windows.Forms.Button();
            this.btn_searchTMC = new System.Windows.Forms.Button();
            this.txt_InvName = new System.Windows.Forms.TextBox();
            this.txt_Obekt = new System.Windows.Forms.TextBox();
            this.btnAddKontragent = new System.Windows.Forms.Button();
            this.txt_kontragent = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_Kod = new System.Windows.Forms.TextBox();
            this.txt_EDRPOU = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(36, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Отправитель";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(36, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Получатель";
            // 
            // dtp_datein
            // 
            this.dtp_datein.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dtp_datein.Location = new System.Drawing.Point(203, 82);
            this.dtp_datein.Name = "dtp_datein";
            this.dtp_datein.Size = new System.Drawing.Size(195, 23);
            this.dtp_datein.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(36, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Инвентарный номер";
            // 
            // cbx_plan
            // 
            this.cbx_plan.AutoSize = true;
            this.cbx_plan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbx_plan.Location = new System.Drawing.Point(727, 87);
            this.cbx_plan.Name = "cbx_plan";
            this.cbx_plan.Size = new System.Drawing.Size(94, 21);
            this.cbx_plan.TabIndex = 4;
            this.cbx_plan.Text = "Плановый";
            this.cbx_plan.UseVisualStyleBackColor = true;
            // 
            // cbx_cehIn
            // 
            this.cbx_cehIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbx_cehIn.FormattingEnabled = true;
            this.cbx_cehIn.Location = new System.Drawing.Point(203, 22);
            this.cbx_cehIn.Name = "cbx_cehIn";
            this.cbx_cehIn.Size = new System.Drawing.Size(618, 24);
            this.cbx_cehIn.TabIndex = 5;
            this.cbx_cehIn.SelectedIndexChanged += new System.EventHandler(this.cbx_cehIn_SelectedIndexChanged);
            // 
            // cbx_cehTo
            // 
            this.cbx_cehTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbx_cehTo.FormattingEnabled = true;
            this.cbx_cehTo.Location = new System.Drawing.Point(203, 51);
            this.cbx_cehTo.Name = "cbx_cehTo";
            this.cbx_cehTo.Size = new System.Drawing.Size(618, 24);
            this.cbx_cehTo.TabIndex = 6;
            this.cbx_cehTo.SelectedIndexChanged += new System.EventHandler(this.cbx_cehTo_SelectedIndexChanged);
            // 
            // txt_invNum
            // 
            this.txt_invNum.BackColor = System.Drawing.SystemColors.Info;
            this.txt_invNum.Enabled = false;
            this.txt_invNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_invNum.Location = new System.Drawing.Point(203, 116);
            this.txt_invNum.Name = "txt_invNum";
            this.txt_invNum.Size = new System.Drawing.Size(364, 23);
            this.txt_invNum.TabIndex = 7;
            this.txt_invNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(36, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Дата отправки";
            // 
            // btn_SaveRepair
            // 
            this.btn_SaveRepair.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_SaveRepair.Location = new System.Drawing.Point(293, 224);
            this.btn_SaveRepair.Name = "btn_SaveRepair";
            this.btn_SaveRepair.Size = new System.Drawing.Size(592, 44);
            this.btn_SaveRepair.TabIndex = 9;
            this.btn_SaveRepair.Text = "Сохранить";
            this.btn_SaveRepair.UseVisualStyleBackColor = true;
            this.btn_SaveRepair.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_searchTMC
            // 
            this.btn_searchTMC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_searchTMC.Location = new System.Drawing.Point(656, 116);
            this.btn_searchTMC.Name = "btn_searchTMC";
            this.btn_searchTMC.Size = new System.Drawing.Size(221, 23);
            this.btn_searchTMC.TabIndex = 10;
            this.btn_searchTMC.Text = "Выбор ОС";
            this.btn_searchTMC.UseVisualStyleBackColor = true;
            this.btn_searchTMC.Click += new System.EventHandler(this.button2_Click);
            // 
            // txt_InvName
            // 
            this.txt_InvName.BackColor = System.Drawing.SystemColors.Info;
            this.txt_InvName.Enabled = false;
            this.txt_InvName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_InvName.Location = new System.Drawing.Point(40, 145);
            this.txt_InvName.Name = "txt_InvName";
            this.txt_InvName.Size = new System.Drawing.Size(782, 23);
            this.txt_InvName.TabIndex = 11;
            this.txt_InvName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_Obekt
            // 
            this.txt_Obekt.BackColor = System.Drawing.SystemColors.Info;
            this.txt_Obekt.Enabled = false;
            this.txt_Obekt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_Obekt.Location = new System.Drawing.Point(573, 116);
            this.txt_Obekt.Name = "txt_Obekt";
            this.txt_Obekt.ReadOnly = true;
            this.txt_Obekt.Size = new System.Drawing.Size(81, 23);
            this.txt_Obekt.TabIndex = 12;
            // 
            // btnAddKontragent
            // 
            this.btnAddKontragent.Enabled = false;
            this.btnAddKontragent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddKontragent.Location = new System.Drawing.Point(656, 174);
            this.btnAddKontragent.Name = "btnAddKontragent";
            this.btnAddKontragent.Size = new System.Drawing.Size(166, 23);
            this.btnAddKontragent.TabIndex = 15;
            this.btnAddKontragent.Text = "Выбор контрагента";
            this.btnAddKontragent.UseVisualStyleBackColor = true;
            this.btnAddKontragent.Click += new System.EventHandler(this.btnAddKontragent_Click);
            // 
            // txt_kontragent
            // 
            this.txt_kontragent.BackColor = System.Drawing.SystemColors.Info;
            this.txt_kontragent.Enabled = false;
            this.txt_kontragent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_kontragent.Location = new System.Drawing.Point(290, 174);
            this.txt_kontragent.Name = "txt_kontragent";
            this.txt_kontragent.Size = new System.Drawing.Size(277, 23);
            this.txt_kontragent.TabIndex = 14;
            this.txt_kontragent.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(37, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "Контрагент";
            // 
            // txt_Kod
            // 
            this.txt_Kod.BackColor = System.Drawing.SystemColors.Info;
            this.txt_Kod.Enabled = false;
            this.txt_Kod.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_Kod.Location = new System.Drawing.Point(203, 174);
            this.txt_Kod.Name = "txt_Kod";
            this.txt_Kod.Size = new System.Drawing.Size(81, 23);
            this.txt_Kod.TabIndex = 17;
            this.txt_Kod.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_EDRPOU
            // 
            this.txt_EDRPOU.BackColor = System.Drawing.SystemColors.Info;
            this.txt_EDRPOU.Enabled = false;
            this.txt_EDRPOU.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_EDRPOU.Location = new System.Drawing.Point(573, 174);
            this.txt_EDRPOU.Name = "txt_EDRPOU";
            this.txt_EDRPOU.Size = new System.Drawing.Size(81, 23);
            this.txt_EDRPOU.TabIndex = 18;
            this.txt_EDRPOU.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(60, 236);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 19;
            // 
            // myfrmAddNewRepair
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 276);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txt_EDRPOU);
            this.Controls.Add(this.txt_Kod);
            this.Controls.Add(this.btnAddKontragent);
            this.Controls.Add(this.txt_kontragent);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_Obekt);
            this.Controls.Add(this.txt_InvName);
            this.Controls.Add(this.btn_searchTMC);
            this.Controls.Add(this.btn_SaveRepair);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_invNum);
            this.Controls.Add(this.cbx_cehTo);
            this.Controls.Add(this.cbx_cehIn);
            this.Controls.Add(this.cbx_plan);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtp_datein);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "myfrmAddNewRepair";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Отправка в ремонт";
            this.Load += new System.EventHandler(this.myfrmAddNewRepair_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtp_datein;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox cbx_plan;
        private System.Windows.Forms.ComboBox cbx_cehIn;
        private System.Windows.Forms.ComboBox cbx_cehTo;
        private System.Windows.Forms.TextBox txt_invNum;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_SaveRepair;
        private System.Windows.Forms.Button btn_searchTMC;
        private System.Windows.Forms.TextBox txt_InvName;
        private System.Windows.Forms.TextBox txt_Obekt;
        private System.Windows.Forms.Button btnAddKontragent;
        private System.Windows.Forms.TextBox txt_kontragent;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_Kod;
        private System.Windows.Forms.TextBox txt_EDRPOU;
        private System.Windows.Forms.TextBox textBox1;
    }
}