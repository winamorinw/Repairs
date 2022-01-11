namespace Repairs
{
    partial class myfrmVedomostResursovForAllRepairs
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgv_RepPlaceVedRes = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgv_VozvrDet = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgv_Vozvr_Met = new System.Windows.Forms.DataGridView();
            this.btn_AddNewVedRes = new System.Windows.Forms.Button();
            this.dtp_date1 = new System.Windows.Forms.DateTimePicker();
            this.dtp_date2 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_numberVed = new System.Windows.Forms.TextBox();
            this.cbx_sprrem = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.label19 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.vedomostResursov = new Repairs.VedomostResursov();
            this.vedomostResursovBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_RepPlaceVedRes)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_VozvrDet)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Vozvr_Met)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vedomostResursov)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vedomostResursovBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgv_RepPlaceVedRes);
            this.groupBox1.Location = new System.Drawing.Point(13, 48);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(554, 300);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Использованные запчасти";
            // 
            // dgv_RepPlaceVedRes
            // 
            this.dgv_RepPlaceVedRes.AllowUserToAddRows = false;
            this.dgv_RepPlaceVedRes.AllowUserToDeleteRows = false;
            this.dgv_RepPlaceVedRes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_RepPlaceVedRes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_RepPlaceVedRes.Location = new System.Drawing.Point(4, 20);
            this.dgv_RepPlaceVedRes.Name = "dgv_RepPlaceVedRes";
            this.dgv_RepPlaceVedRes.ReadOnly = true;
            this.dgv_RepPlaceVedRes.Size = new System.Drawing.Size(546, 276);
            this.dgv_RepPlaceVedRes.TabIndex = 3;
            this.dgv_RepPlaceVedRes.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_RepPlaceVedRes_CellMouseClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgv_VozvrDet);
            this.groupBox2.Location = new System.Drawing.Point(592, 48);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(436, 158);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Возвратные запчасти";
            // 
            // dgv_VozvrDet
            // 
            this.dgv_VozvrDet.AllowUserToAddRows = false;
            this.dgv_VozvrDet.AllowUserToDeleteRows = false;
            this.dgv_VozvrDet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_VozvrDet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_VozvrDet.Location = new System.Drawing.Point(3, 19);
            this.dgv_VozvrDet.Name = "dgv_VozvrDet";
            this.dgv_VozvrDet.ReadOnly = true;
            this.dgv_VozvrDet.Size = new System.Drawing.Size(430, 136);
            this.dgv_VozvrDet.TabIndex = 0;
            this.dgv_VozvrDet.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_VozvrDet_CellContentClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgv_Vozvr_Met);
            this.groupBox3.Location = new System.Drawing.Point(592, 212);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(436, 152);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Возвратный металлолом";
            // 
            // dgv_Vozvr_Met
            // 
            this.dgv_Vozvr_Met.AllowUserToAddRows = false;
            this.dgv_Vozvr_Met.AllowUserToDeleteRows = false;
            this.dgv_Vozvr_Met.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Vozvr_Met.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Vozvr_Met.Location = new System.Drawing.Point(3, 19);
            this.dgv_Vozvr_Met.Name = "dgv_Vozvr_Met";
            this.dgv_Vozvr_Met.ReadOnly = true;
            this.dgv_Vozvr_Met.Size = new System.Drawing.Size(430, 130);
            this.dgv_Vozvr_Met.TabIndex = 0;
            // 
            // btn_AddNewVedRes
            // 
            this.btn_AddNewVedRes.Location = new System.Drawing.Point(595, 515);
            this.btn_AddNewVedRes.Name = "btn_AddNewVedRes";
            this.btn_AddNewVedRes.Size = new System.Drawing.Size(273, 44);
            this.btn_AddNewVedRes.TabIndex = 4;
            this.btn_AddNewVedRes.Text = "Сформировать";
            this.btn_AddNewVedRes.UseVisualStyleBackColor = true;
            this.btn_AddNewVedRes.Click += new System.EventHandler(this.button2_Click);
            // 
            // dtp_date1
            // 
            this.dtp_date1.Location = new System.Drawing.Point(221, 7);
            this.dtp_date1.Name = "dtp_date1";
            this.dtp_date1.Size = new System.Drawing.Size(200, 23);
            this.dtp_date1.TabIndex = 5;
            // 
            // dtp_date2
            // 
            this.dtp_date2.Location = new System.Drawing.Point(486, 7);
            this.dtp_date2.Name = "dtp_date2";
            this.dtp_date2.Size = new System.Drawing.Size(200, 23);
            this.dtp_date2.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(188, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "C";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(444, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "по";
            // 
            // txt_numberVed
            // 
            this.txt_numberVed.Location = new System.Drawing.Point(925, 11);
            this.txt_numberVed.Name = "txt_numberVed";
            this.txt_numberVed.Size = new System.Drawing.Size(100, 23);
            this.txt_numberVed.TabIndex = 9;
            // 
            // cbx_sprrem
            // 
            this.cbx_sprrem.FormattingEnabled = true;
            this.cbx_sprrem.Location = new System.Drawing.Point(140, 353);
            this.cbx_sprrem.Name = "cbx_sprrem";
            this.cbx_sprrem.Size = new System.Drawing.Size(228, 24);
            this.cbx_sprrem.TabIndex = 10;
            this.cbx_sprrem.Visible = false;
            this.cbx_sprrem.SelectedIndexChanged += new System.EventHandler(this.cbx_sprrem_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 355);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "ВИД ремонта";
            this.label3.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(396, 352);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(166, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Цех исполнитель";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "label4";
            this.label4.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(507, 381);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 17);
            this.label6.TabIndex = 15;
            this.label6.Text = "label6";
            this.label6.Visible = false;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Checked = true;
            this.radioButton3.Location = new System.Drawing.Point(409, 448);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(82, 21);
            this.radioButton3.TabIndex = 36;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "3. --------";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.Visible = false;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton1.Location = new System.Drawing.Point(409, 407);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(383, 19);
            this.radioButton1.TabIndex = 28;
            this.radioButton1.Text = "1. Термін наступної аналогічної заміни БІЛЬШЕ  12-ти місяців.";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.Visible = false;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton2.Location = new System.Drawing.Point(409, 426);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(389, 19);
            this.radioButton2.TabIndex = 29;
            this.radioButton2.Text = "2. Термін наступної аналогічної заміни МЕНЬШЕ  12-ти місяців";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.Visible = false;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(151, 30);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 17);
            this.label9.TabIndex = 35;
            this.label9.Text = "ОЗ:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(57, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 17);
            this.label8.TabIndex = 34;
            this.label8.Text = "ОЗ:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(235, 445);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 17);
            this.label7.TabIndex = 33;
            this.label7.Text = "text";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(235, 397);
            this.label10.Name = "label10";
            this.label10.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label10.Size = new System.Drawing.Size(30, 17);
            this.label10.TabIndex = 32;
            this.label10.Text = "text";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(25, 445);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(158, 17);
            this.label11.TabIndex = 31;
            this.label11.Text = "в т.ч. ТМЦ по тек.док.:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(20, 397);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(168, 17);
            this.label12.TabIndex = 30;
            this.label12.Text = "Залишкова вартість ОЗ:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(20, 30);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(32, 17);
            this.label13.TabIndex = 38;
            this.label13.Text = "ОЗ:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(402, 381);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "label5";
            this.label5.Visible = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label14.Location = new System.Drawing.Point(790, 409);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(106, 15);
            this.label14.TabIndex = 39;
            this.label14.Text = "Оформляти Ф-2.";
            this.label14.Visible = false;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label15.Location = new System.Drawing.Point(62, 462);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(121, 17);
            this.label15.TabIndex = 40;
            this.label15.Text = "ТМЦ по тек.мес.:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label16.Location = new System.Drawing.Point(235, 462);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(30, 17);
            this.label16.TabIndex = 41;
            this.label16.Text = "text";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label17.Location = new System.Drawing.Point(20, 418);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(97, 17);
            this.label17.TabIndex = 42;
            this.label17.Text = "ТМЦ на суму:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label18.Location = new System.Drawing.Point(235, 420);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(30, 17);
            this.label18.TabIndex = 43;
            this.label18.Text = "text";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.ForeColor = System.Drawing.Color.Red;
            this.radioButton5.Location = new System.Drawing.Point(12, 38);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(119, 21);
            this.radioButton5.TabIndex = 50;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "не завершено";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label19.ForeColor = System.Drawing.Color.Navy;
            this.label19.Location = new System.Drawing.Point(434, 488);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(117, 17);
            this.label19.TabIndex = 53;
            this.label19.Text = "Статус ремонта:";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.radioButton5);
            this.panel1.Controls.Add(this.radioButton4);
            this.panel1.Location = new System.Drawing.Point(416, 495);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(151, 64);
            this.panel1.TabIndex = 54;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.ForeColor = System.Drawing.Color.Green;
            this.radioButton4.Location = new System.Drawing.Point(12, 15);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(99, 21);
            this.radioButton4.TabIndex = 49;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "завершено";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // vedomostResursov
            // 
            this.vedomostResursov.DataSetName = "VedomostResursov";
            this.vedomostResursov.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vedomostResursovBindingSource
            // 
            this.vedomostResursovBindingSource.DataSource = this.vedomostResursov;
            this.vedomostResursovBindingSource.Position = 0;
            // 
            // myfrmVedomostResursovForAllRepairs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 571);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbx_sprrem);
            this.Controls.Add(this.txt_numberVed);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtp_date2);
            this.Controls.Add(this.dtp_date1);
            this.Controls.Add(this.btn_AddNewVedRes);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "myfrmVedomostResursovForAllRepairs";
            this.Text = "0";
            this.Load += new System.EventHandler(this.myfrmVedomostResursovForAllRepairs_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_RepPlaceVedRes)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_VozvrDet)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Vozvr_Met)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vedomostResursov)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vedomostResursovBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgv_RepPlaceVedRes;
        private System.Windows.Forms.DataGridView dgv_VozvrDet;
        private System.Windows.Forms.DataGridView dgv_Vozvr_Met;
        private System.Windows.Forms.Button btn_AddNewVedRes;
        private System.Windows.Forms.DateTimePicker dtp_date1;
        private System.Windows.Forms.DateTimePicker dtp_date2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_numberVed;
        private System.Windows.Forms.ComboBox cbx_sprrem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingSource vedomostResursovBindingSource;
        private VedomostResursov vedomostResursov;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioButton4;
    }
}