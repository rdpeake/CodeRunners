using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

using Language;

namespace CodeRunners.Game
{
    public static class Text
    {
        public static string processString(string s)
        {
            //replace variables strings to start with
            string retval = replaceVariables(s);

            //Loop until no lang replace exist, replacing any variable structures that show up in the process
            while (System.Text.RegularExpressions.Regex.IsMatch(retval, @"\{\$[a-zA-Z0-9_\.]*\}"))
            {
                retval = System.Text.RegularExpressions.Regex.Replace(retval, @"\{\$[a-zA-Z0-9_\.]*\}", (Match m) =>
                {
                    return Lang.getString(m.Value.Substring(2, m.Value.Length - 3)); //remoe the {$} and send to lang.
                }); 
                //replace any new variable strings
                if (System.Text.RegularExpressions.Regex.IsMatch(retval, @"\{@[a-zA-Z0-9_\.]*\}"))
                    retval = replaceVariables(retval);
            }
            return retval;
        }

        private static string replaceVariables(string s)
        {
            string retval = s;
            //Loop until no variables exist...
            while (System.Text.RegularExpressions.Regex.IsMatch(retval, @"\{@[a-zA-Z0-9_\.]*\}"))
            {
                //replace {#...} with gameState.getVariable(...) 
                retval = System.Text.RegularExpressions.Regex.Replace(retval, @"\{@[a-zA-Z0-9_\.]*\}", (Match m) =>
                {
                    return GameState.getVariable(m.Value.Substring(2, m.Value.Length - 3)).ToString(); //remove the {#}
                });
            }
            return retval;
        }
    }
}
