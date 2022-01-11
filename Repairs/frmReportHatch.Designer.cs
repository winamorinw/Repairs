namespace Repairs
{
    partial class frmReportHatch
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
            this.reportHatchBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.repairOSDS = new Repairs.RepairOSDS();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.reportHatchTableAdapter = new Repairs.RepairOSDSTableAdapters.ReportHatchTableAdapter();
            this.tableAdapterManager = new Repairs.RepairOSDSTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.reportHatchBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repairOSDS)).BeginInit();
            this.SuspendLayout();
            // 
            // reportHatchBindingSource
            // 
            this.reportHatchBindingSource.DataMember = "ReportHatch";
            this.reportHatchBindingSource.DataSource = this.repairOSDS;
            // 
            // repairOSDS
            // 
            this.repairOSDS.DataSetName = "RepairOSDS";
            this.repairOSDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.reportHatchBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Repairs.Report7.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(909, 508);
            this.reportViewer1.TabIndex = 0;
            // 
            // reportHatchTableAdapter
            // 
            this.reportHatchTableAdapter.ClearBeforeFill = true;
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
            // frmReportHatch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 508);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmReportHatch";
            this.Text = "frmReportHatch";
            this.Load += new System.EventHandler(this.frmReportHatch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.reportHatchBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repairOSDS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private RepairOSDS repairOSDS;
        private System.Windows.Forms.BindingSource reportHatchBindingSource;
        private RepairOSDSTableAdapters.ReportHatchTableAdapter reportHatchTableAdapter;
        private RepairOSDSTableAdapters.TableAdapterManager tableAdapterManager;
    }
}