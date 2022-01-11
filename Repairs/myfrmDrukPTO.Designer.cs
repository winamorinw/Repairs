namespace Repairs
{
    partial class myfrmDrukPTO
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
            this.cmb_reportBoy = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.DTPend = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.DTPbeg = new System.Windows.Forms.DateTimePicker();
            this.dgvPTO = new System.Windows.Forms.DataGridView();
            this.Grid_Viev = new System.Windows.Forms.DataGridView();
            this.dgvPTOFromVedR = new System.Windows.Forms.DataGridView();
            this.btn_formDrukPTO = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.vedomostResursov = new Repairs.VedomostResursov();
            this.vedomostResursovBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cmb_reportCeh = new System.Windows.Forms.ComboBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPTO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Viev)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPTOFromVedR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vedomostResursov)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vedomostResursovBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cmb_reportBoy
            // 
            this.cmb_reportBoy.Enabled = false;
            this.cmb_reportBoy.FormattingEnabled = true;
            this.cmb_reportBoy.Location = new System.Drawing.Point(127, 51);
            this.cmb_reportBoy.Name = "cmb_reportBoy";
            this.cmb_reportBoy.Size = new System.Drawing.Size(451, 21);
            this.cmb_reportBoy.TabIndex = 1;
            this.cmb_reportBoy.SelectedIndexChanged += new System.EventHandler(this.cmb_reportBoy_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(264, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 17);
            this.label2.TabIndex = 22;
            this.label2.Text = "по";
            // 
            // DTPend
            // 
            this.DTPend.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DTPend.Location = new System.Drawing.Point(291, 10);
            this.DTPend.Name = "DTPend";
            this.DTPend.Size = new System.Drawing.Size(155, 23);
            this.DTPend.TabIndex = 21;
            this.DTPend.CloseUp += new System.EventHandler(this.DTPend_CloseUp);
            this.DTPend.ValueChanged += new System.EventHandler(this.DTPend_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(90, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 17);
            this.label1.TabIndex = 20;
            this.label1.Text = "З";
            // 
            // DTPbeg
            // 
            this.DTPbeg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DTPbeg.Location = new System.Drawing.Point(112, 10);
            this.DTPbeg.Name = "DTPbeg";
            this.DTPbeg.Size = new System.Drawing.Size(148, 23);
            this.DTPbeg.TabIndex = 19;
            this.DTPbeg.CloseUp += new System.EventHandler(this.DTPbeg_CloseUp);
            // 
            // dgvPTO
            // 
            this.dgvPTO.AllowUserToAddRows = false;
            this.dgvPTO.AllowUserToDeleteRows = false;
            this.dgvPTO.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPTO.Location = new System.Drawing.Point(12, 149);
            this.dgvPTO.Name = "dgvPTO";
            this.dgvPTO.ReadOnly = true;
            this.dgvPTO.Size = new System.Drawing.Size(529, 386);
            this.dgvPTO.TabIndex = 23;
            this.dgvPTO.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPTO_CellEnter_1);
            // 
            // Grid_Viev
            // 
            this.Grid_Viev.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid_Viev.Location = new System.Drawing.Point(603, 5);
            this.Grid_Viev.Name = "Grid_Viev";
            this.Grid_Viev.Size = new System.Drawing.Size(368, 69);
            this.Grid_Viev.TabIndex = 25;
            this.Grid_Viev.Visible = false;
            // 
            // dgvPTOFromVedR
            // 
            this.dgvPTOFromVedR.AllowUserToAddRows = false;
            this.dgvPTOFromVedR.AllowUserToDeleteRows = false;
            this.dgvPTOFromVedR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPTOFromVedR.Location = new System.Drawing.Point(547, 149);
            this.dgvPTOFromVedR.Name = "dgvPTOFromVedR";
            this.dgvPTOFromVedR.ReadOnly = true;
            this.dgvPTOFromVedR.Size = new System.Drawing.Size(424, 386);
            this.dgvPTOFromVedR.TabIndex = 26;
            // 
            // btn_formDrukPTO
            // 
            this.btn_formDrukPTO.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_formDrukPTO.Location = new System.Drawing.Point(697, 53);
            this.btn_formDrukPTO.Name = "btn_formDrukPTO";
            this.btn_formDrukPTO.Size = new System.Drawing.Size(200, 30);
            this.btn_formDrukPTO.TabIndex = 27;
            this.btn_formDrukPTO.Text = "Друк ПТЗ";
            this.btn_formDrukPTO.UseVisualStyleBackColor = true;
            this.btn_formDrukPTO.Click += new System.EventHandler(this.btn_formDrukPTO_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(697, 81);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 30);
            this.button1.TabIndex = 28;
            this.button1.Text = "Друк звіта повернутих деталів";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(483, 13);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(95, 23);
            this.button2.TabIndex = 29;
            this.button2.Text = "Вилучити ПТО";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // vedomostResursov
            // 
            this.vedomostResursov.DataSetName = "VedomostResursov";
            this.vedomostResursov.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vedomostResursovBindingSource
            // 
            this.vedomostResursovBindingSource.DataSource = this.vedomostResursov;
            this.vedomostResursovBindingSource.Position = 0;
            // 
            // cmb_reportCeh
            // 
            this.cmb_reportCeh.Enabled = false;
            this.cmb_reportCeh.FormattingEnabled = true;
            this.cmb_reportCeh.Location = new System.Drawing.Point(127, 86);
            this.cmb_reportCeh.Name = "cmb_reportCeh";
            this.cmb_reportCeh.Size = new System.Drawing.Size(451, 21);
            this.cmb_reportCeh.TabIndex = 30;
            this.cmb_reportCeh.SelectedIndexChanged += new System.EventHandler(this.cmb_reportCeh_SelectedIndexChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(22, 57);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(64, 17);
            this.radioButton1.TabIndex = 31;
            this.radioButton1.Text = "по МВО";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(22, 86);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(64, 17);
            this.radioButton2.TabIndex = 32;
            this.radioButton2.Text = "по Цеху";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button3.Location = new System.Drawing.Point(267, 113);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(96, 25);
            this.button3.TabIndex = 33;
            this.button3.Text = "Продивитись";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // myfrmDrukPTO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(977, 565);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.cmb_reportCeh);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_formDrukPTO);
            this.Controls.Add(this.dgvPTOFromVedR);
            this.Controls.Add(this.Grid_Viev);
            this.Controls.Add(this.dgvPTO);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DTPend);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DTPbeg);
            this.Controls.Add(this.cmb_reportBoy);
            this.Name = "myfrmDrukPTO";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Перегляд/Друк ПТЗ";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPTO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Viev)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPTOFromVedR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vedomostResursov)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vedomostResursovBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_reportBoy;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker DTPend;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker DTPbeg;
        private System.Windows.Forms.DataGridView dgvPTO;
        private System.Windows.Forms.DataGridView Grid_Viev;
        private System.Windows.Forms.DataGridView dgvPTOFromVedR;
        private System.Windows.Forms.BindingSource vedomostResursovBindingSource;
        private VedomostResursov vedomostResursov;
        private System.Windows.Forms.Button btn_formDrukPTO;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox cmb_reportCeh;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Button button3;
    }
}