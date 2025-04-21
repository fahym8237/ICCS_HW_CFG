using System;
using System.Windows.Forms;

namespace ICCS_HW_CFG
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new Form2()); // Start with the Login Form
        }
    }
}
