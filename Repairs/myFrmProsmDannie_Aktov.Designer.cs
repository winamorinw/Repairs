namespace Repairs
{
    partial class myFrmProsmDannie_Aktov
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
            this.Vedomost_ResursovBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.VedomostResursov = new Repairs.VedomostResursov();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.Vedomost_ResursovTableAdapter = new Repairs.VedomostResursovTableAdapters.Vedomost_ResursovTableAdapter();
            this.vedomostResursov_stringInventoryNumber1 = new Repairs.VedomostResursov_stringInventoryNumber();
            this.vedomost_ResursovTableAdapter1 = new Repairs.VedomostResursov_stringInventoryNumberTableAdapters.Vedomost_ResursovTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.Vedomost_ResursovBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VedomostResursov)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vedomostResursov_stringInventoryNumber1)).BeginInit();
            this.SuspendLayout();
            // 
            // Vedomost_ResursovBindingSource
            // 
            this.Vedomost_ResursovBindingSource.DataMember = "Vedomost_Resursov";
            this.Vedomost_ResursovBindingSource.DataSource = this.vedomostResursov_stringInventoryNumber1;
            // 
            // VedomostResursov
            // 
            this.VedomostResursov.DataSetName = "VedomostResursov";
            this.VedomostResursov.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.Vedomost_ResursovBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Repairs.Report_Prosm_Akti.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1052, 523);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // Vedomost_ResursovTableAdapter
            // 
            this.Vedomost_ResursovTableAdapter.ClearBeforeFill = true;
            // 
            // vedomostResursov_stringInventoryNumber1
            // 
            this.vedomostResursov_stringInventoryNumber1.DataSetName = "VedomostResursov_stringInventoryNumber";
            this.vedomostResursov_stringInventoryNumber1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vedomost_ResursovTableAdapter1
            // 
            this.vedomost_ResursovTableAdapter1.ClearBeforeFill = true;
            // 
            // myFrmProsmDannie_Aktov
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 523);
            this.Controls.Add(this.reportViewer1);
            this.Name = "myFrmProsmDannie_Aktov";
            this.Text = "myFrmProsmDannie_Aktov";
            this.Load += new System.EventHandler(this.myFrmProsmDannie_Aktov_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Vedomost_ResursovBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VedomostResursov)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vedomostResursov_stringInventoryNumber1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource Vedomost_ResursovBindingSource;
        private VedomostResursov VedomostResursov;
        private VedomostResursovTableAdapters.Vedomost_ResursovTableAdapter Vedomost_ResursovTableAdapter;
        private VedomostResursov_stringInventoryNumber vedomostResursov_stringInventoryNumber1;
        private VedomostResursov_stringInventoryNumberTableAdapters.Vedomost_ResursovTableAdapter vedomost_ResursovTableAdapter1;
    }
}