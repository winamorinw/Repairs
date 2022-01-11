namespace Repairs
{
    partial class frmReport_Zvit_Vitrach_Chas
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
            this.button1 = new System.Windows.Forms.Button();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.dtpBeg = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.RepairsDataSet12 = new Repairs.RepairsDataSet12();
            this.Vedomost_ResursovBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Vedomost_ResursovTableAdapter = new Repairs.RepairsDataSet12TableAdapters.Vedomost_ResursovTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.RepairsDataSet12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Vedomost_ResursovBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(946, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Формувати";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dtpEnd
            // 
            this.dtpEnd.Location = new System.Drawing.Point(683, 21);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(200, 20);
            this.dtpEnd.TabIndex = 5;
            // 
            // dtpBeg
            // 
            this.dtpBeg.Location = new System.Drawing.Point(424, 21);
            this.dtpBeg.Name = "dtpBeg";
            this.dtpBeg.Size = new System.Drawing.Size(200, 20);
            this.dtpBeg.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(255, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Виконані ремонти за період   з";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(645, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "по";
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.Vedomost_ResursovBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Repairs.Report20.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 64);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1253, 569);
            this.reportViewer1.TabIndex = 9;
            // 
            // RepairsDataSet12
            // 
            this.RepairsDataSet12.DataSetName = "RepairsDataSet12";
            this.RepairsDataSet12.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Vedomost_ResursovBindingSource
            // 
            this.Vedomost_ResursovBindingSource.DataMember = "Vedomost_Resursov";
            this.Vedomost_ResursovBindingSource.DataSource = this.RepairsDataSet12;
            // 
            // Vedomost_ResursovTableAdapter
            // 
            this.Vedomost_ResursovTableAdapter.ClearBeforeFill = true;
            // 
            // frmReport_Zvit_Vitrach_Chas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1277, 652);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dtpEnd);
            this.Controls.Add(this.dtpBeg);
            this.Name = "frmReport_Zvit_Vitrach_Chas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Звіт про витрачений час на виконання ремонтів та ТО";
            this.Load += new System.EventHandler(this.frmReport_Zvit_Vitrach_Chas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RepairsDataSet12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Vedomost_ResursovBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.DateTimePicker dtpBeg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource Vedomost_ResursovBindingSource;
        private RepairsDataSet12 RepairsDataSet12;
        private RepairsDataSet12TableAdapters.Vedomost_ResursovTableAdapter Vedomost_ResursovTableAdapter;
    }
}