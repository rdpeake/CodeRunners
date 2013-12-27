using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameData
{
    [Serializable]
    public class SaveState
    {
        [Serializable]
        public class PuzzleState
        {
            public bool isAnswered { get; set; }
            public Dictionary<string, int> Tokens {get; set;}
        }

        public static string[] TokenNames = { "Hint", "Code", "Pass" };
        public Dictionary<int, PuzzleState> PuzzleStates { get; set; }
        public Dictionary<string, object> settings { get; set; }
        public Dictionary<string, int> Tokens { get; set; }

        public SaveState()
        {
            settings = new Dictionary<string, object>();
            Tokens = new Dictionary<string, int>();
            Tokens.Add("Hint", 0);
            Tokens.Add("Code", 0);
            Tokens.Add("Pass", 0);
        }

        public int CurrentLevel { get; set; }
        public bool PlayedIntro { get; set; }

        public void setLevel(int Level)
        {
            this.CurrentLevel = Level;
            PlayedIntro = false;
        }

        public object this[string index]
        {
            get
            {
                if (settings.ContainsKey(index))
                    return settings[index];
                return "";
            }
            set
            {
                if (settings.ContainsKey(index))
                    settings[index] = value;
                else
                    settings.Add(index, value);
            }
        }

    }
}
