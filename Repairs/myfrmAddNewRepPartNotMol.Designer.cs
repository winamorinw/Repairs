namespace Repairs
{
    partial class myfrmAddNewRepPartNotMol
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
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.cbx_EdIzm = new System.Windows.Forms.ComboBox();
            this.txt_Quantity = new System.Windows.Forms.TextBox();
            this.dtp_date = new System.Windows.Forms.DateTimePicker();
            this.cbx_TypeDetail = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAddandExit = new System.Windows.Forms.Button();
            this.btn_AddRepPart = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_Note = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txt_Name
            // 
            this.txt_Name.Location = new System.Drawing.Point(167, 74);
            this.txt_Name.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(277, 23);
            this.txt_Name.TabIndex = 0;
            // 
            // cbx_EdIzm
            // 
            this.cbx_EdIzm.FormattingEnabled = true;
            this.cbx_EdIzm.Location = new System.Drawing.Point(336, 122);
            this.cbx_EdIzm.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbx_EdIzm.Name = "cbx_EdIzm";
            this.cbx_EdIzm.Size = new System.Drawing.Size(108, 24);
            this.cbx_EdIzm.TabIndex = 1;
            // 
            // txt_Quantity
            // 
            this.txt_Quantity.Location = new System.Drawing.Point(167, 122);
            this.txt_Quantity.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_Quantity.Name = "txt_Quantity";
            this.txt_Quantity.Size = new System.Drawing.Size(132, 23);
            this.txt_Quantity.TabIndex = 2;
            // 
            // dtp_date
            // 
            this.dtp_date.Location = new System.Drawing.Point(262, 219);
            this.dtp_date.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtp_date.Name = "dtp_date";
            this.dtp_date.Size = new System.Drawing.Size(182, 23);
            this.dtp_date.TabIndex = 3;
            // 
            // cbx_TypeDetail
            // 
            this.cbx_TypeDetail.FormattingEnabled = true;
            this.cbx_TypeDetail.Location = new System.Drawing.Point(167, 25);
            this.cbx_TypeDetail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbx_TypeDetail.Name = "cbx_TypeDetail";
            this.cbx_TypeDetail.Size = new System.Drawing.Size(277, 24);
            this.cbx_TypeDetail.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Тип запчасти";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Наименование";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Количество";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Дата установки";
            // 
            // btnAddandExit
            // 
            this.btnAddandExit.Location = new System.Drawing.Point(262, 267);
            this.btnAddandExit.Name = "btnAddandExit";
            this.btnAddandExit.Size = new System.Drawing.Size(182, 40);
            this.btnAddandExit.TabIndex = 9;
            this.btnAddandExit.Text = "Добавить и закрыть";
            this.btnAddandExit.UseVisualStyleBackColor = true;
            this.btnAddandExit.Click += new System.EventHandler(this.btnAddandExit_Click);
            // 
            // btn_AddRepPart
            // 
            this.btn_AddRepPart.Location = new System.Drawing.Point(25, 267);
            this.btn_AddRepPart.Name = "btn_AddRepPart";
            this.btn_AddRepPart.Size = new System.Drawing.Size(182, 40);
            this.btn_AddRepPart.TabIndex = 10;
            this.btn_AddRepPart.Text = "Добавить";
            this.btn_AddRepPart.UseVisualStyleBackColor = true;
            this.btn_AddRepPart.Click += new System.EventHandler(this.btn_AddRepPart_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Примечание";
            // 
            // txt_Note
            // 
            this.txt_Note.Location = new System.Drawing.Point(167, 171);
            this.txt_Note.Name = "txt_Note";
            this.txt_Note.Size = new System.Drawing.Size(277, 23);
            this.txt_Note.TabIndex = 12;
            // 
            // myfrmAddNewRepPartNotMol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 330);
            this.Controls.Add(this.txt_Note);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_AddRepPart);
            this.Controls.Add(this.btnAddandExit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbx_TypeDetail);
            this.Controls.Add(this.dtp_date);
            this.Controls.Add(this.txt_Quantity);
            this.Controls.Add(this.cbx_EdIzm);
            this.Controls.Add(this.txt_Name);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "myfrmAddNewRepPartNotMol";
            this.Text = "Запчасти без МОЛ";
            this.Load += new System.EventHandler(this.myfrmAddNewRepPartNotMol_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.ComboBox cbx_EdIzm;
        private System.Windows.Forms.TextBox txt_Quantity;
        private System.Windows.Forms.DateTimePicker dtp_date;
        private System.Windows.Forms.ComboBox cbx_TypeDetail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAddandExit;
        private System.Windows.Forms.Button btn_AddRepPart;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_Note;
    }
}