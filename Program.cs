/*
Denna fil har skapats som en del av kursen [C# I] på Malmö Universitet 2020
Skapare: Carl-Adam Berglund
e-mail: adam@carl-adam.tech
StudentID: ak7764
*/

using System;
using System.Windows.Forms;

namespace Assignment3
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
            Application.Run(new MainForm());
        }
    }
}
