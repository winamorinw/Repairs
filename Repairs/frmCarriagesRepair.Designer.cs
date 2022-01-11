namespace Repairs
{
    partial class frmCarriagesRepair
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
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label2;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCarriagesRepair));
            this.ssmenu = new System.Windows.Forms.StatusStrip();
            this.tsmenu = new System.Windows.Forms.ToolStrip();
            this.btnRepair = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnShowCarriagesInR = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.gridCarriages = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inventoryNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateInDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.divisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.asRDivisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOutDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeFlautDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.causeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.responsibleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.repairTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.repairOSDS = new Repairs.RepairOSDS();
            this.repairBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.datpBeg = new System.Windows.Forms.DateTimePicker();
            this.datpEnd = new System.Windows.Forms.DateTimePicker();
            this.lblDateBeg = new System.Windows.Forms.Label();
            this.lblDateEnd = new System.Windows.Forms.Label();
            this.datpDateEndRepair = new System.Windows.Forms.DateTimePicker();
            this.repairTableAdapter = new Repairs.RepairOSDSTableAdapters.RepairTableAdapter();
            this.repairTableTableAdapter = new Repairs.RepairOSDSTableAdapters.RepairTableTableAdapter();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.txtResponsible = new System.Windows.Forms.TextBox();
            this.txtCause = new System.Windows.Forms.TextBox();
            this.txtTypeFlaut = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gridJob = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.jobTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbxRefJob = new System.Windows.Forms.ComboBox();
            this.refJobBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ts = new System.Windows.Forms.ToolStrip();
            this.btnAddJob = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnDeleteJob = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblEdizm = new System.Windows.Forms.Label();
            this.gridReplacedPart = new System.Windows.Forms.DataGridView();
            this.replacedIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jobIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.refPartBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.replacedPartBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.replacePartTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cbxRefPart = new System.Windows.Forms.ComboBox();
            this.refPartBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.btnAddPart = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.btnDeletePart = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.refJobBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.jobBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.jobTableAdapter = new Repairs.RepairOSDSTableAdapters.JobTableAdapter();
            this.jobTableTableAdapter = new Repairs.RepairOSDSTableAdapters.JobTableTableAdapter();
            this.refJobTableAdapter = new Repairs.RepairOSDSTableAdapters.RefJobTableAdapter();
            this.refPartTableAdapter = new Repairs.RepairOSDSTableAdapters.RefPartTableAdapter();
            this.panel4 = new System.Windows.Forms.Panel();
            this.cbxRefPlace = new System.Windows.Forms.ComboBox();
            this.refPlaceBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tsPlacePart = new System.Windows.Forms.ToolStrip();
            this.tsbPlacePartAdd = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbPlasePartDell = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.placePartDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.refPlaceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.placePartBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.refPlaceTableAdapter = new Repairs.RepairOSDSTableAdapters.RefPlaceTableAdapter();
            this.tableAdapterManager = new Repairs.RepairOSDSTableAdapters.TableAdapterManager();
            this.replacedPartBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.replacedPartTableAdapter = new Repairs.RepairOSDSTableAdapters.ReplacedPartTableAdapter();
            this.replacePartTableTableAdapter = new Repairs.RepairOSDSTableAdapters.ReplacePartTableTableAdapter();
            this.placePartTableAdapter = new Repairs.RepairOSDSTableAdapters.PlacePartTableAdapter();
            label5 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            this.tsmenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridCarriages)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repairTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repairOSDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repairBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridJob)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.refJobBindingSource)).BeginInit();
            this.ts.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridReplacedPart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.refPartBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.replacedPartBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.replacePartTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.refPartBindingSource)).BeginInit();
            this.toolStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.refJobBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobBindingSource)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.refPlaceBindingSource1)).BeginInit();
            this.tsPlacePart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.placePartDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.refPlaceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.placePartBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.replacedPartBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(13, 112);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(108, 20);
            label5.TabIndex = 134;
            label5.Text = "Примечания:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(354, 10);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(134, 20);
            label4.TabIndex = 133;
            label4.Text = "Ответственный:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(12, 75);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(148, 20);
            label3.TabIndex = 132;
            label3.Text = "Причина поломки:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(12, 43);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(109, 20);
            label2.TabIndex = 131;
            label2.Text = "Тип поломки:";
            // 
            // ssmenu
            // 
            this.ssmenu.Location = new System.Drawing.Point(0, 599);
            this.ssmenu.Name = "ssmenu";
            this.ssmenu.Padding = new System.Windows.Forms.Padding(2, 0, 14, 0);
            this.ssmenu.Size = new System.Drawing.Size(1199, 22);
            this.ssmenu.TabIndex = 120;
            this.ssmenu.Text = "statusStrip1";
            // 
            // tsmenu
            // 
            this.tsmenu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tsmenu.ImageScalingSize = new System.Drawing.Size(25, 25);
            this.tsmenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnRepair,
            this.toolStripSeparator1,
            this.btnShowCarriagesInR,
            this.toolStripSeparator2});
            this.tsmenu.Location = new System.Drawing.Point(0, 0);
            this.tsmenu.Name = "tsmenu";
            this.tsmenu.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.tsmenu.Size = new System.Drawing.Size(1199, 32);
            this.tsmenu.TabIndex = 121;
            // 
            // btnRepair
            // 
            this.btnRepair.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnRepair.Image = ((System.Drawing.Image)(resources.GetObject("btnRepair.Image")));
            this.btnRepair.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRepair.Name = "btnRepair";
            this.btnRepair.Size = new System.Drawing.Size(29, 29);
            this.btnRepair.Text = "Записать данные о ремонте";
            this.btnRepair.Click += new System.EventHandler(this.btnDateEndRepair_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 32);
            // 
            // btnShowCarriagesInR
            // 
            this.btnShowCarriagesInR.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnShowCarriagesInR.Image = ((System.Drawing.Image)(resources.GetObject("btnShowCarriagesInR.Image")));
            this.btnShowCarriagesInR.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnShowCarriagesInR.Name = "btnShowCarriagesInR";
            this.btnShowCarriagesInR.Size = new System.Drawing.Size(29, 29);
            this.btnShowCarriagesInR.Text = "Просмотр отправленных в ремонт ОС";
            this.btnShowCarriagesInR.Click += new System.EventHandler(this.btnShowCarriagesInR_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 32);
            // 
            // gridCarriages
            // 
            this.gridCarriages.AllowUserToAddRows = false;
            this.gridCarriages.AllowUserToDeleteRows = false;
            this.gridCarriages.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridCarriages.AutoGenerateColumns = false;
            this.gridCarriages.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridCarriages.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.inventoryNumberDataGridViewTextBoxColumn,
            this.dateInDataGridViewTextBoxColumn,
            this.divisDataGridViewTextBoxColumn,
            this.asRDivisDataGridViewTextBoxColumn,
            this.dateOutDataGridViewTextBoxColumn,
            this.typeFlautDataGridViewTextBoxColumn,
            this.causeDataGridViewTextBoxColumn,
            this.responsibleDataGridViewTextBoxColumn,
            this.noteDataGridViewTextBoxColumn});
            this.gridCarriages.DataSource = this.repairTableBindingSource;
            this.gridCarriages.Location = new System.Drawing.Point(9, 147);
            this.gridCarriages.Name = "gridCarriages";
            this.gridCarriages.ReadOnly = true;
            this.gridCarriages.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridCarriages.Size = new System.Drawing.Size(688, 405);
            this.gridCarriages.TabIndex = 122;
            this.gridCarriages.CurrentCellChanged += new System.EventHandler(this.gridCarriages_CurrentCellChanged);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "RepairID";
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            // 
            // inventoryNumberDataGridViewTextBoxColumn
            // 
            this.inventoryNumberDataGridViewTextBoxColumn.DataPropertyName = "InventoryNumber";
            this.inventoryNumberDataGridViewTextBoxColumn.HeaderText = "Инв. №";
            this.inventoryNumberDataGridViewTextBoxColumn.Name = "inventoryNumberDataGridViewTextBoxColumn";
            this.inventoryNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateInDataGridViewTextBoxColumn
            // 
            this.dateInDataGridViewTextBoxColumn.DataPropertyName = "DateIn";
            this.dateInDataGridViewTextBoxColumn.HeaderText = "Дата отправки";
            this.dateInDataGridViewTextBoxColumn.Name = "dateInDataGridViewTextBoxColumn";
            this.dateInDataGridViewTextBoxColumn.ReadOnly = true;
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
            this.repairTableBindingSource.DataSource = this.repairOSDS;
            // 
            // repairOSDS
            // 
            this.repairOSDS.DataSetName = "RepairOSDS";
            this.repairOSDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // repairBindingSource
            // 
            this.repairBindingSource.DataMember = "Repair";
            this.repairBindingSource.DataSource = this.repairOSDS;
            // 
            // datpBeg
            // 
            this.datpBeg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.datpBeg.Location = new System.Drawing.Point(403, 5);
            this.datpBeg.Name = "datpBeg";
            this.datpBeg.Size = new System.Drawing.Size(155, 26);
            this.datpBeg.TabIndex = 0;
            this.datpBeg.ValueChanged += new System.EventHandler(this.datpBeg_ValueChanged);
            // 
            // datpEnd
            // 
            this.datpEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.datpEnd.Location = new System.Drawing.Point(621, 3);
            this.datpEnd.Name = "datpEnd";
            this.datpEnd.Size = new System.Drawing.Size(155, 26);
            this.datpEnd.TabIndex = 1;
            this.datpEnd.ValueChanged += new System.EventHandler(this.datpBeg_ValueChanged);
            // 
            // lblDateBeg
            // 
            this.lblDateBeg.AutoSize = true;
            this.lblDateBeg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDateBeg.Location = new System.Drawing.Point(373, 8);
            this.lblDateBeg.Name = "lblDateBeg";
            this.lblDateBeg.Size = new System.Drawing.Size(24, 20);
            this.lblDateBeg.TabIndex = 3;
            this.lblDateBeg.Text = "С:";
            // 
            // lblDateEnd
            // 
            this.lblDateEnd.AutoSize = true;
            this.lblDateEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDateEnd.Location = new System.Drawing.Point(588, 8);
            this.lblDateEnd.Name = "lblDateEnd";
            this.lblDateEnd.Size = new System.Drawing.Size(34, 20);
            this.lblDateEnd.TabIndex = 4;
            this.lblDateEnd.Text = "По:";
            // 
            // datpDateEndRepair
            // 
            this.datpDateEndRepair.Location = new System.Drawing.Point(214, 8);
            this.datpDateEndRepair.Name = "datpDateEndRepair";
            this.datpDateEndRepair.Size = new System.Drawing.Size(134, 26);
            this.datpDateEndRepair.TabIndex = 6;
            // 
            // repairTableAdapter
            // 
            this.repairTableAdapter.ClearBeforeFill = true;
            // 
            // repairTableTableAdapter
            // 
            this.repairTableTableAdapter.ClearBeforeFill = true;
            // 
            // txtNote
            // 
            this.txtNote.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.repairTableBindingSource, "Note", true));
            this.txtNote.Location = new System.Drawing.Point(166, 104);
            this.txtNote.Multiline = true;
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(522, 37);
            this.txtNote.TabIndex = 130;
            // 
            // txtResponsible
            // 
            this.txtResponsible.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.repairTableBindingSource, "Responsible", true));
            this.txtResponsible.Location = new System.Drawing.Point(494, 7);
            this.txtResponsible.Name = "txtResponsible";
            this.txtResponsible.Size = new System.Drawing.Size(194, 26);
            this.txtResponsible.TabIndex = 129;
            // 
            // txtCause
            // 
            this.txtCause.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.repairTableBindingSource, "Cause", true));
            this.txtCause.Location = new System.Drawing.Point(166, 72);
            this.txtCause.Name = "txtCause";
            this.txtCause.Size = new System.Drawing.Size(522, 26);
            this.txtCause.TabIndex = 128;
            // 
            // txtTypeFlaut
            // 
            this.txtTypeFlaut.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.repairTableBindingSource, "TypeFlaut", true));
            this.txtTypeFlaut.Location = new System.Drawing.Point(166, 40);
            this.txtTypeFlaut.Name = "txtTypeFlaut";
            this.txtTypeFlaut.Size = new System.Drawing.Size(522, 26);
            this.txtTypeFlaut.TabIndex = 127;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.datpDateEndRepair);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(label5);
            this.panel1.Controls.Add(label4);
            this.panel1.Controls.Add(label3);
            this.panel1.Controls.Add(label2);
            this.panel1.Controls.Add(this.txtNote);
            this.panel1.Controls.Add(this.txtResponsible);
            this.panel1.Controls.Add(this.txtCause);
            this.panel1.Controls.Add(this.txtTypeFlaut);
            this.panel1.Controls.Add(this.gridCarriages);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel1.Location = new System.Drawing.Point(0, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(708, 564);
            this.panel1.TabIndex = 135;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(201, 20);
            this.label6.TabIndex = 135;
            this.label6.Text = "Дата окончания ремонта";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.gridJob);
            this.panel2.Controls.Add(this.cbxRefJob);
            this.panel2.Controls.Add(this.ts);
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel2.Location = new System.Drawing.Point(702, 35);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(483, 179);
            this.panel2.TabIndex = 136;
            // 
            // gridJob
            // 
            this.gridJob.AllowUserToAddRows = false;
            this.gridJob.AutoGenerateColumns = false;
            this.gridJob.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridJob.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewCheckBoxColumn1});
            this.gridJob.DataSource = this.jobTableBindingSource;
            this.gridJob.Location = new System.Drawing.Point(0, 25);
            this.gridJob.Name = "gridJob";
            this.gridJob.ReadOnly = true;
            this.gridJob.Size = new System.Drawing.Size(379, 154);
            this.gridJob.TabIndex = 0;
            this.gridJob.CurrentCellChanged += new System.EventHandler(this.gridJob_CurrentCellChanged);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "JobId";
            this.dataGridViewTextBoxColumn1.HeaderText = "JobId";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "RepairId";
            this.dataGridViewTextBoxColumn2.HeaderText = "RepairId";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Visible = false;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "JobCode";
            this.dataGridViewTextBoxColumn3.HeaderText = "JobCode";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Visible = false;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "JobName";
            this.dataGridViewTextBoxColumn4.HeaderText = "Выполненые работы";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "T_Inspect";
            this.dataGridViewCheckBoxColumn1.HeaderText = "Плановые";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.ReadOnly = true;
            // 
            // jobTableBindingSource
            // 
            this.jobTableBindingSource.DataMember = "JobTable";
            this.jobTableBindingSource.DataSource = this.repairOSDS;
            // 
            // cbxRefJob
            // 
            this.cbxRefJob.DataSource = this.refJobBindingSource;
            this.cbxRefJob.DisplayMember = "JobName";
            this.cbxRefJob.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbxRefJob.FormattingEnabled = true;
            this.cbxRefJob.Location = new System.Drawing.Point(73, 6);
            this.cbxRefJob.Name = "cbxRefJob";
            this.cbxRefJob.Size = new System.Drawing.Size(406, 24);
            this.cbxRefJob.TabIndex = 9;
            this.cbxRefJob.ValueMember = "JobCode";
            // 
            // refJobBindingSource
            // 
            this.refJobBindingSource.DataMember = "RefJob";
            this.refJobBindingSource.DataSource = this.repairOSDS;
            // 
            // ts
            // 
            this.ts.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAddJob,
            this.toolStripSeparator3,
            this.btnDeleteJob,
            this.toolStripSeparator4});
            this.ts.Location = new System.Drawing.Point(0, 0);
            this.ts.Name = "ts";
            this.ts.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.ts.Size = new System.Drawing.Size(483, 25);
            this.ts.TabIndex = 7;
            // 
            // btnAddJob
            // 
            this.btnAddJob.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAddJob.Image = ((System.Drawing.Image)(resources.GetObject("btnAddJob.Image")));
            this.btnAddJob.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAddJob.Name = "btnAddJob";
            this.btnAddJob.Size = new System.Drawing.Size(23, 22);
            this.btnAddJob.Text = "Добавить работу";
            this.btnAddJob.Click += new System.EventHandler(this.btnAddJob_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // btnDeleteJob
            // 
            this.btnDeleteJob.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnDeleteJob.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteJob.Image")));
            this.btnDeleteJob.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDeleteJob.Name = "btnDeleteJob";
            this.btnDeleteJob.Size = new System.Drawing.Size(23, 22);
            this.btnDeleteJob.Text = "Удалить выбранную работу";
            this.btnDeleteJob.Click += new System.EventHandler(this.btnDeleteJob_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(84, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 20);
            this.label1.TabIndex = 137;
            this.label1.Text = "Поиск по дате сдачи в ремонт";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lblEdizm);
            this.panel3.Controls.Add(this.gridReplacedPart);
            this.panel3.Controls.Add(this.textBox1);
            this.panel3.Controls.Add(this.cbxRefPart);
            this.panel3.Controls.Add(this.toolStrip2);
            this.panel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel3.Location = new System.Drawing.Point(705, 217);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(483, 190);
            this.panel3.TabIndex = 137;
            // 
            // lblEdizm
            // 
            this.lblEdizm.AutoSize = true;
            this.lblEdizm.Location = new System.Drawing.Point(422, 2);
            this.lblEdizm.Name = "lblEdizm";
            this.lblEdizm.Size = new System.Drawing.Size(65, 20);
            this.lblEdizm.TabIndex = 14;
            this.lblEdizm.Text = "ед.изм.";
            // 
            // gridReplacedPart
            // 
            this.gridReplacedPart.AllowUserToAddRows = false;
            this.gridReplacedPart.AutoGenerateColumns = false;
            this.gridReplacedPart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridReplacedPart.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.replacedIdDataGridViewTextBoxColumn,
            this.jobIdDataGridViewTextBoxColumn,
            this.partIdDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn});
            this.gridReplacedPart.DataSource = this.replacedPartBindingSource1;
            this.gridReplacedPart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridReplacedPart.Location = new System.Drawing.Point(0, 25);
            this.gridReplacedPart.Name = "gridReplacedPart";
            this.gridReplacedPart.ReadOnly = true;
            this.gridReplacedPart.Size = new System.Drawing.Size(483, 165);
            this.gridReplacedPart.TabIndex = 13;
            this.gridReplacedPart.CurrentCellChanged += new System.EventHandler(this.gridReplacedPart_CurrentCellChanged);
            // 
            // replacedIdDataGridViewTextBoxColumn
            // 
            this.replacedIdDataGridViewTextBoxColumn.DataPropertyName = "ReplacedId";
            this.replacedIdDataGridViewTextBoxColumn.HeaderText = "ReplacedId";
            this.replacedIdDataGridViewTextBoxColumn.Name = "replacedIdDataGridViewTextBoxColumn";
            this.replacedIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.replacedIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // jobIdDataGridViewTextBoxColumn
            // 
            this.jobIdDataGridViewTextBoxColumn.DataPropertyName = "JobId";
            this.jobIdDataGridViewTextBoxColumn.HeaderText = "Выполненая работа";
            this.jobIdDataGridViewTextBoxColumn.Name = "jobIdDataGridViewTextBoxColumn";
            this.jobIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.jobIdDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.jobIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // partIdDataGridViewTextBoxColumn
            // 
            this.partIdDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.partIdDataGridViewTextBoxColumn.DataPropertyName = "PartId";
            this.partIdDataGridViewTextBoxColumn.DataSource = this.refPartBindingSource1;
            this.partIdDataGridViewTextBoxColumn.DisplayMember = "PartName";
            this.partIdDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.partIdDataGridViewTextBoxColumn.HeaderText = "Запчасть заменяемая (списание)";
            this.partIdDataGridViewTextBoxColumn.Name = "partIdDataGridViewTextBoxColumn";
            this.partIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.partIdDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.partIdDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.partIdDataGridViewTextBoxColumn.ValueMember = "PartId";
            // 
            // refPartBindingSource1
            // 
            this.refPartBindingSource1.DataMember = "RefPart";
            this.refPartBindingSource1.DataSource = this.repairOSDS;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Кол-во";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            this.quantityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // replacedPartBindingSource1
            // 
            this.replacedPartBindingSource1.DataMember = "ReplacedPart";
            this.replacedPartBindingSource1.DataSource = this.replacePartTableBindingSource;
            // 
            // replacePartTableBindingSource
            // 
            this.replacePartTableBindingSource.DataSource = this.repairOSDS;
            this.replacePartTableBindingSource.Position = 0;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(382, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(34, 22);
            this.textBox1.TabIndex = 12;
            this.textBox1.Text = "1";
            // 
            // cbxRefPart
            // 
            this.cbxRefPart.DataSource = this.refPartBindingSource;
            this.cbxRefPart.DisplayMember = "PartName";
            this.cbxRefPart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbxRefPart.FormattingEnabled = true;
            this.cbxRefPart.Location = new System.Drawing.Point(71, 2);
            this.cbxRefPart.Name = "cbxRefPart";
            this.cbxRefPart.Size = new System.Drawing.Size(305, 24);
            this.cbxRefPart.TabIndex = 11;
            this.cbxRefPart.ValueMember = "PartId";
            this.cbxRefPart.DropDown += new System.EventHandler(this.cbxRefPart_DropDown);
            this.cbxRefPart.SelectedIndexChanged += new System.EventHandler(this.cbxRefPart_SelectedIndexChanged);
            this.cbxRefPart.TextUpdate += new System.EventHandler(this.cbxRefPart_TextUpdate);
            this.cbxRefPart.TextChanged += new System.EventHandler(this.cbxRefPart_TextChanged);
            this.cbxRefPart.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbxRefPart_KeyDown);
            this.cbxRefPart.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbxRefPart_KeyPress);
            this.cbxRefPart.KeyUp += new System.Windows.Forms.KeyEventHandler(this.cbxRefPart_KeyUp);
            // 
            // refPartBindingSource
            // 
            this.refPartBindingSource.DataMember = "RefPart";
            this.refPartBindingSource.DataSource = this.repairOSDS;
            // 
            // toolStrip2
            // 
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAddPart,
            this.toolStripSeparator5,
            this.btnDeletePart,
            this.toolStripSeparator6});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStrip2.Size = new System.Drawing.Size(483, 25);
            this.toolStrip2.TabIndex = 10;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // btnAddPart
            // 
            this.btnAddPart.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAddPart.Image = ((System.Drawing.Image)(resources.GetObject("btnAddPart.Image")));
            this.btnAddPart.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAddPart.Name = "btnAddPart";
            this.btnAddPart.Size = new System.Drawing.Size(23, 22);
            this.btnAddPart.Text = "Добавить деталь";
            this.btnAddPart.Click += new System.EventHandler(this.btnAddPart_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // btnDeletePart
            // 
            this.btnDeletePart.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnDeletePart.Image = ((System.Drawing.Image)(resources.GetObject("btnDeletePart.Image")));
            this.btnDeletePart.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDeletePart.Name = "btnDeletePart";
            this.btnDeletePart.Size = new System.Drawing.Size(23, 22);
            this.btnDeletePart.Text = "Удалить выбранную деталь";
            this.btnDeletePart.Click += new System.EventHandler(this.btnDeletePart_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 25);
            // 
            // refJobBindingSource1
            // 
            this.refJobBindingSource1.DataMember = "RefJob";
            this.refJobBindingSource1.DataSource = this.repairOSDS;
            // 
            // jobBindingSource
            // 
            this.jobBindingSource.DataMember = "Job";
            this.jobBindingSource.DataSource = this.repairOSDS;
            // 
            // jobTableAdapter
            // 
            this.jobTableAdapter.ClearBeforeFill = true;
            // 
            // jobTableTableAdapter
            // 
            this.jobTableTableAdapter.ClearBeforeFill = true;
            // 
            // refJobTableAdapter
            // 
            this.refJobTableAdapter.ClearBeforeFill = true;
            // 
            // refPartTableAdapter
            // 
            this.refPartTableAdapter.ClearBeforeFill = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.cbxRefPlace);
            this.panel4.Controls.Add(this.tsPlacePart);
            this.panel4.Controls.Add(this.placePartDataGridView);
            this.panel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel4.Location = new System.Drawing.Point(704, 414);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(484, 177);
            this.panel4.TabIndex = 138;
            // 
            // cbxRefPlace
            // 
            this.cbxRefPlace.DataSource = this.refPlaceBindingSource1;
            this.cbxRefPlace.DisplayMember = "PlaceName";
            this.cbxRefPlace.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbxRefPlace.FormattingEnabled = true;
            this.cbxRefPlace.Location = new System.Drawing.Point(72, 2);
            this.cbxRefPlace.Name = "cbxRefPlace";
            this.cbxRefPlace.Size = new System.Drawing.Size(405, 24);
            this.cbxRefPlace.TabIndex = 12;
            this.cbxRefPlace.ValueMember = "PlaceCode";
            // 
            // refPlaceBindingSource1
            // 
            this.refPlaceBindingSource1.DataMember = "RefPlace";
            this.refPlaceBindingSource1.DataSource = this.repairOSDS;
            // 
            // tsPlacePart
            // 
            this.tsPlacePart.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbPlacePartAdd,
            this.toolStripSeparator7,
            this.tsbPlasePartDell,
            this.toolStripSeparator8});
            this.tsPlacePart.Location = new System.Drawing.Point(0, 0);
            this.tsPlacePart.Name = "tsPlacePart";
            this.tsPlacePart.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.tsPlacePart.Size = new System.Drawing.Size(484, 25);
            this.tsPlacePart.TabIndex = 11;
            this.tsPlacePart.Text = "toolStrip1";
            // 
            // tsbPlacePartAdd
            // 
            this.tsbPlacePartAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbPlacePartAdd.Image = ((System.Drawing.Image)(resources.GetObject("tsbPlacePartAdd.Image")));
            this.tsbPlacePartAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbPlacePartAdd.Name = "tsbPlacePartAdd";
            this.tsbPlacePartAdd.Size = new System.Drawing.Size(23, 22);
            this.tsbPlacePartAdd.Text = "Добавить деталь";
            this.tsbPlacePartAdd.Click += new System.EventHandler(this.tsbPlacePartAdd_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbPlasePartDell
            // 
            this.tsbPlasePartDell.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbPlasePartDell.Image = ((System.Drawing.Image)(resources.GetObject("tsbPlasePartDell.Image")));
            this.tsbPlasePartDell.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbPlasePartDell.Name = "tsbPlasePartDell";
            this.tsbPlasePartDell.Size = new System.Drawing.Size(23, 22);
            this.tsbPlasePartDell.Text = "Удалить выбранную деталь";
            this.tsbPlasePartDell.Click += new System.EventHandler(this.tsbPlasePartDell_Click);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(6, 25);
            // 
            // placePartDataGridView
            // 
            this.placePartDataGridView.AllowUserToAddRows = false;
            this.placePartDataGridView.AutoGenerateColumns = false;
            this.placePartDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.placePartDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.Id});
            this.placePartDataGridView.DataSource = this.placePartBindingSource;
            this.placePartDataGridView.Location = new System.Drawing.Point(2, 28);
            this.placePartDataGridView.Name = "placePartDataGridView";
            this.placePartDataGridView.Size = new System.Drawing.Size(483, 149);
            this.placePartDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn10.DataPropertyName = "PlaceCode";
            this.dataGridViewTextBoxColumn10.DataSource = this.refPlaceBindingSource;
            this.dataGridViewTextBoxColumn10.DisplayMember = "PlaceName";
            this.dataGridViewTextBoxColumn10.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.dataGridViewTextBoxColumn10.HeaderText = "Место установки";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn10.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn10.ValueMember = "PlaceCode";
            // 
            // refPlaceBindingSource
            // 
            this.refPlaceBindingSource.DataMember = "RefPlace";
            this.refPlaceBindingSource.DataSource = this.repairOSDS;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "ReplacedId";
            this.dataGridViewTextBoxColumn11.HeaderText = "ReplacedId";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.Visible = false;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn12.DataPropertyName = "PartId";
            this.dataGridViewTextBoxColumn12.DataSource = this.refPartBindingSource1;
            this.dataGridViewTextBoxColumn12.DisplayMember = "PartName";
            this.dataGridViewTextBoxColumn12.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.dataGridViewTextBoxColumn12.HeaderText = "Запчасть";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn12.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn12.ValueMember = "PartId";
            this.dataGridViewTextBoxColumn12.Visible = false;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // placePartBindingSource
            // 
            this.placePartBindingSource.DataMember = "PlacePart";
            this.placePartBindingSource.DataSource = this.repairOSDS;
            // 
            // refPlaceTableAdapter
            // 
            this.refPlaceTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Branch_1TableAdapter = null;
            this.tableAdapterManager.BranchTableAdapter = null;
            this.tableAdapterManager.Hatch1TableAdapter = null;
            this.tableAdapterManager.HatchTableAdapter = null;
            this.tableAdapterManager.HorizontTableAdapter = null;
            this.tableAdapterManager.InspectNormTableAdapter = null;
            this.tableAdapterManager.JobTableAdapter = this.jobTableAdapter;
            this.tableAdapterManager.PlacePartTableAdapter = null;
            this.tableAdapterManager.PlanJobTableAdapter = null;
            this.tableAdapterManager.PlotTableAdapter = null;
            this.tableAdapterManager.RefJobTableAdapter = this.refJobTableAdapter;
            this.tableAdapterManager.RefPartTableAdapter = this.refPartTableAdapter;
            this.tableAdapterManager.RefPlaceTableAdapter = null;
            this.tableAdapterManager.RepairTableAdapter = this.repairTableAdapter;
            this.tableAdapterManager.ReplacedPartTableAdapter = null;
            this.tableAdapterManager.Shtrek1TableAdapter = null;
            this.tableAdapterManager.ShtrekTableAdapter = null;
            this.tableAdapterManager.sprDivisionTableAdapter = null;
            this.tableAdapterManager.SprOSGroupTableAdapter = null;
            this.tableAdapterManager.SprOSTableAdapter = null;
            this.tableAdapterManager.sprRepairDivisionTableAdapter = null;
            this.tableAdapterManager.SprUserTableAdapter = null;
            this.tableAdapterManager.StatusBranchTableAdapter = null;
            this.tableAdapterManager.StoreTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Repairs.RepairOSDSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Users_listTableAdapter = null;
            this.tableAdapterManager.WorkOSTableAdapter = null;
            // 
            // replacedPartBindingSource
            // 
            this.replacedPartBindingSource.DataMember = "ReplacedPart";
            this.replacedPartBindingSource.DataSource = this.repairOSDS;
            // 
            // replacedPartTableAdapter
            // 
            this.replacedPartTableAdapter.ClearBeforeFill = true;
            // 
            // replacePartTableTableAdapter
            // 
            this.replacePartTableTableAdapter.ClearBeforeFill = true;
            // 
            // placePartTableAdapter
            // 
            this.placePartTableAdapter.ClearBeforeFill = true;
            // 
            // frmCarriagesRepair
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1199, 621);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.datpBeg);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.datpEnd);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblDateBeg);
            this.Controls.Add(this.lblDateEnd);
            this.Controls.Add(this.ssmenu);
            this.Controls.Add(this.tsmenu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "frmCarriagesRepair";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ремонты";
            this.Load += new System.EventHandler(this.frmCarriagesRepair_Load);
            this.tsmenu.ResumeLayout(false);
            this.tsmenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridCarriages)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repairTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repairOSDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repairBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridJob)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.refJobBindingSource)).EndInit();
            this.ts.ResumeLayout(false);
            this.ts.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridReplacedPart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.refPartBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.replacedPartBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.replacePartTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.refPartBindingSource)).EndInit();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.refJobBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobBindingSource)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.refPlaceBindingSource1)).EndInit();
            this.tsPlacePart.ResumeLayout(false);
            this.tsPlacePart.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.placePartDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.refPlaceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.placePartBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.replacedPartBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip ssmenu;
        private System.Windows.Forms.ToolStrip tsmenu;
        private System.Windows.Forms.ToolStripButton btnRepair;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnShowCarriagesInR;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.DataGridView gridCarriages;
        private System.Windows.Forms.DateTimePicker datpBeg;
        private System.Windows.Forms.DateTimePicker datpEnd;
        private System.Windows.Forms.Label lblDateBeg;
        private System.Windows.Forms.Label lblDateEnd;
        private System.Windows.Forms.DateTimePicker datpDateEndRepair;
        private RepairOSDS repairOSDS;
        private System.Windows.Forms.BindingSource repairBindingSource;
        private RepairOSDSTableAdapters.RepairTableAdapter repairTableAdapter;
        private System.Windows.Forms.BindingSource repairTableBindingSource;
        private RepairOSDSTableAdapters.RepairTableTableAdapter repairTableTableAdapter;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.TextBox txtResponsible;
        private System.Windows.Forms.TextBox txtCause;
        private System.Windows.Forms.TextBox txtTypeFlaut;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox cbxRefJob;
        private System.Windows.Forms.ToolStrip ts;
        private System.Windows.Forms.ToolStripButton btnAddJob;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton btnDeleteJob;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.BindingSource jobBindingSource;
        private RepairOSDSTableAdapters.JobTableAdapter jobTableAdapter;
        private System.Windows.Forms.BindingSource jobTableBindingSource;
        private System.Windows.Forms.DataGridView gridJob;
        private RepairOSDSTableAdapters.JobTableTableAdapter jobTableTableAdapter;
        private RepairOSDSTableAdapters.RefJobTableAdapter refJobTableAdapter;
        private System.Windows.Forms.BindingSource refJobBindingSource;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox cbxRefPart;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton btnAddPart;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton btnDeletePart;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private RepairOSDSTableAdapters.RefPartTableAdapter refPartTableAdapter;
        private System.Windows.Forms.BindingSource refPartBindingSource;
        private System.Windows.Forms.DataGridView gridReplacedPart;
