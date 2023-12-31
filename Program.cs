using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Group_11___COSC_31112
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Log());
            //Application.Run(new Form6());
            //Application.Run(new addNewAcc());
            //Application.Run(new frmAddNewSubT());
            // Application.Run(new Home());
            //Application.Run(new Form7());

        }
    }
}
