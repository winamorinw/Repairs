namespace Repairs
{
    partial class myfrmPrintVedRes
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.RepairOSDS = new Repairs.RepairOSDS();
            this.ReportHatchBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ReportHatchTableAdapter = new Repairs.RepairOSDSTableAdapters.ReportHatchTableAdapter();
            this.VRVedBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.VedomostResursov = new Repairs.VedomostResursov();
            this.VRRepPartBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.VRVozvrDetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.VRVozvrMetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.VRVedTableAdapter = new Repairs.VedomostResursovTableAdapters.VRVedTableAdapter();
            this.VRRepPartTableAdapter = new Repairs.VedomostResursovTableAdapters.VRRepPartTableAdapter();
            this.VRVozvrDetTableAdapter = new Repairs.VedomostResursovTableAdapters.VRVozvrDetTableAdapter();
            this.VRVozvrMetTableAdapter = new Repairs.VedomostResursovTableAdapters.VRVozvrMetTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RepairOSDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReportHatchBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VRVedBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VedomostResursov)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VRRepPartBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VRVozvrDetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VRVozvrMetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.reportViewer1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1074, 499);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "VedRes";
            reportDataSource1.Value = this.VRVedBindingSource;
            reportDataSource2.Name = "RepPart";
            reportDataSource2.Value = this.VRRepPartBindingSource;
            reportDataSource3.Name = "VozvrDet";
            reportDataSource3.Value = this.VRVozvrDetBindingSource;
            reportDataSource4.Name = "VozvrMet";
            reportDataSource4.Value = this.VRVozvrMetBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource4);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Repairs.VedomostResursov.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(3, 16);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1068, 480);
            this.reportViewer1.TabIndex = 0;
            // 
            // RepairOSDS
            // 
            this.RepairOSDS.DataSetName = "RepairOSDS";
            this.RepairOSDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ReportHatchBindingSource
            // 
            this.ReportHatchBindingSource.DataMember = "ReportHatch";
            this.ReportHatchBindingSource.DataSource = this.RepairOSDS;
            // 
            // ReportHatchTableAdapter
            // 
            this.ReportHatchTableAdapter.ClearBeforeFill = true;
            // 
            // VRVedBindingSource
            // 
            this.VRVedBindingSource.DataMember = "VRVed";
            this.VRVedBindingSource.DataSource = this.VedomostResursov;
            // 
            // VedomostResursov
            // 
            this.VedomostResursov.DataSetName = "VedomostResursov";
            this.VedomostResursov.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // VRRepPartBindingSource
            // 
            this.VRRepPartBindingSource.DataMember = "VRRepPart";
            this.VRRepPartBindingSource.DataSource = this.VedomostResursov;
            // 
            // VRVozvrDetBindingSource
            // 
            this.VRVozvrDetBindingSource.DataMember = "VRVozvrDet";
            this.VRVozvrDetBindingSource.DataSource = this.VedomostResursov;
            // 
            // VRVozvrMetBindingSource
            // 
            this.VRVozvrMetBindingSource.DataMember = "VRVozvrMet";
            this.VRVozvrMetBindingSource.DataSource = this.VedomostResursov;
            // 
            // VRVedTableAdapter
            // 
            this.VRVedTableAdapter.ClearBeforeFill = true;
            // 
            // VRRepPartTableAdapter
            // 
            this.VRRepPartTableAdapter.ClearBeforeFill = true;
            // 
            // VRVozvrDetTableAdapter
            // 
            this.VRVozvrDetTableAdapter.ClearBeforeFill = true;
            // 
            // VRVozvrMetTableAdapter
            // 
            this.VRVozvrMetTableAdapter.ClearBeforeFill = true;
            // 
            // myfrmPrintVedRes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1074, 499);
            this.Controls.Add(this.groupBox1);
            this.Name = "myfrmPrintVedRes";
            this.Text = "Печать ведомости ресурсов";
            this.Load += new System.EventHandler(this.myfrmPrintVedRes_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.RepairOSDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReportHatchBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VRVedBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VedomostResursov)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VRRepPartBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VRVozvrDetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VRVozvrMetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource VRVedBindingSource;
        private VedomostResursov VedomostResursov;
        private System.Windows.Forms.BindingSource VRRepPartBindingSource;
        private System.Windows.Forms.BindingSource VRVozvrDetBindingSource;
        private System.Windows.Forms.BindingSource VRVozvrMetBindingSource;
        private VedomostResursovTableAdapters.VRVedTableAdapter VRVedTableAdapter;
        private VedomostResursovTableAdapters.VRRepPartTableAdapter VRRepPartTableAdapter;
        private VedomostResursovTableAdapters.VRVozvrDetTableAdapter VRVozvrDetTableAdapter;
        private VedomostResursovTableAdapters.VRVozvrMetTableAdapter VRVozvrMetTableAdapter;
        private System.Windows.Forms.BindingSource ReportHatchBindingSource;
        private RepairOSDS RepairOSDS;
        private RepairOSDSTableAdapters.ReportHatchTableAdapter ReportHatchTableAdapter;
    }
}