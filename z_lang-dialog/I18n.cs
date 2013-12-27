using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Language
{
    public class I18n : LanguageImport
    {
        public override Dictionary<string, string> getImportDictionary()
        {
            importDictionary.Add("Chapter1OpeningEpisode1", "Welcome to Code Runners by {#00ff00}Russell Peake{/#}\n" +
                "This is a game which combines Puzzles and Programming. No prior programming knowledge is required as the game introduces you to it along the way");

            importDictionary.Add("Chapter1OpeningEpisode2", "Before we proceed any further, are you a male or female?");
            importDictionary.Add("Chapter1OpeningEpisode3", "So you are a {@player.gender}?");
            importDictionary.Add("Chapter1OpeningEpisode4", "Now, What is your name?");
            importDictionary.Add("Chapter1OpeningEpisode5", "So your name is {@player.name}");
            importDictionary.Add("Chapter1OpeningEpisode6", "Great, Hello {@player.name}.\n" + 
                "I now hand you over to the director of {#000fff}Code Runners Inc.{/#}");
            return base.getImportDictionary();
        }

        /*
        public override string[] getLangList()
        {
            /eturn new string[] { "male", "female" };
        }
         */
    }
}
