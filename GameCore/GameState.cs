using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StoryLine;
using Utils;
using System.IO;


namespace CodeRunners.Game
{
    public static class GameState
    {
        public static CurrentGame currentGame = new CurrentGame();

        #region load story line
        private static Story storyLine = null;
        private static AppDomain storyDomain;

        public static bool loadStoryLine(string path)
        {
            storyDomain = DllUtils.loadDllClass<Story>(path, "StoryLine.StoryLine", out storyLine);
            if (storyDomain != null && storyLine != null)
            {
                //load strings
                foreach (string s in storyLine.getLang())
                {
                    Language.Lang.loadLanguage(s);
                }
                return true;
            }
            if (storyDomain != null)
            {
                AppDomain.Unload(storyDomain);
            }
            return false;
        }
        #endregion

        #region SaveGames
        private static DirectoryInfo saveDirectory = null;
        public static bool loadSaves(string saveDirectoryPath)
        {
            if (File.Exists(saveDirectoryPath))
            {
                saveDirectory = new DirectoryInfo(saveDirectoryPath);
            }
            if (saveDirectory == null)
                return false;

            //check if there are save files in directory
            if (saveDirectory.GetFiles().Length == 0)
                return false;
            int count = 0;
            foreach (FileInfo file in saveDirectory.GetFiles()) {
                if (file.Extension == "sav")
                    count++;
            }
            return count > 0;
        }

        public static FileInfo[] getSaveNames()
        {
            List<FileInfo> names = new List<FileInfo>();
            foreach (FileInfo file in saveDirectory.GetFiles())
            {
                if (file.Extension == "sav")
                    names.Add(file);
            }
            return names.ToArray();
        }

        public static bool loadSave(string name)
        {
            //update current game...
            try
            {
                currentGame = CurrentGame.load(Path.Combine(saveDirectory.ToString(), name + ".sav"));
                return true;
            }
            catch (Exception e)
            {
                currentGame = new CurrentGame();
                return false;
            }
        }

        //saves the current game state
        public static bool saveGame()
        {
            //save current game as .sav
            return currentGame.Save(Path.Combine(saveDirectory.ToString(), currentGame["Player.Name"] + ".sav")); //TODO improve the robustness of this...
        }
#endregion

        public static Chapter getCurrentChapter()
        {
            if (storyLine == null)
                throw new InvalidOperationException("StoryLine is not loaded");

            //TODO work out how to get the current state, using variables of some form which can be saved and loaded
            if (currentGame["Story.CurrentChapter"] == null) 
                currentGame["Story.CurrentChapter"] = "0";
            return storyLine[(int)currentGame["Story.CurrentChapter"]];
        }

        public static object getVariable(string name)
        {
            return currentGame[name];
        }

        public static object setVariable(string name, object value)
        {
            return (currentGame[name] = value);
        }

        public static void clearVariableScope(string scopeName)
        {
            currentGame.clearScope(scopeName);
        }
    }
}
