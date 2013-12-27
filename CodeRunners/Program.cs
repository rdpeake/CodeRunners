using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeRunners
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
            Application.Run(new MyContext());
        }
    }

    public class MyContext : ApplicationContext
    {
        public MyContext()
        {
            MenuScreen ms = new MenuScreen();
            new SplashScreen(ms).Show();
            ms.Shown += ms_Shown;
        }

        void ms_Shown(object sender, EventArgs e)
        {
            MenuScreen ms = sender as MenuScreen;
            ms.Shown -= ms_Shown;
            this.MainForm = ms;
        }
    }
}
