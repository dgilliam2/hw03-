using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hw03_donovangilliam
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            CarList.LoadTxtIntoList();
            FillListBox();
        }

        private void btn_addcars_Click(object sender, EventArgs e)
        {
            LoadAddForm();
        }
        private void LoadAddForm()
        {
            AddForm addform = new AddForm(this);
            this.Hide();
            addform.Show();
        }

        public void FillListBox()
        {
            //clear to avoid repeats
            LB_vinlist.Items.Clear();
            foreach (CarInfo info in CarList.CarInfoList)
            {
                LB_vinlist.Items.Add(info.vinNum);
            }
        }

        //vin list handling
        private void LB_vinlist_DoubleClick(object sender, EventArgs e)
        {
            string vinNum = LB_vinlist.SelectedItem.ToString();
            DetailForm detailform = new DetailForm(this, vinNum);
            this.Hide();
            detailform.Show();
        }

        //update car form handling
        private void btn_updatecars_Click(object sender, EventArgs e)
        {
            UpdateForm updateform = new UpdateForm(this);
            this.Hide();
            updateform.Show();
        }

        //delete car handling
        private void btn_deletecars_Click(object sender, EventArgs e)
        {
            DeleteForm deleteform = new DeleteForm(this);
            this.Hide();
            deleteform.Show();
        }
    }

}
