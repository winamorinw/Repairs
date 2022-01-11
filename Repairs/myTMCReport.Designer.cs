namespace Repairs
{
    partial class myTMCReport
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_searchTMC = new System.Windows.Forms.Button();
            this.cmb_reportBoy = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_print = new System.Windows.Forms.Button();
            this.dgv_m_kart = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_m_kart)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_searchTMC);
            this.groupBox1.Controls.Add(this.cmb_reportBoy);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1073, 124);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Поиск";
            // 
            // btn_searchTMC
            // 
            this.btn_searchTMC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_searchTMC.Location = new System.Drawing.Point(927, 85);
            this.btn_searchTMC.Name = "btn_searchTMC";
            this.btn_searchTMC.Size = new System.Drawing.Size(117, 23);
            this.btn_searchTMC.TabIndex = 1;
            this.btn_searchTMC.Text = "Поиск";
            this.btn_searchTMC.UseVisualStyleBackColor = true;
            this.btn_searchTMC.Click += new System.EventHandler(this.btn_searchTMC_Click);
            // 
            // cmb_reportBoy
            // 
            this.cmb_reportBoy.FormattingEnabled = true;
            this.cmb_reportBoy.Location = new System.Drawing.Point(28, 19);
            this.cmb_reportBoy.Name = "cmb_reportBoy";
            this.cmb_reportBoy.Size = new System.Drawing.Size(503, 21);
            this.cmb_reportBoy.TabIndex = 0;
            this.cmb_reportBoy.SelectedIndexChanged += new System.EventHandler(this.cmb_reportBoy_SelectedIndexChanged);
            this.cmb_reportBoy.SelectedValueChanged += new System.EventHandler(this.cmb_reportBoy_SelectedValueChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgv_m_kart);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel1.Location = new System.Drawing.Point(13, 152);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1072, 308);
            this.panel1.TabIndex = 1;
            // 
            // btn_print
            // 
            this.btn_print.Location = new System.Drawing.Point(1010, 506);
            this.btn_print.Name = "btn_print";
            this.btn_print.Size = new System.Drawing.Size(75, 23);
            this.btn_print.TabIndex = 2;
            this.btn_print.Text = "Печать";
            this.btn_print.UseVisualStyleBackColor = true;
            this.btn_print.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgv_m_kart
            // 
            this.dgv_m_kart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_m_kart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_m_kart.Location = new System.Drawing.Point(0, 0);
            this.dgv_m_kart.Name = "dgv_m_kart";
            this.dgv_m_kart.Size = new System.Drawing.Size(1072, 308);
            this.dgv_m_kart.TabIndex = 3;
            // 
            // myTMCReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1097, 542);
            this.Controls.Add(this.btn_print);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Name = "myTMCReport";
            this.Text = "Остатки ТМЦ";
            this.Load += new System.EventHandler(this.myTMCReport_Load);
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_m_kart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmb_reportBoy;
        private System.Windows.Forms.Button btn_searchTMC;
        private System.Windows.Forms.Button btn_print;
        private System.Windows.Forms.DataGridView dgv_m_kart;
    }
}