namespace Repairs
{
    partial class frmReport_Vip_Remonti
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
            this.RepairsDataSet10 = new Repairs.RepairsDataSet10();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dtpBeg = new System.Windows.Forms.DateTimePicker();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.RepairTableAdapter = new Repairs.RepairsDataSet10TableAdapters.RepairTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.RepairBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RepairsDataSet10)).BeginInit();
            this.SuspendLayout();
            // 
            // RepairBindingSource
            // 
            this.RepairBindingSource.DataSource = this.RepairsDataSet10;
            this.RepairBindingSource.Position = 0;
            this.RepairBindingSource.CurrentChanged += new System.EventHandler(this.RepairBindingSource_CurrentChanged);
            // 
            // RepairsDataSet10
            // 
            this.RepairsDataSet10.DataSetName = "RepairsDataSet10";
            this.RepairsDataSet10.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.RepairBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Repairs.Report18.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(6, 82);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1259, 558);
            this.reportViewer1.TabIndex = 0;
            // 
            // dtpBeg
            // 
            this.dtpBeg.Location = new System.Drawing.Point(434, 23);
            this.dtpBeg.Name = "dtpBeg";
            this.dtpBeg.Size = new System.Drawing.Size(128, 20);
            this.dtpBeg.TabIndex = 1;
            // 
            // dtpEnd
            // 
            this.dtpEnd.Location = new System.Drawing.Point(602, 23);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(123, 20);
            this.dtpEnd.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(264, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Виконані ремонти за період   з";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(573, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "по";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(755, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Формувати";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // RepairTableAdapter
            // 
            this.RepairTableAdapter.ClearBeforeFill = true;
            // 
            // frmReport_Vip_Remonti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1277, 652);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpEnd);
            this.Controls.Add(this.dtpBeg);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmReport_Vip_Remonti";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Звіт про виконані ремонти (з \"Ремонти ОС\")";
            this.Load += new System.EventHandler(this.frmReport_Vip_Remonti_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RepairBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RepairsDataSet10)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.DateTimePicker dtpBeg;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource RepairBindingSource;
        private RepairsDataSet10 RepairsDataSet10;
        private RepairsDataSet10TableAdapters.RepairTableAdapter RepairTableAdapter;
    }
}