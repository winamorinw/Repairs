namespace Repairs
{
    partial class myfrmAddNewVozvrDet
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
            this.label7 = new System.Windows.Forms.Label();
            this.txt_Note = new System.Windows.Forms.TextBox();
            this.btn_SaveNewVozvrDet = new System.Windows.Forms.Button();
            this.txt_Quantity = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.dtp_dataVozvrDet = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_ednome = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 177);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 17);
            this.label7.TabIndex = 29;
            this.label7.Text = "Примечание";
            // 
            // txt_Note
            // 
            this.txt_Note.Location = new System.Drawing.Point(130, 177);
            this.txt_Note.Name = "txt_Note";
            this.txt_Note.Size = new System.Drawing.Size(452, 23);
            this.txt_Note.TabIndex = 28;
            // 
            // btn_SaveNewVozvrDet
            // 
            this.btn_SaveNewVozvrDet.Location = new System.Drawing.Point(285, 223);
            this.btn_SaveNewVozvrDet.Name = "btn_SaveNewVozvrDet";
            this.btn_SaveNewVozvrDet.Size = new System.Drawing.Size(298, 44);
            this.btn_SaveNewVozvrDet.TabIndex = 27;
            this.btn_SaveNewVozvrDet.Text = "Сохранить";
            this.btn_SaveNewVozvrDet.UseVisualStyleBackColor = true;
            this.btn_SaveNewVozvrDet.Click += new System.EventHandler(this.btn_SaveNewVozvrMet_Click);
            // 
            // txt_Quantity
            // 
            this.txt_Quantity.Location = new System.Drawing.Point(130, 79);
            this.txt_Quantity.Name = "txt_Quantity";
            this.txt_Quantity.Size = new System.Drawing.Size(155, 23);
            this.txt_Quantity.TabIndex = 24;
            this.txt_Quantity.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 128);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 17);
            this.label6.TabIndex = 22;
            this.label6.Text = "Дата";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 17);
            this.label4.TabIndex = 20;
            this.label4.Text = "Количество";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 17);
            this.label1.TabIndex = 17;
            this.label1.Text = "Название";
            // 
            // txt_Name
            // 
            this.txt_Name.Location = new System.Drawing.Point(130, 30);
            this.txt_Name.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(453, 23);
            this.txt_Name.TabIndex = 16;
            // 
            // dtp_dataVozvrDet
            // 
            this.dtp_dataVozvrDet.Location = new System.Drawing.Point(130, 128);
            this.dtp_dataVozvrDet.Margin = new System.Windows.Forms.Padding(4);
            this.dtp_dataVozvrDet.Name = "dtp_dataVozvrDet";
            this.dtp_dataVozvrDet.Size = new System.Drawing.Size(155, 23);
            this.dtp_dataVozvrDet.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 3);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 17);
            this.label2.TabIndex = 31;
            this.label2.Text = "Номенклатур.№";
            this.label2.Visible = false;
            // 
            // txt_ednome
            // 
            this.txt_ednome.Location = new System.Drawing.Point(130, 3);
            this.txt_ednome.Margin = new System.Windows.Forms.Padding(4);
            this.txt_ednome.Name = "txt_ednome";
            this.txt_ednome.Size = new System.Drawing.Size(129, 23);
            this.txt_ednome.TabIndex = 30;
            this.txt_ednome.Visible = false;
            // 
            // myfrmAddNewVozvrDet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 298);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_ednome);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_Note);
            this.Controls.Add(this.btn_SaveNewVozvrDet);
            this.Controls.Add(this.txt_Quantity);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Name);
            this.Controls.Add(this.dtp_dataVozvrDet);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "myfrmAddNewVozvrDet";
            this.Text = "Добавить возвратную деталь";
            this.Load += new System.EventHandler(this.myfrmAddNewVozvrDet_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_Note;
        private System.Windows.Forms.Button btn_SaveNewVozvrDet;
        private System.Windows.Forms.TextBox txt_Quantity;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.DateTimePicker dtp_dataVozvrDet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_ednome;
    }
}