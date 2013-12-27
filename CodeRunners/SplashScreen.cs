using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;

namespace CodeRunners
{
    public partial class SplashScreen : Form
    {
        private Timer LoadTimer;
        MenuScreen mainForm;

        public SplashScreen(MenuScreen mainForm)
        {
            this.mainForm = mainForm;
            InitializeComponent();
            LoadTimer = new Timer();
            LoadTimer.Interval = (int)TimeSpan.FromSeconds(10).TotalMilliseconds;
            LoadTimer.Tick += LoadTimer_Tick;
            LoadTimer.Start();

            //load backimage from file
            string path;
            if (File.Exists(path = Path.Combine(Application.StartupPath, "Data", "Images", "Splash.bmp")))
            {
                this.BackgroundImage = Bitmap.FromFile(path);
                this.Width = this.BackgroundImage.Width;
                this.Height = this.BackgroundImage.Height;
            }
        }


        void LoadTimer_Tick(object sender, EventArgs e)
        {
            LoadTimer.Stop();
            this.Close();
            this.Dispose();
            //TODO incorporate wait for mainForm to load async...
            mainForm.Show();
        }
    }
}
