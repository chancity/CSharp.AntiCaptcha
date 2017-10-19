using System;
using System.Net;
using System.Windows.Forms;
using AntiCaptchaUI.View;

namespace AntiCaptchaUI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ServicePointManager.DefaultConnectionLimit = 100;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new CaptchaListViewForm());
        }
    }
}
