using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hw03_donovangilliam
{
    public partial class DetailForm : Form
    {
        MainForm mainFormHere;
        string vinNumber;
        public DetailForm()
        {
            InitializeComponent();
        }
        public DetailForm(MainForm mf, String vn)
        {
            InitializeComponent();
            mainFormHere = mf;
            vinNumber = vn;
            foreach (CarInfo info in CarList.CarInfoList)
            {
                if (info.vinNum == vinNumber) 
                {
                    lbl_vin.Text += info.vinNum;
                    lbl_make.Text += info.makeString;
                    lbl_model.Text += info.modelString;
                    lbl_year.Text += info.yearString;
                    lbl_color.Text += info.colorString;
                }
            }
        }

        private void DetailForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            mainFormHere.Show();
        }
    }
}
