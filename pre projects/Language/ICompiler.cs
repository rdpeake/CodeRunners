using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Language
{
    public interface ICompiler
    {
        object Compile(string filename, List<String> references);
        object Compile(System.IO.Stream Content, List<String> references);
        object getLastCompiledClass(string className);
    }
}
