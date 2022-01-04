using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Media;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using COMPROG2_FINPROJ;
using COMPROG2_FINPROJ_DRAWY;

namespace COMPROG2_FINPROJ_DRAWY
{
    public partial class HomeUsrCtrl : UserControl
    {
        private static string copyValUserN = "";
        private static string copyValRoomN = "";
        public HomeUsrCtrl()
        {
            InitializeComponent();
            
        }
        private void enableSounds_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void createRoomBox_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void userNameBox_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

     

        private void button_woc1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(userNameBox.Text) == false || String.IsNullOrWhiteSpace(createRoomBox.Text) == false)
            {
                
                LoadingBar LB = new LoadingBar();
                LB.ShowDialog();
                LB.Close();

                
                ZGRET greetSirRon = new ZGRET();
                greetSirRon.ShowDialog(); 

                copyValUserN = userNameBox.Text;
                copyValRoomN = createRoomBox.Text;
                MainGameForm MG = new MainGameForm();
                MG.ShowDialog();

            }
            else if (String.IsNullOrWhiteSpace(userNameBox.Text) == true || String.IsNullOrWhiteSpace(createRoomBox.Text) == false)
            {
                MessageBox.Show("Please enter valid Names!", "Input Username/Room Name", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Please enter Values!", "Input Values", MessageBoxButtons.OK);
            }

        }


        public static string GetUserN
        {
            get { return copyValUserN; }
        }
        public static string GetRoomN
        {
            get { return copyValRoomN; }
        }
    }
}
