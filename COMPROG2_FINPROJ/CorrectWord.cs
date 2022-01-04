using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace COMPROG2_FINPROJ_DRAWY
{
     
    public partial class CorrectWord : Form
    {
        
        public CorrectWord()
        {
            InitializeComponent();
            MainGameForm cw = new MainGameForm();

        }

        private void CorrectWord_Load(object sender, EventArgs e)
        {
            
        }

        private void button_woc1_Click(object sender, EventArgs e)
        {
            MainGameForm m = new MainGameForm();
            m.reJumble();
            this.Close();
        }

        
    }
}
