namespace Repairs
{
    partial class myfrmPrintReportTMCMOL
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ReportTMCMOLBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ReportTMCMOL = new Repairs.ReportTMCMOL();
            this.ReportTMCMOLShapkaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ReportTMCMOLTableAdapter = new Repairs.ReportTMCMOLTableAdapters.ReportTMCMOLTableAdapter();
            this.ReportTMCMOLShapkaTableAdapter = new Repairs.ReportTMCMOLTableAdapters.ReportTMCMOLShapkaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ReportTMCMOLBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReportTMCMOL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReportTMCMOLShapkaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.ReportTMCMOLBindingSource;
            reportDataSource2.Name = "DataSet2";
            reportDataSource2.Value = this.ReportTMCMOLShapkaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Repairs.ReportTMCMOL.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(933, 449);
            this.reportViewer1.TabIndex = 0;
            // 
            // ReportTMCMOLBindingSource
            // 
            this.ReportTMCMOLBindingSource.DataMember = "ReportTMCMOL";
            this.ReportTMCMOLBindingSource.DataSource = this.ReportTMCMOL;
            // 
            // ReportTMCMOL
            // 
            this.ReportTMCMOL.DataSetName = "ReportTMCMOL";
            this.ReportTMCMOL.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ReportTMCMOLShapkaBindingSource
            // 
            this.ReportTMCMOLShapkaBindingSource.DataMember = "ReportTMCMOLShapka";
            this.ReportTMCMOLShapkaBindingSource.DataSource = this.ReportTMCMOL;
            // 
            // ReportTMCMOLTableAdapter
            // 
            this.ReportTMCMOLTableAdapter.ClearBeforeFill = true;
            // 
            // ReportTMCMOLShapkaTableAdapter
            // 
            this.ReportTMCMOLShapkaTableAdapter.ClearBeforeFill = true;
            // 
            // myfrmPrintReportTMCMOL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 449);
            this.Controls.Add(this.reportViewer1);
            this.Name = "myfrmPrintReportTMCMOL";
            this.Text = "Отчет по МОЛ";
            this.Load += new System.EventHandler(this.myfrmPrintReportTMCMOL_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ReportTMCMOLBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReportTMCMOL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReportTMCMOLShapkaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ReportTMCMOLBindingSource;
        private ReportTMCMOL ReportTMCMOL;
        private System.Windows.Forms.BindingSource ReportTMCMOLShapkaBindingSource;
        private ReportTMCMOLTableAdapters.ReportTMCMOLTableAdapter ReportTMCMOLTableAdapter;
        private ReportTMCMOLTableAdapters.ReportTMCMOLShapkaTableAdapter ReportTMCMOLShapkaTableAdapter;
    }
}