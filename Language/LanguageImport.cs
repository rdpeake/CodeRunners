using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Language
{
    public abstract class LanguageImport : MarshalByRefObject
    {
        public Dictionary<string, string> importDictionary = new Dictionary<string, string>();

        public virtual Dictionary<string, string> getImportDictionary()
        {
            return importDictionary;
        }

        public virtual string[] getLangList()
        {
            return null;
        }
    }
}
