using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Language;
using System.IO;

namespace CodeRunners
{
    public partial class MenuScreen : Form
    {
        public MenuScreen()
        {
            Lang.setLanguageRoot(Path.Combine(Application.StartupPath, "Data", "Lang"));
            //load in saved lang setting
            //Lang.setLanguage("en");
            

            InitializeComponent();
            string path;
            if (File.Exists(path = Path.Combine(Application.StartupPath, "data", "Images", "Menu.bmp").ToString())) {
                this.BackgroundImage = Bitmap.FromFile(path);
            }
            setLangButtonText();

            if (HasSave())
                btnContinue.Enabled = true;
        }

        private void setLangButtonText()
        {
            btnContinue.Text = Lang.getString("Continue");
            btnExit.Text = Lang.getString("Exit");
            btnNew.Text = Lang.getString("New_game");
            btnOptions.Text = Lang.getString("Options");
        }

        private bool HasSave()
        {
            //TODO check for save?
            return false;
        }

        private void StartGame()
        {
            this.Hide();
            new Game.Game(this);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //TODO determine save?
            //show the loadGame Menu;
            (new LoadGame()).ShowDialog();
            StartGame();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StartGame();
        }

        private void btnOptions_Click(object sender, EventArgs e)
        {
            (new Options()).isHome().ShowDialog();
            //what steps do i need to do for option change?
            //reload language for buttons
            setLangButtonText();
        }
    }
}
