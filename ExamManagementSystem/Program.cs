using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamManagementSystem
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
            //Application.Run(new SplashScreenWindow());
            //Application.Run(new Form1());
            //Application.Run(new InstructorWindow());
            //Application.Run(new ExamWindow());
            //Application.Run(new SigninWindow());
            Application.Run(new AdminWindow());
            //Application.Run(new AddRemoveCourse());
        }
    }
}
