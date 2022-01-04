using COMPROG2_FINPROJ_DRAWY;
using System;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace COMPROG2_FINPROJ
{
    public partial class GTW : Form
    {

        private SoundPlayer playSound;
       

        public GTW()
        {
            InitializeComponent();
            playSound = new SoundPlayer("BGMUSIC.wav");
            playSound.PlayLooping();

            SidePanel.Height = homeButton1.Height;
            homeUsrCtrl1.BringToFront();

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
       

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void EnterGameButton_Click(object sender, EventArgs e)
        {

        }


        private void linkLabel1_MouseClick(object sender, MouseEventArgs e)
        {
        }

        private void EnterRoomButton2_Click(object sender, EventArgs e)
        {

        }

        private void DRAWY_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Are you sure to close the application?", "Exit", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void DRAWY_Load(object sender, EventArgs e)
        {
          
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
           
        }

        private void userNameBox_KeyDown(object sender, KeyEventArgs e)
        {
           
        }

        private void button_woc1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void enableSounds_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void homeButton1_Click(object sender, EventArgs e)
        {
            SidePanel.Height = homeButton1.Height;
            SidePanel.Top = homeButton1.Top;
            homeUsrCtrl1.BringToFront();
        }

        private void contactButton2_Click(object sender, EventArgs e)
        {
            SidePanel.Height = contactButton2.Height;
            SidePanel.Top = contactButton2.Top;
            contactUs1.BringToFront();
        }

        private void aboutButton3_Click(object sender, EventArgs e)
        {
            SidePanel.Height = aboutButton3.Height;
            SidePanel.Top = aboutButton3.Top;
            about1.BringToFront();
        }

        
        public void HideUIFormMain()
        {
            this.Hide();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (SoundEnable.Checked)
                {
                    playSound.PlayLooping();
                }
                else
                {
                    playSound.Stop();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error enabling sounds. Sorry. \n"+ex.Message);
            }
        }

        public void CloseGTW()
        {

            this.Dispose();
        }




    }
}
