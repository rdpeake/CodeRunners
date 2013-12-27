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
            importDictionary.Add("puzzle_1_line1", "puzzle 1 line 1 text here!");
            return base.getImportDictionary();
        }

        /*
        public override string[] getLangList()
        {
            return new string[] { "male", "female" };
        }
         */
    }
}
