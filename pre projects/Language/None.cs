using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Language
{
    public class None : ILanguage
    {
        public ICompiler Compiler
        {
            get { throw new NotImplementedException(); }
        }


    }
}
