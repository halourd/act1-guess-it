using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using COMPROG2_FINPROJ_DRAWY;

namespace COMPROG2_FINPROJ_DRAWY
{
    public partial class TimesUpForm : Form
    {
        public TimesUpForm()
        {
            InitializeComponent();
            MainGameForm TP = new MainGameForm();
            
        }

        private void button_woc1_Click(object sender, EventArgs e)
        {

            MainGameForm mG = new MainGameForm();
            
                mG.reJumble();
                this.Close();

           
        }
        

        private void TimesUpForm_MouseDown(object sender, MouseEventArgs e)
        {
            
        }

        private void TimesUpForm_Load(object sender, EventArgs e)
        {
           
            lbl_corrWord.Text = MainGameForm.GetCorrWord;
           // tuf_totalpoints.Text = "Total Points: " + MainGameForm.DeductTotalPoints;
        }

        private void button_woc1_MouseClick(object sender, MouseEventArgs e)
        {
        }
    }
}
