namespace Repairs
{
    partial class myfrm_ne_spisano
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.NeSpisMaterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.VedomostResursov = new Repairs.VedomostResursov();
            this.NeSpisMaterTableAdapter = new Repairs.VedomostResursovTableAdapters.NeSpisMaterTableAdapter();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NeSpisMaterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VedomostResursov)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1119, 531);
            this.panel1.TabIndex = 16;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.reportViewer1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1119, 531);
            this.panel3.TabIndex = 1;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.NeSpisMaterBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Repairs.Rep_Ne_spis_mat.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1119, 531);
            this.reportViewer1.TabIndex = 0;
            // 
            // NeSpisMaterBindingSource
            // 
            this.NeSpisMaterBindingSource.DataMember = "NeSpisMater";
            this.NeSpisMaterBindingSource.DataSource = this.VedomostResursov;
            // 
            // VedomostResursov
            // 
            this.VedomostResursov.DataSetName = "VedomostResursov";
            this.VedomostResursov.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // NeSpisMaterTableAdapter
            // 
            this.NeSpisMaterTableAdapter.ClearBeforeFill = true;
            // 
            // myfrm_ne_spisano
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1119, 531);
            this.Controls.Add(this.panel1);
            this.Name = "myfrm_ne_spisano";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Не списані матеріали";
            this.Load += new System.EventHandler(this.myfrm_ne_spisano_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.NeSpisMaterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VedomostResursov)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource NeSpisMaterBindingSource;
        private VedomostResursov VedomostResursov;
        private VedomostResursovTableAdapters.NeSpisMaterTableAdapter NeSpisMaterTableAdapter;

    }
}