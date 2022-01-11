using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.Data.Common;

namespace Repairs
{
    public partial class formChooseAdditionalCeh : Form
    {
        public formChooseAdditionalCeh(ArrayList list)
        {
            InitializeComponent();
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            //comboBox1.DataSource = list;
            foreach(DbDataRecord item in list)
            {
                comboBox1.Items.Add($"{item[0]}");
            }
            comboBox1.SelectedIndex = 0;
        }
        public int selectedIndex;
        private void button1_Click(object sender, EventArgs e)
        {
            selectedIndex = comboBox1.SelectedIndex;
            DialogResult = DialogResult.OK;
        }
    }
}
