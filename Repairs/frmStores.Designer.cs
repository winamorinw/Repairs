namespace Repairs
{
    partial class frmStores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStores));
            this.repairOSDS = new Repairs.RepairOSDS();
            this.storeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.storeTableAdapter = new Repairs.RepairOSDSTableAdapters.StoreTableAdapter();
            this.tableAdapterManager = new Repairs.RepairOSDSTableAdapters.TableAdapterManager();
            this.storeBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.storeBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.storeDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.repairOSDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.storeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.storeBindingNavigator)).BeginInit();
            this.storeBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.storeDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // repairOSDS
            // 
            this.repairOSDS.DataSetName = "RepairOSDS";
            this.repairOSDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // storeBindingSource
            // 
            this.storeBindingSource.DataMember = "Store";
            this.storeBindingSource.DataSource = this.repairOSDS;
            // 
            // storeTableAdapter
            // 
            this.storeTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.RefPartTableAdapter = null;
            this.tableAdapterManager.RefPlaceTableAdapter = null;
            this.tableAdapterManager.RepairTableAdapter = null;
            this.tableAdapterManager.ReplacedPartTableAdapter = null;
            this.tableAdapterManager.sprDivisionTableAdapter = null;
            this.tableAdapterManager.SprOSGroupTableAdapter = null;
            this.tableAdapterManager.SprOSTableAdapter = null;
            this.tableAdapterManager.sprRepairDivisionTableAdapter = null;
            this.tableAdapterManager.SprUserTableAdapter = null;
            this.tableAdapterManager.StoreTableAdapter = this.storeTableAdapter;
            this.tableAdapterManager.UpdateOrder = Repairs.RepairOSDSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Users_listTableAdapter = null;
            this.tableAdapterManager.WorkOSTableAdapter = null;
            // 
            // storeBindingNavigator
            // 
            this.storeBindingNavigator.AddNewItem = null;
            this.storeBindingNavigator.BindingSource = this.storeBindingSource;
            this.storeBindingNavigator.CountItem = null;
            this.storeBindingNavigator.DeleteItem = null;
            this.storeBindingNavigator.ImageScalingSize = new System.Drawing.Size(30, 30);
            this.storeBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.storeBindingNavigatorSaveItem});
            this.storeBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.storeBindingNavigator.MoveFirstItem = null;
            this.storeBindingNavigator.MoveLastItem = null;
            this.storeBindingNavigator.MoveNextItem = null;
            this.storeBindingNavigator.MovePreviousItem = null;
            this.storeBindingNavigator.Name = "storeBindingNavigator";
            this.storeBindingNavigator.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.storeBindingNavigator.PositionItem = null;
            this.storeBindingNavigator.Size = new System.Drawing.Size(465, 37);
            this.storeBindingNavigator.TabIndex = 0;
            this.storeBindingNavigator.Text = "bindingNavigator1";
            // 
            // storeBindingNavigatorSaveItem
            // 
            this.storeBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.storeBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("storeBindingNavigatorSaveItem.Image")));
            this.storeBindingNavigatorSaveItem.Name = "storeBindingNavigatorSaveItem";
            this.storeBindingNavigatorSaveItem.Size = new System.Drawing.Size(34, 34);
            this.storeBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.storeBindingNavigatorSaveItem.Click += new System.EventHandler(this.storeBindingNavigatorSaveItem_Click);
            // 
            // storeDataGridView
            // 
            this.storeDataGridView.AllowUserToAddRows = false;
            this.storeDataGridView.AllowUserToDeleteRows = false;
            this.storeDataGridView.AutoGenerateColumns = false;
            this.storeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.storeDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewCheckBoxColumn1});
            this.storeDataGridView.DataSource = this.storeBindingSource;
            this.storeDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.storeDataGridView.Location = new System.Drawing.Point(0, 37);
            this.storeDataGridView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.storeDataGridView.Name = "storeDataGridView";
            this.storeDataGridView.Size = new System.Drawing.Size(465, 363);
            this.storeDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "StoreID";
            this.dataGridViewTextBoxColumn1.HeaderText = "№ цеха";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 48;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "StoreName";
            this.dataGridViewTextBoxColumn2.HeaderText = "Название";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "Repair";
            this.dataGridViewCheckBoxColumn1.HeaderText = "Ремонтный";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            // 
            // frmStores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 400);
            this.Controls.Add(this.storeDataGridView);
            this.Controls.Add(this.storeBindingNavigator);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmStores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Справочник цехов";
            this.Load += new System.EventHandler(this.frmStores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.repairOSDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.storeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.storeBindingNavigator)).EndInit();
            this.storeBindingNavigator.ResumeLayout(false);
            this.storeBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.storeDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RepairOSDS repairOSDS;
        private System.Windows.Forms.BindingSource storeBindingSource;
        private RepairOSDSTableAdapters.StoreTableAdapter storeTableAdapter;
        private RepairOSDSTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator storeBindingNavigator;
        private System.Windows.Forms.ToolStripButton storeBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView storeDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
    }
}