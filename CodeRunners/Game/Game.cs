using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeRunners.Game.Forms;

using System.IO;
using System.Windows.Forms;

namespace CodeRunners.Game
{
    class Game
    {
        private MenuScreen mainForm;
        private HostForm hostForm;
        private volatile bool RunGame = true;

        public Game(MenuScreen mainForm)
        {
            this.mainForm = mainForm;

            //load story line for game state
            if (!GameState.loadStoryLine(Path.Combine(Application.StartupPath, "Data", "story.dll")))
                throw new FileNotFoundException("Could not find the storyLine file, /Data/stroy.dll");//do nothing at the moment;

            hostForm = new HostForm();

            hostForm.ShowDialog();

            mainForm.Show();

            //new System.Threading.Thread(GameLoop).Start();
        }

        private void GameLoop()
        {
            //load resources
            hostForm = new HostForm();

            //set first Display Window
            //hostForm.setChapter(GameState.getCurrentChapter());

            hostForm.Show();
            //Main Loop
            do
            {
                System.Windows.Forms.Application.DoEvents();
            } while (RunGame && !hostForm.IsDisposed);

            //Cleanup


            mainForm.Invoke((Action)(() => mainForm.Show()));
        }
    }
}
