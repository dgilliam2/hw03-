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
using hw03_donovangilliam.Properties;

namespace hw03_donovangilliam
{
    public partial class UpdateForm : Form
    {
        MainForm mainFormHere;
        public UpdateForm()
        {
            InitializeComponent();
        }
        public UpdateForm(MainForm mf)
        {
            InitializeComponent();
            mainFormHere = mf;
        }
        private bool NotEmptyChecker()
        {
            foreach (TextBox textbox in pnl_updateform.Controls.OfType<TextBox>())
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
        private bool VinCheckAndUpdate()
        {
            foreach (CarInfo info in CarList.CarInfoList)
            {
                if (info.vinNum == txt_curvin.Text)
                {
                    lbl_vingone.Visible = false;
                    info.vinNum = txt_newvin.Text;
                    info.makeString = txt_newmake.Text;
                    info.modelString = txt_newmodel.Text;
                    info.yearString = txt_newyear.Text;
                    info.colorString = txt_newcolor.Text;
                    UpdateTxtFile(info);
                    return true;
                }
            }
            lbl_vingone.Visible = true;
            return false;
        }

        //modified from LoadTxtIntoList
        private void UpdateTxtFile(CarInfo updateinfo)
        {
            string[] fileLines = File.ReadAllLines(Resources.SavedList);
            for (int i = 0; i < fileLines.Length; i += 5)
            {
                if (fileLines[i] == txt_curvin.Text)
                {
                    fileLines[i] = updateinfo.vinNum;
                    fileLines[i + 1] = updateinfo.makeString;
                    fileLines[i + 2] = updateinfo.modelString;
                    fileLines[i + 3] = updateinfo.yearString;
                    fileLines[i + 4] = updateinfo.colorString;
                }
            }
            File.WriteAllLines(Resources.SavedList, fileLines);
        }
        private void btn_updatecar_Click(object sender, EventArgs e)
        {
            MainFormLoad();
        }

        private void MainFormLoad()
        {
            if (NotEmptyChecker())
            {
                if (VinCheckAndUpdate())
                {
                    mainFormHere.FillListBox();
                    this.Hide();
                    mainFormHere.Show();
                }
            }
        }
        private void UpdateForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            mainFormHere.Show();
        }
    }
}
