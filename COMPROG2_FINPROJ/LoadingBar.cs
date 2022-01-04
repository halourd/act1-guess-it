using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using COMPROG2_FINPROJ;
using COMPROG2_FINPROJ_DRAWY;

namespace COMPROG2_FINPROJ_DRAWY
{
    public partial class LoadingBar : Form
    {
        public LoadingBar()
        {
            InitializeComponent();
        }

        private void LoadingBar_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            loadpanel2.Width += 3;

            if (loadpanel2.Width >= 508)
            {
                timer1.Stop();
                Close();
            }
            

        }
    }
}
