namespace Repairs
{
    partial class frmReport_Zvit_Vip_Remonti_FromVedRes
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dtpBeg = new System.Windows.Forms.DateTimePicker();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.Vedomost_ResursovBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.RDSet12 = new Repairs.RDSet12();
            this.Vedomost_ResursovTableAdapter = new Repairs.RDSet12TableAdapters.Vedomost_ResursovTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Vedomost_ResursovBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RDSet12)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource3.Name = "DataSet1";
            reportDataSource3.Value = this.Vedomost_ResursovBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Repairs.Report19.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 81);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1255, 559);
            this.reportViewer1.TabIndex = 0;
            // 
            // dtpBeg
            // 
            this.dtpBeg.Location = new System.Drawing.Point(445, 24);
            this.dtpBeg.Name = "dtpBeg";
            this.dtpBeg.Size = new System.Drawing.Size(200, 20);
            this.dtpBeg.TabIndex = 1;
            // 
            // dtpEnd
            // 
            this.dtpEnd.Location = new System.Drawing.Point(704, 24);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(200, 20);
            this.dtpEnd.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(932, 23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Формувати";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Vedomost_ResursovBindingSource
            // 
            this.Vedomost_ResursovBindingSource.DataMember = "Vedomost_Resursov";
            this.Vedomost_ResursovBindingSource.DataSource = this.RDSet12;
            // 
            // RDSet12
            // 
            this.RDSet12.DataSetName = "RDSet12";
            this.RDSet12.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Vedomost_ResursovTableAdapter
            // 
            this.Vedomost_ResursovTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(269, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Виконані ремонти за період   з";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(662, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "по";
            // 
            // frmReport_Zvit_Vip_Remonti_FromVedRes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1277, 652);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dtpEnd);
            this.Controls.Add(this.dtpBeg);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmReport_Zvit_Vip_Remonti_FromVedRes";
            this.Text = "Звіт про виконані ремонти (з \"Відомості ресурсів\")";
            this.Load += new System.EventHandler(this.frmReport_Zvit_Vip_Remonti_FromVedRes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Vedomost_ResursovBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RDSet12)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.DateTimePicker dtpBeg;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource Vedomost_ResursovBindingSource;
        private RDSet12 RDSet12;
        private RDSet12TableAdapters.Vedomost_ResursovTableAdapter Vedomost_ResursovTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}