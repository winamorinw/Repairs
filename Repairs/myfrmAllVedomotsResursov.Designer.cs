namespace Repairs
{
    partial class myfrmAllVedomotsResursov
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
            this.dgv_AllVedomostsResursob = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgv_RepPlace = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgv_Met = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.dgv_Det = new System.Windows.Forms.DataGridView();
            this.btn_PrintVedRes = new System.Windows.Forms.Button();
            this.btn_UpdateVedRes = new System.Windows.Forms.Button();
            this.btn_DelVedRes = new System.Windows.Forms.Button();
            this.btn_alterRepair = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txt_SearchInv = new System.Windows.Forms.TextBox();
            this.btn_PrintForm2 = new System.Windows.Forms.Button();
            this.btn_Update_F_2 = new System.Windows.Forms.Button();
            this.btn_ProizTezhOtchet = new System.Windows.Forms.Button();
            this.btn_procenti_akt = new System.Windows.Forms.Button();
            this.btn_DrukAktF2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dgv_mes_god_ceh = new System.Windows.Forms.DataGridView();
            this.btn_UpdateShpz = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_AvtomatAktF2 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.labelCapital = new System.Windows.Forms.Label();
            this.buttonCapital = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_AllVedomostsResursob)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_RepPlace)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Met)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Det)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_mes_god_ceh)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgv_AllVedomostsResursob);
            this.groupBox1.Location = new System.Drawing.Point(12, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(769, 202);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Все ведомости ресурсов";
            // 
            // dgv_AllVedomostsResursob
            // 
            this.dgv_AllVedomostsResursob.AllowUserToAddRows = false;
            this.dgv_AllVedomostsResursob.AllowUserToDeleteRows = false;
            this.dgv_AllVedomostsResursob.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_AllVedomostsResursob.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_AllVedomostsResursob.Location = new System.Drawing.Point(3, 16);
            this.dgv_AllVedomostsResursob.Name = "dgv_AllVedomostsResursob";
            this.dgv_AllVedomostsResursob.ReadOnly = true;
            this.dgv_AllVedomostsResursob.Size = new System.Drawing.Size(763, 183);
            this.dgv_AllVedomostsResursob.TabIndex = 0;
            this.dgv_AllVedomostsResursob.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_AllVedomostsResursob_CellContentClick);
            this.dgv_AllVedomostsResursob.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_AllVedomostsResursob_CellEnter);
            this.dgv_AllVedomostsResursob.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_AllVedomostsResursob_RowEnter);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgv_RepPlace);
            this.groupBox2.Location = new System.Drawing.Point(15, 278);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(769, 229);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Запчасти";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // dgv_RepPlace
            // 
            this.dgv_RepPlace.AllowUserToAddRows = false;
            this.dgv_RepPlace.AllowUserToDeleteRows = false;
            this.dgv_RepPlace.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_RepPlace.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_RepPlace.Location = new System.Drawing.Point(3, 16);
            this.dgv_RepPlace.Name = "dgv_RepPlace";
            this.dgv_RepPlace.ReadOnly = true;
            this.dgv_RepPlace.Size = new System.Drawing.Size(763, 210);
            this.dgv_RepPlace.TabIndex = 0;
            this.dgv_RepPlace.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_RepPlace_CellContentClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgv_Met);
            this.groupBox3.Location = new System.Drawing.Point(790, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(350, 238);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Возвратный металлолом";
            // 
            // dgv_Met
            // 
            this.dgv_Met.AllowUserToAddRows = false;
            this.dgv_Met.AllowUserToDeleteRows = false;
            this.dgv_Met.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Met.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Met.Location = new System.Drawing.Point(3, 16);
            this.dgv_Met.Name = "dgv_Met";
            this.dgv_Met.ReadOnly = true;
            this.dgv_Met.Size = new System.Drawing.Size(344, 219);
            this.dgv_Met.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button3);
            this.groupBox4.Controls.Add(this.dgv_Det);
            this.groupBox4.Location = new System.Drawing.Point(790, 257);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(350, 228);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Возвратные детали";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(260, -4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 27;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Visible = false;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // dgv_Det
            // 
            this.dgv_Det.AllowUserToAddRows = false;
            this.dgv_Det.AllowUserToDeleteRows = false;
            this.dgv_Det.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Det.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Det.Location = new System.Drawing.Point(3, 16);
            this.dgv_Det.Name = "dgv_Det";
            this.dgv_Det.ReadOnly = true;
            this.dgv_Det.Size = new System.Drawing.Size(344, 209);
            this.dgv_Det.TabIndex = 0;
            // 
            // btn_PrintVedRes
            // 
            this.btn_PrintVedRes.ForeColor = System.Drawing.Color.Blue;
            this.btn_PrintVedRes.Location = new System.Drawing.Point(646, 510);
            this.btn_PrintVedRes.Name = "btn_PrintVedRes";
            this.btn_PrintVedRes.Size = new System.Drawing.Size(123, 42);
            this.btn_PrintVedRes.TabIndex = 4;
            this.btn_PrintVedRes.Text = "Печать ведомость ресурсов";
            this.btn_PrintVedRes.UseVisualStyleBackColor = true;
            this.btn_PrintVedRes.Click += new System.EventHandler(this.btn_PrintVedRes_Click);
            // 
            // btn_UpdateVedRes
            // 
            this.btn_UpdateVedRes.Location = new System.Drawing.Point(591, 12);
            this.btn_UpdateVedRes.Name = "btn_UpdateVedRes";
            this.btn_UpdateVedRes.Size = new System.Drawing.Size(94, 39);
            this.btn_UpdateVedRes.TabIndex = 5;
            this.btn_UpdateVedRes.Text = "Редактировать ведомость";
            this.btn_UpdateVedRes.UseVisualStyleBackColor = true;
            this.btn_UpdateVedRes.Click += new System.EventHandler(this.btn_UpdateVedRes_Click);
            // 
            // btn_DelVedRes
            // 
            this.btn_DelVedRes.Location = new System.Drawing.Point(690, 12);
            this.btn_DelVedRes.Name = "btn_DelVedRes";
            this.btn_DelVedRes.Size = new System.Drawing.Size(90, 39);
            this.btn_DelVedRes.TabIndex = 6;
            this.btn_DelVedRes.Text = "Удалить ведомость";
            this.btn_DelVedRes.UseVisualStyleBackColor = true;
            this.btn_DelVedRes.Click += new System.EventHandler(this.btn_DelVedRes_Click);
            // 
            // btn_alterRepair
            // 
            this.btn_alterRepair.Location = new System.Drawing.Point(21, 515);
            this.btn_alterRepair.Name = "btn_alterRepair";
            this.btn_alterRepair.Size = new System.Drawing.Size(116, 37);
            this.btn_alterRepair.TabIndex = 7;
            this.btn_alterRepair.Text = "Редактировать запчасти";
            this.btn_alterRepair.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btn_alterRepair.UseVisualStyleBackColor = true;
            this.btn_alterRepair.Click += new System.EventHandler(this.btn_alterRepair_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox5.Controls.Add(this.txt_SearchInv);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox5.Location = new System.Drawing.Point(18, 2);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(143, 49);
            this.groupBox5.TabIndex = 16;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Поиск по инв. №";
            // 
            // txt_SearchInv
            // 
            this.txt_SearchInv.Location = new System.Drawing.Point(6, 22);
            this.txt_SearchInv.Name = "txt_SearchInv";
            this.txt_SearchInv.Size = new System.Drawing.Size(131, 21);
            this.txt_SearchInv.TabIndex = 0;
            this.txt_SearchInv.TextChanged += new System.EventHandler(this.txt_SearchInv_TextChanged);
            // 
            // btn_PrintForm2
            // 
            this.btn_PrintForm2.Location = new System.Drawing.Point(1061, 533);
            this.btn_PrintForm2.Name = "btn_PrintForm2";
            this.btn_PrintForm2.Size = new System.Drawing.Size(76, 26);
            this.btn_PrintForm2.TabIndex = 17;
            this.btn_PrintForm2.Text = "Печать Ф.2";
            this.btn_PrintForm2.UseVisualStyleBackColor = true;
            this.btn_PrintForm2.Visible = false;
            this.btn_PrintForm2.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_Update_F_2
            // 
            this.btn_Update_F_2.Location = new System.Drawing.Point(1001, 510);
            this.btn_Update_F_2.Name = "btn_Update_F_2";
            this.btn_Update_F_2.Size = new System.Drawing.Size(136, 21);
            this.btn_Update_F_2.TabIndex = 18;
            this.btn_Update_F_2.Text = "Редактировать Ф.2";
            this.btn_Update_F_2.UseVisualStyleBackColor = true;
            this.btn_Update_F_2.Visible = false;
            this.btn_Update_F_2.Click += new System.EventHandler(this.btn_Update_F_2_Click);
            // 
            // btn_ProizTezhOtchet
            // 
            this.btn_ProizTezhOtchet.Location = new System.Drawing.Point(932, 488);
            this.btn_ProizTezhOtchet.Name = "btn_ProizTezhOtchet";
            this.btn_ProizTezhOtchet.Size = new System.Drawing.Size(205, 20);
            this.btn_ProizTezhOtchet.TabIndex = 19;
            this.btn_ProizTezhOtchet.Text = "Производственно-технический отчет";
            this.btn_ProizTezhOtchet.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btn_ProizTezhOtchet.UseVisualStyleBackColor = true;
            this.btn_ProizTezhOtchet.Visible = false;
            this.btn_ProizTezhOtchet.Click += new System.EventHandler(this.btn_ProizTezhOtchet_Click);
            // 
            // btn_procenti_akt
            // 
            this.btn_procenti_akt.Location = new System.Drawing.Point(167, 3);
            this.btn_procenti_akt.Name = "btn_procenti_akt";
            this.btn_procenti_akt.Size = new System.Drawing.Size(122, 23);
            this.btn_procenti_akt.TabIndex = 20;
            this.btn_procenti_akt.Text = "% по АКТу(ф2)";
            this.btn_procenti_akt.UseMnemonic = false;
            this.btn_procenti_akt.UseVisualStyleBackColor = true;
            this.btn_procenti_akt.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // btn_DrukAktF2
            // 
            this.btn_DrukAktF2.ForeColor = System.Drawing.Color.MediumBlue;
            this.btn_DrukAktF2.Location = new System.Drawing.Point(409, 3);
            this.btn_DrukAktF2.Name = "btn_DrukAktF2";
            this.btn_DrukAktF2.Size = new System.Drawing.Size(152, 23);
            this.btn_DrukAktF2.TabIndex = 21;
            this.btn_DrukAktF2.Text = "Печать АКТа (ф2)";
            this.btn_DrukAktF2.UseVisualStyleBackColor = true;
            this.btn_DrukAktF2.Click += new System.EventHandler(this.button1_Click_3);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(167, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 23);
            this.button1.TabIndex = 22;
            this.button1.Text = "Работы по  АКТу(ф2)";
            this.button1.UseMnemonic = false;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_4);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(19, 253);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(429, 15);
            this.label2.TabIndex = 26;
            this.label2.Text = "Черный  фон - инв.№ ремонтируют разные цеха  в один и тот же период";
            // 
            // dgv_mes_god_ceh
            // 
            this.dgv_mes_god_ceh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_mes_god_ceh.Location = new System.Drawing.Point(961, 2);
            this.dgv_mes_god_ceh.Name = "dgv_mes_god_ceh";
            this.dgv_mes_god_ceh.ReadOnly = true;
            this.dgv_mes_god_ceh.Size = new System.Drawing.Size(22, 19);
            this.dgv_mes_god_ceh.TabIndex = 27;
            this.dgv_mes_god_ceh.Visible = false;
            // 
            // btn_UpdateShpz
            // 
            this.btn_UpdateShpz.Location = new System.Drawing.Point(471, 257);
            this.btn_UpdateShpz.Name = "btn_UpdateShpz";
            this.btn_UpdateShpz.Size = new System.Drawing.Size(170, 24);
            this.btn_UpdateShpz.TabIndex = 28;
            this.btn_UpdateShpz.Text = "ШПЗ автоматом в рабоч.мес.";
            this.btn_UpdateShpz.UseVisualStyleBackColor = true;
            this.btn_UpdateShpz.Click += new System.EventHandler(this.btn_UpdateShpz_Click_1);
            // 
            // button4
            // 
            this.button4.ForeColor = System.Drawing.Color.MediumBlue;
            this.button4.Location = new System.Drawing.Point(409, 28);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(153, 23);
            this.button4.TabIndex = 29;
            this.button4.Text = "Печать приложений  к акту";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(148, 515);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(141, 35);
            this.button5.TabIndex = 30;
            this.button5.Text = "Изменить дату установки запчасти";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Visible = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(405, 510);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(116, 42);
            this.button2.TabIndex = 31;
            this.button2.Text = "Печать списка вед.ресурсов";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // btn_AvtomatAktF2
            // 
            this.btn_AvtomatAktF2.ForeColor = System.Drawing.Color.Purple;
            this.btn_AvtomatAktF2.Location = new System.Drawing.Point(295, 2);
            this.btn_AvtomatAktF2.Name = "btn_AvtomatAktF2";
            this.btn_AvtomatAktF2.Size = new System.Drawing.Size(108, 49);
            this.btn_AvtomatAktF2.TabIndex = 32;
            this.btn_AvtomatAktF2.Text = "Автоматическое заполнение Акта(ф2)  по Цеху";
            this.btn_AvtomatAktF2.UseVisualStyleBackColor = true;
            this.btn_AvtomatAktF2.Click += new System.EventHandler(this.btn_AvtomatAktF2_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(569, 34);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(15, 14);
            this.checkBox1.TabIndex = 33;
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // labelCapital
            // 
            this.labelCapital.AutoSize = true;
            this.labelCapital.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.labelCapital.Location = new System.Drawing.Point(792, 510);
            this.labelCapital.Name = "labelCapital";
            this.labelCapital.Size = new System.Drawing.Size(101, 18);
            this.labelCapital.TabIndex = 34;
            this.labelCapital.Text = "Капитальный";
            // 
            // buttonCapital
            // 
            this.buttonCapital.Location = new System.Drawing.Point(793, 531);
            this.buttonCapital.Name = "buttonCapital";
            this.buttonCapital.Size = new System.Drawing.Size(88, 23);
            this.buttonCapital.TabIndex = 35;
            this.buttonCapital.Text = "Изменить";
            this.buttonCapital.UseVisualStyleBackColor = true;
            this.buttonCapital.Click += new System.EventHandler(this.buttonCapital_Click);
            // 
            // myfrmAllVedomotsResursov
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1172, 561);
            this.Controls.Add(this.buttonCapital);
            this.Controls.Add(this.labelCapital);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.btn_AvtomatAktF2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_UpdateShpz);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.dgv_mes_god_ceh);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_DrukAktF2);
            this.Controls.Add(this.btn_procenti_akt);
            this.Controls.Add(this.btn_ProizTezhOtchet);
            this.Controls.Add(this.btn_Update_F_2);
            this.Controls.Add(this.btn_PrintForm2);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.btn_alterRepair);
            this.Controls.Add(this.btn_DelVedRes);
            this.Controls.Add(this.btn_UpdateVedRes);
            this.Controls.Add(this.btn_PrintVedRes);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "myfrmAllVedomotsResursov";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Все ведомости ресурсов";
            this.Load += new System.EventHandler(this.myfrmAllVedomotsResursov_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_AllVedomostsResursob)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_RepPlace)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Met)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Det)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_mes_god_ceh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgv_AllVedomostsResursob;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgv_RepPlace;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgv_Met;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dgv_Det;
        private System.Windows.Forms.Button btn_PrintVedRes;
        private System.Windows.Forms.Button btn_UpdateVedRes;
        private System.Windows.Forms.Button btn_DelVedRes;
        private System.Windows.Forms.Button btn_alterRepair;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox txt_SearchInv;
        private System.Windows.Forms.Button btn_PrintForm2;
        private System.Windows.Forms.Button btn_Update_F_2;
        private System.Windows.Forms.Button btn_ProizTezhOtchet;
        private System.Windows.Forms.Button btn_procenti_akt;
        private System.Windows.Forms.Button btn_DrukAktF2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dgv_mes_god_ceh;
        private System.Windows.Forms.Button btn_UpdateShpz;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_AvtomatAktF2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label labelCapital;
        private System.Windows.Forms.Button buttonCapital;
    }
}