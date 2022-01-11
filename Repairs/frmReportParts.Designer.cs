namespace Repairs
{
    partial class frmReportParts
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.partsReportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.repairOSDS = new Repairs.RepairOSDS();
            this.rpvParts = new Microsoft.Reporting.WinForms.ReportViewer();
            this.pnl = new System.Windows.Forms.Panel();
            this.chbId = new System.Windows.Forms.CheckBox();
            this.chkbStore = new System.Windows.Forms.CheckBox();
            this.cbxStore = new System.Windows.Forms.ComboBox();
            this.storeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.grid = new System.Windows.Forms.DataGridView();
            this.refPartBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.datpEnd = new System.Windows.Forms.DateTimePicker();
            this.datpBeg = new System.Windows.Forms.DateTimePicker();
            this.refPartTableAdapter = new Repairs.RepairOSDSTableAdapters.RefPartTableAdapter();
            this.storeTableAdapter = new Repairs.RepairOSDSTableAdapters.StoreTableAdapter();
            this.partsReportTableAdapter = new Repairs.RepairOSDSTableAdapters.PartsReportTableAdapter();
            this.tableAdapterManager = new Repairs.RepairOSDSTableAdapters.TableAdapterManager();
            this.partIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.partsReportBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repairOSDS)).BeginInit();
            this.pnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.storeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.refPartBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // partsReportBindingSource
            // 
            this.partsReportBindingSource.DataMember = "PartsReport";
            this.partsReportBindingSource.DataSource = this.repairOSDS;
            // 
            // repairOSDS
            // 
            this.repairOSDS.DataSetName = "RepairOSDS";
            this.repairOSDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rpvParts
            // 
            this.rpvParts.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.partsReportBindingSource;
            this.rpvParts.LocalReport.DataSources.Add(reportDataSource1);
            this.rpvParts.LocalReport.ReportEmbeddedResource = "Repairs.Report4.rdlc";
            this.rpvParts.Location = new System.Drawing.Point(0, 0);
            this.rpvParts.Name = "rpvParts";
            this.rpvParts.Size = new System.Drawing.Size(989, 620);
            this.rpvParts.TabIndex = 8;
            this.rpvParts.Load += new System.EventHandler(this.rpvParts_Load);
            // 
            // pnl
            // 
            this.pnl.Controls.Add(this.chbId);
            this.pnl.Controls.Add(this.chkbStore);
            this.pnl.Controls.Add(this.cbxStore);
            this.pnl.Controls.Add(this.grid);
            this.pnl.Controls.Add(this.button1);
            this.pnl.Controls.Add(this.textBox1);
            this.pnl.Controls.Add(this.datpEnd);
            this.pnl.Controls.Add(this.datpBeg);
            this.pnl.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pnl.Location = new System.Drawing.Point(989, 0);
            this.pnl.Name = "pnl";
            this.pnl.Size = new System.Drawing.Size(281, 620);
            this.pnl.TabIndex = 7;
            // 
            // chbId
            // 
            this.chbId.AutoSize = true;
            this.chbId.Location = new System.Drawing.Point(16, 12);
            this.chbId.Name = "chbId";
            this.chbId.Size = new System.Drawing.Size(150, 24);
            this.chbId.TabIndex = 13;
            this.chbId.Text = "Поиск по инв. №";
            this.chbId.UseVisualStyleBackColor = true;
            this.chbId.CheckedChanged += new System.EventHandler(this.chbId_CheckedChanged);
            // 
            // chkbStore
            // 
            this.chkbStore.AutoSize = true;
            this.chkbStore.Location = new System.Drawing.Point(16, 43);
            this.chkbStore.Name = "chkbStore";
            this.chkbStore.Size = new System.Drawing.Size(56, 24);
            this.chkbStore.TabIndex = 12;
            this.chkbStore.Text = "Цех";
            this.chkbStore.UseVisualStyleBackColor = true;
            this.chkbStore.CheckedChanged += new System.EventHandler(this.chkbStore_CheckedChanged);
            // 
            // cbxStore
            // 
            this.cbxStore.DataSource = this.storeBindingSource;
            this.cbxStore.DisplayMember = "StoreName";
            this.cbxStore.Enabled = false;
            this.cbxStore.FormattingEnabled = true;
            this.cbxStore.Location = new System.Drawing.Point(78, 39);
            this.cbxStore.Name = "cbxStore";
            this.cbxStore.Size = new System.Drawing.Size(191, 28);
            this.cbxStore.TabIndex = 11;
            this.cbxStore.ValueMember = "StoreID";
            // 
            // storeBindingSource
            // 
            this.storeBindingSource.DataMember = "Store";
            this.storeBindingSource.DataSource = this.repairOSDS;
            // 
            // grid
            // 
            this.grid.AllowUserToAddRows = false;
            this.grid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.grid.AutoGenerateColumns = false;
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.partIdDataGridViewTextBoxColumn,
            this.partNameDataGridViewTextBoxColumn});
            this.grid.DataSource = this.refPartBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid.DefaultCellStyle = dataGridViewCellStyle2;
            this.grid.Location = new System.Drawing.Point(6, 137);
            this.grid.Name = "grid";
            this.grid.ReadOnly = true;
            this.grid.RowHeadersVisible = false;
            this.grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid.Size = new System.Drawing.Size(272, 434);
            this.grid.TabIndex = 10;
            // 
            // refPartBindingSource
            // 
            this.refPartBindingSource.DataMember = "RefPart";
            this.refPartBindingSource.DataSource = this.repairOSDS;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(64, 577);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(161, 31);
            this.button1.TabIndex = 9;
            this.button1.Text = "Сформировать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.frmReportParts_Load);
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(172, 10);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(97, 26);
            this.textBox1.TabIndex = 6;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // datpEnd
            // 
            this.datpEnd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.datpEnd.Location = new System.Drawing.Point(52, 105);
            this.datpEnd.Name = "datpEnd";
            this.datpEnd.Size = new System.Drawing.Size(173, 26);
            this.datpEnd.TabIndex = 3;
            // 
            // datpBeg
            // 
            this.datpBeg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.datpBeg.Location = new System.Drawing.Point(52, 73);
            this.datpBeg.Name = "datpBeg";
            this.datpBeg.Size = new System.Drawing.Size(173, 26);
            this.datpBeg.TabIndex = 1;
            // 
            // refPartTableAdapter
            // 
            this.refPartTableAdapter.ClearBeforeFill = true;
            // 
            // storeTableAdapter
            // 
            this.storeTableAdapter.ClearBeforeFill = true;
            // 
            // partsReportTableAdapter
            // 
            this.partsReportTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.InspectNormTableAdapter = null;
            this.tableAdapterManager.JobTableAdapter = null;
            this.tableAdapterManager.PlacePartTableAdapter = null;
            this.tableAdapterManager.PlanJobTableAdapter = null;
            this.tableAdapterManager.PlotTableAdapter = null;
            this.tableAdapterManager.RefJobTableAdapter = null;
            this.tableAdapterManager.RefPartTableAdapter = this.refPartTableAdapter;
            this.tableAdapterManager.RefPlaceTableAdapter = null;
            this.tableAdapterManager.RepairTableAdapter = null;
            this.tableAdapterManager.ReplacedPartTableAdapter = null;
            this.tableAdapterManager.sprDivisionTableAdapter = null;
            this.tableAdapterManager.SprOSGroupTableAdapter = null;
            this.tableAdapterManager.SprOSTableAdapter = null;
            this.tableAdapterManager.sprRepairDivisionTableAdapter = null;
            this.tableAdapterManager.SprUserTableAdapter = null;
            this.tableAdapterManager.StoreTableAdapter = this.storeTableAdapter;
            this.tableAdapterManager.UpdateOrder = Repairs.RepairOSDSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Users_listTableAdapter = null;
            this.tableAdapterManager.WorkOSTableAdapter = null;
            // 
            // partIdDataGridViewTextBoxColumn
            // 
            this.partIdDataGridViewTextBoxColumn.DataPropertyName = "PartId";
            this.partIdDataGridViewTextBoxColumn.HeaderText = "Инд. №";
            this.partIdDataGridViewTextBoxColumn.Name = "partIdDataGridViewTextBoxColumn";
            this.partIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.partIdDataGridViewTextBoxColumn.Width = 60;
            // 
            // partNameDataGridViewTextBoxColumn
            // 
            this.partNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.partNameDataGridViewTextBoxColumn.DataPropertyName = "PartName";
            this.partNameDataGridViewTextBoxColumn.HeaderText = "Наименование";
            this.partNameDataGridViewTextBoxColumn.Name = "partNameDataGridViewTextBoxColumn";
            this.partNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // frmReportParts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1270, 620);
            this.Controls.Add(this.rpvParts);
            this.Controls.Add(this.pnl);
            this.Name = "frmReportParts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Отчет по запчастям";
            this.Load += new System.EventHandler(this.frmReportParts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.partsReportBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repairOSDS)).EndInit();
            this.pnl.ResumeLayout(false);
            this.pnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.storeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.refPartBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpvParts;
        private System.Windows.Forms.Panel pnl;
        private System.Windows.Forms.DataGridView grid;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DateTimePicker datpEnd;
        private System.Windows.Forms.DateTimePicker datpBeg;
        private System.Windows.Forms.CheckBox chbId;
        private System.Windows.Forms.CheckBox chkbStore;
        private System.Windows.Forms.ComboBox cbxStore;
        private RepairOSDS repairOSDS;
        private System.Windows.Forms.BindingSource refPartBindingSource;
        private RepairOSDSTableAdapters.RefPartTableAdapter refPartTableAdapter;
        private System.Windows.Forms.BindingSource storeBindingSource;
        private RepairOSDSTableAdapters.StoreTableAdapter storeTableAdapter;
        private System.Windows.Forms.BindingSource partsReportBindingSource;
        private RepairOSDSTableAdapters.PartsReportTableAdapter partsReportTableAdapter;
        private RepairOSDSTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridViewTextBoxColumn partIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn partNameDataGridViewTextBoxColumn;
    }
}