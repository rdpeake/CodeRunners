using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Language
{
    class I18n : LanguageImport
    {
        public override Dictionary<string, string> getImportDictionary()
        {
            importDictionary.Add("New_game", "New Game");
            importDictionary.Add("Exit", "Exit");
            importDictionary.Add("Continue", "Continue");
            importDictionary.Add("Options", "Options");
            return base.getImportDictionary();
        }

        public override string[] getLangList()
        {
            return new string[] { "male", "female" };
        }
    }
}
