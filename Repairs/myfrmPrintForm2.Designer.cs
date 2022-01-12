namespace Repairs
{
    partial class myfrmPrintForm2
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.VRVedBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.VedomostResursov = new Repairs.VedomostResursov();
            this.VRVedTableAdapter = new Repairs.VedomostResursovTableAdapters.VRVedTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.VRVedBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VedomostResursov)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "VedRes";
            reportDataSource1.Value = this.VRVedBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Repairs.RepForm2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 21);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(932, 548);
            this.reportViewer1.TabIndex = 0;
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
            // VRVedTableAdapter
            // 
            this.VRVedTableAdapter.ClearBeforeFill = true;
            // 
            // myfrmPrintForm2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1257, 570);
            this.Controls.Add(this.reportViewer1);
            this.Name = "myfrmPrintForm2";
            this.Text = "Печать форма 2";
            this.Load += new System.EventHandler(this.myfrmPrintForm2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.VRVedBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VedomostResursov)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource VRVedBindingSource;
        private VedomostResursov VedomostResursov;
        private VedomostResursovTableAdapters.VRVedTableAdapter VRVedTableAdapter;



    }
}