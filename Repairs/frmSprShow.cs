using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Repairs
{
    public partial class frmSprShow : Form
    {
        public string frm;
        private string user_p, user_n;
       /*   public partial class frmSprShow : System.Windows.Forms.Form {
      
       private CLBaseDirectory _BaseDirectory;
        System.Windows.Forms.TextBox _txtBox;
        System.String _nameColumn;//*/
        public frmSprShow(string userp, string usern)
        {
            InitializeComponent();
            user_n = usern;
            user_p = userp;

        }//*/

     /*   protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (Keys.Escape == keyData)
                this.Close();
            else
                if (Keys.Enter == keyData)
                    btnSearch_Click(new Object(), new EventArgs());
            return base.ProcessCmdKey(ref msg, keyData);
        }

                public frmSprShow(CLBaseDirectory BaseDirectory, System.Windows.Forms.TextBox txtBox, System.String nameColumn) {
            InitializeComponent();
            this._BaseDirectory = BaseDirectory;
            this._BaseDirectory.SetFormSize(this);
            this._txtBox = txtBox;
            this._nameColumn = nameColumn;
        }

                private void fmSprShow_Load(object sender, EventArgs e)
                {
                    this.Text = this._BaseDirectory.GetDirectoryName;
                    this.grid.DataSource = this._BaseDirectory.GetSource;
                    this._BaseDirectory.SetSettingsColumns(this.grid);
                }

                #region Выбор нужного цеха



                
            //*/
   /*  private void Choose(TextBox txtBox)
                {
                    if (txtBox.DataBindings.Count > 0)
                        txtBox.DataBindings.Clear();
                    txtBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this._BaseDirectory.GetSource, _nameColumn, true));

                    this.Close();
                }//*/
        private void grid_DoubleClick(object sender, EventArgs e)
        {
          //  Choose();
            if (grid.Rows.Count > 0)
            {

                 try
                    {
                    frmGetToRepair main = this.Owner as frmGetToRepair;
                    main.txtInventoryNumber.Text = grid[0, grid.CurrentRow.Index].Value.ToString();
                    this.Close();
                    }
                 catch { }

                    try
                    {
                        frmPlanRepairs mainp = this.Owner as frmPlanRepairs;
                        mainp.inspectNormDataGridView[0, mainp.inspectNormDataGridView.CurrentRow.Index].Value = grid[0, grid.CurrentRow.Index].Value.ToString();
                        mainp.inspectNormDataGridView[1, mainp.inspectNormDataGridView.CurrentRow.Index].Value = grid[0, grid.CurrentRow.Index].Value.ToString();
                        this.Close();
                    }
                    catch { }


                    try
                    {
                        frmWorkOS mainos = this.Owner as frmWorkOS;
                        mainos.workOSDataGridView[0, mainos.workOSDataGridView.CurrentRow.Index].Value = grid[0, grid.CurrentRow.Index].Value.ToString();
                        mainos.workOSDataGridView[1, mainos.workOSDataGridView.CurrentRow.Index].Value = grid[0, grid.CurrentRow.Index].Value.ToString();
                        this.Close();
                    }
                    catch { }


                    try
                    {
                        frmHatch mainh = this.Owner as frmHatch;
                        try
                        {
                            mainh.hatchDataGridView[1, mainh.hatchDataGridView.CurrentRow.Index].Value = grid[0, grid.CurrentRow.Index].Value.ToString();
                        }
                        catch{ mainh.hatchDataGridView[1, mainh.hatchDataGridView.Rows.Count].Value = grid[0, grid.CurrentRow.Index].Value.ToString(); }
                        this.Close();
                    }
                    catch { }
            }
        }


        private void btnChoose_Click(object sender, EventArgs e)
        {
         //   Choose();
        }
//#endregion

        private void btnSearch_Click(object sender, EventArgs e)
        {
  /*          String str = this.txtSearch.Text.Length == 0 ? null
    : String.Format("CONVERT({0}, 'System.String') LIKE '{1}%'", this._nameColumn, this.txtSearch.Text);
            this._BaseDirectory.GetSource.Filter = str;//*/
        }

        private void frmSprShow_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "repairOSDS.SprOS". При необходимости она может быть перемещена или удалена.

          /*  if ((user_p == "3" || user_p == "4") || user_n == "14")
            {
                this.sprOSTableAdapter.Fill(this.repairOSDS.SprOS);
            }
            else
                if (user_p == "1" || user_p == "2" || user_p == "5")
                {
                    this.sprOSTableAdapter.FillByStorId(this.repairOSDS.SprOS, int.Parse(user_n));
                } //*/

            //this.sprOSTableAdapter.Fill(this.repairOSDS.SprOS);
            toolStripComboBox1.SelectedText = "Всі";

      
               
                if (user_n != "")
                {
                    this.sprOSTableAdapter.FillByStorId(this.repairOSDS.SprOS, int.Parse(user_n));
                }
                else
                { 
                    
                    
                    this.sprOSTableAdapter.Fill(this.repairOSDS.SprOS);}
            
        }


        private void GridSearch(string text, DataGridView grid, int column_num)
        {

            for (int i = 0; i < grid.RowCount; i++)
                if (grid[column_num, i].FormattedValue.ToString().
                    Contains(text.Trim()))
                {
                    grid.CurrentCell = grid[column_num, i];
                    return;
                }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text != "")
            {
                GridSearch(txtSearch.Text, grid, 0);

            }
        }

        private void toolStripComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (toolStripComboBox1.SelectedIndex == 0)
            {
                if ((user_p == "3" || user_p == "4") || user_n == "14")
                {
                    this.sprOSTableAdapter.Fill(this.repairOSDS.SprOS);
                }
                else
                    if (user_p == "1" || user_p == "2" || user_p == "5")
                    {
                        this.sprOSTableAdapter.FillByStorId(this.repairOSDS.SprOS, int.Parse(user_n));
                    }
            }
            if (toolStripComboBox1.SelectedIndex == 1)
            {
                this.sprOSTableAdapter.FillByHatch(this.repairOSDS.SprOS);
            }
        }


    }
}
