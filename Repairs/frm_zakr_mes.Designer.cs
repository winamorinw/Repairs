namespace Repairs
{
    partial class frm_zakr_mes
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle37 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle38 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle39 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle40 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.storeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.storeNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.godDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataTable2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabl = new Repairs.tabl();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dataTable2TableAdapter = new Repairs.tablTableAdapters.DataTable2TableAdapter();
            this.button4 = new System.Windows.Forms.Button();
            this.dgvMol = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMol)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(23, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Вибраний рік:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(126, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "label2";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(26, 35);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.storeIDDataGridViewTextBoxColumn,
            this.storeNameDataGridViewTextBoxColumn,
            this.godDataGridViewTextBoxColumn,
            this.mes});
            this.dataGridView1.DataSource = this.dataTable2BindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 69);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(607, 504);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEndEdit);
            this.dataGridView1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEnter);
            // 
            // storeIDDataGridViewTextBoxColumn
            // 
            this.storeIDDataGridViewTextBoxColumn.DataPropertyName = "StoreID";
            dataGridViewCellStyle37.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.storeIDDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle37;
            this.storeIDDataGridViewTextBoxColumn.HeaderText = "Код Цеху";
            this.storeIDDataGridViewTextBoxColumn.Name = "storeIDDataGridViewTextBoxColumn";
            this.storeIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.storeIDDataGridViewTextBoxColumn.Width = 50;
            // 
            // storeNameDataGridViewTextBoxColumn
            // 
            this.storeNameDataGridViewTextBoxColumn.DataPropertyName = "StoreName";
            dataGridViewCellStyle38.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.storeNameDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle38;
            this.storeNameDataGridViewTextBoxColumn.HeaderText = "Назва";
            this.storeNameDataGridViewTextBoxColumn.Name = "storeNameDataGridViewTextBoxColumn";
            this.storeNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.storeNameDataGridViewTextBoxColumn.Width = 350;
            // 
            // godDataGridViewTextBoxColumn
            // 
            this.godDataGridViewTextBoxColumn.DataPropertyName = "god";
            dataGridViewCellStyle39.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.godDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle39;
            this.godDataGridViewTextBoxColumn.HeaderText = "Робочий рік";
            this.godDataGridViewTextBoxColumn.Name = "godDataGridViewTextBoxColumn";
            this.godDataGridViewTextBoxColumn.ReadOnly = true;
            this.godDataGridViewTextBoxColumn.Width = 80;
            // 
            // mes
            // 
            this.mes.DataPropertyName = "mes";
            dataGridViewCellStyle40.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.mes.DefaultCellStyle = dataGridViewCellStyle40;
            this.mes.HeaderText = "Робочий місяць";
            this.mes.Name = "mes";
            this.mes.ReadOnly = true;
            this.mes.Width = 80;
            // 
            // dataTable2BindingSource
            // 
            this.dataTable2BindingSource.DataMember = "DataTable2";
            this.dataTable2BindingSource.DataSource = this.tabl;
            // 
            // tabl
            // 
            this.tabl.DataSetName = "tabl";
            this.tabl.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(527, 30);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(159, 33);
            this.button2.TabIndex = 7;
            this.button2.Text = "Закрити поточний місяць";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(362, 30);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(159, 33);
            this.button3.TabIndex = 8;
            this.button3.Text = "Відкрити попередній місяць";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dataTable2TableAdapter
            // 
            this.dataTable2TableAdapter.ClearBeforeFill = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(199, 30);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(151, 33);
            this.button4.TabIndex = 9;
            this.button4.Text = "Оновлення МОЛов";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Visible = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // dgvMol
            // 
            this.dgvMol.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMol.Location = new System.Drawing.Point(623, 106);
            this.dgvMol.MultiSelect = false;
            this.dgvMol.Name = "dgvMol";
            this.dgvMol.Size = new System.Drawing.Size(488, 467);
            this.dgvMol.TabIndex = 10;
            this.dgvMol.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMol_CellValueChanged);
            this.dgvMol.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMol_CellValueChanged);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(1076, 12);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(15, 12);
            this.dataGridView2.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(641, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(384, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Заборонити МОЛам вносити матеріали в робочому місяці";
            // 
            // frm_zakr_mes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1123, 578);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dgvMol);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frm_zakr_mes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Закриття місяців";
            this.Load += new System.EventHandler(this.frm_zakr_mes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMol)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource dataTable2BindingSource;
        private tabl tabl;
        private tablTableAdapters.DataTable2TableAdapter dataTable2TableAdapter;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridViewTextBoxColumn storeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn storeNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn godDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mes;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView dgvMol;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label3;
    }
}