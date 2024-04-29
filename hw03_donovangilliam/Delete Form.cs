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
    public partial class DeleteForm : Form
    {
        MainForm mainFormHere;
        public DeleteForm()
        {
            InitializeComponent();
        }
        public DeleteForm(MainForm mf)
        {
            InitializeComponent();
            mainFormHere = mf;
        }
        private bool NotEmptyChecker()
        {
            foreach (TextBox textbox in pnl_deleteform.Controls.OfType<TextBox>())
            {
                if (textbox.Text == string.Empty)
                {
                    lbl_allfields.Visible = true;
                    return false;
                }
            }
            lbl_allfields.Visible = false;
            return true;
        }
        private bool DeleteInfo()
        {
            //delete items from list and txt
            foreach (CarInfo info in CarList.CarInfoList)
            {
                if (txt_deletevin.Text == info.vinNum)
                {
                    lbl_vinnoexist.Visible = false;
                    DeleteFromTxt();
                    CarList.CarInfoList.Remove(info);
                    return true;
                }
            }
            lbl_vinnoexist.Visible = true;
            return false;
        }

        private void DeleteFromTxt()
        {
            using (StreamWriter sw = new StreamWriter(CarList.filepath))
            {
                foreach (CarInfo info in CarList.CarInfoList)
                {
                    if (info.vinNum != txt_deletevin.Text)
                    {
                        sw.WriteLine($"{info.vinNum}");
                        sw.WriteLine($"{info.makeString}");
                        sw.WriteLine($"{info.modelString}");
                        sw.WriteLine($"{info.yearString}");
                        sw.WriteLine($"{info.colorString}");
                    }
                }
                sw.Flush();
            }
        }

        private void btn_deletecar_Click(object sender, EventArgs e)
        {
            if (NotEmptyChecker())
            {
                if (DeleteInfo())
                {
                    mainFormHere.FillListBox();
                    this.Hide();
                    mainFormHere.Show();
                }
            }
        }

        private void DeleteForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            mainFormHere.Show();
        }
    }
}
