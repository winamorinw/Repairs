namespace Repairs
{
    partial class frmOS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOS));
            this.repairOSDS = new Repairs.RepairOSDS();
            this.sprOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sprOSTableAdapter = new Repairs.RepairOSDSTableAdapters.SprOSTableAdapter();
            this.tableAdapterManager = new Repairs.RepairOSDSTableAdapters.TableAdapterManager();
            this.sprOSGroupTableAdapter = new Repairs.RepairOSDSTableAdapters.SprOSGroupTableAdapter();
            this.storeTableAdapter = new Repairs.RepairOSDSTableAdapters.StoreTableAdapter();
            this.sprOSBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.sprOSBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.sprOSDataGridView = new System.Windows.Forms.DataGridView();
            this.storeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sprOSGroupBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Hours_Beg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.repairOSDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sprOSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sprOSBindingNavigator)).BeginInit();
            this.sprOSBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sprOSDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.storeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sprOSGroupBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // repairOSDS
            // 
            this.repairOSDS.DataSetName = "RepairOSDS";
            this.repairOSDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sprOSBindingSource
            // 
            this.sprOSBindingSource.DataMember = "SprOS";
            this.sprOSBindingSource.DataSource = this.repairOSDS;
            // 
            // sprOSTableAdapter
            // 
            this.sprOSTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.SprOSGroupTableAdapter = this.sprOSGroupTableAdapter;
            this.tableAdapterManager.SprOSTableAdapter = this.sprOSTableAdapter;
            this.tableAdapterManager.sprRepairDivisionTableAdapter = null;
            this.tableAdapterManager.SprUserTableAdapter = null;
            this.tableAdapterManager.StoreTableAdapter = this.storeTableAdapter;
            this.tableAdapterManager.UpdateOrder = Repairs.RepairOSDSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Users_listTableAdapter = null;
            this.tableAdapterManager.WorkOSTableAdapter = null;
            // 
            // sprOSGroupTableAdapter
            // 
            this.sprOSGroupTableAdapter.ClearBeforeFill = true;
            // 
            // storeTableAdapter
            // 
            this.storeTableAdapter.ClearBeforeFill = true;
            // 
            // sprOSBindingNavigator
            // 
            this.sprOSBindingNavigator.AddNewItem = null;
            this.sprOSBindingNavigator.BindingSource = this.sprOSBindingSource;
            this.sprOSBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.sprOSBindingNavigator.DeleteItem = null;
            this.sprOSBindingNavigator.ImageScalingSize = new System.Drawing.Size(30, 30);
            this.sprOSBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.sprOSBindingNavigatorSaveItem});
            this.sprOSBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.sprOSBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.sprOSBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.sprOSBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.sprOSBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.sprOSBindingNavigator.Name = "sprOSBindingNavigator";
            this.sprOSBindingNavigator.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.sprOSBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.sprOSBindingNavigator.Size = new System.Drawing.Size(1007, 37);
            this.sprOSBindingNavigator.TabIndex = 0;
            this.sprOSBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 54);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(34, 34);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(34, 54);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 57);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(73, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 57);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(34, 54);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(34, 54);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 57);
            // 
            // sprOSBindingNavigatorSaveItem
            // 
            this.sprOSBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.sprOSBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("sprOSBindingNavigatorSaveItem.Image")));
            this.sprOSBindingNavigatorSaveItem.Name = "sprOSBindingNavigatorSaveItem";
            this.sprOSBindingNavigatorSaveItem.Size = new System.Drawing.Size(34, 54);
            this.sprOSBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.sprOSBindingNavigatorSaveItem.Click += new System.EventHandler(this.sprOSBindingNavigatorSaveItem_Click);
            // 
            // sprOSDataGridView
            // 
            this.sprOSDataGridView.AllowUserToAddRows = false;
            this.sprOSDataGridView.AllowUserToDeleteRows = false;
            this.sprOSDataGridView.AutoGenerateColumns = false;
            this.sprOSDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sprOSDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewCheckBoxColumn1,
            this.Hours_Beg});
            this.sprOSDataGridView.DataSource = this.sprOSBindingSource;
            this.sprOSDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sprOSDataGridView.Location = new System.Drawing.Point(0, 37);
            this.sprOSDataGridView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.sprOSDataGridView.Name = "sprOSDataGridView";
            this.sprOSDataGridView.Size = new System.Drawing.Size(1007, 359);
            this.sprOSDataGridView.TabIndex = 1;
            // 
            // storeBindingSource
            // 
            this.storeBindingSource.DataMember = "Store";
            this.storeBindingSource.DataSource = this.repairOSDS;
            // 
            // sprOSGroupBindingSource
            // 
            this.sprOSGroupBindingSource.DataMember = "SprOSGroup";
            this.sprOSGroupBindingSource.DataSource = this.repairOSDS;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "InventoryNumber";
            this.dataGridViewTextBoxColumn1.HeaderText = "Инв. №";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 86;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Наименование";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "StoreId";
            this.dataGridViewTextBoxColumn3.DataSource = this.storeBindingSource;
            this.dataGridViewTextBoxColumn3.DisplayMember = "StoreName";
            this.dataGridViewTextBoxColumn3.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.dataGridViewTextBoxColumn3.HeaderText = "Цех";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn3.ValueMember = "StoreID";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "DateBeg";
            this.dataGridViewTextBoxColumn4.HeaderText = "Дата ввода в эксплуатацию";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 120;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "DateEnd";
            this.dataGridViewTextBoxColumn5.HeaderText = "Дата списания";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn6.DataPropertyName = "GroupOSCode";
            this.dataGridViewTextBoxColumn6.DataSource = this.sprOSGroupBindingSource;
            this.dataGridViewTextBoxColumn6.DisplayMember = "GroupOSName";
            this.dataGridViewTextBoxColumn6.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.dataGridViewTextBoxColumn6.HeaderText = "Группа";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn6.ValueMember = "GroupOSCode";
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "Flag";
            this.dataGridViewCheckBoxColumn1.HeaderText = "Для отчётности";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            // 
            // Hours_Beg
            // 
            this.Hours_Beg.DataPropertyName = "Hours_Beg";
            this.Hours_Beg.HeaderText = "Нач. знач. отраб. часов";
            this.Hours_Beg.Name = "Hours_Beg";
            this.Hours_Beg.Width = 140;
            // 
            // frmOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 396);
            this.Controls.Add(this.sprOSDataGridView);
            this.Controls.Add(this.sprOSBindingNavigator);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmOS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Справочник основных средств";
            this.Load += new System.EventHandler(this.frmOS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.repairOSDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sprOSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sprOSBindingNavigator)).EndInit();
            this.sprOSBindingNavigator.ResumeLayout(false);
            this.sprOSBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sprOSDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.storeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sprOSGroupBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RepairOSDS repairOSDS;
        private System.Windows.Forms.BindingSource sprOSBindingSource;
        private RepairOSDSTableAdapters.SprOSTableAdapter sprOSTableAdapter;
        private RepairOSDSTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator sprOSBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton sprOSBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView sprOSDataGridView;
        private RepairOSDSTableAdapters.StoreTableAdapter storeTableAdapter;
        private System.Windows.Forms.BindingSource storeBindingSource;
        private RepairOSDSTableAdapters.SprOSGroupTableAdapter sprOSGroupTableAdapter;
        private System.Windows.Forms.BindingSource sprOSGroupBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hours_Beg;





    }
}