namespace Repairs
{
    partial class myfrmUpdateReplacedPart
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgv_RepPlace = new System.Windows.Forms.DataGridView();
            this.btn_Save = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_RepPlace)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgv_RepPlace);
            this.panel1.Location = new System.Drawing.Point(16, 59);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(882, 337);
            this.panel1.TabIndex = 0;
            // 
            // dgv_RepPlace
            // 
            this.dgv_RepPlace.AllowUserToAddRows = false;
            this.dgv_RepPlace.AllowUserToDeleteRows = false;
            this.dgv_RepPlace.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_RepPlace.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_RepPlace.Location = new System.Drawing.Point(0, 0);
            this.dgv_RepPlace.Name = "dgv_RepPlace";
            this.dgv_RepPlace.ReadOnly = true;
            this.dgv_RepPlace.Size = new System.Drawing.Size(882, 337);
            this.dgv_RepPlace.TabIndex = 0;
            this.dgv_RepPlace.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_RepPlace_CellContentClick);
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(719, 409);
            this.btn_Save.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(179, 38);
            this.btn_Save.TabIndex = 1;
            this.btn_Save.Text = "Сохранить";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 420);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(200, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "цифрами в колонках введите";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(224, 420);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(488, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "1 - норма, 2 - не норма;                            1 - технология; 2 - содержани" +
    "е; ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // myfrmUpdateReplacedPart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 460);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "myfrmUpdateReplacedPart";
            this.Text = "Редактирование запчастей";
            this.Load += new System.EventHandler(this.myfrmUpdateReplacedPart_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_RepPlace)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgv_RepPlace;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;

    }
}