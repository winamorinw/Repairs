namespace Repairs
{
    partial class MyfrmAgrJournal
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
            this.AgrJornalReportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.RepairOSDS = new Repairs.RepairOSDS();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txt_SearchInv = new System.Windows.Forms.TextBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.txt_SearchName = new System.Windows.Forms.TextBox();
            this.btn_formjournal = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgv_os = new System.Windows.Forms.DataGridView();
            this.AgrJornalReportTableAdapter = new Repairs.RepairOSDSTableAdapters.AgrJornalReportTableAdapter();
            this.btn_All = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.AgrJornalReportBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RepairOSDS)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_os)).BeginInit();
            this.SuspendLayout();
            // 
            // AgrJornalReportBindingSource
            // 
            this.AgrJornalReportBindingSource.DataMember = "AgrJornalReport";
            this.AgrJornalReportBindingSource.DataSource = this.RepairOSDS;
            // 
            // RepairOSDS
            // 
            this.RepairOSDS.DataSetName = "RepairOSDS";
            this.RepairOSDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.reportViewer1);
            this.groupBox1.Location = new System.Drawing.Point(1, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1041, 694);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Агрегатный журнал";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.AgrJornalReportBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Repairs.Report3.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(3, 16);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1035, 675);
            this.reportViewer1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_All);
            this.groupBox2.Controls.Add(this.groupBox5);
            this.groupBox2.Controls.Add(this.groupBox8);
            this.groupBox2.Controls.Add(this.btn_formjournal);
            this.groupBox2.Location = new System.Drawing.Point(1048, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(587, 123);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Фильтр";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txt_SearchInv);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox5.Location = new System.Drawing.Point(6, 19);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(143, 61);
            this.groupBox5.TabIndex = 17;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Поиск по инв. №";
            // 
            // txt_SearchInv
            // 
            this.txt_SearchInv.Location = new System.Drawing.Point(6, 22);
            this.txt_SearchInv.Name = "txt_SearchInv";
            this.txt_SearchInv.Size = new System.Drawing.Size(131, 23);
            this.txt_SearchInv.TabIndex = 0;
            this.txt_SearchInv.TextChanged += new System.EventHandler(this.txt_SearchInv_TextChanged);
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.txt_SearchName);
            this.groupBox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox8.Location = new System.Drawing.Point(155, 19);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(158, 61);
            this.groupBox8.TabIndex = 18;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Поиск по названию";
            // 
            // txt_SearchName
            // 
            this.txt_SearchName.Location = new System.Drawing.Point(6, 22);
            this.txt_SearchName.Name = "txt_SearchName";
            this.txt_SearchName.Size = new System.Drawing.Size(146, 23);
            this.txt_SearchName.TabIndex = 0;
            this.txt_SearchName.TextChanged += new System.EventHandler(this.txt_SearchName_TextChanged);
            // 
            // btn_formjournal
            // 
            this.btn_formjournal.Location = new System.Drawing.Point(12, 86);
            this.btn_formjournal.Name = "btn_formjournal";
            this.btn_formjournal.Size = new System.Drawing.Size(131, 23);
            this.btn_formjournal.TabIndex = 0;
            this.btn_formjournal.Text = "Поиск по №";
            this.btn_formjournal.UseVisualStyleBackColor = true;
            this.btn_formjournal.Click += new System.EventHandler(this.btn_formjournal_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgv_os);
            this.groupBox3.Location = new System.Drawing.Point(1048, 132);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(587, 568);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Основные средства";
            // 
            // dgv_os
            // 
            this.dgv_os.AllowUserToAddRows = false;
            this.dgv_os.AllowUserToDeleteRows = false;
            this.dgv_os.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_os.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_os.Location = new System.Drawing.Point(3, 16);
            this.dgv_os.Name = "dgv_os";
            this.dgv_os.ReadOnly = true;
            this.dgv_os.Size = new System.Drawing.Size(581, 549);
            this.dgv_os.TabIndex = 0;
            this.dgv_os.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_os_CellEnter);
            // 
            // AgrJornalReportTableAdapter
            // 
            this.AgrJornalReportTableAdapter.ClearBeforeFill = true;
            // 
            // btn_All
            // 
            this.btn_All.Location = new System.Drawing.Point(155, 86);
            this.btn_All.Name = "btn_All";
            this.btn_All.Size = new System.Drawing.Size(158, 23);
            this.btn_All.TabIndex = 19;
            this.btn_All.Text = "Показать все";
            this.btn_All.UseVisualStyleBackColor = true;
            this.btn_All.Click += new System.EventHandler(this.btn_All_Click);
            // 
            // MyfrmAgrJournal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1637, 712);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "MyfrmAgrJournal";
            this.Text = "Агрегатный журнал";
            this.Load += new System.EventHandler(this.MyfrmAgrJournal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AgrJornalReportBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RepairOSDS)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_os)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgv_os;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource AgrJornalReportBindingSource;
        private RepairOSDS RepairOSDS;
        private RepairOSDSTableAdapters.AgrJornalReportTableAdapter AgrJornalReportTableAdapter;
        private System.Windows.Forms.Button btn_formjournal;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox txt_SearchInv;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.TextBox txt_SearchName;
        private System.Windows.Forms.Button btn_All;

    }
}