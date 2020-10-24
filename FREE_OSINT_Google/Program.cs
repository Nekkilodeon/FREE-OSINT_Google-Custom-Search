using Main;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FREE_OSINT_Google
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (Config.Instance.first_time)
            {
                Application.Run(new SettingUp());
            }
            else
            {
                Application.Run(new FREE_OSINT_Google_MainForm());
            }
        }
    }
}
