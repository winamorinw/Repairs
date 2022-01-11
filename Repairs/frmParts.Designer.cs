namespace Repairs
{
    partial class frmParts
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
            this.refPartBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.repairOSDS = new Repairs.RepairOSDS();
            this.refPartTableAdapter = new Repairs.RepairOSDSTableAdapters.RefPartTableAdapter();
            this.tableAdapterManager = new Repairs.RepairOSDSTableAdapters.TableAdapterManager();
            this.refPartDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.refPartBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repairOSDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.refPartDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // refPartBindingSource
            // 
            this.refPartBindingSource.DataMember = "RefPart";
            this.refPartBindingSource.DataSource = this.repairOSDS;
            // 
            // repairOSDS
            // 
            this.repairOSDS.DataSetName = "RepairOSDS";
            this.repairOSDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // refPartTableAdapter
            // 
            this.refPartTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.InspectNormTableAdapter = null;
            this.tableAdapterManager.JobTableAdapter = null;
            this.tableAdapterManager.PlacePartTableAdapter = null;
            this.tableAdapterManager.PlanJobTableAdapter = null;
            this.tableAdapterManager.PlotTableAdapter = null;
            this.tableAdapterManager.RefJobTableAdapter = null;
            this.tableAdapterManager.RefPartTableAdapter = this.refPartTableAdapter;
            this.tableAdapterManager.RefPlaceTableAdapter = null;
            this.tableAdapterManager.RepairTableAdapter = null;
            this.tableAdapterManager.ReplacedPartTableAdapter = null;
            this.tableAdapterManager.sprDivisionTableAdapter = null;
            this.tableAdapterManager.SprOSGroupTableAdapter = null;
            this.tableAdapterManager.SprOSTableAdapter = null;
            this.tableAdapterManager.sprRepairDivisionTableAdapter = null;
            this.tableAdapterManager.SprUserTableAdapter = null;
            this.tableAdapterManager.StoreTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Repairs.RepairOSDSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Users_listTableAdapter = null;
            this.tableAdapterManager.WorkOSTableAdapter = null;
            // 
            // refPartDataGridView
            // 
            this.refPartDataGridView.AllowUserToAddRows = false;
            this.refPartDataGridView.AllowUserToDeleteRows = false;
            this.refPartDataGridView.AutoGenerateColumns = false;
            this.refPartDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.refPartDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.refPartDataGridView.DataSource = this.refPartBindingSource;
            this.refPartDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.refPartDataGridView.Location = new System.Drawing.Point(0, 0);
            this.refPartDataGridView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.refPartDataGridView.Name = "refPartDataGridView";
            this.refPartDataGridView.ReadOnly = true;
            this.refPartDataGridView.Size = new System.Drawing.Size(433, 354);
            this.refPartDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "PartId";
            this.dataGridViewTextBoxColumn1.HeaderText = "Инв. №";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "PartName";
            this.dataGridViewTextBoxColumn2.HeaderText = "Наименование";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "EdIzm";
            this.dataGridViewTextBoxColumn3.HeaderText = "Ед. изм.";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // frmParts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 354);
            this.Controls.Add(this.refPartDataGridView);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmParts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Справочник запчастей";
            this.Load += new System.EventHandler(this.frmParts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.refPartBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repairOSDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.refPartDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private RepairOSDS repairOSDS;
        private System.Windows.Forms.BindingSource refPartBindingSource;
        private RepairOSDSTableAdapters.RefPartTableAdapter refPartTableAdapter;
        private RepairOSDSTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView refPartDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;






    }
}