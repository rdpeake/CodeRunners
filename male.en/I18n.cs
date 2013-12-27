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
            importDictionary.Add("single", "him");
            return base.getImportDictionary();
        }
    }
}
