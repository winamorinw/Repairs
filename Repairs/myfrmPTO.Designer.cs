namespace Repairs
{
    partial class myfrmPTO
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
            this.cmb_reportBoy = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Grid_Viev = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_formuvPTO = new System.Windows.Forms.Button();
            this.btn_formVedRes = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.DTPend = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.DTPbeg = new System.Windows.Forms.DateTimePicker();
            this.btn_searchTMC = new System.Windows.Forms.Button();
            this.gridVedom = new System.Windows.Forms.DataGridView();
            this.ColumnCheck = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InventoryNamber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameOS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PeriodData1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PeriodData2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ispolnitel_codcx = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ispolnitel_coduth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ispolnitel_codbrig = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ispolnitel_coddet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ispolnitel_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VedomostNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdPTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kod_rem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.repairIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vedomostResursovBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vedomostResursov = new Repairs.VedomostResursov();
            this.pTOTableAdapter = new Repairs.VedomostResursovTableAdapters.PTOTableAdapter();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Viev)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridVedom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pTOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vedomostResursovBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vedomostResursov)).BeginInit();
            this.SuspendLayout();
            // 
            // cmb_reportBoy
            // 
            this.cmb_reportBoy.FormattingEnabled = true;
            this.cmb_reportBoy.Location = new System.Drawing.Point(18, 19);
            this.cmb_reportBoy.Name = "cmb_reportBoy";
            this.cmb_reportBoy.Size = new System.Drawing.Size(503, 21);
            this.cmb_reportBoy.TabIndex = 0;
            this.cmb_reportBoy.SelectedIndexChanged += new System.EventHandler(this.cmb_reportBoy_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Grid_Viev);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.btn_formuvPTO);
            this.groupBox1.Controls.Add(this.btn_formVedRes);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmb_reportBoy);
            this.groupBox1.Controls.Add(this.DTPend);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.DTPbeg);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(841, 117);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Пошук";
            // 
            // Grid_Viev
            // 
            this.Grid_Viev.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid_Viev.Location = new System.Drawing.Point(392, 45);
            this.Grid_Viev.Name = "Grid_Viev";
            this.Grid_Viev.Size = new System.Drawing.Size(172, 64);
            this.Grid_Viev.TabIndex = 21;
            this.Grid_Viev.Visible = false;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(111, 72);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(106, 23);
            this.button3.TabIndex = 21;
            this.button3.Text = "Зняти всі помітки";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(6, 72);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(99, 23);
            this.button2.TabIndex = 20;
            this.button2.Text = "Помітити все";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_formuvPTO
            // 
            this.btn_formuvPTO.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_formuvPTO.Location = new System.Drawing.Point(570, 47);
            this.btn_formuvPTO.Name = "btn_formuvPTO";
            this.btn_formuvPTO.Size = new System.Drawing.Size(155, 28);
            this.btn_formuvPTO.TabIndex = 19;
            this.btn_formuvPTO.Text = " Формування ВТЗ";
            this.btn_formuvPTO.UseVisualStyleBackColor = false;
            this.btn_formuvPTO.Visible = false;
            this.btn_formuvPTO.Click += new System.EventHandler(this.btn_formuvPTO_Click);
            // 
            // btn_formVedRes
            // 
            this.btn_formVedRes.AutoSize = true;
            this.btn_formVedRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_formVedRes.Location = new System.Drawing.Point(546, 15);
            this.btn_formVedRes.Name = "btn_formVedRes";
            this.btn_formVedRes.Size = new System.Drawing.Size(200, 26);
            this.btn_formVedRes.TabIndex = 15;
            this.btn_formVedRes.Text = "Перегляд відомостей ресурсів";
            this.btn_formVedRes.UseVisualStyleBackColor = true;
            this.btn_formVedRes.Click += new System.EventHandler(this.btn_formVedRes_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(188, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 17);
            this.label2.TabIndex = 18;
            this.label2.Text = "по";
            // 
            // DTPend
            // 
            this.DTPend.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DTPend.Location = new System.Drawing.Point(218, 45);
            this.DTPend.Name = "DTPend";
            this.DTPend.Size = new System.Drawing.Size(148, 23);
            this.DTPend.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(11, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 17);
            this.label1.TabIndex = 16;
            this.label1.Text = "З";
            // 
            // DTPbeg
            // 
            this.DTPbeg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DTPbeg.Location = new System.Drawing.Point(34, 43);
            this.DTPbeg.Name = "DTPbeg";
            this.DTPbeg.Size = new System.Drawing.Size(148, 23);
            this.DTPbeg.TabIndex = 14;
            this.DTPbeg.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // btn_searchTMC
            // 
            this.btn_searchTMC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_searchTMC.Location = new System.Drawing.Point(1043, 185);
            this.btn_searchTMC.Name = "btn_searchTMC";
            this.btn_searchTMC.Size = new System.Drawing.Size(117, 23);
            this.btn_searchTMC.TabIndex = 1;
            this.btn_searchTMC.Text = "Поиск";
            this.btn_searchTMC.UseVisualStyleBackColor = true;
            this.btn_searchTMC.Visible = false;
            // 
            // gridVedom
            // 
            this.gridVedom.AllowUserToAddRows = false;
            this.gridVedom.AllowUserToDeleteRows = false;
            this.gridVedom.AutoGenerateColumns = false;
            this.gridVedom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridVedom.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnCheck,
            this.ID,
            this.InventoryNamber,
            this.NameOS,
            this.PeriodData1,
            this.PeriodData2,
            this.Ispolnitel_codcx,
            this.Ispolnitel_coduth,
            this.Ispolnitel_codbrig,
            this.Ispolnitel_coddet,
            this.Ispolnitel_Name,
            this.VedomostNumber,
            this.IdPTO,
            this.kod_rem,
            this.repairIDDataGridViewTextBoxColumn});
            this.gridVedom.DataSource = this.pTOBindingSource;
            this.gridVedom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridVedom.Location = new System.Drawing.Point(0, 117);
            this.gridVedom.Name = "gridVedom";
            this.gridVedom.Size = new System.Drawing.Size(841, 442);
            this.gridVedom.TabIndex = 2;
            // 
            // ColumnCheck
            // 
            this.ColumnCheck.DataPropertyName = "ColumnCheck";
            this.ColumnCheck.FalseValue = "0";
            this.ColumnCheck.HeaderText = "Вибрати";
            this.ColumnCheck.Name = "ColumnCheck";
            this.ColumnCheck.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ColumnCheck.TrueValue = "1";
            this.ColumnCheck.Width = 50;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "№ відомості";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 70;
            // 
            // InventoryNamber
            // 
            this.InventoryNamber.DataPropertyName = "InventoryNamber";
            this.InventoryNamber.HeaderText = "Інв.№";
            this.InventoryNamber.Name = "InventoryNamber";
            // 
            // NameOS
            // 
            this.NameOS.DataPropertyName = "NameOS";
            this.NameOS.HeaderText = "Найменування ОЗ";
            this.NameOS.Name = "NameOS";
            this.NameOS.Width = 350;
            // 
            // PeriodData1
            // 
            this.PeriodData1.DataPropertyName = "PeriodData1";
            this.PeriodData1.HeaderText = "З";
            this.PeriodData1.Name = "PeriodData1";
            // 
            // PeriodData2
            // 
            this.PeriodData2.DataPropertyName = "PeriodData2";
            this.PeriodData2.HeaderText = "По";
            this.PeriodData2.Name = "PeriodData2";
            // 
            // Ispolnitel_codcx
            // 
            this.Ispolnitel_codcx.DataPropertyName = "Ispolnitel_codcx";
            this.Ispolnitel_codcx.HeaderText = "Цех";
            this.Ispolnitel_codcx.Name = "Ispolnitel_codcx";
            this.Ispolnitel_codcx.Visible = false;
            // 
            // Ispolnitel_coduth
            // 
            this.Ispolnitel_coduth.DataPropertyName = "Ispolnitel_coduth";
            this.Ispolnitel_coduth.HeaderText = "Діл.";
            this.Ispolnitel_coduth.Name = "Ispolnitel_coduth";
            this.Ispolnitel_coduth.Visible = false;
            // 
            // Ispolnitel_codbrig
            // 
            this.Ispolnitel_codbrig.DataPropertyName = "Ispolnitel_codbrig";
            this.Ispolnitel_codbrig.HeaderText = "Бюро";
            this.Ispolnitel_codbrig.Name = "Ispolnitel_codbrig";
            this.Ispolnitel_codbrig.Visible = false;
            // 
            // Ispolnitel_coddet
            // 
            this.Ispolnitel_coddet.DataPropertyName = "Ispolnitel_coddet";
            this.Ispolnitel_coddet.HeaderText = "Ispolnitel_coddet";
            this.Ispolnitel_coddet.Name = "Ispolnitel_coddet";
            this.Ispolnitel_coddet.Visible = false;
            // 
            // Ispolnitel_Name
            // 
            this.Ispolnitel_Name.DataPropertyName = "Ispolnitel_Name";
            this.Ispolnitel_Name.HeaderText = "Ispolnitel_Name";
            this.Ispolnitel_Name.Name = "Ispolnitel_Name";
            this.Ispolnitel_Name.Visible = false;
            // 
            // VedomostNumber
            // 
            this.VedomostNumber.DataPropertyName = "VedomostNumber";
            this.VedomostNumber.HeaderText = "№ відомості";
            this.VedomostNumber.Name = "VedomostNumber";
            this.VedomostNumber.Visible = false;
            // 
            // IdPTO
            // 
            this.IdPTO.DataPropertyName = "IdPTO";
            this.IdPTO.HeaderText = "IdPTO";
            this.IdPTO.Name = "IdPTO";
            this.IdPTO.Visible = false;
            // 
            // kod_rem
            // 
            this.kod_rem.DataPropertyName = "kod_rem";
            this.kod_rem.HeaderText = "kod_rem";
            this.kod_rem.Name = "kod_rem";
            this.kod_rem.Visible = false;
            // 
            // repairIDDataGridViewTextBoxColumn
            // 
            this.repairIDDataGridViewTextBoxColumn.DataPropertyName = "RepairID";
            this.repairIDDataGridViewTextBoxColumn.HeaderText = "RepairID";
            this.repairIDDataGridViewTextBoxColumn.Name = "repairIDDataGridViewTextBoxColumn";
            this.repairIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.repairIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // pTOBindingSource
            // 
            this.pTOBindingSource.DataMember = "PTO";
            this.pTOBindingSource.DataSource = this.vedomostResursovBindingSource;
            this.pTOBindingSource.CurrentChanged += new System.EventHandler(this.pTOBindingSource_CurrentChanged);
            // 
            // vedomostResursovBindingSource
            // 
            this.vedomostResursovBindingSource.DataSource = this.vedomostResursov;
            this.vedomostResursovBindingSource.Position = 0;
            this.vedomostResursovBindingSource.CurrentChanged += new System.EventHandler(this.vedomostResursovBindingSource_CurrentChanged);
            // 
            // vedomostResursov
            // 
            this.vedomostResursov.DataSetName = "VedomostResursov";
            this.vedomostResursov.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pTOTableAdapter
            // 
            this.pTOTableAdapter.ClearBeforeFill = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(18, 451);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(1292, 20);
            this.textBox1.TabIndex = 22;
            this.textBox1.Visible = false;
            // 
            // myfrmPTO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 559);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.gridVedom);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_searchTMC);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "myfrmPTO";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Формування Виробничо-технiчних звiтiв по ТО";
            this.Load += new System.EventHandler(this.myfrmPTO_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Viev)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridVedom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pTOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vedomostResursovBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vedomostResursov)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_reportBoy;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_searchTMC;
        private System.Windows.Forms.Button btn_formVedRes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker DTPend;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker DTPbeg;
        private System.Windows.Forms.Button btn_formuvPTO;
        private System.Windows.Forms.DataGridView gridVedom;
        private System.Windows.Forms.DataGridView Grid_Viev;
        private System.Windows.Forms.BindingSource vedomostResursovBindingSource;
        private VedomostResursov vedomostResursov;
        private System.Windows.Forms.BindingSource pTOBindingSource;
        private VedomostResursovTableAdapters.PTOTableAdapter pTOTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateInDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn inventoryNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rDivisionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn divisionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOutDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeFlautDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn causeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn responsibleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn planrDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataNextDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn notedataNextDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cODCXDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cODUTHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cODBRIGDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cODDETDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nAMEDETDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColumnCheck;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn InventoryNamber;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameOS;
        private System.Windows.Forms.DataGridViewTextBoxColumn PeriodData1;
        private System.Windows.Forms.DataGridViewTextBoxColumn PeriodData2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ispolnitel_codcx;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ispolnitel_coduth;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ispolnitel_codbrig;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ispolnitel_coddet;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ispolnitel_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn VedomostNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdPTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn kod_rem;
        private System.Windows.Forms.DataGridViewTextBoxColumn repairIDDataGridViewTextBoxColumn;
    }
}