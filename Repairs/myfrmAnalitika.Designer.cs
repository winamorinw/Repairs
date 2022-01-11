namespace Repairs
{
    partial class myfrmAnalitika
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
            this.cbx_Rep = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txt_SearchName = new System.Windows.Forms.TextBox();
            this.vedomostResursov = new Repairs.VedomostResursov();
            this.vedomostResursovBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportTMCMOL = new Repairs.ReportTMCMOL();
            this.reportTMCMOLBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportTMCMOLTableAdapter = new Repairs.ReportTMCMOLTableAdapters.ReportTMCMOLTableAdapter();
            this.sprOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.analitikaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.analitika = new Repairs.analitika();
            this.sprOSTableAdapter = new Repairs.analitikaTableAdapters.SprOSTableAdapter();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.inventoryNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.storeIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateBegDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateEndDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupOSCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullSrokDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoursBegDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flagDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.cODUTHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cODBRIGDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cODDETDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dgv_RepPartNew = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgv_RepPartOld = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgv_Repair = new System.Windows.Forms.DataGridView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dgv_job = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgv_analit = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.vedomostResursov)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vedomostResursovBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportTMCMOL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportTMCMOLBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sprOSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.analitikaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.analitika)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_RepPartNew)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_RepPartOld)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Repair)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_job)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_analit)).BeginInit();
            this.SuspendLayout();
            // 
            // cbx_Rep
            // 
            this.cbx_Rep.FormattingEnabled = true;
            this.cbx_Rep.Location = new System.Drawing.Point(27, 23);
            this.cbx_Rep.Name = "cbx_Rep";
            this.cbx_Rep.Size = new System.Drawing.Size(185, 21);
            this.cbx_Rep.TabIndex = 1;
            this.cbx_Rep.SelectedIndexChanged += new System.EventHandler(this.cbx_Rep_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(594, 23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_SearchName
            // 
            this.txt_SearchName.Location = new System.Drawing.Point(275, 23);
            this.txt_SearchName.Name = "txt_SearchName";
            this.txt_SearchName.Size = new System.Drawing.Size(185, 20);
            this.txt_SearchName.TabIndex = 3;
            this.txt_SearchName.TextChanged += new System.EventHandler(this.txt_SearchName_TextChanged);
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
            // reportTMCMOL
            // 
            this.reportTMCMOL.DataSetName = "ReportTMCMOL";
            this.reportTMCMOL.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportTMCMOLBindingSource
            // 
            this.reportTMCMOLBindingSource.DataMember = "ReportTMCMOL";
            this.reportTMCMOLBindingSource.DataSource = this.reportTMCMOL;
            // 
            // reportTMCMOLTableAdapter
            // 
            this.reportTMCMOLTableAdapter.ClearBeforeFill = true;
            // 
            // sprOSBindingSource
            // 
            this.sprOSBindingSource.DataMember = "SprOS";
            this.sprOSBindingSource.DataSource = this.analitikaBindingSource;
            // 
            // analitikaBindingSource
            // 
            this.analitikaBindingSource.DataSource = this.analitika;
            this.analitikaBindingSource.Position = 0;
            this.analitikaBindingSource.CurrentChanged += new System.EventHandler(this.analitikaBindingSource_CurrentChanged);
            // 
            // analitika
            // 
            this.analitika.DataSetName = "analitika";
            this.analitika.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sprOSTableAdapter
            // 
            this.sprOSTableAdapter.ClearBeforeFill = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1031, 513);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.inventoryNumberDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.storeIdDataGridViewTextBoxColumn,
            this.dateBegDataGridViewTextBoxColumn,
            this.dateEndDataGridViewTextBoxColumn,
            this.groupOSCodeDataGridViewTextBoxColumn,
            this.fullSrokDataGridViewTextBoxColumn,
            this.hoursBegDataGridViewTextBoxColumn,
            this.flagDataGridViewCheckBoxColumn,
            this.cODUTHDataGridViewTextBoxColumn,
            this.cODBRIGDataGridViewTextBoxColumn,
            this.cODDETDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.sprOSBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1025, 507);
            this.dataGridView1.TabIndex = 0;
            // 
            // inventoryNumberDataGridViewTextBoxColumn
            // 
            this.inventoryNumberDataGridViewTextBoxColumn.DataPropertyName = "InventoryNumber";
            this.inventoryNumberDataGridViewTextBoxColumn.HeaderText = "InventoryNumber";
            this.inventoryNumberDataGridViewTextBoxColumn.Name = "inventoryNumberDataGridViewTextBoxColumn";
            this.inventoryNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // storeIdDataGridViewTextBoxColumn
            // 
            this.storeIdDataGridViewTextBoxColumn.DataPropertyName = "StoreId";
            this.storeIdDataGridViewTextBoxColumn.HeaderText = "StoreId";
            this.storeIdDataGridViewTextBoxColumn.Name = "storeIdDataGridViewTextBoxColumn";
            this.storeIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateBegDataGridViewTextBoxColumn
            // 
            this.dateBegDataGridViewTextBoxColumn.DataPropertyName = "DateBeg";
            this.dateBegDataGridViewTextBoxColumn.HeaderText = "DateBeg";
            this.dateBegDataGridViewTextBoxColumn.Name = "dateBegDataGridViewTextBoxColumn";
            this.dateBegDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateEndDataGridViewTextBoxColumn
            // 
            this.dateEndDataGridViewTextBoxColumn.DataPropertyName = "DateEnd";
            this.dateEndDataGridViewTextBoxColumn.HeaderText = "DateEnd";
            this.dateEndDataGridViewTextBoxColumn.Name = "dateEndDataGridViewTextBoxColumn";
            this.dateEndDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // groupOSCodeDataGridViewTextBoxColumn
            // 
            this.groupOSCodeDataGridViewTextBoxColumn.DataPropertyName = "GroupOSCode";
            this.groupOSCodeDataGridViewTextBoxColumn.HeaderText = "GroupOSCode";
            this.groupOSCodeDataGridViewTextBoxColumn.Name = "groupOSCodeDataGridViewTextBoxColumn";
            this.groupOSCodeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fullSrokDataGridViewTextBoxColumn
            // 
            this.fullSrokDataGridViewTextBoxColumn.DataPropertyName = "Full_Srok";
            this.fullSrokDataGridViewTextBoxColumn.HeaderText = "Full_Srok";
            this.fullSrokDataGridViewTextBoxColumn.Name = "fullSrokDataGridViewTextBoxColumn";
            this.fullSrokDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // hoursBegDataGridViewTextBoxColumn
            // 
            this.hoursBegDataGridViewTextBoxColumn.DataPropertyName = "Hours_Beg";
            this.hoursBegDataGridViewTextBoxColumn.HeaderText = "Hours_Beg";
            this.hoursBegDataGridViewTextBoxColumn.Name = "hoursBegDataGridViewTextBoxColumn";
            this.hoursBegDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // flagDataGridViewCheckBoxColumn
            // 
            this.flagDataGridViewCheckBoxColumn.DataPropertyName = "Flag";
            this.flagDataGridViewCheckBoxColumn.HeaderText = "Flag";
            this.flagDataGridViewCheckBoxColumn.Name = "flagDataGridViewCheckBoxColumn";
            this.flagDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // cODUTHDataGridViewTextBoxColumn
            // 
            this.cODUTHDataGridViewTextBoxColumn.DataPropertyName = "CODUTH";
            this.cODUTHDataGridViewTextBoxColumn.HeaderText = "CODUTH";
            this.cODUTHDataGridViewTextBoxColumn.Name = "cODUTHDataGridViewTextBoxColumn";
            this.cODUTHDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cODBRIGDataGridViewTextBoxColumn
            // 
            this.cODBRIGDataGridViewTextBoxColumn.DataPropertyName = "CODBRIG";
            this.cODBRIGDataGridViewTextBoxColumn.HeaderText = "CODBRIG";
            this.cODBRIGDataGridViewTextBoxColumn.Name = "cODBRIGDataGridViewTextBoxColumn";
            this.cODBRIGDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cODDETDataGridViewTextBoxColumn
            // 
            this.cODDETDataGridViewTextBoxColumn.DataPropertyName = "CODDET";
            this.cODDETDataGridViewTextBoxColumn.HeaderText = "CODDET";
            this.cODDETDataGridViewTextBoxColumn.Name = "cODDETDataGridViewTextBoxColumn";
            this.cODDETDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 52);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1039, 539);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tabControl2);
            this.tabPage1.Controls.Add(this.groupBox5);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1031, 513);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage3);
            this.tabControl2.Controls.Add(this.tabPage4);
            this.tabControl2.Location = new System.Drawing.Point(536, 7);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(489, 492);
            this.tabControl2.TabIndex = 5;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupBox4);
            this.tabPage3.Controls.Add(this.groupBox3);
            this.tabPage3.Controls.Add(this.groupBox2);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(481, 466);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "Детально";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dgv_RepPartNew);
            this.groupBox4.Location = new System.Drawing.Point(-5, 322);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(491, 159);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Детали (новая форма ввода)";
            // 
            // dgv_RepPartNew
            // 
            this.dgv_RepPartNew.AllowUserToAddRows = false;
            this.dgv_RepPartNew.AllowUserToDeleteRows = false;
            this.dgv_RepPartNew.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_RepPartNew.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_RepPartNew.Location = new System.Drawing.Point(3, 16);
            this.dgv_RepPartNew.Name = "dgv_RepPartNew";
            this.dgv_RepPartNew.ReadOnly = true;
            this.dgv_RepPartNew.Size = new System.Drawing.Size(485, 140);
            this.dgv_RepPartNew.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgv_RepPartOld);
            this.groupBox3.Location = new System.Drawing.Point(-5, 156);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(491, 163);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Детали (старая форма ввода)";
            // 
            // dgv_RepPartOld
            // 
            this.dgv_RepPartOld.AllowUserToAddRows = false;
            this.dgv_RepPartOld.AllowUserToDeleteRows = false;
            this.dgv_RepPartOld.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_RepPartOld.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_RepPartOld.Location = new System.Drawing.Point(3, 16);
            this.dgv_RepPartOld.Name = "dgv_RepPartOld";
            this.dgv_RepPartOld.ReadOnly = true;
            this.dgv_RepPartOld.Size = new System.Drawing.Size(485, 144);
            this.dgv_RepPartOld.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgv_Repair);
            this.groupBox2.Location = new System.Drawing.Point(-6, -15);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(492, 168);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ремонты";
            // 
            // dgv_Repair
            // 
            this.dgv_Repair.AllowUserToAddRows = false;
            this.dgv_Repair.AllowUserToDeleteRows = false;
            this.dgv_Repair.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Repair.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Repair.Location = new System.Drawing.Point(3, 16);
            this.dgv_Repair.Name = "dgv_Repair";
            this.dgv_Repair.ReadOnly = true;
            this.dgv_Repair.Size = new System.Drawing.Size(486, 149);
            this.dgv_Repair.TabIndex = 0;
            this.dgv_Repair.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Repair_CellEnter_1);
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(481, 466);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "Общая информация";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.dgv_job);
            this.groupBox5.Location = new System.Drawing.Point(6, 343);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(520, 159);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Выполняемая работа";
            // 
            // dgv_job
            // 
            this.dgv_job.AllowUserToAddRows = false;
            this.dgv_job.AllowUserToDeleteRows = false;
            this.dgv_job.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_job.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_job.Location = new System.Drawing.Point(3, 16);
            this.dgv_job.Name = "dgv_job";
            this.dgv_job.ReadOnly = true;
            this.dgv_job.Size = new System.Drawing.Size(514, 140);
            this.dgv_job.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgv_analit);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(526, 334);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Основные средства";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // dgv_analit
            // 
            this.dgv_analit.AllowUserToAddRows = false;
            this.dgv_analit.AllowUserToDeleteRows = false;
            this.dgv_analit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_analit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_analit.Location = new System.Drawing.Point(3, 16);
            this.dgv_analit.Name = "dgv_analit";
            this.dgv_analit.ReadOnly = true;
            this.dgv_analit.Size = new System.Drawing.Size(520, 315);
            this.dgv_analit.TabIndex = 0;
            this.dgv_analit.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_analit_CellContentClick);
            this.dgv_analit.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_analit_CellEnter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(232, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "поиск";
            // 
            // myfrmAnalitika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1055, 588);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.txt_SearchName);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbx_Rep);
            this.Name = "myfrmAnalitika";
            this.Text = "Аналитика";
            this.Load += new System.EventHandler(this.myfrmAnalitika_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vedomostResursov)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vedomostResursovBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportTMCMOL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportTMCMOLBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sprOSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.analitikaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.analitika)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_RepPartNew)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_RepPartOld)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Repair)).EndInit();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_job)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_analit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbx_Rep;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt_SearchName;
        private System.Windows.Forms.BindingSource vedomostResursovBindingSource;
        private VedomostResursov vedomostResursov;
        private ReportTMCMOL reportTMCMOL;
        private System.Windows.Forms.BindingSource reportTMCMOLBindingSource;
        private ReportTMCMOLTableAdapters.ReportTMCMOLTableAdapter reportTMCMOLTableAdapter;
        private System.Windows.Forms.BindingSource analitikaBindingSource;
        private analitika analitika;
        private System.Windows.Forms.BindingSource sprOSBindingSource;
        private analitikaTableAdapters.SprOSTableAdapter sprOSTableAdapter;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn inventoryNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn storeIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateBegDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateEndDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn groupOSCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullSrokDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoursBegDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn flagDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cODUTHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cODBRIGDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cODDETDataGridViewTextBoxColumn;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dgv_analit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataGridView dgv_job;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dgv_RepPartNew;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgv_RepPartOld;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgv_Repair;
        private System.Windows.Forms.TabPage tabPage4;
    }
}