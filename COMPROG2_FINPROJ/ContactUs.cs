using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace COMPROG2_FINPROJ_DRAWY
{
    public partial class ContactUs : UserControl
    {
        WebBrowser web = new WebBrowser();
        public ContactUs()
        {
            InitializeComponent();
        }

        private void ContactUs_Load(object sender, EventArgs e)
        {

        }

        private void haroldFB_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("explorer.exe", "https://www.facebook.com/h01000111");
        }

        private void haroldIG_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("explorer.exe", "https://instagram.com/halord.jpg");
        }
        private void haroldTWR_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("explorer.exe", "https://twitter.com/harordg");
        }

        private void jeckFB_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("explorer.exe", "https://www.facebook.com/jeeeccckk");
        }

        private void jeckIG_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("explorer.exe", "https://www.instagram.com/jsslygts_/"); 
        }

        private void jeckTWR_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("explorer.exe", "https://twitter.com/dyeseli_");
        }

        private void jamFB_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("explorer.exe", "https://facebook.com/jamaica.bontilao.9");
        }

        private void jamIG_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("explorer.exe", "https://instagram.com/jamaicabontilao");
        }

        private void jamTWR_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("explorer.exe", "https://twitter.com/bontilaojam");

        }
        private void mitchFB_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("explorer.exe", "https://facebook.com/mitchang4.7");
        }

        private void mitchIG_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("explorer.exe", "https://instagram.com/mtch_ngl");
        }

        private void mitchTWR_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("explorer.exe", "https://twitter.com/mitch_angel_");
        }

        private void jamFB_MouseHover(object sender, EventArgs e)
        {
            this.lblClickToVisit1.Visible = true;
        }

        private void jamIG_MouseHover(object sender, EventArgs e)
        {
            this.lblClickToVisit1.Visible = true;
        }

        private void jamTWR_MouseHover(object sender, EventArgs e)
        {
            this.lblClickToVisit1.Visible = true;
        }

        private void haroldFB_MouseHover(object sender, EventArgs e)
        {
            this.lblClickToVisit2.Visible = true;
        }

        private void haroldIG_MouseHover(object sender, EventArgs e)
        {
            this.lblClickToVisit2.Visible = true;
        }

        private void haroldTWR_MouseHover(object sender, EventArgs e)
        {
            this.lblClickToVisit2.Visible = true;
        }

        private void jamFB_MouseLeave(object sender, EventArgs e)
        {
            this.lblClickToVisit1.Visible = false;
        }

        private void jamIG_MouseLeave(object sender, EventArgs e)
        {
            this.lblClickToVisit1.Visible = false;
        }

        private void jamTWR_MouseLeave(object sender, EventArgs e)
        {
            this.lblClickToVisit1.Visible = false;
        }

        private void haroldFB_MouseLeave(object sender, EventArgs e)
        {
            this.lblClickToVisit2.Visible = false;
        }

        private void haroldIG_MouseLeave(object sender, EventArgs e)
        {
            this.lblClickToVisit2.Visible = false;
        }

        private void haroldTWR_MouseLeave(object sender, EventArgs e)
        {
            this.lblClickToVisit2.Visible = false;
        }

        private void jeckFB_MouseHover(object sender, EventArgs e)
        {
            this.lblClickToVisit3.Visible = true;
        }

        private void jeckFB_MouseLeave(object sender, EventArgs e)
        {
            this.lblClickToVisit3.Visible = false;
        }

        private void jeckIG_MouseHover(object sender, EventArgs e)
        {
            this.lblClickToVisit3.Visible = true;
        }

        private void jeckIG_MouseLeave(object sender, EventArgs e)
        {
            this.lblClickToVisit3.Visible = false;
        }

        private void jeckTWR_MouseHover(object sender, EventArgs e)
        {
            this.lblClickToVisit3.Visible = true;
        }

        private void jeckTWR_MouseLeave(object sender, EventArgs e)
        {
            this.lblClickToVisit3.Visible = false;
        }

        private void mitchFB_MouseHover(object sender, EventArgs e)
        {
            this.lblClickToVisit4.Visible = true;
        }

        private void mitchIG_MouseHover(object sender, EventArgs e)
        {
            this.lblClickToVisit4.Visible = true;
        }

        private void mitchTWR_MouseHover(object sender, EventArgs e)
        {
            this.lblClickToVisit4.Visible = true;
        }

        private void mitchFB_MouseLeave(object sender, EventArgs e)
        {
            this.lblClickToVisit4.Visible = false;
        }

        private void mitchIG_MouseLeave(object sender, EventArgs e)
        {
            this.lblClickToVisit4.Visible = false;
        }

        private void mitchTWR_MouseLeave(object sender, EventArgs e)
        {
            this.lblClickToVisit4.Visible = false;
        }
    }
}
