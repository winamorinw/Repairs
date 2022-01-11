namespace Repairs
{
    partial class frmPrintAktF2
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
            this.Tmp_JobAKTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.repairsDataSet5 = new Repairs.RepairsDataSet5();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.repairsDataSet5BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Tmp_JobAKTTableAdapter = new Repairs.RepairsDataSet5TableAdapters.Tmp_JobAKTTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.Tmp_JobAKTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repairsDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repairsDataSet5BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Tmp_JobAKTBindingSource
            // 
            this.Tmp_JobAKTBindingSource.DataMember = "Tmp_JobAKT";
            this.Tmp_JobAKTBindingSource.DataSource = this.repairsDataSet5;
            // 
            // repairsDataSet5
            // 
            this.repairsDataSet5.DataSetName = "RepairsDataSet5";
            this.repairsDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.AutoScroll = true;
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet5";
            reportDataSource1.Value = this.Tmp_JobAKTBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Repairs.Report11.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Margin = new System.Windows.Forms.Padding(0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(879, 591);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.ZoomPercent = 90;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // repairsDataSet5BindingSource
            // 
            this.repairsDataSet5BindingSource.DataSource = this.repairsDataSet5;
            this.repairsDataSet5BindingSource.Position = 0;
            // 
            // Tmp_JobAKTTableAdapter
            // 
            this.Tmp_JobAKTTableAdapter.ClearBeforeFill = true;
            // 
            // frmPrintAktF2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 591);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmPrintAktF2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Друк АКТа форма  2";
            this.Load += new System.EventHandler(this.frmPrintAktF2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Tmp_JobAKTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repairsDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repairsDataSet5BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource repairsDataSet5BindingSource;
        private RepairsDataSet5 repairsDataSet5;
        private System.Windows.Forms.BindingSource Tmp_JobAKTBindingSource;
        private RepairsDataSet5TableAdapters.Tmp_JobAKTTableAdapter Tmp_JobAKTTableAdapter;

    }
}