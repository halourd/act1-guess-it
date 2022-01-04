using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using COMPROG2_FINPROJ;
using System.IO;
using System.Media;


namespace COMPROG2_FINPROJ_DRAWY
{
    public partial class MainGameForm : Form
    {
        private SoundPlayer newMainBG;
        private int seconds;
        private static string SetValueForCorrWord = "";
        public static string AddTotalPoints = "";
        public static string DeductTotalPoints = "";

        private int totalPointsAdd = 0;
        private static int totalPointsDe = 0;
        private int addedpoints = 0;
        private int deductedPoints = 0;
        private int totalpoints = 0;

        public MainGameForm()
        {
            InitializeComponent();
            newMainBG = new SoundPlayer("Super Mario World Game Over LoFi Hip Hop Remix.wav");
            newMainBG.PlayLooping();
            //lbl_totalPoints.Text = "Points:   "+TotalPoints.ToString();
        }


        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void jumbledLetter_MouseClick(object sender, MouseEventArgs e)
        {
            txtbxGuessInp.Enabled = true;
            enterButton.Enabled = true;
            panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            txtbxGuessInp.Clear();
            countdown_timer.Start();
            seconds = 15;
        }

        


        public void countdown_timer_Tick(object sender, EventArgs e)
        {
            lblTimer.Text = seconds--.ToString();


            if (seconds >= 9 && seconds <= 15)
            {
                //addedpoints = 500;
                lblTimer.ForeColor = System.Drawing.Color.SeaGreen;

            }

            if (seconds >= 4 && seconds <= 8)
            {
               // addedpoints = 300;
                panel1.BackColor = System.Drawing.Color.DarkOrange;
                lblTimer.ForeColor = System.Drawing.Color.DarkOrange;

            }

            if (seconds >= 0 && seconds <= 3)
            {
                
                //addedpoints = 100;
                lblTimer.ForeColor = System.Drawing.Color.Crimson;
                panel1.BackColor = System.Drawing.Color.Crimson;
            }

            if (seconds == -1)
            {
              //  addedpoints = 0;
               // deductedPoints = 500;
                jumbledLetter.Text = "Click here to continue!";
                txtbxGuessInp.Enabled = false;
                enterButton.Enabled = false;
                
               // lbl_totalPoints.Text = "Points:   "+ DeductToTotal.ToString();
                countdown_timer.Stop();
                this.TimesUpPopUp();
            }

        }

        /*public int AddToTotal
        {
            get { return totalPointsAdd = totalpoints + addedpoints; }
            set { totalpoints = totalPointsAdd; }
        }

        public int DeductToTotal
        {
            get { return totalPointsDe = totalpoints - deductedPoints; }
            set { totalpoints = totalPointsDe; }
        }

        public int TotalPoints
        {
            get { return totalpoints; }
        }*/



        private void label6_Click(object sender, EventArgs e)
        {

        }

        private string setRefFilePath;

        private void jumbledLetter_Click(object sender, EventArgs e)
        {
            getSelectWord(setRefFilePath);
        }
        public void reJumble()
        {
            jumbledLetter.Visible = true;
            txtbxGuessInp.Enabled = false;
            enterButton.Enabled = false;
            jumbledLetter.Text = "Click here to Continue!";
        }

        


        private string selectedword;
        private void getSelectWord(string path)
        {
          
            //Scan and place it into an array
            Random rand = new Random();
            string[] ReadWord = File.ReadAllLines(path);

            WordJumble w = new WordJumble();
            selectedword = ReadWord[rand.Next(0, ReadWord.Length)];

            string JWord1 = selectedword;
            string JWord2 = w.ScrambleWord(JWord1);
            jumbledLetter.Text = JWord2;
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            countdown_timer.Stop();
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to quit the game?", "Exit", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                countdown_timer.Stop();
                this.Close();
                GTW ui = new GTW();
                ui.ShowDialog();
            }
        }
        


