using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hw03_donovangilliam
{
    public partial class AddForm : Form
    {
        
        MainForm mainFormHere;
        public AddForm()
        {
            InitializeComponent();
        }
        public AddForm(MainForm mf)
        {
            InitializeComponent();
            mainFormHere = mf;
        }

        private void btn_addcar_Click(object sender, EventArgs e)
        {
            MainFormLoad();
        }

        //checks if all fields are filled in, modified from previous homework
        private bool NotEmptyChecker()
        {
            foreach (TextBox textbox in pnl_addform.Controls.OfType<TextBox>())
            {
                if (textbox.Text == string.Empty)
                {
                    lbl_allfields.Visible = true;
                    return false;
                }
            }
            lbl_allfields.Visible=false;
            return true;
        }

        private bool VinCheck()
        {
            foreach (CarInfo info in CarList.CarInfoList) 
            {
                if (info.vinNum == txt_vin.Text)
                {
                    lbl_vinunique.Visible = true;
                    return false;
                }
            }
            lbl_vinunique.Visible=false;
            return true;
        }


        //loads main form and closes this one
        //adds car info to the list if notemptychecker returns true
        private void MainFormLoad()
        {
            if (NotEmptyChecker())
            {
                if (VinCheck())
                {
                    CarList.CarInfoList.Add(new CarInfo
                    {
                        vinNum = txt_vin.Text,
                        makeString = txt_make.Text,
                        modelString = txt_model.Text,
                        yearString = txt_year.Text,
                        colorString = txt_color.Text
                    });
                    CarList.AddToTxtFile();
                    CarList.LoadTxtIntoList();
                    mainFormHere.FillListBox();
                    this.Close();
                    mainFormHere.Show();
                }
            }
        }

        private void AddForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            mainFormHere.Show();
        }
    }
}
