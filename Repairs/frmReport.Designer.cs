namespace Repairs
{
    partial class frmReport
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.repairTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.repairOSDS = new Repairs.RepairOSDS();
            this.reportWorkOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pnl = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.rbtnReportIn = new System.Windows.Forms.RadioButton();
            this.datpBeg = new System.Windows.Forms.DateTimePicker();
            this.rbtnInvNum = new System.Windows.Forms.RadioButton();
            this.rbtnReportOut = new System.Windows.Forms.RadioButton();
            this.datpEnd = new System.Windows.Forms.DateTimePicker();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.grid = new System.Windows.Forms.DataGridView();
            this.inventoryNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Obekt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sprOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rpvRepair = new Microsoft.Reporting.WinForms.ReportViewer();
            this.rpvAgr = new Microsoft.Reporting.WinForms.ReportViewer();
            this.rpvWorkOS = new Microsoft.Reporting.WinForms.ReportViewer();
            this.workOSTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.repairTableTableAdapter = new Repairs.RepairOSDSTableAdapters.RepairTableTableAdapter();
            this.tableAdapterManager = new Repairs.RepairOSDSTableAdapters.TableAdapterManager();
            this.workOSTableTableAdapter = new Repairs.RepairOSDSTableAdapters.WorkOSTableTableAdapter();
            this.agrJornalReportTableAdapter = new Repairs.RepairOSDSTableAdapters.AgrJornalReportTableAdapter();
            this.sprOSTableAdapter = new Repairs.RepairOSDSTableAdapters.SprOSTableAdapter();
            this.reportWorkOSTableAdapter = new Repairs.RepairOSDSTableAdapters.ReportWorkOSTableAdapter();
            this.AgrJornalReportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.repairTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repairOSDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportWorkOSBindingSource)).BeginInit();
            this.pnl.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sprOSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workOSTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AgrJornalReportBindingSource)).BeginInit();
            this.SuspendLayout();
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
            // reportWorkOSBindingSource
            // 
            this.reportWorkOSBindingSource.DataMember = "ReportWorkOS";
            this.reportWorkOSBindingSource.DataSource = this.repairOSDS;
            // 
            // pnl
            // 
            this.pnl.Controls.Add(this.panel2);
            this.pnl.Controls.Add(this.panel1);
            this.pnl.Controls.Add(this.grid);
            this.pnl.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pnl.Location = new System.Drawing.Point(858, 0);
            this.pnl.Name = "pnl";
            this.pnl.Size = new System.Drawing.Size(266, 737);
            this.pnl.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.checkBox1);
            this.panel2.Controls.Add(this.rbtnReportIn);
            this.panel2.Controls.Add(this.datpBeg);
            this.panel2.Controls.Add(this.rbtnInvNum);
            this.panel2.Controls.Add(this.rbtnReportOut);
            this.panel2.Controls.Add(this.datpEnd);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(266, 187);
            this.panel2.TabIndex = 16;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(76, 40);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(166, 20);
            this.checkBox1.TabIndex = 14;
            this.checkBox1.Text = "Отбор оборудования";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // rbtnReportIn
            // 
            this.rbtnReportIn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rbtnReportIn.AutoSize = true;
            this.rbtnReportIn.Location = new System.Drawing.Point(28, 90);
            this.rbtnReportIn.Name = "rbtnReportIn";
            this.rbtnReportIn.Size = new System.Drawing.Size(216, 20);
            this.rbtnReportIn.TabIndex = 2;
            this.rbtnReportIn.Text = "В ремонте на заданную дату\r\n";
            this.rbtnReportIn.UseVisualStyleBackColor = true;
            this.rbtnReportIn.CheckedChanged += new System.EventHandler(this.frmReport_Load);
            // 
            // datpBeg
            // 
            this.datpBeg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.datpBeg.Location = new System.Drawing.Point(77, 116);
            this.datpBeg.Name = "datpBeg";
            this.datpBeg.Size = new System.Drawing.Size(147, 22);
            this.datpBeg.TabIndex = 1;
            this.datpBeg.ValueChanged += new System.EventHandler(this.frmReport_Load);
            // 
            // rbtnInvNum
            // 
            this.rbtnInvNum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rbtnInvNum.AutoSize = true;
            this.rbtnInvNum.Location = new System.Drawing.Point(28, 13);
            this.rbtnInvNum.Name = "rbtnInvNum";
            this.rbtnInvNum.Size = new System.Drawing.Size(91, 20);
            this.rbtnInvNum.TabIndex = 11;
            this.rbtnInvNum.Text = "По инв. №";
            this.rbtnInvNum.UseVisualStyleBackColor = true;
            this.rbtnInvNum.CheckedChanged += new System.EventHandler(this.rbtnInvNum_CheckedChanged);
            // 
            // rbtnReportOut
            // 
            this.rbtnReportOut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rbtnReportOut.AutoSize = true;
            this.rbtnReportOut.Checked = true;
            this.rbtnReportOut.Location = new System.Drawing.Point(28, 64);
            this.rbtnReportOut.Name = "rbtnReportOut";
            this.rbtnReportOut.Size = new System.Drawing.Size(232, 20);
            this.rbtnReportOut.TabIndex = 4;
            this.rbtnReportOut.TabStop = true;
            this.rbtnReportOut.Text = "Отремонтированных за период";
            this.rbtnReportOut.UseVisualStyleBackColor = true;
            this.rbtnReportOut.CheckedChanged += new System.EventHandler(this.frmReport_Load);
            // 
            // datpEnd
            // 
            this.datpEnd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.datpEnd.Location = new System.Drawing.Point(77, 144);
            this.datpEnd.Name = "datpEnd";
            this.datpEnd.Size = new System.Drawing.Size(147, 22);
            this.datpEnd.TabIndex = 3;
            this.datpEnd.ValueChanged += new System.EventHandler(this.frmReport_Load);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(125, 11);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(117, 22);
            this.textBox1.TabIndex = 6;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel1.Location = new System.Drawing.Point(0, 678);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(266, 59);
            this.panel1.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Год";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(101, 3);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(84, 22);
            this.textBox2.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(59, 31);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Сформировать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.frmReport_Load);
            // 
            // grid
            // 
            this.grid.AllowUserToAddRows = false;
            this.grid.AllowUserToDeleteRows = false;
            this.grid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grid.AutoGenerateColumns = false;
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.inventoryNumberDataGridViewTextBoxColumn,
            this.Obekt,
            this.nameDataGridViewTextBoxColumn});
            this.grid.DataSource = this.sprOSBindingSource;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid.DefaultCellStyle = dataGridViewCellStyle1;
            this.grid.Location = new System.Drawing.Point(1, 187);
            this.grid.Name = "grid";
            this.grid.ReadOnly = true;
            this.grid.RowHeadersVisible = false;
            this.grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid.Size = new System.Drawing.Size(263, 490);
            this.grid.TabIndex = 10;
            this.grid.Visible = false;
            // 
            // inventoryNumberDataGridViewTextBoxColumn
            // 
            this.inventoryNumberDataGridViewTextBoxColumn.DataPropertyName = "InventoryNumber";
            this.inventoryNumberDataGridViewTextBoxColumn.HeaderText = "Инв №";
            this.inventoryNumberDataGridViewTextBoxColumn.Name = "inventoryNumberDataGridViewTextBoxColumn";
            this.inventoryNumberDataGridViewTextBoxColumn.ReadOnly = true;
            this.inventoryNumberDataGridViewTextBoxColumn.Width = 50;
            // 
            // Obekt
            // 
            this.Obekt.DataPropertyName = "Obekt";
            this.Obekt.HeaderText = "Obekt";
            this.Obekt.Name = "Obekt";
            this.Obekt.ReadOnly = true;
            this.Obekt.Visible = false;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Название";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sprOSBindingSource
            // 
            this.sprOSBindingSource.DataMember = "SprOS";
            this.sprOSBindingSource.DataSource = this.repairOSDS;
            // 
            // rpvRepair
            // 
            this.rpvRepair.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.repairTableBindingSource;
            this.rpvRepair.LocalReport.DataSources.Add(reportDataSource1);
            this.rpvRepair.LocalReport.ReportEmbeddedResource = "Repairs.Report1.rdlc";
            this.rpvRepair.Location = new System.Drawing.Point(0, 0);
            this.rpvRepair.Name = "rpvRepair";
            this.rpvRepair.Size = new System.Drawing.Size(858, 737);
            this.rpvRepair.TabIndex = 4;
            this.rpvRepair.Load += new System.EventHandler(this.rpvRepair_Load);
            // 
            // rpvAgr
            // 
            this.rpvAgr.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = null;
            this.rpvAgr.LocalReport.DataSources.Add(reportDataSource2);
            this.rpvAgr.LocalReport.ReportEmbeddedResource = "Repairs.Report3.rdlc";
            this.rpvAgr.Location = new System.Drawing.Point(0, 0);
            this.rpvAgr.Name = "rpvAgr";
            this.rpvAgr.Size = new System.Drawing.Size(979, 718);
            this.rpvAgr.TabIndex = 5;
            this.rpvAgr.Visible = false;
            // 
            // rpvWorkOS
            // 
            this.rpvWorkOS.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource3.Name = "DataSet1";
            reportDataSource3.Value = this.reportWorkOSBindingSource;
            this.rpvWorkOS.LocalReport.DataSources.Add(reportDataSource3);
            this.rpvWorkOS.LocalReport.ReportEmbeddedResource = "Repairs.Report2.rdlc";
            this.rpvWorkOS.Location = new System.Drawing.Point(0, 0);
            this.rpvWorkOS.Name = "rpvWorkOS";
            this.rpvWorkOS.Size = new System.Drawing.Size(979, 718);
            this.rpvWorkOS.TabIndex = 6;
            this.rpvWorkOS.Visible = false;
            // 
            // workOSTableBindingSource
            // 
            this.workOSTableBindingSource.DataMember = "WorkOSTable";
            this.workOSTableBindingSource.DataSource = this.repairOSDS;
            // 
            // repairTableTableAdapter
            // 
            this.repairTableTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Branch_1TableAdapter = null;
            this.tableAdapterManager.BranchTableAdapter = null;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.Hatch1TableAdapter = null;
            this.tableAdapterManager.HatchTableAdapter = null;
            this.tableAdapterManager.HorizontTableAdapter = null;
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
            this.tableAdapterManager.StoreTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Repairs.RepairOSDSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Users_listTableAdapter = null;
            this.tableAdapterManager.WorkOSTableAdapter = null;
            // 
            // workOSTableTableAdapter
            // 
            this.workOSTableTableAdapter.ClearBeforeFill = true;
            // 
            // agrJornalReportTableAdapter
            // 
            this.agrJornalReportTableAdapter.ClearBeforeFill = true;
            // 
            // sprOSTableAdapter
            // 
            this.sprOSTableAdapter.ClearBeforeFill = true;
            // 
            // reportWorkOSTableAdapter
            // 
            this.reportWorkOSTableAdapter.ClearBeforeFill = true;
            // 
            // AgrJornalReportBindingSource
            // 
            this.AgrJornalReportBindingSource.DataMember = "AgrJornalReport";
            this.AgrJornalReportBindingSource.DataSource = this.repairOSDS;
            this.AgrJornalReportBindingSource.CurrentChanged += new System.EventHandler(this.AgrJornalReportBindingSource_CurrentChanged);
            // 
            // frmReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1124, 737);
            this.Controls.Add(this.rpvWorkOS);
            this.Controls.Add(this.rpvRepair);
            this.Controls.Add(this.pnl);
            this.Controls.Add(this.rpvAgr);
            this.Name = "frmReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Отчёт";
            this.Load += new System.EventHandler(this.frmReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.repairTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repairOSDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportWorkOSBindingSource)).EndInit();
            this.pnl.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sprOSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workOSTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AgrJornalReportBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl;
        private System.Windows.Forms.RadioButton rbtnReportOut;
        private System.Windows.Forms.DateTimePicker datpEnd;
        private System.Windows.Forms.DateTimePicker datpBeg;
        private System.Windows.Forms.RadioButton rbtnReportIn;
        private Microsoft.Reporting.WinForms.ReportViewer rpvRepair;
        private RepairOSDS repairOSDS;
        private System.Windows.Forms.BindingSource repairTableBindingSource;
        private RepairOSDSTableAdapters.RepairTableTableAdapter repairTableTableAdapter;
        private RepairOSDSTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.BindingSource workOSTableBindingSource;
        private RepairOSDSTableAdapters.WorkOSTableTableAdapter workOSTableTableAdapter;
        private System.Windows.Forms.Button button1;
        private Microsoft.Reporting.WinForms.ReportViewer rpvAgr;
        private Microsoft.Reporting.WinForms.ReportViewer rpvWorkOS;
        private RepairOSDSTableAdapters.AgrJornalReportTableAdapter agrJornalReportTableAdapter;
        private System.Windows.Forms.DataGridView grid;
        private System.Windows.Forms.BindingSource sprOSBindingSource;
        private RepairOSDSTableAdapters.SprOSTableAdapter sprOSTableAdapter;
        private System.Windows.Forms.RadioButton rbtnInvNum;
        private RepairOSDSTableAdapters.ReportWorkOSTableAdapter reportWorkOSTableAdapter;
        private System.Windows.Forms.BindingSource reportWorkOSBindingSource;
        private System.Windows.Forms.BindingSource AgrJornalReportBindingSource;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn inventoryNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Obekt;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;

    }
}