using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Repairs
{
    public partial class frmMap : Form
    {
        SqlConnection cn = new SqlConnection();
        bool pan = false;
        public frmMap()
        {
            InitializeComponent();
            cn.ConnectionString = Repairs.Properties.Settings.Default.RepairOSConnStr;

        }

   



        private void button2_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(comboBox3.SelectedValue) == Convert.ToInt32(comboBox2.SelectedValue))
            { MessageBox.Show("Виберіть інше значення!"); return; }
             int m_h = 65, m_w = 100;
             string q_h = @"SELECT        MAX(Branch_len) AS Expr1
FROM            Branch
WHERE        HorizontID = " + comboBox1.SelectedValue.ToString();
             SqlDataAdapter sqlDA_h = new SqlDataAdapter(q_h, cn);
             DataTable tab_h = new DataTable();
             sqlDA_h.Fill(tab_h);
             int hhh = Convert.ToInt32(Convert.ToInt32(tab_h.Rows[0][0]) * m_h + 150);
         //   pictureBox1.Width = (branchDataGridView.Rows.Count*m_w) + (branch_1DataGridView.Rows.Count*m_w)+100;

        //    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

             Bitmap bitmap = new Bitmap((branchDataGridView.Rows.Count * m_w) + (branch_1DataGridView.Rows.Count * m_w) + 100, hhh);
            Graphics graf =Graphics.FromImage( bitmap);//pictureBox1.CreateGraphics();
//graf = new Graphics Size(Convert.ToInt32((branchDataGridView.Rows.Count * m_w) + (branch_1DataGridView.Rows.Count * m_w) + 100), Convert.ToInt32(pictureBox1.Height));
graf.Clear(SystemColors.Window);

            Pen pp = new Pen(Brushes.Violet, 14);
            Brush bb = new SolidBrush(Color.Black);


            int h = bitmap.Size.Height - 115;
            int w = bitmap.Size.Width - 105;




//***************************************** Южный штрек
      if (branchDataGridView.Rows.Count > 0)
      {
          string shtrek_1 = @"SELECT        ShtrekID, ShtrekName
FROM            Shtrek  WHERE ShtrekID="+comboBox3.SelectedValue.ToString();
          SqlDataAdapter sqlDA_shtrek_1 = new SqlDataAdapter(shtrek_1, cn);
          DataTable tab_shtrek_1 = new DataTable();
          sqlDA_shtrek_1.Fill(tab_shtrek_1);

          String Text_shtrek_1 = String.Format("{0}", tab_shtrek_1.Rows[0][1].ToString());
          graf.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
          graf.DrawString(Text_shtrek_1, Font, bb, bitmap.Size.Width - (bitmap.Size.Width - 20), h + m_h - m_h / 3); // Координаты размещения текста
      }

 for (int i = 0; i < branchDataGridView.Rows.Count; i++)
 {
     int color = 0;
     try { color = Convert.ToInt32(branchDataGridView[6, i].Value); }
     catch { }
     string quer = @"SELECT        HatchID, InventoryNumber, BranchID, Position_on_branch, Side_branches, MAX(Date_hatch) AS Date_hatch
FROM            Hatch
WHERE        (BranchID = " + branchDataGridView[3,i].Value.ToString() + @")
GROUP BY HatchID, InventoryNumber, BranchID, Position_on_branch, Side_branches";
 SqlDataAdapter sqlDA_ok2 = new SqlDataAdapter(quer, cn);
         DataTable tab = new DataTable();
         sqlDA_ok2.Fill(tab);
       
             if (i == 0)
             {
                 if (i == branchDataGridView.Rows.Count - 1)
                 {
                 
                     Point pt0 = new Point(w - (branch_1DataGridView.Rows.Count * m_w - 50) - i * m_w - m_w - 8, h - m_h - 3);

                     Image currv_25 = Repairs.Properties.Resources.currv_25;
                     switch (color)
                     {
                         case 1: currv_25 = Repairs.Properties.Resources.currv_25; break;
                           case 2: currv_25 = Repairs.Properties.Resources.r_currv_25; break;
                             case 3: currv_25 = Repairs.Properties.Resources.o_currv_25; break;
                             case 4: currv_25 = Repairs.Properties.Resources.y_currv_25; break;
                             case 5: currv_25 = Repairs.Properties.Resources.g_currv_25; break;
                             case 6: currv_25 = Repairs.Properties.Resources.b_currv_25; break;
                     }
                     graf.DrawImageUnscaled(currv_25, pt0);
                 }
                 else
       
                 {
             
                     Point pt0 = new Point(w - (branch_1DataGridView.Rows.Count * m_w - 50) - i * m_w - m_w - 8, h - m_h - 3);

                     Image curr_12 = Repairs.Properties.Resources.curr_12;
                     switch (color)
                     {
                         case 1: curr_12 = Repairs.Properties.Resources.curr_12; break;
                           case 2: curr_12 = Repairs.Properties.Resources.r_curr_12; break;
                             case 3: curr_12 = Repairs.Properties.Resources.o_curr_12; break;
                             case 4: curr_12 = Repairs.Properties.Resources.y_curr_12; break;
                             case 5: curr_12 = Repairs.Properties.Resources.g_curr_12; break;
                             case 6: curr_12 = Repairs.Properties.Resources.b_curr_12; break;
                     }
                     graf.DrawImageUnscaled(curr_12, pt0);

                    
                }
             }


             if ((i != branchDataGridView.Rows.Count) & (i > 0) & (i != branchDataGridView.Rows.Count - 1))
             {
         
                 Point pt0 = new Point(w - (branch_1DataGridView.Rows.Count * m_w - 50) - i * m_w - m_w-8, h - m_h-3);


                 Image currv_up = Repairs.Properties.Resources.currv_up;
                 switch (color)
                 {
                     case 1: currv_up = Repairs.Properties.Resources.currv_up; break;
                       case 2: currv_up = Repairs.Properties.Resources.r_currv_up; break;
                         case 3: currv_up = Repairs.Properties.Resources.o_currv_up; break;
                         case 4: currv_up = Repairs.Properties.Resources.y_currv_up; break;
                         case 5: currv_up = Repairs.Properties.Resources.g_currv_up; break;
                         case 6: currv_up = Repairs.Properties.Resources.b_currv_up; break;
                 }
                 graf.DrawImageUnscaled(currv_up, pt0);
      

             }

             if ((i == branchDataGridView.Rows.Count - 1)&(i != 0))
             {
            

                 Point pt0 = new Point(w - (branch_1DataGridView.Rows.Count * m_w - 50) - i * m_w-m_w-8, h-m_h - 3);


                 Image currv_l = Repairs.Properties.Resources.currv_l;
                 switch (color)
                 {
                     case 1: currv_l = Repairs.Properties.Resources.currv_l; break;
                       case 2: currv_l = Repairs.Properties.Resources.r_currv_l; break;
                         case 3: currv_l = Repairs.Properties.Resources.o_currv_l; break;
                         case 4: currv_l = Repairs.Properties.Resources.y_currv_l; break;
                         case 5: currv_l = Repairs.Properties.Resources.g_currv_l; break;
                         case 6: currv_l = Repairs.Properties.Resources.b_currv_l; break;
                 }
                 graf.DrawImageUnscaled(currv_l, pt0);
             }


             int col = 0;
             if (tab.Rows.Count > Convert.ToInt32(branchDataGridView[5, i].Value)) { col = tab.Rows.Count; } else { col = Convert.ToInt32(branchDataGridView[5, i].Value); }

             //    MessageBox.Show(branchDataGridView[0, i].Value.ToString() + " - " + branchDataGridView[1, i].Value.ToString()+"="+i.ToString());
             string dat = "";
             try { dat = "\r\n(" + Convert.ToDateTime(branchDataGridView[7, i].Value).ToShortDateString().ToString() + ")"; }
             catch { dat = ""; }
             String Text = String.Format("{0}", branchDataGridView[0, i].Value.ToString() + " - " + branchDataGridView[1, i].Value.ToString() + dat);
             graf.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
             graf.DrawString(Text, Font, bb, w - (branch_1DataGridView.Rows.Count * m_w - 50) - m_w  - i * m_w, h + 15); // Координаты размещения текста

             for (int j = 0; j < col; j++)
             {

            
                 if (j != 0)
                 {
                     Point pt = new Point(w - (branch_1DataGridView.Rows.Count * m_w - 50) - (i + 1) * m_w-8, h - j * m_h -m_h);
                    graf.DrawImageUnscaled(Repairs.Properties.Resources.ll, pt);
                 }

                 if (tab.Rows.Count > 0)
                 {
                     for (int l = 0; l < tab.Rows.Count; l++)
                     {


                         this.repairTableAdapter.FillByInv(this.repairOSDS.Repair, Convert.ToInt32(tab.Rows[l][1]), Convert.ToDateTime(dateTimePicker1.Value));
                         Pen pp_l;
                         if (repairBindingSource.Count > 0)
                         { pp_l = new Pen(Brushes.Red, 12); }
                         else { pp_l = new Pen(Brushes.Green, 12); }
                         int j1 = 0;
                         try
                         {
                             j1 = Convert.ToInt32(tab.Rows[l][3]) - 1;
                         }
                         catch { j1 = 0; }

                         if (j == j1)
                         {
                             if (Convert.ToInt32(tab.Rows[l][4]) == 1)
                             { graf.DrawEllipse(pp_l, w - (branch_1DataGridView.Rows.Count * m_w-50) - (i + 1) * m_w + 24, h - j * m_h - m_h + 7, 10, 10);

                     


                             String Text_l = String.Format("{0}", tab.Rows[l][1].ToString());
                             graf.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
                             graf.DrawString(Text_l, Font, bb, w - (branch_1DataGridView.Rows.Count * m_w - 50) - (i + 1) * m_w+16 , h - j * m_h - m_h-16); // Координаты размещения текста}
                             }
                             else
                             { graf.DrawEllipse(pp_l, w - (branch_1DataGridView.Rows.Count * m_w-50) - (i + 1) * m_w - 30, h - j * m_h - m_h + 7, 10, 10);
                               String Text_l = String.Format("{0}", tab.Rows[l][1].ToString());
                             graf.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
                             graf.DrawString(Text_l, Font, bb, w - (branch_1DataGridView.Rows.Count * m_w - 50) - (i + 1) * m_w - 47, h - j * m_h - m_h -16); // Координаты размещения текста}
                             }
                         }
                     }

                 }
             }

    
     
 }


   //******************************************************** Северный штрек        
 if (branch_1DataGridView.Rows.Count > 0)
 {

     string shtrek_2 = @"SELECT        ShtrekID, ShtrekName
FROM            Shtrek  WHERE ShtrekID=" + comboBox2.SelectedValue.ToString(); ;
     SqlDataAdapter sqlDA_shtrek_2 = new SqlDataAdapter(shtrek_2, cn);
     DataTable tab_shtrek_2 = new DataTable();
     sqlDA_shtrek_2.Fill(tab_shtrek_2);

     String Text_shtrek_2 = String.Format("{0}", tab_shtrek_2.Rows[0][1].ToString());
     graf.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
     graf.DrawString(Text_shtrek_2, Font, bb, bitmap.Size.Width - 100, h + m_h - m_h / 3);
 }


 for (int i = 0; i < branch_1DataGridView.Rows.Count; i++)
 {
     int color = 0;
     try { color = Convert.ToInt32(branch_1DataGridView[6, i].Value); }
     catch { }

     string quer = @"SELECT        HatchID, InventoryNumber, BranchID, Position_on_branch, Side_branches, MAX(Date_hatch) AS Date_hatch
FROM            Hatch
WHERE        (BranchID = " + branch_1DataGridView[3, i].Value.ToString() + @")
GROUP BY HatchID, InventoryNumber, BranchID, Position_on_branch, Side_branches";
     SqlDataAdapter sqlDA_ok2 = new SqlDataAdapter(quer, cn);
     DataTable tab = new DataTable();
     sqlDA_ok2.Fill(tab);

     if (i == 0)
     {
         if (i == branch_1DataGridView.Rows.Count - 1)
         {
      
                   Point pt0 = new Point(w - (branch_1DataGridView.Rows.Count * m_w - 50)-2, h - m_h - 3);



                  Image currv_2_2 = Repairs.Properties.Resources.currv_2_2;
             switch (color)
             {
                 case 1: currv_2_2 = Repairs.Properties.Resources.currv_2_2; break;
               case 2: currv_2_2 = Repairs.Properties.Resources.r_currv_2_2; break;
                 case 3: currv_2_2 = Repairs.Properties.Resources.o_currv_2_2; break;
                 case 4: currv_2_2 = Repairs.Properties.Resources.y_currv_2_2; break;
                 case 5: currv_2_2 = Repairs.Properties.Resources.g_currv_2_2; break;
                 case 6: currv_2_2 = Repairs.Properties.Resources.b_currv_2_2; break;
             }
                 graf.DrawImageUnscaled(currv_2_2, pt0);
         }else
   
         {
     
             Point pt0 = new Point(w - (branch_1DataGridView.Rows.Count * m_w - 50)-2 , h - m_h - 3);


             Image curr_12_2 = Repairs.Properties.Resources.curr_12_2;
             switch (color)
             {
                 case 1: curr_12_2 = Repairs.Properties.Resources.curr_12_2; break;
                   case 2: curr_12_2 = Repairs.Properties.Resources.r_curr_12_2; break;
                     case 3: curr_12_2 = Repairs.Properties.Resources.o_curr_12_2; break;
                     case 4: curr_12_2 = Repairs.Properties.Resources.y_curr_12_2; break;
                     case 5: curr_12_2 = Repairs.Properties.Resources.g_curr_12_2; break;
                     case 6: curr_12_2 = Repairs.Properties.Resources.b_curr_12_2; break;
             }
             graf.DrawImageUnscaled(curr_12_2, pt0);
         }
     }


     if ((i != branch_1DataGridView.Rows.Count) & (i > 0) & (i != branch_1DataGridView.Rows.Count - 1))
     {
      
         Point pt0 = new Point(w - (branch_1DataGridView.Rows.Count * m_w - 50) + i * m_w +5, h - m_h - 3);


         Image currv_up_2 = Repairs.Properties.Resources.currv_up_2;
         switch (color)
         {
             case 1: currv_up_2 = Repairs.Properties.Resources.currv_up_2; break;
               case 2: currv_up_2 = Repairs.Properties.Resources.r_currv_up_2; break;
                 case 3: currv_up_2 = Repairs.Properties.Resources.o_currv_up_2; break;
                 case 4: currv_up_2 = Repairs.Properties.Resources.y_currv_up_2; break;
                 case 5: currv_up_2 = Repairs.Properties.Resources.g_currv_up_2; break;
                 case 6: currv_up_2 = Repairs.Properties.Resources.b_currv_up_2; break;
         }
         graf.DrawImageUnscaled(currv_up_2, pt0);


     }

     if ((i == branch_1DataGridView.Rows.Count - 1)&(i != 0))
     {
      
         Point pt0 = new Point(w - (branch_1DataGridView.Rows.Count * m_w - 50) + i * m_w+5, h - m_h - 3);

         Image currv_l_2 = Repairs.Properties.Resources.currv_l_2;
         switch (color)
         {
             case 1: currv_l_2 = Repairs.Properties.Resources.currv_up_2; break;
               case 2: currv_l_2 = Repairs.Properties.Resources.r_currv_l_2; break;
                 case 3: currv_l_2 = Repairs.Properties.Resources.o_currv_l_2; break;
                 case 4: currv_l_2 = Repairs.Properties.Resources.y_currv_l_2; break;
                 case 5: currv_l_2 = Repairs.Properties.Resources.g_currv_l_2; break;
                 case 6: currv_l_2 = Repairs.Properties.Resources.b_currv_l_2; break;
         }
         graf.DrawImageUnscaled(currv_l_2, pt0);
     }


     int col = 0;
     if (tab.Rows.Count > Convert.ToInt32(branch_1DataGridView[5, i].Value)) { col = tab.Rows.Count; } else { col = Convert.ToInt32(branch_1DataGridView[5, i].Value); }


      //   MessageBox.Show(branch_1DataGridView[0, i].Value.ToString() + " - " + branch_1DataGridView[1, i].Value.ToString()+"="+i.ToString());
                  string dat = "";
                  try { dat = "\r\n(" + Convert.ToDateTime(branch_1DataGridView[7, i].Value).ToShortDateString().ToString() + ")"; }
             catch {dat = ""; }

     if ((i == branch_1DataGridView.Rows.Count - 1)&(i==0))
     {
         String Text = String.Format("{0}", branch_1DataGridView[0, i].Value.ToString() + " - " + branch_1DataGridView[1, i].Value.ToString() +  dat);
         graf.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
         graf.DrawString(Text, Font, bb, w - (branch_1DataGridView.Rows.Count * m_w - 50)  + m_w / 2 - i * m_w, h + 15); // Координаты размещения текста
     
     }
     else
     {
         String Text = String.Format("{0}", branch_1DataGridView[0, i].Value.ToString() + " - " + branch_1DataGridView[1, i].Value.ToString() +  dat );
         graf.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
         graf.DrawString(Text, Font, bb, w - (branch_1DataGridView.Rows.Count * m_w - 50) +  m_w / 2+i*m_w, h + 15); // Координаты размещения текста
     }

     for (int j = 0; j < col; j++)
     {

         if (j != 0)
         {
             Point pt = new Point(w - (branch_1DataGridView.Rows.Count * m_w - 50) + (i + 1) * m_w - 8, h - j * m_h - m_h);
             graf.DrawImageUnscaled(Repairs.Properties.Resources.ll, pt);
         }
         if (tab.Rows.Count > 0)
         {
             for (int l = 0; l < tab.Rows.Count; l++)
             {


                 this.repairTableAdapter.FillByInv(this.repairOSDS.Repair, Convert.ToInt32(tab.Rows[l][1]), Convert.ToDateTime(dateTimePicker1.Value));
                 Pen pp_l;
                 if (repairBindingSource.Count > 0)
                 { pp_l = new Pen(Brushes.Red, 12); }
                 else { pp_l = new Pen(Brushes.Green, 12); }
                 int j1 = 0;
                 try
                 {
                     j1 = Convert.ToInt32(tab.Rows[l][3]) - 1;
                 }
                 catch { j1 = 0; }

                 if (j == j1)
                 {
                     if (Convert.ToInt32(tab.Rows[l][4]) == 1)
                     { graf.DrawEllipse(pp_l, w - (branch_1DataGridView.Rows.Count * m_w - 50)+ (i + 1) * m_w + 24, h - j * m_h - m_h + 7, 10, 10);
                     String Text_l = String.Format("{0}", tab.Rows[l][1].ToString());
                     graf.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
                     graf.DrawString(Text_l, Font, bb, w - (branch_1DataGridView.Rows.Count * m_w - 50) + (i + 1) * m_w +16 , h - j * m_h - m_h - 16); // Координаты размещения текста}
                     }
                     else
                     { graf.DrawEllipse(pp_l, w - (branch_1DataGridView.Rows.Count * m_w - 50) + (i + 1) * m_w - 30, h - j * m_h - m_h + 7, 10, 10);
                     String Text_l = String.Format("{0}", tab.Rows[l][1].ToString());
                     graf.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
                     graf.DrawString(Text_l, Font, bb, w - (branch_1DataGridView.Rows.Count * m_w - 50) + (i + 1) * m_w - 47, h - j * m_h - m_h - 16); // Координаты размещения текста}
                     }
                 }
             }

         }
     }


     Image ToView = Image.FromHbitmap(bitmap.GetHbitmap());
    /* pictureBox1.Size = new Size(bitmap.Width, bitmap.Height);
     pictureBox1.Image = bitmap;*/

     // если объект, хранящий изображение не равен null
     if (ToView != null)
     {
         // устанавливаем новые размеры элемента pictureBox1,
         // равные ширине (ToView.Width) и высоте (ToView.Height) загружаемого изображения.
         pictureBox1.Size = new Size(ToView.Width, ToView.Height);
         // устанавливаем изображение для отображения в элементе pictureBox1
         pictureBox1.Image = ToView;
     }

 }
        }

        private void frmMap_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "repairOSDS.StatusBranch". При необходимости она может быть перемещена или удалена.
            this.statusBranchTableAdapter.Fill(this.repairOSDS.StatusBranch);
           
           

          
            this.horizontTableAdapter.Fill(this.repairOSDS.Horizont);

        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            this.shtrek1TableAdapter.FillBy(this.repairOSDS.Shtrek1, Convert.ToInt32(comboBox1.SelectedValue));

            this.shtrekTableAdapter.FillBy(this.repairOSDS.Shtrek, Convert.ToInt32(comboBox1.SelectedValue));

         
         
        }

        private void panel2_Scroll(object sender, ScrollEventArgs e)
        {
         
        }

        private void branch_1DataGridView_CurrentCellChanged(object sender, EventArgs e)
        {
            try
            {
                this.hatchTableAdapter.FillByL1(this.repairOSDS.Hatch, Convert.ToInt32(branch_1DataGridView[3, branch_1DataGridView.CurrentRow.Index].Value));
            }
            catch { }
        }

        private void branchDataGridView_CurrentCellChanged(object sender, EventArgs e)
        {
            try
            {
                this.hatch1TableAdapter.FillByL2(this.repairOSDS.Hatch1, Convert.ToInt32(branchDataGridView[3, branchDataGridView.CurrentRow.Index].Value));
            }
            catch { }
        }

        private void comboBox3_SelectedValueChanged(object sender, EventArgs e)
        {
          
            this.branchTableAdapter.FillByShtrek(this.repairOSDS.Branch, Convert.ToInt32(comboBox1.SelectedValue), Convert.ToInt32(comboBox2.SelectedValue));
            try { comboBox2.SelectedIndex = comboBox3.SelectedIndex + 1; /*comboBox2_SelectedValueChanged(this, null);*/ }
            catch
            {
                try { comboBox2.SelectedIndex = comboBox3.SelectedIndex - 1; }
                catch { }
            }

            label5.Text = comboBox3.Text;
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentCell == dataGridView1[3, dataGridView1.CurrentRow.Index])
            { this.repairTableAdapter.FillByInv(this.repairOSDS.Repair, Convert.ToInt32(dataGridView1[1, dataGridView1.CurrentRow.Index].Value), Convert.ToDateTime(dateTimePicker1.Value));
            if (repairBindingSource.Count > 0)
            {
                frmCarriagesRepair frm = new frmCarriagesRepair("", "", "", "", "", "", "");
                frm.inv =dataGridView1[1, dataGridView1.CurrentRow.Index].Value.ToString();
                frm.dat = Convert.ToDateTime(dateTimePicker1.Value);
                frm.ShowDialog();
            }
            }
        }

        private void dgL1_Click(object sender, EventArgs e)
        {
            if (dgL1.CurrentCell == dgL1[3, dgL1.CurrentRow.Index])
            { this.repairTableAdapter.FillByInv(this.repairOSDS.Repair, Convert.ToInt32(dgL1[1, dgL1.CurrentRow.Index].Value), Convert.ToDateTime(dateTimePicker1.Value));
            if (repairBindingSource.Count > 0)
            {
                frmCarriagesRepair frm = new frmCarriagesRepair("", "", "","","","","");
                frm.inv = dgL1[1, dgL1.CurrentRow.Index].Value.ToString();
                frm.dat = Convert.ToDateTime(dateTimePicker1.Value);
                frm.ShowDialog();
            }
            }
        }

        private void comboBox2_SelectedValueChanged(object sender, EventArgs e)
        {
            this.branch_1TableAdapter.Fill(this.repairOSDS.Branch_1, Convert.ToInt32(comboBox1.SelectedValue), Convert.ToInt32(comboBox2.SelectedValue));
            label6.Text = comboBox2.Text;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (pan == false)
            { panel2.Visible = true; /*panel1.Width = panel1.Width - panel2.Width; */ pan = true; }
            else
            { panel2.Visible = false; /*panel1.Width = panel1.Width + panel2.Width;*/  pan = false; }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
{
string format = "Карта люків "+dateTimePicker1.Text;
SaveFileDialog savedialog = new SaveFileDialog();
savedialog.OverwritePrompt = true; // если файл с указанным именем уже существует
savedialog.CheckPathExists = true; //если пользователь вводит неверный путь или имя файла 
savedialog.ShowHelp = true;
savedialog.Filter = "Image Files(*.BMP)|*.BMP|Image Files(*.JPG)|*.JPG|Image Files(*.GIF)|*.GIF|Image Files(*.PNG)|*.PNG|All files (*.*)|*.*";
if (savedialog.ShowDialog() == DialogResult.OK)
{
try
{
Bitmap MM = new Bitmap(pictureBox1.Image);
MM.Save(savedialog.FileName, System.Drawing.Imaging.ImageFormat.Jpeg);
}
catch
{
MessageBox.Show("Неможливо зберегти файл!", "Помилка!",
MessageBoxButtons.OK, MessageBoxIcon.Error);
}
}
}
        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = (char)Keys.None;
        }

    

  
    

       


    }
}
