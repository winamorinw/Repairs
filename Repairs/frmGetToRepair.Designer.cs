namespace Repairs
{
    partial class frmGetToRepair
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
            System.Windows.Forms.Label lblDivision;
            System.Windows.Forms.Label lblRDivision;
            System.Windows.Forms.Label lblDateIn;
            System.Windows.Forms.Label lblInventoryNumber;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label5;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGetToRepair));
            this.gridRepair = new System.Windows.Forms.DataGridView();
            this.repairIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inventoryNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.divisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.asRDivisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateInDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOutDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeFlautDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.causeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.responsibleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.repairTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.repairOSDS1 = new Repairs.RepairOSDS();
            this.repairBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.repairOSDS = new Repairs.RepairOSDS();
            this.pnl = new System.Windows.Forms.Panel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.txtResponsible = new System.Windows.Forms.TextBox();
            this.txtCause = new System.Windows.Forms.TextBox();
            this.txtTypeFlaut = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtInventoryNumber = new System.Windows.Forms.TextBox();
            this.txtDivision = new System.Windows.Forms.TextBox();
            this.mtxtDateIn = new System.Windows.Forms.MaskedTextBox();
            this.cbxSprRepairDivision = new System.Windows.Forms.ComboBox();
            this.storeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnRefOkrt = new System.Windows.Forms.Button();
            this.storeBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.ssmenu = new System.Windows.Forms.StatusStrip();
            this.tsmenu = new System.Windows.Forms.ToolStrip();
            this.btnSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnReport = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.btnDelete = new System.Windows.Forms.ToolStripButton();
            this.repairTableAdapter = new Repairs.RepairOSDSTableAdapters.RepairTableAdapter();
            this.repairTableTableAdapter = new Repairs.RepairOSDSTableAdapters.RepairTableTableAdapter();
            this.storeTableAdapter = new Repairs.RepairOSDSTableAdapters.StoreTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            lblDivision = new System.Windows.Forms.Label();
            lblRDivision = new System.Windows.Forms.Label();
            lblDateIn = new System.Windows.Forms.Label();
            lblInventoryNumber = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridRepair)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repairTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repairOSDS1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repairBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repairOSDS)).BeginInit();
            this.pnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.storeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.storeBindingSource1)).BeginInit();
            this.tsmenu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDivision
            // 
            lblDivision.AutoSize = true;
            lblDivision.Location = new System.Drawing.Point(34, 13);
            lblDivision.Name = "lblDivision";
            lblDivision.Size = new System.Drawing.Size(145, 20);
            lblDivision.TabIndex = 107;
            lblDivision.Text = "Цех отправитель:";
            // 
            // lblRDivision
            // 
            lblRDivision.AutoSize = true;
            lblRDivision.Location = new System.Drawing.Point(51, 45);
            lblRDivision.Name = "lblRDivision";
            lblRDivision.Size = new System.Drawing.Size(128, 20);
            lblRDivision.TabIndex = 108;
            lblRDivision.Text = "Ремонтный цех:";
            // 
            // lblDateIn
            // 
            lblDateIn.AutoSize = true;
            lblDateIn.Location = new System.Drawing.Point(23, 77);
            lblDateIn.Name = "lblDateIn";
            lblDateIn.Size = new System.Drawing.Size(156, 20);
            lblDateIn.TabIndex = 109;
            lblDateIn.Text = "Дата отправления:";
            // 
            // lblInventoryNumber
            // 
            lblInventoryNumber.AutoSize = true;
            lblInventoryNumber.Location = new System.Drawing.Point(12, 109);
            lblInventoryNumber.Name = "lblInventoryNumber";
            lblInventoryNumber.Size = new System.Drawing.Size(167, 20);
            lblInventoryNumber.TabIndex = 110;
            lblInventoryNumber.Text = "Инвентарный номер:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(420, 13);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(109, 20);
            label2.TabIndex = 123;
            label2.Text = "Тип поломки:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(450, 45);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(79, 20);
            label3.TabIndex = 124;
            label3.Text = "Причина:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(395, 77);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(134, 20);
            label4.TabIndex = 125;
            label4.Text = "Ответственный:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(421, 109);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(108, 20);
            label5.TabIndex = 126;
            label5.Text = "Примечания:";
            // 
            // gridRepair
            // 
            this.gridRepair.AllowUserToAddRows = false;
            this.gridRepair.AllowUserToDeleteRows = false;
            this.gridRepair.AutoGenerateColumns = false;
            this.gridRepair.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridRepair.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.repairIDDataGridViewTextBoxColumn,
            this.inventoryNumberDataGridViewTextBoxColumn,
            this.divisDataGridViewTextBoxColumn,
            this.asRDivisDataGridViewTextBoxColumn,
            this.dateInDataGridViewTextBoxColumn,
            this.dateOutDataGridViewTextBoxColumn,
            this.typeFlautDataGridViewTextBoxColumn,
            this.causeDataGridViewTextBoxColumn,
            this.responsibleDataGridViewTextBoxColumn,
            this.noteDataGridViewTextBoxColumn});
            this.gridRepair.DataSource = this.repairTableBindingSource;
            this.gridRepair.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridRepair.Location = new System.Drawing.Point(0, 0);
            this.gridRepair.Name = "gridRepair";
            this.gridRepair.ReadOnly = true;
            this.gridRepair.Size = new System.Drawing.Size(718, 327);
            this.gridRepair.TabIndex = 122;
            // 
            // repairIDDataGridViewTextBoxColumn
            // 
            this.repairIDDataGridViewTextBoxColumn.DataPropertyName = "RepairID";
            this.repairIDDataGridViewTextBoxColumn.HeaderText = "RepairID";
            this.repairIDDataGridViewTextBoxColumn.Name = "repairIDDataGridViewTextBoxColumn";
            this.repairIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.repairIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // inventoryNumberDataGridViewTextBoxColumn
            // 
            this.inventoryNumberDataGridViewTextBoxColumn.DataPropertyName = "InventoryNumber";
            this.inventoryNumberDataGridViewTextBoxColumn.HeaderText = "Инв.№";
            this.inventoryNumberDataGridViewTextBoxColumn.Name = "inventoryNumberDataGridViewTextBoxColumn";
            this.inventoryNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // divisDataGridViewTextBoxColumn
            // 
            this.divisDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.divisDataGridViewTextBoxColumn.DataPropertyName = "Divis";
            this.divisDataGridViewTextBoxColumn.HeaderText = "Цех отправитель";
            this.divisDataGridViewTextBoxColumn.Name = "divisDataGridViewTextBoxColumn";
            this.divisDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // asRDivisDataGridViewTextBoxColumn
            // 
            this.asRDivisDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.asRDivisDataGridViewTextBoxColumn.DataPropertyName = "AsRDivis";
            this.asRDivisDataGridViewTextBoxColumn.HeaderText = "Ремонтный цех";
            this.asRDivisDataGridViewTextBoxColumn.Name = "asRDivisDataGridViewTextBoxColumn";
            this.asRDivisDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateInDataGridViewTextBoxColumn
            // 
            this.dateInDataGridViewTextBoxColumn.DataPropertyName = "DateIn";
            this.dateInDataGridViewTextBoxColumn.HeaderText = "Дата отправки";
            this.dateInDataGridViewTextBoxColumn.Name = "dateInDataGridViewTextBoxColumn";
            this.dateInDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateOutDataGridViewTextBoxColumn
            // 
            this.dateOutDataGridViewTextBoxColumn.DataPropertyName = "DateOut";
            this.dateOutDataGridViewTextBoxColumn.HeaderText = "Дата ремонта";
            this.dateOutDataGridViewTextBoxColumn.Name = "dateOutDataGridViewTextBoxColumn";
            this.dateOutDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // typeFlautDataGridViewTextBoxColumn
            // 
            this.typeFlautDataGridViewTextBoxColumn.DataPropertyName = "TypeFlaut";
            this.typeFlautDataGridViewTextBoxColumn.HeaderText = "TypeFlaut";
            this.typeFlautDataGridViewTextBoxColumn.Name = "typeFlautDataGridViewTextBoxColumn";
            this.typeFlautDataGridViewTextBoxColumn.ReadOnly = true;
            this.typeFlautDataGridViewTextBoxColumn.Visible = false;
            // 
            // causeDataGridViewTextBoxColumn
            // 
            this.causeDataGridViewTextBoxColumn.DataPropertyName = "Cause";
            this.causeDataGridViewTextBoxColumn.HeaderText = "Cause";
            this.causeDataGridViewTextBoxColumn.Name = "causeDataGridViewTextBoxColumn";
            this.causeDataGridViewTextBoxColumn.ReadOnly = true;
            this.causeDataGridViewTextBoxColumn.Visible = false;
            // 
            // responsibleDataGridViewTextBoxColumn
            // 
            this.responsibleDataGridViewTextBoxColumn.DataPropertyName = "Responsible";
            this.responsibleDataGridViewTextBoxColumn.HeaderText = "Responsible";
            this.responsibleDataGridViewTextBoxColumn.Name = "responsibleDataGridViewTextBoxColumn";
            this.responsibleDataGridViewTextBoxColumn.ReadOnly = true;
            this.responsibleDataGridViewTextBoxColumn.Visible = false;
            // 
            // noteDataGridViewTextBoxColumn
            // 
            this.noteDataGridViewTextBoxColumn.DataPropertyName = "Note";
            this.noteDataGridViewTextBoxColumn.HeaderText = "Note";
            this.noteDataGridViewTextBoxColumn.Name = "noteDataGridViewTextBoxColumn";
            this.noteDataGridViewTextBoxColumn.ReadOnly = true;
            this.noteDataGridViewTextBoxColumn.Visible = false;
            // 
            // repairTableBindingSource
            // 
            this.repairTableBindingSource.DataMember = "RepairTable";
            this.repairTableBindingSource.DataSource = this.repairOSDS1;
            // 
            // repairOSDS1
            // 
            this.repairOSDS1.DataSetName = "RepairOSDS";
            this.repairOSDS1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // repairBindingSource
            // 
            this.repairBindingSource.DataMember = "Repair";
            this.repairBindingSource.DataSource = this.repairOSDS;
            // 
            // repairOSDS
            // 
            this.repairOSDS.DataSetName = "RepairOSDS";
            this.repairOSDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pnl
            // 
            this.pnl.Controls.Add(this.checkBox1);
            this.pnl.Controls.Add(label5);
            this.pnl.Controls.Add(label4);
            this.pnl.Controls.Add(label3);
            this.pnl.Controls.Add(label2);
            this.pnl.Controls.Add(this.txtNote);
            this.pnl.Controls.Add(this.txtResponsible);
            this.pnl.Controls.Add(this.txtCause);
            this.pnl.Controls.Add(this.txtTypeFlaut);
            this.pnl.Controls.Add(this.label1);
            this.pnl.Controls.Add(this.txtInventoryNumber);
            this.pnl.Controls.Add(lblDivision);
            this.pnl.Controls.Add(lblRDivision);
            this.pnl.Controls.Add(lblDateIn);
            this.pnl.Controls.Add(this.txtDivision);
            this.pnl.Controls.Add(lblInventoryNumber);
            this.pnl.Controls.Add(this.mtxtDateIn);
            this.pnl.Controls.Add(this.cbxSprRepairDivision);
            this.pnl.Controls.Add(this.btnRefOkrt);
            this.pnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pnl.Location = new System.Drawing.Point(0, 32);
            this.pnl.Name = "pnl";
            this.pnl.Size = new System.Drawing.Size(718, 163);
            this.pnl.TabIndex = 123;
            this.pnl.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_Paint);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(185, 136);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(106, 24);
            this.checkBox1.TabIndex = 127;
            this.checkBox1.Text = "Плановый";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // txtNote
            // 
            this.txtNote.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.repairTableBindingSource, "Note", true));
            this.txtNote.Location = new System.Drawing.Point(535, 106);
            this.txtNote.Multiline = true;
            this.txtNote.Name = "txtNote";
            this.txtNote.ReadOnly = true;
            this.txtNote.Size = new System.Drawing.Size(171, 37);
            this.txtNote.TabIndex = 122;
            // 
            // txtResponsible
            // 
            this.txtResponsible.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.repairTableBindingSource, "Responsible", true));
            this.txtResponsible.Location = new System.Drawing.Point(535, 74);
            this.txtResponsible.Name = "txtResponsible";
            this.txtResponsible.ReadOnly = true;
            this.txtResponsible.Size = new System.Drawing.Size(171, 26);
            this.txtResponsible.TabIndex = 120;
            // 
            // txtCause
            // 
            this.txtCause.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.repairTableBindingSource, "Cause", true));
            this.txtCause.Location = new System.Drawing.Point(535, 42);
            this.txtCause.Name = "txtCause";
            this.txtCause.ReadOnly = true;
            this.txtCause.Size = new System.Drawing.Size(171, 26);
            this.txtCause.TabIndex = 119;
            // 
            // txtTypeFlaut
            // 
            this.txtTypeFlaut.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.repairTableBindingSource, "TypeFlaut", true));
            this.txtTypeFlaut.Location = new System.Drawing.Point(535, 10);
            this.txtTypeFlaut.Name = "txtTypeFlaut";
            this.txtTypeFlaut.ReadOnly = true;
            this.txtTypeFlaut.Size = new System.Drawing.Size(171, 26);
            this.txtTypeFlaut.TabIndex = 118;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(244, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 20);
            this.label1.TabIndex = 117;
            this.label1.Text = "_________";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtInventoryNumber
            // 
            this.txtInventoryNumber.Location = new System.Drawing.Point(185, 106);
            this.txtInventoryNumber.Name = "txtInventoryNumber";
            this.txtInventoryNumber.ReadOnly = true;
            this.txtInventoryNumber.Size = new System.Drawing.Size(171, 26);
            this.txtInventoryNumber.TabIndex = 115;
            // 
            // txtDivision
            // 
            this.txtDivision.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDivision.Location = new System.Drawing.Point(204, 13);
            this.txtDivision.Name = "txtDivision";
            this.txtDivision.ReadOnly = true;
            this.txtDivision.Size = new System.Drawing.Size(34, 19);
            this.txtDivision.TabIndex = 112;
            // 
            // mtxtDateIn
            // 
            this.mtxtDateIn.Location = new System.Drawing.Point(185, 74);
            this.mtxtDateIn.Mask = "00/00/0000";
            this.mtxtDateIn.Name = "mtxtDateIn";
            this.mtxtDateIn.Size = new System.Drawing.Size(207, 26);
            this.mtxtDateIn.TabIndex = 114;
            this.mtxtDateIn.ValidatingType = typeof(System.DateTime);
            // 
            // cbxSprRepairDivision
            // 
            this.cbxSprRepairDivision.DataSource = this.storeBindingSource;
            this.cbxSprRepairDivision.DisplayMember = "StoreName";
            this.cbxSprRepairDivision.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSprRepairDivision.FormattingEnabled = true;
            this.cbxSprRepairDivision.Location = new System.Drawing.Point(185, 42);
            this.cbxSprRepairDivision.Name = "cbxSprRepairDivision";
            this.cbxSprRepairDivision.Size = new System.Drawing.Size(207, 28);
            this.cbxSprRepairDivision.TabIndex = 113;
            this.cbxSprRepairDivision.ValueMember = "StoreID";
            this.cbxSprRepairDivision.SelectedIndexChanged += new System.EventHandler(this.cbxSprRepairDivision_SelectedIndexChanged);
            // 
            // storeBindingSource
            // 
            this.storeBindingSource.DataMember = "Store";
            this.storeBindingSource.DataSource = this.repairOSDS1;
            // 
            // btnRefOkrt
            // 
            this.btnRefOkrt.Image = ((System.Drawing.Image)(resources.GetObject("btnRefOkrt.Image")));
            this.btnRefOkrt.Location = new System.Drawing.Point(362, 104);
            this.btnRefOkrt.Name = "btnRefOkrt";
            this.btnRefOkrt.Size = new System.Drawing.Size(30, 30);
            this.btnRefOkrt.TabIndex = 116;
            this.btnRefOkrt.UseVisualStyleBackColor = true;
            this.btnRefOkrt.Click += new System.EventHandler(this.btnRefOkrt_Click);
            // 
            // storeBindingSource1
            // 
            this.storeBindingSource1.DataMember = "Store";
            this.storeBindingSource1.DataSource = this.repairOSDS1;
            // 
            // ssmenu
            // 
            this.ssmenu.Location = new System.Drawing.Point(0, 522);
            this.ssmenu.Name = "ssmenu";
            this.ssmenu.Size = new System.Drawing.Size(718, 22);
            this.ssmenu.TabIndex = 120;
            this.ssmenu.Text = "statusStrip1";
            // 
            // tsmenu
            // 
            this.tsmenu.ImageScalingSize = new System.Drawing.Size(25, 25);
            this.tsmenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSave,
            this.toolStripSeparator1,
            this.btnReport,
            this.toolStripButton1,
            this.btnDelete});
            this.tsmenu.Location = new System.Drawing.Point(0, 0);
            this.tsmenu.Name = "tsmenu";
            this.tsmenu.Size = new System.Drawing.Size(718, 32);
            this.tsmenu.TabIndex = 121;
            // 
            // btnSave
            // 
            this.btnSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(29, 29);
            this.btnSave.Text = "Отправить в ремонт";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 32);
            // 
            // btnReport
            // 
            this.btnReport.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnReport.Image = ((System.Drawing.Image)(resources.GetObject("btnReport.Image")));
            this.btnReport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(29, 29);
            this.btnReport.Text = "Отчеты";
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(29, 29);
            this.toolStripButton1.Text = "Обновить";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(29, 29);
            this.btnDelete.Text = "Удалить информацию о ремонте";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // repairTableAdapter
            // 
            this.repairTableAdapter.ClearBeforeFill = true;
            // 
            // repairTableTableAdapter
            // 
            this.repairTableTableAdapter.ClearBeforeFill = true;
            // 
            // storeTableAdapter
            // 
            this.storeTableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gridRepair);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel1.Location = new System.Drawing.Point(0, 195);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(718, 327);
            this.panel1.TabIndex = 124;
            // 
            // frmGetToRepair
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 544);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnl);
            this.Controls.Add(this.ssmenu);
            this.Controls.Add(this.tsmenu);
            this.Name = "frmGetToRepair";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Отправка в ремонт";
            this.Load += new System.EventHandler(this.frmGetToRepair_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridRepair)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repairTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repairOSDS1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repairBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repairOSDS)).EndInit();
            this.pnl.ResumeLayout(false);
            this.pnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.storeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.storeBindingSource1)).EndInit();
            this.tsmenu.ResumeLayout(false);
            this.tsmenu.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridRepair;
        private System.Windows.Forms.Panel pnl;
        private System.Windows.Forms.TextBox txtDivision;
        private System.Windows.Forms.MaskedTextBox mtxtDateIn;
        private System.Windows.Forms.ComboBox cbxSprRepairDivision;
        private System.Windows.Forms.Button btnRefOkrt;
        private System.Windows.Forms.StatusStrip ssmenu;
        private System.Windows.Forms.ToolStrip tsmenu;
        private System.Windows.Forms.ToolStripButton btnSave;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnReport;
        private RepairOSDS repairOSDS;
        private System.Windows.Forms.BindingSource repairBindingSource;
        private RepairOSDSTableAdapters.RepairTableAdapter repairTableAdapter;
        public System.Windows.Forms.TextBox txtInventoryNumber;
        private System.Windows.Forms.Label label1;
        private RepairOSDS repairOSDS1;
        private System.Windows.Forms.BindingSource repairTableBindingSource;
        private RepairOSDSTableAdapters.RepairTableTableAdapter repairTableTableAdapter;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.TextBox txtResponsible;
        private System.Windows.Forms.TextBox txtCause;
        private System.Windows.Forms.TextBox txtTypeFlaut;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.DataGridViewTextBoxColumn repairIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn inventoryNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn divisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn asRDivisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateInDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOutDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeFlautDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn causeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn responsibleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noteDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource storeBindingSource;
        private RepairOSDSTableAdapters.StoreTableAdapter storeTableAdapter;
        private System.Windows.Forms.BindingSource storeBindingSource1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ToolStripButton btnDelete;
    }
}