namespace Repairs
{
    partial class myfrmGetToRepairs
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
            this.gbx_Repair = new System.Windows.Forms.GroupBox();
            this.dgv_Repair = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_DeleteRep = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbx_RDiv = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_noteDataNext = new System.Windows.Forms.TextBox();
            this.cbx_plan = new System.Windows.Forms.CheckBox();
            this.txt_Cause = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_TypeFlaut = new System.Windows.Forms.TextBox();
            this.txt_dataNext = new System.Windows.Forms.TextBox();
            this.txt_Responsible = new System.Windows.Forms.TextBox();
            this.txt_note = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txt_SearchInv = new System.Windows.Forms.TextBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.txt_SearchName = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.gbx_Repair.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Repair)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbx_Repair
            // 
            this.gbx_Repair.Controls.Add(this.dgv_Repair);
            this.gbx_Repair.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbx_Repair.Location = new System.Drawing.Point(9, 241);
            this.gbx_Repair.Name = "gbx_Repair";
            this.gbx_Repair.Size = new System.Drawing.Size(974, 284);
            this.gbx_Repair.TabIndex = 0;
            this.gbx_Repair.TabStop = false;
            this.gbx_Repair.Text = "Переданные в ремонт";
            // 
            // dgv_Repair
            // 
            this.dgv_Repair.AllowUserToDeleteRows = false;
            this.dgv_Repair.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Repair.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Repair.Location = new System.Drawing.Point(3, 19);
            this.dgv_Repair.Name = "dgv_Repair";
            this.dgv_Repair.Size = new System.Drawing.Size(968, 262);
            this.dgv_Repair.TabIndex = 0;
            this.dgv_Repair.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Repair_CellEnter);
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.Color.DarkMagenta;
            this.button1.Location = new System.Drawing.Point(434, 217);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(180, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Добавить ОС  в ремонт";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(620, 217);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(177, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Редактировать запись";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_DeleteRep
            // 
            this.btn_DeleteRep.Location = new System.Drawing.Point(803, 217);
            this.btn_DeleteRep.Name = "btn_DeleteRep";
            this.btn_DeleteRep.Size = new System.Drawing.Size(177, 23);
            this.btn_DeleteRep.TabIndex = 3;
            this.btn_DeleteRep.Text = "Удалить запись";
            this.btn_DeleteRep.UseVisualStyleBackColor = true;
            this.btn_DeleteRep.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbx_RDiv);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(9, 157);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(974, 49);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Поиск";
            // 
            // cbx_RDiv
            // 
            this.cbx_RDiv.FormattingEnabled = true;
            this.cbx_RDiv.Location = new System.Drawing.Point(397, 21);
            this.cbx_RDiv.Name = "cbx_RDiv";
            this.cbx_RDiv.Size = new System.Drawing.Size(199, 24);
            this.cbx_RDiv.TabIndex = 4;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(654, 20);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(47, 23);
            this.textBox1.TabIndex = 3;
            this.textBox1.Visible = false;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(826, 22);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(134, 21);
            this.radioButton2.TabIndex = 2;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Ремонт окончен";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(713, 22);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(96, 21);
            this.radioButton1.TabIndex = 1;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "В Ремонте";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_noteDataNext);
            this.groupBox2.Controls.Add(this.cbx_plan);
            this.groupBox2.Controls.Add(this.txt_Cause);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txt_TypeFlaut);
            this.groupBox2.Controls.Add(this.txt_dataNext);
            this.groupBox2.Controls.Add(this.txt_Responsible);
            this.groupBox2.Controls.Add(this.txt_note);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(9, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(971, 147);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Дополнительная информация";
            // 
            // txt_noteDataNext
            // 
            this.txt_noteDataNext.BackColor = System.Drawing.SystemColors.Info;
            this.txt_noteDataNext.Enabled = false;
            this.txt_noteDataNext.Location = new System.Drawing.Point(420, 88);
            this.txt_noteDataNext.Name = "txt_noteDataNext";
            this.txt_noteDataNext.Size = new System.Drawing.Size(540, 23);
            this.txt_noteDataNext.TabIndex = 10;
            // 
            // cbx_plan
            // 
            this.cbx_plan.AutoSize = true;
            this.cbx_plan.Location = new System.Drawing.Point(6, 86);
            this.cbx_plan.Name = "cbx_plan";
            this.cbx_plan.Size = new System.Drawing.Size(92, 21);
            this.cbx_plan.TabIndex = 18;
            this.cbx_plan.Text = "плановый";
            this.cbx_plan.UseVisualStyleBackColor = true;
            // 
            // txt_Cause
            // 
            this.txt_Cause.BackColor = System.Drawing.SystemColors.Info;
            this.txt_Cause.Enabled = false;
            this.txt_Cause.Location = new System.Drawing.Point(750, 53);
            this.txt_Cause.Name = "txt_Cause";
            this.txt_Cause.Size = new System.Drawing.Size(210, 23);
            this.txt_Cause.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(208, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(193, 17);
            this.label6.TabIndex = 16;
            this.label6.Text = "Причина переноса ремонта";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(608, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 17);
            this.label2.TabIndex = 15;
            this.label2.Text = "Причина поломки";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(608, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "Тип поломки";
            // 
            // txt_TypeFlaut
            // 
            this.txt_TypeFlaut.BackColor = System.Drawing.SystemColors.Info;
            this.txt_TypeFlaut.Enabled = false;
            this.txt_TypeFlaut.Location = new System.Drawing.Point(750, 26);
            this.txt_TypeFlaut.Name = "txt_TypeFlaut";
            this.txt_TypeFlaut.Size = new System.Drawing.Size(210, 23);
            this.txt_TypeFlaut.TabIndex = 13;
            // 
            // txt_dataNext
            // 
            this.txt_dataNext.BackColor = System.Drawing.SystemColors.Info;
            this.txt_dataNext.Enabled = false;
            this.txt_dataNext.Location = new System.Drawing.Point(211, 54);
            this.txt_dataNext.Name = "txt_dataNext";
            this.txt_dataNext.Size = new System.Drawing.Size(354, 23);
            this.txt_dataNext.TabIndex = 12;
            this.txt_dataNext.TextChanged += new System.EventHandler(this.txt_dataNext_TextChanged);
            // 
            // txt_Responsible
            // 
            this.txt_Responsible.BackColor = System.Drawing.SystemColors.Info;
            this.txt_Responsible.Enabled = false;
            this.txt_Responsible.Location = new System.Drawing.Point(211, 25);
            this.txt_Responsible.Name = "txt_Responsible";
            this.txt_Responsible.Size = new System.Drawing.Size(354, 23);
            this.txt_Responsible.TabIndex = 11;
            // 
            // txt_note
            // 
            this.txt_note.BackColor = System.Drawing.SystemColors.Info;
            this.txt_note.Enabled = false;
            this.txt_note.Location = new System.Drawing.Point(211, 117);
            this.txt_note.Name = "txt_note";
            this.txt_note.Size = new System.Drawing.Size(749, 23);
            this.txt_note.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Ответственный";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Дата начала ремонта";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Примечание";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txt_SearchInv);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox5.Location = new System.Drawing.Point(92, 157);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(143, 49);
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
            this.groupBox8.Location = new System.Drawing.Point(241, 157);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(158, 49);
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
            // button3
            // 
            this.button3.ForeColor = System.Drawing.Color.Maroon;
            this.button3.Location = new System.Drawing.Point(241, 217);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(180, 23);
            this.button3.TabIndex = 19;
            this.button3.Text = "Добавить услугу для цеха";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // myfrmGetToRepairs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 537);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_DeleteRep);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.gbx_Repair);
            this.Name = "myfrmGetToRepairs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Отправка в ремонт";
            this.Load += new System.EventHandler(this.myfrmGetToRepairs_Load);
            this.gbx_Repair.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Repair)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbx_Repair;
        private System.Windows.Forms.DataGridView dgv_Repair;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_DeleteRep;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_noteDataNext;
        private System.Windows.Forms.CheckBox cbx_plan;
        private System.Windows.Forms.TextBox txt_Cause;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_TypeFlaut;
        private System.Windows.Forms.TextBox txt_dataNext;
        private System.Windows.Forms.TextBox txt_Responsible;
        private System.Windows.Forms.TextBox txt_note;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox txt_SearchInv;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.TextBox txt_SearchName;
        private System.Windows.Forms.ComboBox cbx_RDiv;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button3;
    }
}