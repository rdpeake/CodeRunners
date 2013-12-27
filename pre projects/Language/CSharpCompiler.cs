using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.CodeDom.Compiler;
using Microsoft.CSharp;

namespace Language
{
    class CSharpCompiler : ICompiler
    {
        public object Compile(string filename, List<string> references)
        {
            if (System.IO.File.Exists(filename))
            {
                return Compile(System.IO.File.OpenRead(filename), references);
            }
            return null;
        }

        public object Compile(System.IO.Stream Content, List<string> references)
        {
            CodeDomProvider cc = CodeDomProvider.CreateProvider("CSharp");
            CompilerParameters cp = new CompilerParameters();
            cp.OutputAssembly = Environment.CurrentDirectory + "\\Output_csharp.dll";
            cp.ReferencedAssemblies.Add("System.dll");
            cp.ReferencedAssemblies.Add("System.Core.dll");
            cp.ReferencedAssemblies.Add("System.Data.dll");
            cp.ReferencedAssemblies.Add("System.Xml.dll");
            cp.ReferencedAssemblies.Add("Microsoft.CSharp.dll");

            foreach (string assembly in references)
            {
                cp.ReferencedAssemblies.Add(assembly);
            }

            cp.WarningLevel = 3;

            cp.CompilerOptions = "/target:library /optimize";
            cp.GenerateExecutable = false;
            cp.GenerateInMemory = false; //TODO check this setting

            System.IO.StreamReader sr = new System.IO.StreamReader(Content);

            CompilerResults cr = cc.CompileAssemblyFromSource(cp, sr.ReadToEnd());

            return cr;
        }


        public object getLastCompiledClass(string className)
        {
            if (!System.IO.File.Exists(Environment.CurrentDirectory + "\\Output_csharp.dll"))
            {
                return null;
            }                

            AppDomainSetup ads = new AppDomainSetup();
            ads.ShadowCopyFiles = "true";
            AppDomain newDomain = AppDomain.CreateDomain("newDomain");

            byte[] rawAssembly = System.IO.File.ReadAllBytes(Environment.CurrentDirectory + "\\Output_csharp.dll");
            System.Reflection.Assembly assembly = newDomain.Load(rawAssembly, null);
            object value = assembly.CreateInstance(className);
            AppDomain.Unload(newDomain);
            return value;
        }
    }
}
