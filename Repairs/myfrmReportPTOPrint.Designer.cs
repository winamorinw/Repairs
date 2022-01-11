namespace Repairs
{
    partial class myfrmReportPTOPrint
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
            this.proizvodTehOtchetWithNomerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.repairsDataSet3 = new Repairs.RepairsDataSet3();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.proizvodTehOtchetWithNomerTableAdapter = new Repairs.RepairsDataSet3TableAdapters.ProizvodTehOtchetWithNomerTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.proizvodTehOtchetWithNomerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repairsDataSet3)).BeginInit();
            this.SuspendLayout();
            // 
            // proizvodTehOtchetWithNomerBindingSource
            // 
            this.proizvodTehOtchetWithNomerBindingSource.DataMember = "ProizvodTehOtchetWithNomer";
            this.proizvodTehOtchetWithNomerBindingSource.DataSource = this.repairsDataSet3;
            // 
            // repairsDataSet3
            // 
            this.repairsDataSet3.DataSetName = "RepairsDataSet3";
            this.repairsDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.proizvodTehOtchetWithNomerBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Repairs.ReporPTOPrint.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(954, 656);
            this.reportViewer1.TabIndex = 1;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // proizvodTehOtchetWithNomerTableAdapter
            // 
            this.proizvodTehOtchetWithNomerTableAdapter.ClearBeforeFill = true;
            // 
            // myfrmReportPTOPrint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 656);
            this.Controls.Add(this.reportViewer1);
            this.Name = "myfrmReportPTOPrint";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ПТЗ";
            this.Load += new System.EventHandler(this.myfrmReportPTOPrint_Load);
            ((System.ComponentModel.ISupportInitialize)(this.proizvodTehOtchetWithNomerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repairsDataSet3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource proizvodTehOtchetWithNomerBindingSource;
        private RepairsDataSet3 repairsDataSet3;
        private RepairsDataSet3TableAdapters.ProizvodTehOtchetWithNomerTableAdapter proizvodTehOtchetWithNomerTableAdapter;

    }
}