//        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn inventoryNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateInDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn divisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn asRDivisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOutDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeFlautDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn causeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn responsibleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ToolStrip tsPlacePart;
        private System.Windows.Forms.ToolStripButton tsbPlacePartAdd;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripButton tsbPlasePartDell;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.DataGridView placePartDataGridView;
        private System.Windows.Forms.BindingSource refPlaceBindingSource;
        private RepairOSDSTableAdapters.RefPlaceTableAdapter refPlaceTableAdapter;
        private System.Windows.Forms.BindingSource refPartBindingSource1;
        private RepairOSDSTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource replacedPartBindingSource;
        private RepairOSDSTableAdapters.ReplacedPartTableAdapter replacedPartTableAdapter;
        private System.Windows.Forms.BindingSource replacePartTableBindingSource;
        private RepairOSDSTableAdapters.ReplacePartTableTableAdapter replacePartTableTableAdapter;
        private System.Windows.Forms.BindingSource replacedPartBindingSource1;
        private System.Windows.Forms.BindingSource refJobBindingSource1;
        private System.Windows.Forms.ComboBox cbxRefPlace;
        private System.Windows.Forms.BindingSource refPlaceBindingSource1;
        private System.Windows.Forms.BindingSource placePartBindingSource;
        private RepairOSDSTableAdapters.PlacePartTableAdapter placePartTableAdapter;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblEdizm;
        private System.Windows.Forms.DataGridViewTextBoxColumn replacedIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jobIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn partIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
    }
}