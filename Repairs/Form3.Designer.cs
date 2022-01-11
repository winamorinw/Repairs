namespace Repairs
{
    partial class frm_ZvitNabrSum
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
            this.RepairBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.repairsDataSet7 = new Repairs.RepairsDataSet7();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.repairsDataSet7BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.RepairTableAdapter = new Repairs.RepairsDataSet7TableAdapters.RepairTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.RepairBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repairsDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repairsDataSet7BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // RepairBindingSource
            // 
            this.RepairBindingSource.DataMember = "Repair";
            this.RepairBindingSource.DataSource = this.repairsDataSet7;
            // 
            // repairsDataSet7
            // 
            this.repairsDataSet7.DataSetName = "RepairsDataSet7";
            this.repairsDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.RepairBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Repairs.Report12.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(28, 26);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1316, 515);
            this.reportViewer1.TabIndex = 0;
            // 
            // repairsDataSet7BindingSource
            // 
            this.repairsDataSet7BindingSource.DataSource = this.repairsDataSet7;
            this.repairsDataSet7BindingSource.Position = 0;
            // 
            // RepairTableAdapter
            // 
            this.RepairTableAdapter.ClearBeforeFill = true;
            // 
            // frm_ZvitNabrSum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1356, 570);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frm_ZvitNabrSum";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ZvitNabrSum";
            this.Load += new System.EventHandler(this.frm_ZvitNabrSum_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RepairBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repairsDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repairsDataSet7BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource repairsDataSet7BindingSource;
        private RepairsDataSet7 repairsDataSet7;
        private System.Windows.Forms.BindingSource RepairBindingSource;
        private RepairsDataSet7TableAdapters.RepairTableAdapter RepairTableAdapter;
    }
}