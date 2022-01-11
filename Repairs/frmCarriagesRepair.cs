/* Changelog
 * 
 * Переписал конструктор формы. Передача прав/цеха происходит через конструктор.
 * Переписал gridJob_CurrentCellChanged
 * В frmCarriagesRepair_Load добавил вывод данных для админа. Соответственно добавил запросы в repairTableTableAdapter и  repairTableAdapter.
 * 
 */

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
    public partial class frmCarriagesRepair : Form
    {
        private string user_n, user_p, dostup_tmc_, cod_cx, cod_uth, cod_brig, cod_det;
        public string inv;
        public DateTime dat = DateTime.Now.Date;
        /// <summary>
        /// Конструктор формы.
        /// </summary>
        /// <param name="usern">Цех</param>
        /// <param name="userp">Права</param>
        /// <param name="theparent">Родительская форма</param>
        public frmCarriagesRepair(string usern, string userp, string dostup_tmc, string codcx, string coduth, string codbrig, string coddet)
        {
            InitializeComponent();

            this.refJobTableAdapter.Fill(this.repairOSDS.RefJob);
            user_n = usern;
            user_p = userp;
            dostup_tmc_ = dostup_tmc;
            cod_cx = codcx;
            cod_uth = coduth;
            cod_brig = codbrig; 
            cod_det = coddet;






            
            //MessageBox.Show("asdasd");

            //MessageBox.Show(dostup_tmc + " " + codcx + " " + coduth + " " + codbrig + " " + coddet);


            //добавление праметров авторизации

            datpBeg.Value = Convert.ToDateTime("01." + DateTime.Now.Month.ToString() + "." + DateTime.Now.Year.ToString());
            datpEnd.Value = dat;
        }

        private void btnShowCarriagesInR_Click(object sender, EventArgs e)
        {
            frmReport fm = new frmReport("carriagesrepair", user_p, user_n, dostup_tmc_, cod_cx, cod_uth, cod_brig, cod_det);
            /*fm.frm = "carriagesrepair";
            fm.user_p = user_p;*/
            if (user_p != "3")
            { fm.store_id = Convert.ToInt32(user_n); }
            fm.ShowDialog();
        }



        private void frmCarriagesRepair_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "repairOSDS.PlacePart". При необходимости она может быть перемещена или удалена.
            //     this.placePartTableAdapter.Fill(this.repairOSDS.PlacePart);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "repairOSDS.PlacePart". При необходимости она может быть перемещена или удалена.
            //     this.placePartTableAdapter.Fill(this.repairOSDS.PlacePart);

        
            if (user_p == "3")
            {
                btnRepair.Enabled = false;
                datpDateEndRepair.Enabled = false;
                txtTypeFlaut.ReadOnly = true;
                txtCause.ReadOnly = true;
                txtResponsible.ReadOnly = true;
                txtNote.ReadOnly = true;
                ts.Enabled = false;
                toolStrip2.Enabled = false;
                tsPlacePart.Enabled = false;
                cbxRefJob.Enabled = false;
                cbxRefPart.Enabled = false;
                cbxRefPlace.Enabled = false;
                textBox1.ReadOnly = true;
            }
       //     datpBeg.Value = Convert.ToDateTime("01." + DateTime.Now.Month.ToString() + "." + DateTime.Now.Year.ToString());
            if (user_p == "3")
            {
                this.repairTableTableAdapter.FillByd1d2(this.repairOSDS.RepairTable, datpBeg.Value, datpEnd.Value);
            }
            else
                if (user_p == "4")//админ
                {
                    this.repairTableTableAdapter.FillByAdmin(this.repairOSDS.RepairTable, datpBeg.Value.Date, datpEnd.Value.Date);
                    // TODO: данная строка кода позволяет загрузить данные в таблицу "repairOSDS.Repair". При необходимости она может быть перемещена или удалена.
                    this.repairTableAdapter.FillByAdmin(this.repairOSDS.Repair, datpBeg.Value.Date, datpEnd.Value.Date);
                    // TODO: данная строка кода позволяет загрузить данные в таблицу "repairOSDS.RepairTable". При необходимости она может быть перемещена или удалена.                    
                }
                else
                {
                    this.repairTableTableAdapter.FillByRDivision(this.repairOSDS.RepairTable, Convert.ToInt32(user_n), datpBeg.Value, datpEnd.Value);
                    // TODO: данная строка кода позволяет загрузить данные в таблицу "repairOSDS.Repair". При необходимости она может быть перемещена или удалена.
                    this.repairTableAdapter.FillByRDivision(this.repairOSDS.Repair, Convert.ToInt32(user_n), datpBeg.Value.ToShortDateString().ToString(), datpEnd.Value.ToShortDateString().ToString());
                    // TODO: данная строка кода позволяет загрузить данные в таблицу "repairOSDS.RepairTable". При необходимости она может быть перемещена или удалена.
                }
            // TODO: данная строка кода позволяет загрузить данные в таблицу "repairOSDS.RefPlace". При необходимости она может быть перемещена или удалена.
            this.refPlaceTableAdapter.Fill(this.repairOSDS.RefPlace);
            this.refPartTableAdapter.Fill(this.repairOSDS.RefPart);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "repairOSDS.ReplacedPart". При необходимости она может быть перемещена или удалена.
            // this.replacedPartTableAdapter.Fill(this.repairOSDS.ReplacedPart);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "repairOSDS.ReplacePartTable". При необходимости она может быть перемещена или удалена.
            //     this.replacePartTableTableAdapter.Fill(this.repairOSDS.ReplacePartTable);

            // TODO: данная строка кода позволяет загрузить данные в таблицу "repairOSDS.PlacePart". При необходимости она может быть перемещена или удалена.
            //       this.placePartTableAdapter.Fill(this.repairOSDS.PlacePart);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "repairOSDS.PlacePart". При необходимости она может быть перемещена или удалена.
            //  this.placePartTableAdapter.Fill(this.repairOSDS.PlacePart);




            // TODO: данная строка кода позволяет загрузить данные в таблицу "repairOSDS.Job". При необходимости она может быть перемещена или удалена.
            //   this.jobTableAdapter.Fill(this.repairOSDS.Job);
            //  this.jobTableTableAdapter.Fill(this.repairOSDS.JobTable, Convert.ToInt32(gridCarriages[0, gridCarriages.CurrentRow.Index].Value));



            // TODO: данная строка кода позволяет загрузить данные в таблицу "repairOSDS.RefPart". При необходимости она может быть перемещена или удалена.


            // TODO: данная строка кода позволяет загрузить данные в таблицу "repairOSDS.ReplacedPart". При необходимости она может быть перемещена или удалена.
            //     this.replacedPartTableAdapter.Fill(this.repairOSDS.ReplacedPart);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "repairOSDS.ReplacePartTable". При необходимости она может быть перемещена или удалена.
            //       this.replacePartTableTableAdapter.Fill(this.repairOSDS.ReplacePartTable);



            // TODO: данная строка кода позволяет загрузить данные в таблицу "repairOSDS.RefJob". При необходимости она может быть перемещена или удалена.
            this.refJobTableAdapter.Fill(this.repairOSDS.RefJob);

        /*    if (inv != "")
            {
                datpBeg.Value = Convert.ToDateTime("01." + DateTime.Now.Month.ToString() + "." + DateTime.Now.Year.ToString())
                datpEnd.Value = dat;
                GridSearch(inv, gridCarriages, 1); }*/
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

        private void btnDateEndRepair_Click(object sender, EventArgs e)
        {
            try
            {
                int curr = gridCarriages.CurrentRow.Index;
                this.repairTableAdapter.UpdateQueryDateOut(Convert.ToInt32(user_n), (datpDateEndRepair.Value.ToShortDateString()).ToString(), txtTypeFlaut.Text, txtCause.Text, txtResponsible.Text, txtNote.Text, Convert.ToInt32(gridCarriages[0, gridCarriages.CurrentRow.Index].Value));
                this.repairTableTableAdapter.FillByRDivision(this.repairOSDS.RepairTable, Convert.ToInt32(user_n), datpBeg.Value, datpEnd.Value);
                gridCarriages.CurrentCell = gridCarriages[1, curr];
                MessageBox.Show("дані записані в базу");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void datpBeg_ValueChanged(object sender, EventArgs e)
        {
            if (user_p == "3")
            {
                this.repairTableTableAdapter.FillByd1d2(this.repairOSDS.RepairTable, datpBeg.Value, datpEnd.Value);
            }
            else
                if (user_p == "4")//админ
                {
                    this.repairTableTableAdapter.FillByAdmin(this.repairOSDS.RepairTable, datpBeg.Value.Date, datpEnd.Value.Date);
                }
                else
                {
                    this.repairTableTableAdapter.FillByRDivision(this.repairOSDS.RepairTable, Convert.ToInt32(user_n), datpBeg.Value, datpEnd.Value);
                }
          
        }

        private void btnAddJob_Click(object sender, EventArgs e)
        {
            this.jobTableAdapter.InsertQuery(Convert.ToInt32(gridCarriages[0, gridCarriages.CurrentRow.Index].Value), Convert.ToInt16(cbxRefJob.SelectedValue));
            // TODO: данная строка кода позволяет загрузить данные в таблицу "repairOSDS.JobTable". При необходимости она может быть перемещена или удалена.
            this.jobTableTableAdapter.Fill(this.repairOSDS.JobTable, Convert.ToInt32(gridCarriages[0, gridCarriages.CurrentRow.Index].Value));
        }

        private void gridCarriages_CurrentCellChanged(object sender, EventArgs e)
        {
            if (gridCarriages.CurrentRow != null)
            //(gridCarriages.Rows.Count > 0)
            {
                try
                {
                    this.jobTableTableAdapter.Fill(this.repairOSDS.JobTable, Convert.ToInt32(gridCarriages[0, gridCarriages.CurrentRow.Index].Value));
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                try
                {
                    this.jobTableTableAdapter.Fill(this.repairOSDS.JobTable, 0);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnDeleteJob_Click(object sender, EventArgs e)
        {
            this.jobTableAdapter.DeleteQuery(Convert.ToInt32(gridJob[0, gridJob.CurrentRow.Index].Value));
            // TODO: данная строка кода позволяет загрузить данные в таблицу "repairOSDS.JobTable". При необходимости она может быть перемещена или удалена.
            this.jobTableTableAdapter.Fill(this.repairOSDS.JobTable, Convert.ToInt32(gridCarriages[0, gridCarriages.CurrentRow.Index].Value));
        }

        private void gridJob_CurrentCellChanged(object sender, EventArgs e)
        {
            if (gridJob.CurrentRow != null)
            //(gridCarriages.Rows.Count > 0)
            {
                try
                {
                    this.replacedPartTableAdapter.FillBy(this.repairOSDS.ReplacedPart, Convert.ToInt32(gridJob[0, gridJob.CurrentRow.Index].Value));
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                try
                {
                    this.replacedPartTableAdapter.FillBy(this.repairOSDS.ReplacedPart, 0);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            
            /*if (gridJob.CurrentRow != null)
                // if (gridJob.Rows.Count > 0)
           // {
            try
            {
                this.replacedPartTableAdapter.FillBy(this.repairOSDS.ReplacedPart, Convert.ToInt32(gridJob[0, gridJob.CurrentRow.Index].Value));
            }
            catch
            {
                this.replacedPartTableAdapter.FillBy(this.repairOSDS.ReplacedPart, 0);
            }
            // }*/
        }

        private void btnAddPart_Click(object sender, EventArgs e)
        {
            this.replacedPartTableAdapter.InsertQuery(Convert.ToInt32(gridJob[0, gridJob.CurrentRow.Index].Value), cbxRefPart.SelectedValue.ToString(), Convert.ToDecimal(textBox1.Text));
            // TODO: данная строка кода позволяет загрузить данные в таблицу "repairOSDS.ReplacePartTable". При необходимости она может быть перемещена или удалена.
            this.replacedPartTableAdapter.FillBy(this.repairOSDS.ReplacedPart, Convert.ToInt32(gridJob[0, gridJob.CurrentRow.Index].Value));
        }

        private void btnDeletePart_Click(object sender, EventArgs e)
        {
            this.replacedPartTableAdapter.DeleteQuery(Convert.ToInt16(gridReplacedPart[0, gridReplacedPart.CurrentRow.Index].Value));
            // TODO: данная строка кода позволяет загрузить данные в таблицу "repairOSDS.ReplacePartTable". При необходимости она может быть перемещена или удалена.
            this.replacedPartTableAdapter.FillBy(this.repairOSDS.ReplacedPart, Convert.ToInt32(gridJob[0, gridJob.CurrentRow.Index].Value));
        }

        private void gridReplacedPart_CurrentCellChanged(object sender, EventArgs e)
        {
            try
            {
                this.placePartTableAdapter.FillBy(this.repairOSDS.PlacePart, Convert.ToInt32(gridReplacedPart[0, gridReplacedPart.CurrentRow.Index].Value));
            }
            catch
            {
                try
                {
                    this.placePartTableAdapter.FillBy(this.repairOSDS.PlacePart, 0);
                }
                catch { }
            }
        }

        private void tsbPlacePartAdd_Click(object sender, EventArgs e)
        {
            if (gridReplacedPart.Rows.Count > 0)
            {
                if (Convert.ToInt32(gridReplacedPart[3, gridReplacedPart.CurrentRow.Index].Value) > placePartDataGridView.Rows.Count)
                {
                    this.placePartTableAdapter.InsertQuery(Convert.ToInt32(cbxRefPlace.SelectedValue), Convert.ToInt32(gridReplacedPart[0, gridReplacedPart.CurrentRow.Index].Value), gridReplacedPart[2, gridReplacedPart.CurrentRow.Index].Value.ToString());
                    this.placePartTableAdapter.FillBy(this.repairOSDS.PlacePart, Convert.ToInt32(gridReplacedPart[0, gridReplacedPart.CurrentRow.Index].Value));
                }
                else
                {
                    MessageBox.Show("Кількість місць установки не може перевищувати кількості встановлених деталей!");
                    

                    return;
                }
            }
        }

        private void tsbPlasePartDell_Click(object sender, EventArgs e)
        {
            this.placePartTableAdapter.DeleteQuery(Convert.ToInt32(placePartDataGridView[0, placePartDataGridView.CurrentRow.Index].Value), Convert.ToInt32(placePartDataGridView[1, placePartDataGridView.CurrentRow.Index].Value), placePartDataGridView[2, placePartDataGridView.CurrentRow.Index].Value.ToString(), Convert.ToInt32(placePartDataGridView[3, placePartDataGridView.CurrentRow.Index].Value));
            this.placePartTableAdapter.FillBy(this.repairOSDS.PlacePart, Convert.ToInt32(gridReplacedPart[0, gridReplacedPart.CurrentRow.Index].Value));
        }

        private void cbxRefPart_TextChanged(object sender, EventArgs e)
        {
        }

        private void cbxRefPart_TextUpdate(object sender, EventArgs e)
        {
            string text = cbxRefPart.Text;
            refPartBindingSource.Filter = "PartName LIKE '%" + text + "%'"; //это действие изменяет свойство Text, т. е. затирает то что было введено юзером
            cbxRefPart.Text = text; //тут восстанавливаем последствия предыдущей строки
            cbxRefPart.SelectionStart = text.Length;
        }

        private void cbxRefPart_DropDown(object sender, EventArgs e)
        {
            cbxRefPart.DropDownWidth = 500;
        }

        private void cbxRefPart_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void cbxRefPart_KeyUp(object sender, KeyEventArgs e)
        {
        }

        private void cbxRefPart_KeyPress(object sender, KeyPressEventArgs e)
        {
            cbxRefPart.DroppedDown = true;
            Cursor.Current = Cursors.Default;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cbxRefPart_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DataRowView drw = refPartBindingSource.Current as DataRowView;
                lblEdizm.Text = drw["EdIzm"].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.repairTableTableAdapter.FillBy(this.repairOSDS.RepairTable);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}