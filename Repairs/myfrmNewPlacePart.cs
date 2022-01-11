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
    public partial class myfrmNewPlacePart : Form
    {
        DAL dal = new DAL();
        
        public myfrmNewPlacePart()
        {
            InitializeComponent();
            cbx_RefPlace.DataSource = dal.GetALLRefPlace();
            cbx_RefPlace.DisplayMember = "PlaceName";
            cbx_RefPlace.ValueMember = "PlaceCode";
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {

            if (dal.SaveNewPlacePart(cbx_RefPlace.SelectedValue.ToString(), PlacePart.Replaced_Id)==true)
            {
                this.DialogResult = DialogResult.OK;
            }

            else
            {
                this.DialogResult = DialogResult.No;
            }

            

        }



        }
    }