        private void txtbxGuessInp_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && txtbxGuessInp.Text == selectedword)
            {
                countdown_timer.Stop();
                jumbledLetter.Text = "Click here to continue!";
                txtbxGuessInp.Enabled = false;
                enterButton.Enabled = false;
                CheckAns();
            }
        }
        
        private void CheckAns()
        {

            Form CorrWordPop = new Form();
            try
            {
                using (CorrectWord CorrectW = new CorrectWord())
                {
                    CorrWordPop.StartPosition = FormStartPosition.CenterScreen;
                    CorrWordPop.FormBorderStyle = FormBorderStyle.None;
                    CorrWordPop.Opacity = .70d;
                    CorrWordPop.BackColor = Color.Black;
                    CorrWordPop.WindowState = FormWindowState.Maximized;
                    CorrWordPop.TopMost = true;
                    CorrWordPop.Location = this.Location;
                    CorrWordPop.ShowInTaskbar = false;
                    CorrWordPop.Show();
                    CorrectW.Owner = CorrWordPop;
                    SetValueForCorrWord = selectedword;
                    //AddTotalPoints = lbl_totalPoints.Text.ToString();
                    CorrectW.ShowDialog();
                    CorrWordPop.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An Error Occured. \n" + ex.Message);
            }
            finally
            {
                CorrWordPop.Dispose();
            }

        }

        private void button_woc1_Click(object sender, EventArgs e)
        {
            if (txtbxGuessInp.Text == selectedword)
            {
                countdown_timer.Stop();
                CheckAns();
            }
            else if (txtbxGuessInp.Text != selectedword)
            {
                MessageBox.Show("Incorrect!");
            }
            else if (String.IsNullOrWhiteSpace(txtbxGuessInp.Text) == true)
            {
                MessageBox.Show("Please input your Answer!");
            }
        }
        private void TimesUpPopUp()
        {
            Form timePop = new Form();
            try
            {
                using (TimesUpForm time = new TimesUpForm())
                {
                    timePop.StartPosition = FormStartPosition.CenterScreen;
                    timePop.FormBorderStyle = FormBorderStyle.None;
                    timePop.Opacity = .70d;
                    timePop.BackColor = Color.Black;
                    timePop.WindowState = FormWindowState.Maximized;
                    timePop.TopMost = true;
                    timePop.Location = this.Location;
                    timePop.ShowInTaskbar = false;
                    timePop.Show();

                    time.Owner = timePop;
                    SetValueForCorrWord = selectedword;
                   // DeductTotalPoints = lbl_totalPoints.Text.ToString();
                    time.ShowDialog();
                    timePop.Dispose();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An Error Occured. \n" + ex.Message);
            }
            finally
            {
                timePop.Dispose();
            }
        }

        private void MainGame_Load(object sender, EventArgs e)
        {
            lbl_playname_value.Text = HomeUsrCtrl.GetUserN;
            roomNameValue.Text = HomeUsrCtrl.GetRoomN;
        }

        public static string GetCorrWord
        {
            get { return SetValueForCorrWord; }
        }

        private void MainGame_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void button_Nature_Click(object sender, EventArgs e)
        {
            setRefFilePath = @"Nature.txt";
            this.label2_cho_cat.Visible = false;
            this.button_Nature.Visible = false;
            this.button_Tech.Visible = false;
            this.button_Obj.Visible = false;
            this.button_BibleChar.Visible = false;
            this.button_Names.Visible = false;


            jumbledLetter.Text = "Click here to Start!";
            lblCategory.Text = "Category: Nature";
            lblCategory.Visible = true;
            jumbledLetter.Visible = true;
            txtbxGuessInp.Visible = true;
            enterButton.Visible = true;



        }

        private void button_Tech_Click(object sender, EventArgs e)
        {
            setRefFilePath = @"Technology.txt";
            this.label2_cho_cat.Visible = false;
            this.button_Nature.Visible = false;
            this.button_Tech.Visible = false;
            this.button_Obj.Visible = false;
            this.button_BibleChar.Visible = false;
            this.button_Names.Visible = false;


            jumbledLetter.Text = "Click here to Start!";
            lblCategory.Text = "Category: Technology";
            lblCategory.Visible = true;
            jumbledLetter.Visible = true;
            txtbxGuessInp.Visible = true;
            enterButton.Visible = true;

        }

        private void button_Obj_Click(object sender, EventArgs e)
        {
            setRefFilePath = @"Objects.txt";
            this.label2_cho_cat.Visible = false;
            this.button_Nature.Visible = false;
            this.button_Tech.Visible = false;
            this.button_Obj.Visible = false;
            this.button_BibleChar.Visible = false;
            this.button_Names.Visible = false;

            jumbledLetter.Text = "Click here to Start!";
            lblCategory.Text = "Category: Objects";
            lblCategory.Visible = true;
            jumbledLetter.Visible = true;
            txtbxGuessInp.Visible = true;
            enterButton.Visible = true;
        }

        private void button_Names_Click(object sender, EventArgs e)
        {
            setRefFilePath = @"Names.txt";
            this.label2_cho_cat.Visible = false;
            this.button_Nature.Visible = false;
            this.button_Tech.Visible = false;
            this.button_Obj.Visible = false;
            this.button_BibleChar.Visible = false;
            this.button_Names.Visible = false;

            jumbledLetter.Text = "Click here to Start!";
            lblCategory.Text = "Category: Names";
            lblCategory.Visible = true;
            jumbledLetter.Visible = true;
            txtbxGuessInp.Visible = true;
            enterButton.Visible = true;
        }

        private void button_BibleCharClick(object sender, EventArgs e)
        {
            setRefFilePath = @"BibleChar.txt";
            this.label2_cho_cat.Visible = false;
            this.button_Nature.Visible = false;
            this.button_Tech.Visible = false;
            this.button_Obj.Visible = false;
            this.button_BibleChar.Visible = false;
            this.button_Names.Visible = false;

            jumbledLetter.Text = "Click here to Start!";
            lblCategory.Text = "Category: Bible Characters";
            lblCategory.Visible = true;
            jumbledLetter.Visible = true;
            txtbxGuessInp.Visible = true;
            enterButton.Visible = true;
        }

        private void Main_SoundEnable_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (Main_SoundEnable.Checked)
                {
                    newMainBG.PlayLooping();
                }
                else
                {
                    newMainBG.Stop();
                }
            }catch(Exception ec)
            {
                MessageBox.Show("Error enabling sounds. \n"+ec.Message);
            }
        }
    }
}
