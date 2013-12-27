using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace CodeRunners.Game
{
    public class CurrentGame
    {
        public string VariableDisplayColour = System.Drawing.ColorTranslator.ToHtml(System.Drawing.Color.DarkBlue);
        //set default values
        private Dictionary<string, Dictionary<string, object>> Variables = new Dictionary<string, Dictionary<string, object>>()
        {
            {"Player", new Dictionary<string, object>() {
                {"Name", ""},
                {"Gender", ""},
                {"Tokens", 0},
                {"AssembleLanguage", ""},
                {"ProgramLanguage", ""}
            }},
            {"Player.Tokens", new Dictionary<string, object>() {
                {"PuzzleHint", 0},
                {"CodeHint", 0},
                {"CodePass", 0}
            }},
            {"Puzzles", new Dictionary<string, object>() {
                {"Complete", 0},
                {"Available", 0}
            }},
            {"Puzzles.Complete", new Dictionary<string, object>()},
            {"Puzzles.Avaiable", new Dictionary<string, object>()},
            {"Story", new Dictionary<string, object>() {
                {"CurrentChapter", 0}
            }},
            {"Story.CurrentChapter", new Dictionary<string, object>() {
                {"Episode", 0},
                {"PlayedOpening", false},
                {"Level", 0}
            }}
        };

        public object this[string variable, Boolean color = true]
        {
            get
            {
                //get the scope
                string[] split = variable.Split('.');
                string scope = String.Join(".", split.Take(split.Length - 1));
                if (Variables.ContainsKey(scope) && Variables[scope].ContainsKey(split.Last()))
                {
                    object retval = Variables[scope][split.Last()];
                    if (color && retval is string)
                    {
                        return "{#" + VariableDisplayColour + "}" + retval + "{/#}";
                    }
                    return retval;
                }
                return null;
            }
            set
            {
                string[] split = variable.Split('.');
                string scope = String.Join(".", split.Take(split.Length - 1));
                if (Variables.ContainsKey(scope) && Variables[scope].ContainsKey(split.Last()))
                {
                    Variables[scope][split.Last()] = value;
                }
                else
                {
                    if (!Variables.ContainsKey(scope)) //if scope is not there, add it before adding variable
                    {
                        Variables.Add(scope, new Dictionary<string, object>());
                    }
                    Variables[scope].Add(split.Last(), value);
                }
                
            }
        }

        /// <summary>
        /// clears existing scopes or adds new scope with name 'scope'
        /// </summary>
        /// <param name="scope">name of scope to clear or add</param>
        public void clearScope(string scope)
        {
            if (Variables.ContainsKey(scope)) {
                Variables[scope] = new Dictionary<string,object>();
            } else {
                Variables.Add(scope, new Dictionary<string,object>());
            }
        }

        #region Save/Load
        public static CurrentGame load(string path)
        {
            if (File.Exists(path))
            {
                FileStream fs = File.OpenRead(path);
                BinaryFormatter bf = new BinaryFormatter();
                Dictionary<string, Dictionary<string, object>> variables = (Dictionary<string, Dictionary<string, object>>)bf.Deserialize(fs);
                CurrentGame cg = new CurrentGame();
                cg.Variables = variables;
                return cg;
            }
            else
            {
                throw new FileNotFoundException();
            }
        }

        public bool Save(string path)
        {
            if (Directory.Exists(Path.GetDirectoryName(path))) {
                FileStream fs;
                try
                {
                   fs = File.Create(path);
                }
                catch (Exception e)
                {
                    throw e;
                }
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fs, Variables);
                fs.Flush();
                fs.Close();
                return true;
            }
            return false;
        }
        #endregion
    }
}
