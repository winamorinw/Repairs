namespace Repairs
{
    partial class myfrmAddNewVozvrMet
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
            this.dtp_dataVozvrMet = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_Price = new System.Windows.Forms.TextBox();
            this.txt_Quantity = new System.Windows.Forms.TextBox();
            this.cbx_EdIzm = new System.Windows.Forms.ComboBox();
            this.txt_Sum = new System.Windows.Forms.TextBox();
            this.btn_SaveNewVozvrMet = new System.Windows.Forms.Button();
            this.txt_Note = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbx_AllMetType = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // dtp_dataVozvrMet
            // 
            this.dtp_dataVozvrMet.Location = new System.Drawing.Point(116, 174);
            this.dtp_dataVozvrMet.Margin = new System.Windows.Forms.Padding(4);
            this.dtp_dataVozvrMet.Name = "dtp_dataVozvrMet";
            this.dtp_dataVozvrMet.Size = new System.Drawing.Size(155, 23);
            this.dtp_dataVozvrMet.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Название";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Цена";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(336, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ед. измерения. ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Количество";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(336, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Сумма";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 170);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 17);
            this.label6.TabIndex = 7;
            this.label6.Text = "Дата";
            // 
            // txt_Price
            // 
            this.txt_Price.Location = new System.Drawing.Point(116, 86);
            this.txt_Price.Name = "txt_Price";
            this.txt_Price.Size = new System.Drawing.Size(155, 23);
            this.txt_Price.TabIndex = 8;
            this.txt_Price.Text = "0";
            this.txt_Price.TextChanged += new System.EventHandler(this.txt_Price_TextChanged);
            // 
            // txt_Quantity
            // 
            this.txt_Quantity.Location = new System.Drawing.Point(116, 130);
            this.txt_Quantity.Name = "txt_Quantity";
            this.txt_Quantity.Size = new System.Drawing.Size(155, 23);
            this.txt_Quantity.TabIndex = 9;
            this.txt_Quantity.Text = "0";
            this.txt_Quantity.TextChanged += new System.EventHandler(this.txt_Quantity_TextChanged);
            // 
            // cbx_EdIzm
            // 
            this.cbx_EdIzm.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cbx_EdIzm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_EdIzm.FormattingEnabled = true;
            this.cbx_EdIzm.Location = new System.Drawing.Point(455, 83);
            this.cbx_EdIzm.Name = "cbx_EdIzm";
            this.cbx_EdIzm.Size = new System.Drawing.Size(135, 24);
            this.cbx_EdIzm.TabIndex = 10;
            // 
            // txt_Sum
            // 
            this.txt_Sum.Enabled = false;
            this.txt_Sum.Location = new System.Drawing.Point(455, 130);
            this.txt_Sum.Name = "txt_Sum";
            this.txt_Sum.Size = new System.Drawing.Size(134, 23);
            this.txt_Sum.TabIndex = 11;
            // 
            // btn_SaveNewVozvrMet
            // 
            this.btn_SaveNewVozvrMet.Location = new System.Drawing.Point(338, 266);
            this.btn_SaveNewVozvrMet.Name = "btn_SaveNewVozvrMet";
            this.btn_SaveNewVozvrMet.Size = new System.Drawing.Size(251, 44);
            this.btn_SaveNewVozvrMet.TabIndex = 12;
            this.btn_SaveNewVozvrMet.Text = "Сохранить";
            this.btn_SaveNewVozvrMet.UseVisualStyleBackColor = true;
            this.btn_SaveNewVozvrMet.Click += new System.EventHandler(this.btn_SaveNewVozvrMet_Click);
            // 
            // txt_Note
            // 
            this.txt_Note.Location = new System.Drawing.Point(116, 220);
            this.txt_Note.Name = "txt_Note";
            this.txt_Note.Size = new System.Drawing.Size(473, 23);
            this.txt_Note.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 220);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "Примечание";
            // 
            // cbx_AllMetType
            // 
            this.cbx_AllMetType.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cbx_AllMetType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_AllMetType.FormattingEnabled = true;
            this.cbx_AllMetType.Location = new System.Drawing.Point(90, 38);
            this.cbx_AllMetType.Name = "cbx_AllMetType";
            this.cbx_AllMetType.Size = new System.Drawing.Size(500, 24);
            this.cbx_AllMetType.TabIndex = 15;
            this.cbx_AllMetType.SelectedIndexChanged += new System.EventHandler(this.cbx_AllMetType_SelectedIndexChanged);
            // 
            // myfrmAddNewVozvrMet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 347);
            this.Controls.Add(this.cbx_AllMetType);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_Note);
            this.Controls.Add(this.btn_SaveNewVozvrMet);
            this.Controls.Add(this.txt_Sum);
            this.Controls.Add(this.cbx_EdIzm);
            this.Controls.Add(this.txt_Quantity);
            this.Controls.Add(this.txt_Price);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtp_dataVozvrMet);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "myfrmAddNewVozvrMet";
            this.Text = "Добавить Возвратный металлолом";
            this.Load += new System.EventHandler(this.myfrmAddNewVozvrMet_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtp_dataVozvrMet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_Price;
        private System.Windows.Forms.TextBox txt_Quantity;
        private System.Windows.Forms.ComboBox cbx_EdIzm;
        private System.Windows.Forms.TextBox txt_Sum;
        private System.Windows.Forms.Button btn_SaveNewVozvrMet;
        private System.Windows.Forms.TextBox txt_Note;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbx_AllMetType;
    }
}