namespace Repairs
{
    partial class frmReportPlan
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.repairOSDS = new Repairs.RepairOSDS();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.rpvPlan = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.rpvNorm = new Microsoft.Reporting.WinForms.ReportViewer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgNormOS = new System.Windows.Forms.DataGridView();
            this.inventoryNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sprOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.tableAdapterManager = new Repairs.RepairOSDSTableAdapters.TableAdapterManager();
            this.sprOSTableAdapter = new Repairs.RepairOSDSTableAdapters.SprOSTableAdapter();
            this.reportNormBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportNormTableAdapter = new Repairs.RepairOSDSTableAdapters.ReportNormTableAdapter();
            this.reportOSTableAdapter = new Repairs.RepairOSDSTableAdapters.ReportOSTableAdapter();
            this.reportOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportJobPlanTableAdapter = new Repairs.RepairOSDSTableAdapters.ReportJobPlanTableAdapter();
            this.reportJobPlanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportJobFaktTableAdapter = new Repairs.RepairOSDSTableAdapters.ReportJobFaktTableAdapter();
            this.reportJobFaktBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.repairOSDS)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgNormOS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sprOSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportNormBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportOSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportJobPlanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportJobFaktBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // repairOSDS
            // 
            this.repairOSDS.DataSetName = "RepairOSDS";
            this.repairOSDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1071, 521);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.rpvPlan);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1063, 495);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Плановые";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // rpvPlan
            // 
            this.rpvPlan.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = null;
            this.rpvPlan.LocalReport.DataSources.Add(reportDataSource1);
            this.rpvPlan.LocalReport.ReportEmbeddedResource = "Repairs.Report6.rdlc";
            this.rpvPlan.Location = new System.Drawing.Point(3, 3);
            this.rpvPlan.Name = "rpvPlan";
            this.rpvPlan.Size = new System.Drawing.Size(1057, 489);
            this.rpvPlan.TabIndex = 8;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.rpvNorm);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1063, 495);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Расписание";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // rpvNorm
            // 
            this.rpvNorm.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = null;
            this.rpvNorm.LocalReport.DataSources.Add(reportDataSource2);
            this.rpvNorm.LocalReport.ReportEmbeddedResource = "Repairs.Report5.rdlc";
            this.rpvNorm.Location = new System.Drawing.Point(3, 3);
            this.rpvNorm.Name = "rpvNorm";
            this.rpvNorm.Size = new System.Drawing.Size(1057, 489);
            this.rpvNorm.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dgNormOS);
            this.panel1.Controls.Add(this.textBox4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel1.Location = new System.Drawing.Point(1073, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(248, 524);
            this.panel1.TabIndex = 8;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(48, 3);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(188, 24);
            this.checkBox1.TabIndex = 13;
            this.checkBox1.Text = "Отбор оборудования";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Поиск по инв.№";
            // 
            // dgNormOS
            // 
            this.dgNormOS.AllowUserToAddRows = false;
            this.dgNormOS.AllowUserToDeleteRows = false;
            this.dgNormOS.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.dgNormOS.AutoGenerateColumns = false;
            this.dgNormOS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgNormOS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.inventoryNumberDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn});
            this.dgNormOS.DataSource = this.sprOSBindingSource;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgNormOS.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgNormOS.Location = new System.Drawing.Point(0, 55);
            this.dgNormOS.Name = "dgNormOS";
            this.dgNormOS.ReadOnly = true;
            this.dgNormOS.RowHeadersVisible = false;
            this.dgNormOS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgNormOS.Size = new System.Drawing.Size(245, 462);
            this.dgNormOS.TabIndex = 10;
            this.dgNormOS.CurrentCellChanged += new System.EventHandler(this.dgNormOS_CurrentCellChanged);
            // 
            // inventoryNumberDataGridViewTextBoxColumn
            // 
            this.inventoryNumberDataGridViewTextBoxColumn.DataPropertyName = "InventoryNumber";
            this.inventoryNumberDataGridViewTextBoxColumn.HeaderText = "Инв.№";
            this.inventoryNumberDataGridViewTextBoxColumn.Name = "inventoryNumberDataGridViewTextBoxColumn";
            this.inventoryNumberDataGridViewTextBoxColumn.ReadOnly = true;
            this.inventoryNumberDataGridViewTextBoxColumn.Width = 70;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Наименование";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sprOSBindingSource
            // 
            this.sprOSBindingSource.DataMember = "SprOS";
            this.sprOSBindingSource.DataSource = this.repairOSDS;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(136, 27);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(109, 26);
            this.textBox4.TabIndex = 6;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
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
            this.tableAdapterManager.RefPartTableAdapter = null;
            this.tableAdapterManager.RefPlaceTableAdapter = null;
            this.tableAdapterManager.RepairTableAdapter = null;
            this.tableAdapterManager.ReplacedPartTableAdapter = null;
            this.tableAdapterManager.sprDivisionTableAdapter = null;
            this.tableAdapterManager.SprOSGroupTableAdapter = null;
            this.tableAdapterManager.SprOSTableAdapter = this.sprOSTableAdapter;
            this.tableAdapterManager.sprRepairDivisionTableAdapter = null;
            this.tableAdapterManager.SprUserTableAdapter = null;
            this.tableAdapterManager.StoreTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Repairs.RepairOSDSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Users_listTableAdapter = null;
            this.tableAdapterManager.WorkOSTableAdapter = null;
            // 
            // sprOSTableAdapter
            // 
            this.sprOSTableAdapter.ClearBeforeFill = true;
            // 
            // reportNormBindingSource
            // 
            this.reportNormBindingSource.DataMember = "ReportNorm";
            this.reportNormBindingSource.DataSource = this.repairOSDS;
            // 
            // reportNormTableAdapter
            // 
            this.reportNormTableAdapter.ClearBeforeFill = true;
            // 
            // reportOSTableAdapter
            // 
            this.reportOSTableAdapter.ClearBeforeFill = true;
            // 
            // reportOSBindingSource
            // 
            this.reportOSBindingSource.DataMember = "ReportOS";
            this.reportOSBindingSource.DataSource = this.repairOSDS;
            // 
            // reportJobPlanTableAdapter
            // 
            this.reportJobPlanTableAdapter.ClearBeforeFill = true;
            // 
            // reportJobPlanBindingSource
            // 
            this.reportJobPlanBindingSource.DataMember = "ReportJobPlan";
            this.reportJobPlanBindingSource.DataSource = this.repairOSDS;
            // 
            // reportJobFaktTableAdapter
            // 
            this.reportJobFaktTableAdapter.ClearBeforeFill = true;
            // 
            // reportJobFaktBindingSource
            // 
            this.reportJobFaktBindingSource.DataMember = "ReportJobFakt";
            this.reportJobFaktBindingSource.DataSource = this.repairOSDS;
            // 
            // frmReportPlan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1321, 524);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmReportPlan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Отчет по плановым работам";
            this.Load += new System.EventHandler(this.frmReportPlan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.repairOSDS)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgNormOS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sprOSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportNormBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportOSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportJobPlanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportJobFaktBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private Microsoft.Reporting.WinForms.ReportViewer rpvPlan;
        private Microsoft.Reporting.WinForms.ReportViewer rpvNorm;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgNormOS;
        private System.Windows.Forms.TextBox textBox4;
        private RepairOSDS repairOSDS;
        private RepairOSDSTableAdapters.TableAdapterManager tableAdapterManager;
        private RepairOSDSTableAdapters.SprOSTableAdapter sprOSTableAdapter;
        private System.Windows.Forms.BindingSource sprOSBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn inventoryNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource reportNormBindingSource;
        private RepairOSDSTableAdapters.ReportNormTableAdapter reportNormTableAdapter;
        private System.Windows.Forms.Label label1;
        private RepairOSDSTableAdapters.ReportOSTableAdapter reportOSTableAdapter;
        private RepairOSDSTableAdapters.ReportJobPlanTableAdapter reportJobPlanTableAdapter;
        private RepairOSDSTableAdapters.ReportJobFaktTableAdapter reportJobFaktTableAdapter;
        private System.Windows.Forms.BindingSource reportOSBindingSource;
        private System.Windows.Forms.BindingSource reportJobPlanBindingSource;
        private System.Windows.Forms.BindingSource reportJobFaktBindingSource;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}