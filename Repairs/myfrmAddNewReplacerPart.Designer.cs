namespace Repairs
{
    partial class myfrmAddNewReplacerPart
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
            this.datagroup = new System.Windows.Forms.GroupBox();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_AddNewRepPartNotMol = new System.Windows.Forms.Button();
            this.dgv_ReplacedPart = new System.Windows.Forms.DataGridView();
            this.btn_SaveReplacedPart = new System.Windows.Forms.Button();
            this.dtp_dataReplaced = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_close = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgv_r_vozvr_det = new System.Windows.Forms.DataGridView();
            this.datagroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ReplacedPart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_r_vozvr_det)).BeginInit();
            this.SuspendLayout();
            // 
            // datagroup
            // 
            this.datagroup.Controls.Add(this.btn_update);
            this.datagroup.Controls.Add(this.btn_AddNewRepPartNotMol);
            this.datagroup.Controls.Add(this.dgv_ReplacedPart);
            this.datagroup.Location = new System.Drawing.Point(3, 4);
            this.datagroup.Margin = new System.Windows.Forms.Padding(4);
            this.datagroup.Name = "datagroup";
            this.datagroup.Padding = new System.Windows.Forms.Padding(4);
            this.datagroup.Size = new System.Drawing.Size(1023, 331);
            this.datagroup.TabIndex = 0;
            this.datagroup.TabStop = false;
            this.datagroup.Text = "Список запчастей";
            // 
            // btn_update
            // 
            this.btn_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_update.Location = new System.Drawing.Point(214, 142);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(533, 39);
            this.btn_update.TabIndex = 12;
            this.btn_update.Text = "Загрузить Остатки";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.trt_Click);
            // 
            // btn_AddNewRepPartNotMol
            // 
            this.btn_AddNewRepPartNotMol.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_AddNewRepPartNotMol.Location = new System.Drawing.Point(214, 36);
            this.btn_AddNewRepPartNotMol.Name = "btn_AddNewRepPartNotMol";
            this.btn_AddNewRepPartNotMol.Size = new System.Drawing.Size(533, 45);
            this.btn_AddNewRepPartNotMol.TabIndex = 1;
            this.btn_AddNewRepPartNotMol.Text = "Внести запчасти, которые без МОЛ";
            this.btn_AddNewRepPartNotMol.UseVisualStyleBackColor = true;
            this.btn_AddNewRepPartNotMol.Click += new System.EventHandler(this.btn_AddNewRepPartNotMol_Click);
            // 
            // dgv_ReplacedPart
            // 
            this.dgv_ReplacedPart.AllowUserToAddRows = false;
            this.dgv_ReplacedPart.AllowUserToDeleteRows = false;
            this.dgv_ReplacedPart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ReplacedPart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_ReplacedPart.Location = new System.Drawing.Point(4, 20);
            this.dgv_ReplacedPart.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_ReplacedPart.Name = "dgv_ReplacedPart";
            this.dgv_ReplacedPart.ReadOnly = true;
            this.dgv_ReplacedPart.Size = new System.Drawing.Size(1015, 307);
            this.dgv_ReplacedPart.TabIndex = 0;
            // 
            // btn_SaveReplacedPart
            // 
            this.btn_SaveReplacedPart.Location = new System.Drawing.Point(493, 395);
            this.btn_SaveReplacedPart.Name = "btn_SaveReplacedPart";
            this.btn_SaveReplacedPart.Size = new System.Drawing.Size(196, 30);
            this.btn_SaveReplacedPart.TabIndex = 7;
            this.btn_SaveReplacedPart.Text = "Сохранить";
            this.btn_SaveReplacedPart.UseVisualStyleBackColor = true;
            this.btn_SaveReplacedPart.Click += new System.EventHandler(this.button2_Click);
            // 
            // dtp_dataReplaced
            // 
            this.dtp_dataReplaced.Location = new System.Drawing.Point(260, 402);
            this.dtp_dataReplaced.Name = "dtp_dataReplaced";
            this.dtp_dataReplaced.Size = new System.Drawing.Size(200, 23);
            this.dtp_dataReplaced.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(248, 376);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Дата фактической установки";
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(797, 395);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(196, 30);
            this.btn_close.TabIndex = 11;
            this.btn_close.Text = "Закрыть не сохраняя";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(517, 339);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(488, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "1 - норма, 2 - не норма;                            1 - технология; 2 - содержани" +
    "е; ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 339);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(200, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "цифрами в колонках введите";
            // 
            // dgv_r_vozvr_det
            // 
            this.dgv_r_vozvr_det.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_r_vozvr_det.Location = new System.Drawing.Point(3, 359);
            this.dgv_r_vozvr_det.Name = "dgv_r_vozvr_det";
            this.dgv_r_vozvr_det.Size = new System.Drawing.Size(230, 81);
            this.dgv_r_vozvr_det.TabIndex = 46;
            this.dgv_r_vozvr_det.Visible = false;
            // 
            // myfrmAddNewReplacerPart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 443);
            this.Controls.Add(this.dgv_r_vozvr_det);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtp_dataReplaced);
            this.Controls.Add(this.btn_SaveReplacedPart);
            this.Controls.Add(this.datagroup);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "myfrmAddNewReplacerPart";
            this.Text = "Добавление запчасти";
            this.Load += new System.EventHandler(this.myfrmAddNewReplacerPart_Load);
            this.datagroup.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ReplacedPart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_r_vozvr_det)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox datagroup;
        private System.Windows.Forms.DataGridView dgv_ReplacedPart;
        private System.Windows.Forms.Button btn_SaveReplacedPart;
        private System.Windows.Forms.DateTimePicker dtp_dataReplaced;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_AddNewRepPartNotMol;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgv_r_vozvr_det;
    }
}