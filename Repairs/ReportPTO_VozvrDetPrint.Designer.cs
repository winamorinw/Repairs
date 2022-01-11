namespace Repairs
{
    partial class ReportPTO_VozvrDetPrint
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
            this.PTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.RepairsDataSet18 = new Repairs.RepairsDataSet18();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.PTOTableAdapter = new Repairs.RepairsDataSet18TableAdapters.PTOTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.PTOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RepairsDataSet18)).BeginInit();
            this.SuspendLayout();
            // 
            // PTOBindingSource
            // 
            this.PTOBindingSource.DataMember = "PTO";
            this.PTOBindingSource.DataSource = this.RepairsDataSet18;
            // 
            // RepairsDataSet18
            // 
            this.RepairsDataSet18.DataSetName = "RepairsDataSet18";
            this.RepairsDataSet18.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.PTOBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Repairs.Report21.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(7, 8);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(951, 496);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // PTOTableAdapter
            // 
            this.PTOTableAdapter.ClearBeforeFill = true;
            // 
            // ReportPTO_VozvrDetPrint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 505);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReportPTO_VozvrDetPrint";
            this.Text = "ReportPTO_VozvrDetPrint";
            this.Load += new System.EventHandler(this.ReportPTO_VozvrDetPrint_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PTOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RepairsDataSet18)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource PTOBindingSource;
        private RepairsDataSet18 RepairsDataSet18;
        private RepairsDataSet18TableAdapters.PTOTableAdapter PTOTableAdapter;
    }
}