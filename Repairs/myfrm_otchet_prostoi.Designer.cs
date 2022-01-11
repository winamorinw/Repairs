namespace Repairs
{
    partial class myfrm_otchet_prostoi
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
            this.ProstoiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.RepairsDataSet19 = new Repairs.RepairsDataSet19();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ProstoiTableAdapter = new Repairs.RepairsDataSet19TableAdapters.ProstoiTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ProstoiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RepairsDataSet19)).BeginInit();
            this.SuspendLayout();
            // 
            // ProstoiBindingSource
            // 
            this.ProstoiBindingSource.DataMember = "Prostoi";
            this.ProstoiBindingSource.DataSource = this.RepairsDataSet19;
            // 
            // RepairsDataSet19
            // 
            this.RepairsDataSet19.DataSetName = "RepairsDataSet19";
            this.RepairsDataSet19.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.ProstoiBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Repairs.Report_otch_prostio.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1236, 535);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // ProstoiTableAdapter
            // 
            this.ProstoiTableAdapter.ClearBeforeFill = true;
            // 
            // myfrm_otchet_prostoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1236, 535);
            this.Controls.Add(this.reportViewer1);
            this.Name = "myfrm_otchet_prostoi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "myfrm_otchet_prostoi";
            this.Load += new System.EventHandler(this.myfrm_otchet_prostoi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProstoiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RepairsDataSet19)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ProstoiBindingSource;
        private RepairsDataSet19 RepairsDataSet19;
        private RepairsDataSet19TableAdapters.ProstoiTableAdapter ProstoiTableAdapter;
    }
}