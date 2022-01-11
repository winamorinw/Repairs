namespace Repairs
{
    partial class frmHatch
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
            System.Windows.Forms.Label branch_nameLabel;
            System.Windows.Forms.Label branch_numLabel;
            System.Windows.Forms.Label shtrekIDLabel;
            System.Windows.Forms.Label branch_lenLabel;
            System.Windows.Forms.Label statusIDLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHatch));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.horizontIDTextBox = new System.Windows.Forms.TextBox();
            this.branchBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.repairOSDS = new Repairs.RepairOSDS();
            this.cbxShtrek = new System.Windows.Forms.ComboBox();
            this.shtrekBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cbxStatus = new System.Windows.Forms.ComboBox();
            this.statusBranchBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.date_branchDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.date_statusDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.date_lenDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.branch_lenTextBox = new System.Windows.Forms.TextBox();
            this.branch_numTextBox = new System.Windows.Forms.TextBox();
            this.branch_nameTextBox = new System.Windows.Forms.TextBox();
            this.branchIDTextBox = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bindingNavigator2 = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton7 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton8 = new System.Windows.Forms.ToolStripButton();
            this.branchDataGridView = new System.Windows.Forms.DataGridView();
            this.Branch_num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Branch_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Branch_len = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ShtrekID = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.StatusID = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.branchIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.branchnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horizontIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.branchnumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shtrekIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.branchlenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datelenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datestatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datebranchDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.horizontBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.horizontDataGridView = new System.Windows.Forms.DataGridView();
            this.namehorizontDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.storeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.storeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.horizontIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.hatchBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.hatchBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.hatchBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton10 = new System.Windows.Forms.ToolStripButton();
            this.hatchDataGridView = new System.Windows.Forms.DataGridView();
            this.branchComboBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.sideBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.bindingNavigator3 = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripButton9 = new System.Windows.Forms.ToolStripButton();
            this.statusBranchDataGridView = new System.Windows.Forms.DataGridView();
            this.statusNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tsmenu = new System.Windows.Forms.ToolStrip();
            this.btnChoose = new System.Windows.Forms.ToolStripButton();
            this.hatchTableAdapter = new Repairs.RepairOSDSTableAdapters.HatchTableAdapter();
            this.tableAdapterManager = new Repairs.RepairOSDSTableAdapters.TableAdapterManager();
            this.branchTableAdapter = new Repairs.RepairOSDSTableAdapters.BranchTableAdapter();
            this.horizontTableAdapter = new Repairs.RepairOSDSTableAdapters.HorizontTableAdapter();
            this.storeTableAdapter = new Repairs.RepairOSDSTableAdapters.StoreTableAdapter();
            this.branchComboTableAdapter = new Repairs.RepairOSDSTableAdapters.BranchComboTableAdapter();
            this.shtrekTableAdapter = new Repairs.RepairOSDSTableAdapters.ShtrekTableAdapter();
            this.statusBranchTableAdapter = new Repairs.RepairOSDSTableAdapters.StatusBranchTableAdapter();
            this.branch_1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.branch_1TableAdapter = new Repairs.RepairOSDSTableAdapters.Branch_1TableAdapter();
            this.but = new System.Windows.Forms.DataGridViewButtonColumn();
            this.inventoryNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.branchIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.positiononbranchDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sidebranchesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.datehatchDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hatchIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            branch_nameLabel = new System.Windows.Forms.Label();
            branch_numLabel = new System.Windows.Forms.Label();
            shtrekIDLabel = new System.Windows.Forms.Label();
            branch_lenLabel = new System.Windows.Forms.Label();
            statusIDLabel = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.branchBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repairOSDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shtrekBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBranchBindingSource)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator2)).BeginInit();
            this.bindingNavigator2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.branchDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.horizontBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.horizontDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.storeBindingSource)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hatchBindingNavigator)).BeginInit();
            this.hatchBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hatchBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hatchDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.branchComboBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sideBindingSource1)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator3)).BeginInit();
            this.bindingNavigator3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statusBranchDataGridView)).BeginInit();
            this.tsmenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.branch_1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // branch_nameLabel
            // 
            branch_nameLabel.AutoSize = true;
            branch_nameLabel.Location = new System.Drawing.Point(36, 86);
            branch_nameLabel.Name = "branch_nameLabel";
            branch_nameLabel.Size = new System.Drawing.Size(60, 13);
            branch_nameLabel.TabIndex = 2;
            branch_nameLabel.Text = "Название:";
            // 
            // branch_numLabel
            // 
            branch_numLabel.AutoSize = true;
            branch_numLabel.Location = new System.Drawing.Point(52, 57);
            branch_numLabel.Name = "branch_numLabel";
            branch_numLabel.Size = new System.Drawing.Size(44, 13);
            branch_numLabel.TabIndex = 6;
            branch_numLabel.Text = "Номер:";
            // 
            // shtrekIDLabel
            // 
            shtrekIDLabel.AutoSize = true;
            shtrekIDLabel.Location = new System.Drawing.Point(47, 145);
            shtrekIDLabel.Name = "shtrekIDLabel";
            shtrekIDLabel.Size = new System.Drawing.Size(42, 13);
            shtrekIDLabel.TabIndex = 8;
            shtrekIDLabel.Text = "Штрек:";
            // 
            // branch_lenLabel
            // 
            branch_lenLabel.AutoSize = true;
            branch_lenLabel.Location = new System.Drawing.Point(47, 116);
            branch_lenLabel.Name = "branch_lenLabel";
            branch_lenLabel.Size = new System.Drawing.Size(49, 13);
            branch_lenLabel.TabIndex = 10;
            branch_lenLabel.Text = "Размер:";
            // 
            // statusIDLabel
            // 
            statusIDLabel.AutoSize = true;
            statusIDLabel.Location = new System.Drawing.Point(25, 176);
            statusIDLabel.Name = "statusIDLabel";
            statusIDLabel.Size = new System.Drawing.Size(64, 13);
            statusIDLabel.TabIndex = 12;
            statusIDLabel.Text = "Состояние:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(0, 43);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(898, 330);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.AutoScroll = true;
            this.tabPage2.Controls.Add(this.panel3);
            this.tabPage2.Controls.Add(this.panel2);
            this.tabPage2.Controls.Add(this.panel1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(890, 304);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Заезды";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.horizontIDTextBox);
            this.panel3.Controls.Add(this.cbxShtrek);
            this.panel3.Controls.Add(this.cbxStatus);
            this.panel3.Controls.Add(this.date_branchDateTimePicker);
            this.panel3.Controls.Add(this.date_statusDateTimePicker);
            this.panel3.Controls.Add(this.date_lenDateTimePicker);
            this.panel3.Controls.Add(statusIDLabel);
            this.panel3.Controls.Add(branch_lenLabel);
            this.panel3.Controls.Add(this.branch_lenTextBox);
            this.panel3.Controls.Add(shtrekIDLabel);
            this.panel3.Controls.Add(branch_numLabel);
            this.panel3.Controls.Add(this.branch_numTextBox);
            this.panel3.Controls.Add(branch_nameLabel);
            this.panel3.Controls.Add(this.branch_nameTextBox);
            this.panel3.Controls.Add(this.branchIDTextBox);
            this.panel3.Location = new System.Drawing.Point(344, 31);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(538, 267);
            this.panel3.TabIndex = 10;
            this.panel3.Visible = false;
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(3, 231);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(396, 30);
            this.panel4.TabIndex = 24;
            // 
            // horizontIDTextBox
            // 
            this.horizontIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.branchBindingSource, "HorizontID", true));
            this.horizontIDTextBox.Location = new System.Drawing.Point(102, 236);
            this.horizontIDTextBox.Name = "horizontIDTextBox";
            this.horizontIDTextBox.Size = new System.Drawing.Size(72, 20);
            this.horizontIDTextBox.TabIndex = 23;
            // 
            // branchBindingSource
            // 
            this.branchBindingSource.DataMember = "Branch";
            this.branchBindingSource.DataSource = this.repairOSDS;
            // 
            // repairOSDS
            // 
            this.repairOSDS.DataSetName = "RepairOSDS";
            this.repairOSDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cbxShtrek
            // 
            this.cbxShtrek.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.branchBindingSource, "ShtrekID", true));
            this.cbxShtrek.DataSource = this.shtrekBindingSource1;
            this.cbxShtrek.DisplayMember = "ShtrekName";
            this.cbxShtrek.FormattingEnabled = true;
            this.cbxShtrek.Location = new System.Drawing.Point(102, 142);
            this.cbxShtrek.Name = "cbxShtrek";
            this.cbxShtrek.Size = new System.Drawing.Size(297, 21);
            this.cbxShtrek.TabIndex = 22;
            this.cbxShtrek.ValueMember = "ShtrekID";
            // 
            // shtrekBindingSource1
            // 
            this.shtrekBindingSource1.DataMember = "Shtrek";
            this.shtrekBindingSource1.DataSource = this.repairOSDS;
            // 
            // cbxStatus
            // 
            this.cbxStatus.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.branchBindingSource, "StatusID", true));
            this.cbxStatus.DataSource = this.statusBranchBindingSource;
            this.cbxStatus.DisplayMember = "StatusName";
            this.cbxStatus.FormattingEnabled = true;
            this.cbxStatus.Location = new System.Drawing.Point(102, 172);
            this.cbxStatus.Name = "cbxStatus";
            this.cbxStatus.Size = new System.Drawing.Size(262, 21);
            this.cbxStatus.TabIndex = 20;
            this.cbxStatus.ValueMember = "StatusID";
            this.cbxStatus.SelectedValueChanged += new System.EventHandler(this.comboBox1_SelectedValueChanged);
            // 
            // statusBranchBindingSource
            // 
            this.statusBranchBindingSource.DataMember = "StatusBranch";
            this.statusBranchBindingSource.DataSource = this.repairOSDS;
            // 
            // date_branchDateTimePicker
            // 
            this.date_branchDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.branchBindingSource, "Date_branch", true));
            this.date_branchDateTimePicker.Location = new System.Drawing.Point(294, 241);
            this.date_branchDateTimePicker.Name = "date_branchDateTimePicker";
            this.date_branchDateTimePicker.Size = new System.Drawing.Size(26, 20);
            this.date_branchDateTimePicker.TabIndex = 19;
            // 
            // date_statusDateTimePicker
            // 
            this.date_statusDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.branchBindingSource, "Date_status", true));
            this.date_statusDateTimePicker.Location = new System.Drawing.Point(264, 241);
            this.date_statusDateTimePicker.Name = "date_statusDateTimePicker";
            this.date_statusDateTimePicker.Size = new System.Drawing.Size(24, 20);
            this.date_statusDateTimePicker.TabIndex = 17;
            // 
            // date_lenDateTimePicker
            // 
            this.date_lenDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.branchBindingSource, "Date_len", true));
            this.date_lenDateTimePicker.Location = new System.Drawing.Point(232, 241);
            this.date_lenDateTimePicker.Name = "date_lenDateTimePicker";
            this.date_lenDateTimePicker.Size = new System.Drawing.Size(26, 20);
            this.date_lenDateTimePicker.TabIndex = 15;
            // 
            // branch_lenTextBox
            // 
            this.branch_lenTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.branchBindingSource, "Branch_len", true));
            this.branch_lenTextBox.Location = new System.Drawing.Point(102, 113);
            this.branch_lenTextBox.Name = "branch_lenTextBox";
            this.branch_lenTextBox.Size = new System.Drawing.Size(194, 20);
            this.branch_lenTextBox.TabIndex = 11;
            this.branch_lenTextBox.TextChanged += new System.EventHandler(this.branch_lenTextBox_TextChanged);
            // 
            // branch_numTextBox
            // 
            this.branch_numTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.branchBindingSource, "Branch_num", true));
            this.branch_numTextBox.Location = new System.Drawing.Point(102, 54);
            this.branch_numTextBox.Name = "branch_numTextBox";
            this.branch_numTextBox.Size = new System.Drawing.Size(138, 20);
            this.branch_numTextBox.TabIndex = 7;
            // 
            // branch_nameTextBox
            // 
            this.branch_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.branchBindingSource, "Branch_name", true));
            this.branch_nameTextBox.Location = new System.Drawing.Point(102, 83);
            this.branch_nameTextBox.Name = "branch_nameTextBox";
            this.branch_nameTextBox.Size = new System.Drawing.Size(297, 20);
            this.branch_nameTextBox.TabIndex = 3;
            // 
            // branchIDTextBox
            // 
            this.branchIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.branchBindingSource, "BranchID", true));
            this.branchIDTextBox.Location = new System.Drawing.Point(18, 236);
            this.branchIDTextBox.Name = "branchIDTextBox";
            this.branchIDTextBox.Size = new System.Drawing.Size(78, 20);
            this.branchIDTextBox.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.bindingNavigator2);
            this.panel2.Controls.Add(this.branchDataGridView);
            this.panel2.Location = new System.Drawing.Point(344, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(541, 295);
            this.panel2.TabIndex = 3;
            // 
            // bindingNavigator2
            // 
            this.bindingNavigator2.AddNewItem = null;
            this.bindingNavigator2.BindingSource = this.branchBindingSource;
            this.bindingNavigator2.CountItem = null;
            this.bindingNavigator2.DeleteItem = this.toolStripButton5;
            this.bindingNavigator2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton6,
            this.toolStripButton5,
            this.toolStripButton7,
            this.toolStripButton4,
            this.toolStripButton8});
            this.bindingNavigator2.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator2.MoveFirstItem = null;
            this.bindingNavigator2.MoveLastItem = null;
            this.bindingNavigator2.MoveNextItem = null;
            this.bindingNavigator2.MovePreviousItem = null;
            this.bindingNavigator2.Name = "bindingNavigator2";
            this.bindingNavigator2.PositionItem = null;
            this.bindingNavigator2.Size = new System.Drawing.Size(541, 25);
            this.bindingNavigator2.TabIndex = 9;
            this.bindingNavigator2.Text = "bindingNavigator2";
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.RightToLeftAutoMirrorImage = true;
            this.toolStripButton5.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton5.Text = "Удалить";
            this.toolStripButton5.Click += new System.EventHandler(this.toolStripButton5_Click);
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton6.Enabled = false;
            this.toolStripButton6.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton6.Image")));
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton6.Text = "Сохранить данные";
            this.toolStripButton6.Click += new System.EventHandler(this.toolStripButton6_Click);
            // 
            // toolStripButton7
            // 
            this.toolStripButton7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton7.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton7.Image")));
            this.toolStripButton7.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton7.Name = "toolStripButton7";
            this.toolStripButton7.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton7.Text = "toolStripButton7";
            this.toolStripButton7.Click += new System.EventHandler(this.toolStripButton7_Click);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.RightToLeftAutoMirrorImage = true;
            this.toolStripButton4.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton4.Text = "Добавить";
            this.toolStripButton4.Click += new System.EventHandler(this.toolStripButton4_Click);
            // 
            // toolStripButton8
            // 
            this.toolStripButton8.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton8.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton8.Image")));
            this.toolStripButton8.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton8.Name = "toolStripButton8";
            this.toolStripButton8.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton8.Text = "toolStripButton8";
            this.toolStripButton8.Click += new System.EventHandler(this.toolStripButton8_Click);
            // 
            // branchDataGridView
            // 
            this.branchDataGridView.AllowUserToAddRows = false;
            this.branchDataGridView.AutoGenerateColumns = false;
            this.branchDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.branchDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Branch_num,
            this.Branch_name,
            this.Branch_len,
            this.ShtrekID,
            this.StatusID,
            this.branchIDDataGridViewTextBoxColumn,
            this.branchnameDataGridViewTextBoxColumn,
            this.horizontIDDataGridViewTextBoxColumn,
            this.branchnumDataGridViewTextBoxColumn,
            this.shtrekIDDataGridViewTextBoxColumn,
            this.branchlenDataGridViewTextBoxColumn,
            this.statusIDDataGridViewTextBoxColumn,
            this.datelenDataGridViewTextBoxColumn,
            this.datestatusDataGridViewTextBoxColumn,
            this.datebranchDataGridViewTextBoxColumn});
            this.branchDataGridView.DataSource = this.branchBindingSource;
            this.branchDataGridView.Location = new System.Drawing.Point(3, 28);
            this.branchDataGridView.Name = "branchDataGridView";
            this.branchDataGridView.ReadOnly = true;
            this.branchDataGridView.RowHeadersVisible = false;
            this.branchDataGridView.Size = new System.Drawing.Size(535, 264);
            this.branchDataGridView.TabIndex = 0;
            // 
            // Branch_num
            // 
            this.Branch_num.DataPropertyName = "Branch_num";
            this.Branch_num.HeaderText = "№";
            this.Branch_num.Name = "Branch_num";
            this.Branch_num.ReadOnly = true;
            this.Branch_num.Width = 50;
            // 
            // Branch_name
            // 
            this.Branch_name.DataPropertyName = "Branch_name";
            this.Branch_name.HeaderText = "Наименование";
            this.Branch_name.Name = "Branch_name";
            this.Branch_name.ReadOnly = true;
            this.Branch_name.Width = 120;
            // 
            // Branch_len
            // 
            this.Branch_len.DataPropertyName = "Branch_len";
            this.Branch_len.HeaderText = "Длина";
            this.Branch_len.Name = "Branch_len";
            this.Branch_len.ReadOnly = true;
            this.Branch_len.Width = 50;
            // 
            // ShtrekID
            // 
            this.ShtrekID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ShtrekID.DataPropertyName = "ShtrekID";
            this.ShtrekID.DataSource = this.shtrekBindingSource1;
            this.ShtrekID.DisplayMember = "ShtrekName";
            this.ShtrekID.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.ShtrekID.HeaderText = "Штрек";
            this.ShtrekID.Name = "ShtrekID";
            this.ShtrekID.ReadOnly = true;
            this.ShtrekID.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ShtrekID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ShtrekID.ValueMember = "ShtrekID";
            // 
            // StatusID
            // 
            this.StatusID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.StatusID.DataPropertyName = "StatusID";
            this.StatusID.DataSource = this.statusBranchBindingSource;
            this.StatusID.DisplayMember = "StatusName";
            this.StatusID.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.StatusID.HeaderText = "Состояние";
            this.StatusID.Name = "StatusID";
            this.StatusID.ReadOnly = true;
            this.StatusID.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.StatusID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.StatusID.ValueMember = "StatusID";
            // 
            // branchIDDataGridViewTextBoxColumn
            // 
            this.branchIDDataGridViewTextBoxColumn.DataPropertyName = "BranchID";
            this.branchIDDataGridViewTextBoxColumn.HeaderText = "Заезд №";
            this.branchIDDataGridViewTextBoxColumn.Name = "branchIDDataGridViewTextBoxColumn";
            this.branchIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.branchIDDataGridViewTextBoxColumn.Width = 80;
            // 
            // branchnameDataGridViewTextBoxColumn
            // 
            this.branchnameDataGridViewTextBoxColumn.DataPropertyName = "Branch_name";
            this.branchnameDataGridViewTextBoxColumn.HeaderText = "Branch_name";
            this.branchnameDataGridViewTextBoxColumn.Name = "branchnameDataGridViewTextBoxColumn";
            this.branchnameDataGridViewTextBoxColumn.ReadOnly = true;
            this.branchnameDataGridViewTextBoxColumn.Visible = false;
            // 
            // horizontIDDataGridViewTextBoxColumn
            // 
            this.horizontIDDataGridViewTextBoxColumn.DataPropertyName = "HorizontID";
            this.horizontIDDataGridViewTextBoxColumn.HeaderText = "HorizontID";
            this.horizontIDDataGridViewTextBoxColumn.Name = "horizontIDDataGridViewTextBoxColumn";
            this.horizontIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.horizontIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // branchnumDataGridViewTextBoxColumn
            // 
            this.branchnumDataGridViewTextBoxColumn.DataPropertyName = "Branch_num";
            this.branchnumDataGridViewTextBoxColumn.HeaderText = "Branch_num";
            this.branchnumDataGridViewTextBoxColumn.Name = "branchnumDataGridViewTextBoxColumn";
            this.branchnumDataGridViewTextBoxColumn.ReadOnly = true;
            this.branchnumDataGridViewTextBoxColumn.Visible = false;
            // 
            // shtrekIDDataGridViewTextBoxColumn
            // 
            this.shtrekIDDataGridViewTextBoxColumn.DataPropertyName = "ShtrekID";
            this.shtrekIDDataGridViewTextBoxColumn.HeaderText = "ShtrekID";
            this.shtrekIDDataGridViewTextBoxColumn.Name = "shtrekIDDataGridViewTextBoxColumn";
            this.shtrekIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.shtrekIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // branchlenDataGridViewTextBoxColumn
            // 
            this.branchlenDataGridViewTextBoxColumn.DataPropertyName = "Branch_len";
            this.branchlenDataGridViewTextBoxColumn.HeaderText = "Branch_len";
            this.branchlenDataGridViewTextBoxColumn.Name = "branchlenDataGridViewTextBoxColumn";
            this.branchlenDataGridViewTextBoxColumn.ReadOnly = true;
            this.branchlenDataGridViewTextBoxColumn.Visible = false;
            // 
            // statusIDDataGridViewTextBoxColumn
            // 
            this.statusIDDataGridViewTextBoxColumn.DataPropertyName = "StatusID";
            this.statusIDDataGridViewTextBoxColumn.HeaderText = "StatusID";
            this.statusIDDataGridViewTextBoxColumn.Name = "statusIDDataGridViewTextBoxColumn";
            this.statusIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.statusIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // datelenDataGridViewTextBoxColumn
            // 
            this.datelenDataGridViewTextBoxColumn.DataPropertyName = "Date_len";
            this.datelenDataGridViewTextBoxColumn.HeaderText = "Date_len";
            this.datelenDataGridViewTextBoxColumn.Name = "datelenDataGridViewTextBoxColumn";
            this.datelenDataGridViewTextBoxColumn.ReadOnly = true;
            this.datelenDataGridViewTextBoxColumn.Visible = false;
            // 
            // datestatusDataGridViewTextBoxColumn
            // 
            this.datestatusDataGridViewTextBoxColumn.DataPropertyName = "Date_status";
            this.datestatusDataGridViewTextBoxColumn.HeaderText = "Date_status";
            this.datestatusDataGridViewTextBoxColumn.Name = "datestatusDataGridViewTextBoxColumn";
            this.datestatusDataGridViewTextBoxColumn.ReadOnly = true;
            this.datestatusDataGridViewTextBoxColumn.Visible = false;
            // 
            // datebranchDataGridViewTextBoxColumn
            // 
            this.datebranchDataGridViewTextBoxColumn.DataPropertyName = "Date_branch";
            this.datebranchDataGridViewTextBoxColumn.HeaderText = "Date_branch";
            this.datebranchDataGridViewTextBoxColumn.Name = "datebranchDataGridViewTextBoxColumn";
            this.datebranchDataGridViewTextBoxColumn.ReadOnly = true;
            this.datebranchDataGridViewTextBoxColumn.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bindingNavigator1);
            this.panel1.Controls.Add(this.horizontDataGridView);
            this.panel1.Location = new System.Drawing.Point(0, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(338, 298);
            this.panel1.TabIndex = 2;
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.toolStripButton1;
            this.bindingNavigator1.BindingSource = this.horizontBindingSource;
            this.bindingNavigator1.CountItem = null;
            this.bindingNavigator1.DeleteItem = this.toolStripButton2;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator1.MoveFirstItem = null;
            this.bindingNavigator1.MoveLastItem = null;
            this.bindingNavigator1.MoveNextItem = null;
            this.bindingNavigator1.MovePreviousItem = null;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = null;
            this.bindingNavigator1.Size = new System.Drawing.Size(338, 25);
            this.bindingNavigator1.TabIndex = 8;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.RightToLeftAutoMirrorImage = true;
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "Добавить";
            // 
            // horizontBindingSource
            // 
            this.horizontBindingSource.DataMember = "Horizont";
            this.horizontBindingSource.DataSource = this.repairOSDS;
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.RightToLeftAutoMirrorImage = true;
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "Удалить";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton3.Text = "Сохранить данные";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // horizontDataGridView
            // 
            this.horizontDataGridView.AutoGenerateColumns = false;
            this.horizontDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.horizontDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.namehorizontDataGridViewTextBoxColumn,
            this.storeIDDataGridViewTextBoxColumn,
            this.horizontIDDataGridViewTextBoxColumn1});
            this.horizontDataGridView.DataSource = this.horizontBindingSource;
            this.horizontDataGridView.Location = new System.Drawing.Point(3, 28);
            this.horizontDataGridView.Name = "horizontDataGridView";
            this.horizontDataGridView.RowHeadersVisible = false;
            this.horizontDataGridView.Size = new System.Drawing.Size(332, 267);
            this.horizontDataGridView.TabIndex = 1;
            this.horizontDataGridView.CurrentCellChanged += new System.EventHandler(this.horizontDataGridView_CurrentCellChanged);
            // 
            // namehorizontDataGridViewTextBoxColumn
            // 
            this.namehorizontDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.namehorizontDataGridViewTextBoxColumn.DataPropertyName = "Name_horizont";
            this.namehorizontDataGridViewTextBoxColumn.HeaderText = "Горизонт";
            this.namehorizontDataGridViewTextBoxColumn.Name = "namehorizontDataGridViewTextBoxColumn";
            // 
            // storeIDDataGridViewTextBoxColumn
            // 
            this.storeIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.storeIDDataGridViewTextBoxColumn.DataPropertyName = "StoreID";
            this.storeIDDataGridViewTextBoxColumn.DataSource = this.storeBindingSource;
            this.storeIDDataGridViewTextBoxColumn.DisplayMember = "StoreName";
            this.storeIDDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.storeIDDataGridViewTextBoxColumn.HeaderText = "Подразделение";
            this.storeIDDataGridViewTextBoxColumn.Name = "storeIDDataGridViewTextBoxColumn";
            this.storeIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.storeIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.storeIDDataGridViewTextBoxColumn.ValueMember = "StoreID";
            // 
            // storeBindingSource
            // 
            this.storeBindingSource.DataMember = "Store";
            this.storeBindingSource.DataSource = this.repairOSDS;
            // 
            // horizontIDDataGridViewTextBoxColumn1
            // 
            this.horizontIDDataGridViewTextBoxColumn1.DataPropertyName = "HorizontID";
            this.horizontIDDataGridViewTextBoxColumn1.HeaderText = "HorizontID";
            this.horizontIDDataGridViewTextBoxColumn1.Name = "horizontIDDataGridViewTextBoxColumn1";
            this.horizontIDDataGridViewTextBoxColumn1.ReadOnly = true;
            this.horizontIDDataGridViewTextBoxColumn1.Visible = false;
            // 
            // tabPage1
            // 
            this.tabPage1.AutoScroll = true;
            this.tabPage1.Controls.Add(this.hatchBindingNavigator);
            this.tabPage1.Controls.Add(this.hatchDataGridView);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(890, 304);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Размещение люков";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // hatchBindingNavigator
            // 
            this.hatchBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.hatchBindingNavigator.BindingSource = this.hatchBindingSource;
            this.hatchBindingNavigator.CountItem = null;
            this.hatchBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.hatchBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.hatchBindingNavigatorSaveItem,
            this.toolStripButton10});
            this.hatchBindingNavigator.Location = new System.Drawing.Point(3, 3);
            this.hatchBindingNavigator.MoveFirstItem = null;
            this.hatchBindingNavigator.MoveLastItem = null;
            this.hatchBindingNavigator.MoveNextItem = null;
            this.hatchBindingNavigator.MovePreviousItem = null;
            this.hatchBindingNavigator.Name = "hatchBindingNavigator";
            this.hatchBindingNavigator.PositionItem = null;
            this.hatchBindingNavigator.Size = new System.Drawing.Size(884, 25);
            this.hatchBindingNavigator.TabIndex = 7;
            this.hatchBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // hatchBindingSource
            // 
            this.hatchBindingSource.DataMember = "Hatch";
            this.hatchBindingSource.DataSource = this.repairOSDS;
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // hatchBindingNavigatorSaveItem
            // 
            this.hatchBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.hatchBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("hatchBindingNavigatorSaveItem.Image")));
            this.hatchBindingNavigatorSaveItem.Name = "hatchBindingNavigatorSaveItem";
            this.hatchBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.hatchBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.hatchBindingNavigatorSaveItem.Click += new System.EventHandler(this.hatchBindingNavigatorSaveItem_Click);
            // 
            // toolStripButton10
            // 
            this.toolStripButton10.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton10.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton10.Image")));
            this.toolStripButton10.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton10.Name = "toolStripButton10";
            this.toolStripButton10.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton10.Text = "toolStripButton10";
            this.toolStripButton10.Click += new System.EventHandler(this.toolStripButton10_Click);
            // 
            // hatchDataGridView
            // 
            this.hatchDataGridView.AutoGenerateColumns = false;
            this.hatchDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.hatchDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.but,
            this.inventoryNumberDataGridViewTextBoxColumn,
            this.branchIDDataGridViewTextBoxColumn1,
            this.positiononbranchDataGridViewTextBoxColumn,
            this.sidebranchesDataGridViewTextBoxColumn,
            this.datehatchDataGridViewTextBoxColumn,
            this.hatchIDDataGridViewTextBoxColumn});
            this.hatchDataGridView.DataSource = this.hatchBindingSource;
            this.hatchDataGridView.Location = new System.Drawing.Point(3, 31);
            this.hatchDataGridView.Name = "hatchDataGridView";
            this.hatchDataGridView.RowHeadersVisible = false;
            this.hatchDataGridView.Size = new System.Drawing.Size(881, 270);
            this.hatchDataGridView.TabIndex = 0;
            this.hatchDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.hatchDataGridView_CellContentClick);
            this.hatchDataGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.hatchDataGridView_DataError);
            // 
            // branchComboBindingSource1
            // 
            this.branchComboBindingSource1.DataMember = "BranchCombo";
            this.branchComboBindingSource1.DataSource = this.repairOSDS;
            // 
            // sideBindingSource1
            // 
            this.sideBindingSource1.DataMember = "Side";
            this.sideBindingSource1.DataSource = this.repairOSDS;
            // 
            // tabPage3
            // 
            this.tabPage3.AutoScroll = true;
            this.tabPage3.Controls.Add(this.bindingNavigator3);
            this.tabPage3.Controls.Add(this.statusBranchDataGridView);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(890, 304);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Состояния (цвета)";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // bindingNavigator3
            // 
            this.bindingNavigator3.AddNewItem = null;
            this.bindingNavigator3.CountItem = null;
            this.bindingNavigator3.DeleteItem = null;
            this.bindingNavigator3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton9});
            this.bindingNavigator3.Location = new System.Drawing.Point(3, 3);
            this.bindingNavigator3.MoveFirstItem = null;
            this.bindingNavigator3.MoveLastItem = null;
            this.bindingNavigator3.MoveNextItem = null;
            this.bindingNavigator3.MovePreviousItem = null;
            this.bindingNavigator3.Name = "bindingNavigator3";
            this.bindingNavigator3.PositionItem = null;
            this.bindingNavigator3.Size = new System.Drawing.Size(884, 25);
            this.bindingNavigator3.TabIndex = 9;
            this.bindingNavigator3.Text = "bindingNavigator3";
            // 
            // toolStripButton9
            // 
            this.toolStripButton9.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton9.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton9.Image")));
            this.toolStripButton9.Name = "toolStripButton9";
            this.toolStripButton9.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton9.Text = "Сохранить данные";
            this.toolStripButton9.Click += new System.EventHandler(this.toolStripButton9_Click);
            // 
            // statusBranchDataGridView
            // 
            this.statusBranchDataGridView.AllowUserToAddRows = false;
            this.statusBranchDataGridView.AllowUserToDeleteRows = false;
            this.statusBranchDataGridView.AutoGenerateColumns = false;
            this.statusBranchDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.statusBranchDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.statusNameDataGridViewTextBoxColumn,
            this.colorDataGridViewTextBoxColumn,
            this.statusIDDataGridViewTextBoxColumn1});
            this.statusBranchDataGridView.DataSource = this.statusBranchBindingSource;
            this.statusBranchDataGridView.Location = new System.Drawing.Point(3, 31);
            this.statusBranchDataGridView.Name = "statusBranchDataGridView";
            this.statusBranchDataGridView.RowHeadersVisible = false;
            this.statusBranchDataGridView.Size = new System.Drawing.Size(881, 265);
            this.statusBranchDataGridView.TabIndex = 0;
            // 
            // statusNameDataGridViewTextBoxColumn
            // 
            this.statusNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.statusNameDataGridViewTextBoxColumn.DataPropertyName = "StatusName";
            this.statusNameDataGridViewTextBoxColumn.HeaderText = "Описание";
            this.statusNameDataGridViewTextBoxColumn.Name = "statusNameDataGridViewTextBoxColumn";
            // 
            // colorDataGridViewTextBoxColumn
            // 
            this.colorDataGridViewTextBoxColumn.DataPropertyName = "Color";
            this.colorDataGridViewTextBoxColumn.HeaderText = "Цвет";
            this.colorDataGridViewTextBoxColumn.Name = "colorDataGridViewTextBoxColumn";
            this.colorDataGridViewTextBoxColumn.ReadOnly = true;
            this.colorDataGridViewTextBoxColumn.Width = 150;
            // 
            // statusIDDataGridViewTextBoxColumn1
            // 
            this.statusIDDataGridViewTextBoxColumn1.DataPropertyName = "StatusID";
            this.statusIDDataGridViewTextBoxColumn1.HeaderText = "StatusID";
            this.statusIDDataGridViewTextBoxColumn1.Name = "statusIDDataGridViewTextBoxColumn1";
            this.statusIDDataGridViewTextBoxColumn1.ReadOnly = true;
            this.statusIDDataGridViewTextBoxColumn1.Visible = false;
            // 
            // tsmenu
            // 
            this.tsmenu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tsmenu.ImageScalingSize = new System.Drawing.Size(35, 35);
            this.tsmenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnChoose});
            this.tsmenu.Location = new System.Drawing.Point(0, 0);
            this.tsmenu.Name = "tsmenu";
            this.tsmenu.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.tsmenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.tsmenu.Size = new System.Drawing.Size(898, 42);
            this.tsmenu.TabIndex = 5;
            // 
            // btnChoose
            // 
            this.btnChoose.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnChoose.Image = ((System.Drawing.Image)(resources.GetObject("btnChoose.Image")));
            this.btnChoose.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnChoose.Name = "btnChoose";
            this.btnChoose.Size = new System.Drawing.Size(39, 39);
            this.btnChoose.Text = "Карта люков";
            this.btnChoose.Click += new System.EventHandler(this.btnChoose_Click);
            // 
            // hatchTableAdapter
            // 
            this.hatchTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Branch_1TableAdapter = null;
            this.tableAdapterManager.BranchTableAdapter = this.branchTableAdapter;
            this.tableAdapterManager.Hatch1TableAdapter = null;
            this.tableAdapterManager.HatchTableAdapter = this.hatchTableAdapter;
            this.tableAdapterManager.HorizontTableAdapter = this.horizontTableAdapter;
            this.tableAdapterManager.InspectNormTableAdapter = null;
            this.tableAdapterManager.JobTableAdapter = null;
            this.tableAdapterManager.PlacePartTableAdapter = null;
            this.tableAdapterManager.PlanJobTableAdapter = null;
            this.tableAdapterManager.PlotTableAdapter = null;
            this.tableAdapterManager.RefJobTableAdapter = null;
            this.tableAdapterManager.RefPartTableAdapter = null;
            this.tableAdapterManager.RefPlaceTableAdapter = null;
            this.tableAdapterManager.RepairTableAdapter = null;
            this.tableAdapterManager.ReplacedPartTableAdapter = null;
            this.tableAdapterManager.Shtrek1TableAdapter = null;
            this.tableAdapterManager.ShtrekTableAdapter = null;
            this.tableAdapterManager.sprDivisionTableAdapter = null;
            this.tableAdapterManager.SprOSGroupTableAdapter = null;
            this.tableAdapterManager.SprOSTableAdapter = null;
            this.tableAdapterManager.sprRepairDivisionTableAdapter = null;
            this.tableAdapterManager.SprUserTableAdapter = null;
            this.tableAdapterManager.StatusBranchTableAdapter = null;
            this.tableAdapterManager.StoreTableAdapter = this.storeTableAdapter;
            this.tableAdapterManager.UpdateOrder = Repairs.RepairOSDSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Users_listTableAdapter = null;
            this.tableAdapterManager.WorkOSTableAdapter = null;
            // 
            // branchTableAdapter
            // 
            this.branchTableAdapter.ClearBeforeFill = true;
            // 
            // horizontTableAdapter
            // 
            this.horizontTableAdapter.ClearBeforeFill = true;
            // 
            // storeTableAdapter
            // 
            this.storeTableAdapter.ClearBeforeFill = true;
            // 
            // branchComboTableAdapter
            // 
            this.branchComboTableAdapter.ClearBeforeFill = true;
            // 
            // shtrekTableAdapter
            // 
            this.shtrekTableAdapter.ClearBeforeFill = true;
            // 
            // statusBranchTableAdapter
            // 
            this.statusBranchTableAdapter.ClearBeforeFill = true;
            // 
            // branch_1BindingSource
            // 
            this.branch_1BindingSource.DataMember = "Branch_1";
            this.branch_1BindingSource.DataSource = this.repairOSDS;
            // 
            // branch_1TableAdapter
            // 
            this.branch_1TableAdapter.ClearBeforeFill = true;
            // 
            // but
            // 
            this.but.HeaderText = "...";
            this.but.Name = "but";
            this.but.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.but.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.but.ToolTipText = "Выбрать люк";
            this.but.Width = 20;
            // 
            // inventoryNumberDataGridViewTextBoxColumn
            // 
            this.inventoryNumberDataGridViewTextBoxColumn.DataPropertyName = "InventoryNumber";
            this.inventoryNumberDataGridViewTextBoxColumn.HeaderText = "Инв. №";
            this.inventoryNumberDataGridViewTextBoxColumn.Name = "inventoryNumberDataGridViewTextBoxColumn";
            this.inventoryNumberDataGridViewTextBoxColumn.Width = 80;
            // 
            // branchIDDataGridViewTextBoxColumn1
            // 
            this.branchIDDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.branchIDDataGridViewTextBoxColumn1.DataPropertyName = "BranchID";
            this.branchIDDataGridViewTextBoxColumn1.DataSource = this.branchComboBindingSource1;
            this.branchIDDataGridViewTextBoxColumn1.DisplayMember = "name";
            this.branchIDDataGridViewTextBoxColumn1.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.branchIDDataGridViewTextBoxColumn1.HeaderText = "Заезд";
            this.branchIDDataGridViewTextBoxColumn1.Name = "branchIDDataGridViewTextBoxColumn1";
            this.branchIDDataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.branchIDDataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.branchIDDataGridViewTextBoxColumn1.ValueMember = "BranchID";
            // 
            // positiononbranchDataGridViewTextBoxColumn
            // 
            this.positiononbranchDataGridViewTextBoxColumn.DataPropertyName = "Position_on_branch";
            this.positiononbranchDataGridViewTextBoxColumn.HeaderText = "Позиция";
            this.positiononbranchDataGridViewTextBoxColumn.Name = "positiononbranchDataGridViewTextBoxColumn";
            // 
            // sidebranchesDataGridViewTextBoxColumn
            // 
            this.sidebranchesDataGridViewTextBoxColumn.DataPropertyName = "Side_branches";
            this.sidebranchesDataGridViewTextBoxColumn.DataSource = this.sideBindingSource1;
            this.sidebranchesDataGridViewTextBoxColumn.DisplayMember = "nam";
            this.sidebranchesDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.sidebranchesDataGridViewTextBoxColumn.HeaderText = "Сторона";
            this.sidebranchesDataGridViewTextBoxColumn.Name = "sidebranchesDataGridViewTextBoxColumn";
            this.sidebranchesDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.sidebranchesDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.sidebranchesDataGridViewTextBoxColumn.ValueMember = "cod";
            // 
            // datehatchDataGridViewTextBoxColumn
            // 
            this.datehatchDataGridViewTextBoxColumn.DataPropertyName = "Date_hatch";
            this.datehatchDataGridViewTextBoxColumn.HeaderText = "Дата";
            this.datehatchDataGridViewTextBoxColumn.Name = "datehatchDataGridViewTextBoxColumn";
            // 
            // hatchIDDataGridViewTextBoxColumn
            // 
            this.hatchIDDataGridViewTextBoxColumn.DataPropertyName = "HatchID";
            this.hatchIDDataGridViewTextBoxColumn.HeaderText = "HatchID";
            this.hatchIDDataGridViewTextBoxColumn.Name = "hatchIDDataGridViewTextBoxColumn";
            this.hatchIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.hatchIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.hatchIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // frmHatch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 373);
            this.Controls.Add(this.tsmenu);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmHatch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Люки";
            this.Load += new System.EventHandler(this.frmHatch_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.branchBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repairOSDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shtrekBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBranchBindingSource)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator2)).EndInit();
            this.bindingNavigator2.ResumeLayout(false);
            this.bindingNavigator2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.branchDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.horizontBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.horizontDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.storeBindingSource)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hatchBindingNavigator)).EndInit();
            this.hatchBindingNavigator.ResumeLayout(false);
            this.hatchBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hatchBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hatchDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.branchComboBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sideBindingSource1)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator3)).EndInit();
            this.bindingNavigator3.ResumeLayout(false);
            this.bindingNavigator3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statusBranchDataGridView)).EndInit();
            this.tsmenu.ResumeLayout(false);
            this.tsmenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.branch_1BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ToolStrip tsmenu;
        private System.Windows.Forms.ToolStripButton btnChoose;
        private RepairOSDSTableAdapters.HatchTableAdapter hatchTableAdapter;
        private RepairOSDSTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator hatchBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton hatchBindingNavigatorSaveItem;
        private RepairOSDSTableAdapters.BranchTableAdapter branchTableAdapter;
        private System.Windows.Forms.DataGridView branchDataGridView;
        private RepairOSDSTableAdapters.HorizontTableAdapter horizontTableAdapter;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.BindingNavigator bindingNavigator2;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripButton toolStripButton6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.DataGridView horizontDataGridView;
        private RepairOSDSTableAdapters.StoreTableAdapter storeTableAdapter;
        private RepairOSDSTableAdapters.BranchComboTableAdapter branchComboTableAdapter;
        public System.Windows.Forms.DataGridView hatchDataGridView;
        private RepairOSDSTableAdapters.ShtrekTableAdapter shtrekTableAdapter;
        private RepairOSDSTableAdapters.StatusBranchTableAdapter statusBranchTableAdapter;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.BindingNavigator bindingNavigator3;
        private System.Windows.Forms.ToolStripButton toolStripButton9;
        private System.Windows.Forms.DataGridView statusBranchDataGridView;
        private RepairOSDS repairOSDS;
        private System.Windows.Forms.BindingSource horizontBindingSource;
        private System.Windows.Forms.BindingSource statusBranchBindingSource;
        private System.Windows.Forms.BindingSource branchBindingSource;
        private System.Windows.Forms.BindingSource sideBindingSource1;
        private System.Windows.Forms.BindingSource shtrekBindingSource1;
        private System.Windows.Forms.BindingSource branchComboBindingSource1;
        private System.Windows.Forms.BindingSource hatchBindingSource;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DateTimePicker date_branchDateTimePicker;
        private System.Windows.Forms.DateTimePicker date_statusDateTimePicker;
        private System.Windows.Forms.DateTimePicker date_lenDateTimePicker;
        private System.Windows.Forms.TextBox branch_lenTextBox;
        private System.Windows.Forms.TextBox branch_nameTextBox;
        private System.Windows.Forms.TextBox branchIDTextBox;
        private System.Windows.Forms.ToolStripButton toolStripButton7;
        private System.Windows.Forms.BindingSource branch_1BindingSource;
        private RepairOSDSTableAdapters.Branch_1TableAdapter branch_1TableAdapter;
        private System.Windows.Forms.ComboBox cbxStatus;
        private System.Windows.Forms.ComboBox cbxShtrek;
        private System.Windows.Forms.TextBox branch_numTextBox;
        private System.Windows.Forms.TextBox horizontIDTextBox;
        private System.Windows.Forms.ToolStripButton toolStripButton8;
        private System.Windows.Forms.DataGridViewTextBoxColumn namehorizontDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn storeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource storeBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn horizontIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ToolStripButton toolStripButton10;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Branch_num;
        private System.Windows.Forms.DataGridViewTextBoxColumn Branch_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Branch_len;
        private System.Windows.Forms.DataGridViewComboBoxColumn ShtrekID;
        private System.Windows.Forms.DataGridViewComboBoxColumn StatusID;
        private System.Windows.Forms.DataGridViewTextBoxColumn branchIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn branchnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn horizontIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn branchnumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shtrekIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn branchlenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datelenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datestatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datebranchDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn but;
        private System.Windows.Forms.DataGridViewTextBoxColumn inventoryNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn branchIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn positiononbranchDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn sidebranchesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datehatchDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hatchIDDataGridViewTextBoxColumn;
    }
}