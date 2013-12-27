using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

using System.Reflection;

namespace Language
{
    public static class Lang
    {
        private static DirectoryInfo rootDirectory;
        private static List<string> loaded_languages = new List<string>();

        private static Dictionary<string, Dictionary<string, string>> LoadedDictionaries = new Dictionary<string,Dictionary<string,string>>();

        public static void setLanguageRoot(string path)
        {
            if (Directory.Exists(path))
            {
                rootDirectory = new DirectoryInfo(path);
                loadLanguage("");
            }
        }

        private static string currentLanguage = "en";
        public static bool setLanguage(string language)
        {
            if (currentLanguage != language)
            {
                currentLanguage = language;
                loadLanguage("");
                return true;
            }
            return false;
        }

        public static string getString(string name)
        {
            string[] split = name.Split('.');
            //instace name
            string instance = split.Last();
            string namespace_string = String.Join(".", split.Take(split.Length - 1));
            namespace_string += '.' + currentLanguage;
            if (LoadedDictionaries.ContainsKey(namespace_string))
            {
                if (LoadedDictionaries[namespace_string].ContainsKey(instance))
                {
                    return LoadedDictionaries[namespace_string][instance];
                }
            }

            //if value doesn't exist.
            return instance.Replace('_', ' ');
        }

        public static bool loadLanguage(string language)
        {
            if (rootDirectory == null)
                throw new InvalidOperationException("The language root must be set prior to loading languages");
            if (loaded_languages.Contains(language + "." + currentLanguage)) //don't reload a language
                return false;
            string[] namespaces = language.Split('.');
            List<string> paths = new List<string>() { rootDirectory.ToString() };
            paths.AddRange(namespaces);
            //build path variable
            string path = Path.Combine(paths.ToArray());
            path = Path.Combine(path, currentLanguage + ".dll");
            Console.WriteLine(path);
            if (!File.Exists(path))
                return false;

            try
            {
                AppDomain mydomain = AppDomain.CreateDomain("lang import", null);
                //load the language dll
                LanguageImport li = (LanguageImport)mydomain.CreateInstanceFromAndUnwrap(path, "Language.I18n");
                /*Assembly asm = Assembly.LoadFrom(path);
                //get the language dictionary
                LanguageImport li = (LanguageImport)asm.CreateInstance("Language.I18n");*/
                //add it to the current dictionary
                addDictionary(language + '.' + currentLanguage, li.getImportDictionary());
                //add loaded language to list
                loaded_languages.Add(language + '.' + currentLanguage);

                //get list of languages to load
                string[] langlist = li.getLangList();
                AppDomain.Unload(mydomain);
                if (langlist != null)
                    foreach (string lang in langlist)
                        loadLanguage(lang);
                
                //return true for success
                return true;
            }
            catch (Exception e)
            {
                //log the exception and return false
                Console.WriteLine(e.ToString());
                return false;
            }
        }

        private static void addDictionary(string language, Dictionary<string, string> dictionary)
        {
            if (LoadedDictionaries.ContainsKey(language))
                throw new InvalidOperationException("Language is attempting to load an already loaded language");
            LoadedDictionaries.Add(language, dictionary);
        }

        public static string[] getLangs()
        {
            List<string> langs = new List<string>();
            //get all files in the root directory
            FileInfo[] fis = rootDirectory.GetFiles();
            foreach (FileInfo fi in fis)
            {
                if (fi.Extension == "dll")
                {
                    if (Path.GetFileNameWithoutExtension(fi.Name).Length == 2)
                    {
                        langs.Add(Path.GetFileNameWithoutExtension(fi.Name));
                    }
                }
            }
            return langs.ToArray();
        }
    }
}
