using System;
using System.Windows.Forms;

namespace SimCorp.IMS.CSharpPrepCourse.GUI
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
            //Lab#2
            //Application.Run(new PlaybackForm());

            //Lab#3,4
            Application.Run(new SMSForm());
        }
    }
}
