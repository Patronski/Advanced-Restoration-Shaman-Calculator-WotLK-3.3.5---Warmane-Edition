using App.Models;
using System;
using System.Windows.Forms;

namespace App
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Forms.Instance.FormStartScreen = new StartScreen();
            Application.Run(Forms.Instance.FormStartScreen);
        }
    }
}