﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Language
{
    class CSharp : ILanguage
    {

        public ICompiler Compiler
        {
            get { throw new NotImplementedException(); }
        }
    }
}
