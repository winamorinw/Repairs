namespace Repairs
{
    partial class frmPrintDodatok1_2
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.Jobs_FromAktF2_for_dodatok_1_2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.RepairsDataSet5 = new Repairs.RepairsDataSet5();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.Jobs_FromAktF2_for_dodatok_1_2TableAdapter = new Repairs.RepairsDataSet5TableAdapters.Jobs_FromAktF2_for_dodatok_1_2TableAdapter();
            this.jobs_FromAktF2_for_dodatok_1_2_kolTableAdapter1 = new Repairs.RepairsDataSet5TableAdapters.Jobs_FromAktF2_for_dodatok_1_2_kolTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.Jobs_FromAktF2_for_dodatok_1_2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RepairsDataSet5)).BeginInit();
            this.SuspendLayout();
            // 
            // Jobs_FromAktF2_for_dodatok_1_2BindingSource
            // 
            this.Jobs_FromAktF2_for_dodatok_1_2BindingSource.DataMember = "Jobs_FromAktF2_for_dodatok_1_2";
            this.Jobs_FromAktF2_for_dodatok_1_2BindingSource.DataSource = this.RepairsDataSet5;
            // 
            // RepairsDataSet5
            // 
            this.RepairsDataSet5.DataSetName = "RepairsDataSet5";
            this.RepairsDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.Jobs_FromAktF2_for_dodatok_1_2BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Repairs.Report_dodatok1_2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(964, 591);
            this.reportViewer1.TabIndex = 2;
            // 
            // Jobs_FromAktF2_for_dodatok_1_2TableAdapter
            // 
            this.Jobs_FromAktF2_for_dodatok_1_2TableAdapter.ClearBeforeFill = true;
            // 
            // jobs_FromAktF2_for_dodatok_1_2_kolTableAdapter1
            // 
            this.jobs_FromAktF2_for_dodatok_1_2_kolTableAdapter1.ClearBeforeFill = true;
            // 
            // frmPrintDodatok1_2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 591);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmPrintDodatok1_2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPrintDodatok1_2";
            ((System.ComponentModel.ISupportInitialize)(this.Jobs_FromAktF2_for_dodatok_1_2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RepairsDataSet5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource Jobs_FromAktF2_for_dodatok_1_2BindingSource;
        private RepairsDataSet5 RepairsDataSet5;
        private RepairsDataSet5TableAdapters.Jobs_FromAktF2_for_dodatok_1_2TableAdapter Jobs_FromAktF2_for_dodatok_1_2TableAdapter;
        private RepairsDataSet5TableAdapters.Jobs_FromAktF2_for_dodatok_1_2_kolTableAdapter jobs_FromAktF2_for_dodatok_1_2_kolTableAdapter1;
    }
}