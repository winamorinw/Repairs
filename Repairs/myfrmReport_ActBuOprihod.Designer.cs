namespace Repairs
{
    partial class myfrmReport_ActBuOprihod
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
            this.Report_B_U_Form_ACTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ActOprihodBU = new Repairs.ActOprihodBU();
            this.Report_ActsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rptv_BUAct = new Microsoft.Reporting.WinForms.ReportViewer();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.Report_B_U_Form_ACTTableAdapter = new Repairs.ActOprihodBUTableAdapters.Report_B_U_Form_ACTTableAdapter();
            this.Report_ActsTableAdapter = new Repairs.ActOprihodBUTableAdapters.Report_ActsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.Report_B_U_Form_ACTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ActOprihodBU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Report_ActsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Report_B_U_Form_ACTBindingSource
            // 
            this.Report_B_U_Form_ACTBindingSource.DataMember = "Report_B_U_Form_ACT";
            this.Report_B_U_Form_ACTBindingSource.DataSource = this.ActOprihodBU;
            // 
            // ActOprihodBU
            // 
            this.ActOprihodBU.DataSetName = "ActOprihodBU";
            this.ActOprihodBU.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Report_ActsBindingSource
            // 
            this.Report_ActsBindingSource.DataMember = "Report_Acts";
            this.Report_ActsBindingSource.DataSource = this.ActOprihodBU;
            // 
            // rptv_BUAct
            // 
            this.rptv_BUAct.Location = new System.Drawing.Point(0, 0);
            this.rptv_BUAct.Name = "rptv_BUAct";
            this.rptv_BUAct.Size = new System.Drawing.Size(396, 246);
            this.rptv_BUAct.TabIndex = 0;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.Report_B_U_Form_ACTBindingSource;
            reportDataSource2.Name = "DataSet2";
            reportDataSource2.Value = this.Report_ActsBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Repairs.Report_OprihodAct_BU.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 47);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1034, 422);
            this.reportViewer1.TabIndex = 0;
            // 
            // Report_B_U_Form_ACTTableAdapter
            // 
            this.Report_B_U_Form_ACTTableAdapter.ClearBeforeFill = true;
            // 
            // Report_ActsTableAdapter
            // 
            this.Report_ActsTableAdapter.ClearBeforeFill = true;
            // 
            // myfrmReport_ActBuOprihod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1076, 494);
            this.Controls.Add(this.reportViewer1);
            this.Name = "myfrmReport_ActBuOprihod";
            this.Text = "myfrmReport_ActBuOprihod";
            this.Load += new System.EventHandler(this.myfrmReport_ActBuOprihod_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Report_B_U_Form_ACTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ActOprihodBU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Report_ActsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rptv_BUAct;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource Report_B_U_Form_ACTBindingSource;
        private ActOprihodBU ActOprihodBU;
        private ActOprihodBUTableAdapters.Report_B_U_Form_ACTTableAdapter Report_B_U_Form_ACTTableAdapter;
        private System.Windows.Forms.BindingSource Report_ActsBindingSource;
        private ActOprihodBUTableAdapters.Report_ActsTableAdapter Report_ActsTableAdapter;



    }
}