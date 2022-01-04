using COMPROG2_FINPROJ_DRAWY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;

namespace COMPROG2_FINPROJ
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.Run(new LoadingBar());
            Application.Run(new GTW());
            // Application.Run(new ZGRET());
            Application.Run(new MainGameForm());
            




        }




    }
}
