namespace Repairs
{
    partial class myfrmProizvodstvennoTehOtchet
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
            this.ProizvodstvoTehnicheskiyOtchetFBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.RepairsDataSet2 = new Repairs.RepairsDataSet2();
            this.cbx_ceh = new System.Windows.Forms.ComboBox();
            this.dtp_Start = new System.Windows.Forms.DateTimePicker();
            this.dtpFinish = new System.Windows.Forms.DateTimePicker();
            this.cbx_uch = new System.Windows.Forms.ComboBox();
            this.cbx_brig = new System.Windows.Forms.ComboBox();
            this.cbx_det = new System.Windows.Forms.ComboBox();
            this.btn_Print = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ProizvodstvoTehnicheskiyOtchetFTableAdapter = new Repairs.RepairsDataSet2TableAdapters.ProizvodstvoTehnicheskiyOtchetFTableAdapter();
            this.txt_dolg = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_fio = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ProizvodstvoTehnicheskiyOtchetFBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RepairsDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // ProizvodstvoTehnicheskiyOtchetFBindingSource
            // 
            this.ProizvodstvoTehnicheskiyOtchetFBindingSource.DataMember = "ProizvodstvoTehnicheskiyOtchetF";
            this.ProizvodstvoTehnicheskiyOtchetFBindingSource.DataSource = this.RepairsDataSet2;
            // 
            // RepairsDataSet2
            // 
            this.RepairsDataSet2.DataSetName = "RepairsDataSet2";
            this.RepairsDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cbx_ceh
            // 
            this.cbx_ceh.FormattingEnabled = true;
            this.cbx_ceh.Location = new System.Drawing.Point(319, 20);
            this.cbx_ceh.Name = "cbx_ceh";
            this.cbx_ceh.Size = new System.Drawing.Size(298, 21);
            this.cbx_ceh.TabIndex = 0;
            this.cbx_ceh.SelectedIndexChanged += new System.EventHandler(this.cbx_ceh_SelectedIndexChanged);
            // 
            // dtp_Start
            // 
            this.dtp_Start.Location = new System.Drawing.Point(5, 20);
            this.dtp_Start.Name = "dtp_Start";
            this.dtp_Start.Size = new System.Drawing.Size(134, 20);
            this.dtp_Start.TabIndex = 1;
            // 
            // dtpFinish
            // 
            this.dtpFinish.Location = new System.Drawing.Point(156, 20);
            this.dtpFinish.Name = "dtpFinish";
            this.dtpFinish.Size = new System.Drawing.Size(134, 20);
            this.dtpFinish.TabIndex = 2;
            // 
            // cbx_uch
            // 
            this.cbx_uch.FormattingEnabled = true;
            this.cbx_uch.Location = new System.Drawing.Point(666, 19);
            this.cbx_uch.Name = "cbx_uch";
            this.cbx_uch.Size = new System.Drawing.Size(61, 21);
            this.cbx_uch.TabIndex = 4;
            this.cbx_uch.SelectedIndexChanged += new System.EventHandler(this.cbx_uch_SelectedIndexChanged);
            // 
            // cbx_brig
            // 
            this.cbx_brig.FormattingEnabled = true;
            this.cbx_brig.Location = new System.Drawing.Point(733, 19);
            this.cbx_brig.Name = "cbx_brig";
            this.cbx_brig.Size = new System.Drawing.Size(61, 21);
            this.cbx_brig.TabIndex = 5;
            this.cbx_brig.SelectedIndexChanged += new System.EventHandler(this.cbx_brig_SelectedIndexChanged);
            // 
            // cbx_det
            // 
            this.cbx_det.FormattingEnabled = true;
            this.cbx_det.Location = new System.Drawing.Point(800, 19);
            this.cbx_det.Name = "cbx_det";
            this.cbx_det.Size = new System.Drawing.Size(61, 21);
            this.cbx_det.TabIndex = 6;
            // 
            // btn_Print
            // 
            this.btn_Print.Location = new System.Drawing.Point(925, 41);
            this.btn_Print.Name = "btn_Print";
            this.btn_Print.Size = new System.Drawing.Size(75, 23);
            this.btn_Print.TabIndex = 7;
            this.btn_Print.Text = "Печать";
            this.btn_Print.UseVisualStyleBackColor = true;
            this.btn_Print.Click += new System.EventHandler(this.btn_Print_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "C";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(209, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "По";
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.ProizvodstvoTehnicheskiyOtchetFBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Repairs.Report9PTO.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(5, 68);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(999, 421);
            this.reportViewer1.TabIndex = 10;
            // 
            // ProizvodstvoTehnicheskiyOtchetFTableAdapter
            // 
            this.ProizvodstvoTehnicheskiyOtchetFTableAdapter.ClearBeforeFill = true;
            // 
            // txt_dolg
            // 
            this.txt_dolg.Location = new System.Drawing.Point(73, 46);
            this.txt_dolg.Name = "txt_dolg";
            this.txt_dolg.Size = new System.Drawing.Size(298, 20);
            this.txt_dolg.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Должность";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(484, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Фамилия, имя, отчество";
            // 
            // txt_fio
            // 
            this.txt_fio.Location = new System.Drawing.Point(666, 46);
            this.txt_fio.Name = "txt_fio";
            this.txt_fio.Size = new System.Drawing.Size(195, 20);
            this.txt_fio.TabIndex = 14;
            // 
            // myfrmProizvodstvennoTehOtchet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 565);
            this.Controls.Add(this.txt_fio);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_dolg);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Print);
            this.Controls.Add(this.cbx_det);
            this.Controls.Add(this.cbx_brig);
            this.Controls.Add(this.cbx_uch);
            this.Controls.Add(this.dtpFinish);
            this.Controls.Add(this.dtp_Start);
            this.Controls.Add(this.cbx_ceh);
            this.Name = "myfrmProizvodstvennoTehOtchet";
            this.Text = "Производственно-технический отчет";
            this.Load += new System.EventHandler(this.myfrmProizvodstvennoTehOtchet_Load);
            this.Resize += new System.EventHandler(this.myfrmProizvodstvennoTehOtchet_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.ProizvodstvoTehnicheskiyOtchetFBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RepairsDataSet2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbx_ceh;
        private System.Windows.Forms.DateTimePicker dtp_Start;
        private System.Windows.Forms.DateTimePicker dtpFinish;
        private System.Windows.Forms.ComboBox cbx_uch;
        private System.Windows.Forms.ComboBox cbx_brig;
        private System.Windows.Forms.ComboBox cbx_det;
        private System.Windows.Forms.Button btn_Print;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ProizvodstvoTehnicheskiyOtchetFBindingSource;
        private RepairsDataSet2 RepairsDataSet2;
        private RepairsDataSet2TableAdapters.ProizvodstvoTehnicheskiyOtchetFTableAdapter ProizvodstvoTehnicheskiyOtchetFTableAdapter;
        private System.Windows.Forms.TextBox txt_dolg;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_fio;
    }
}