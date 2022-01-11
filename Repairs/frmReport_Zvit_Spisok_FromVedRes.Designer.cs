namespace Repairs
{
    partial class frmReport_Zvit_Spisok_FromVedRes
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.dtpBeg = new System.Windows.Forms.DateTimePicker();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.From_ved_resBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.VedomostResursov = new Repairs.VedomostResursov();
            this.From_ved_resTableAdapter = new Repairs.VedomostResursovTableAdapters.From_ved_resTableAdapter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.From_ved_resBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VedomostResursov)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(393, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "по";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Виконані ремонти за період   з";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(767, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Формувати";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dtpEnd
            // 
            this.dtpEnd.Location = new System.Drawing.Point(415, 31);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(200, 20);
            this.dtpEnd.TabIndex = 7;
            // 
            // dtpBeg
            // 
            this.dtpBeg.Location = new System.Drawing.Point(187, 31);
            this.dtpBeg.Name = "dtpBeg";
            this.dtpBeg.Size = new System.Drawing.Size(200, 20);
            this.dtpBeg.TabIndex = 6;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.From_ved_resBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Repairs.spisok_ved_res.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(7, 82);
            this.reportViewer1.Margin = new System.Windows.Forms.Padding(1);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(844, 406);
            this.reportViewer1.TabIndex = 11;
            // 
            // From_ved_resBindingSource
            // 
            this.From_ved_resBindingSource.DataMember = "From_ved_res";
            this.From_ved_resBindingSource.DataSource = this.VedomostResursov;
            // 
            // VedomostResursov
            // 
            this.VedomostResursov.DataSetName = "VedomostResursov";
            this.VedomostResursov.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // From_ved_resTableAdapter
            // 
            this.From_ved_resTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(632, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(129, 68);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Сортувати ";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(14, 37);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(62, 17);
            this.radioButton2.TabIndex = 15;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "по цеху";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(14, 14);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(101, 17);
            this.radioButton1.TabIndex = 14;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "по № відомості";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // frmReport_Zvit_Spisok_FromVedRes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 520);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dtpEnd);
            this.Controls.Add(this.dtpBeg);
            this.Name = "frmReport_Zvit_Spisok_FromVedRes";
            this.Text = "frmReport_Zvit_Spisok_FromVedRes";
            this.Load += new System.EventHandler(this.frmReport_Zvit_Spisok_FromVedRes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.From_ved_resBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VedomostResursov)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.DateTimePicker dtpBeg;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource From_ved_resBindingSource;
        private VedomostResursov VedomostResursov;
        private VedomostResursovTableAdapters.From_ved_resTableAdapter From_ved_resTableAdapter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;

    }
}