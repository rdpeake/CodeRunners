using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

namespace Utils
{
    public class DllUtils
    {
        public static AppDomain loadDllClass<T>(string path, string className, out T loadedObject) where T : MarshalByRefObject
        {
            loadedObject = null;
            if (!File.Exists(path))
                return null;

            AppDomain mydomain = AppDomain.CreateDomain("import" + Path.GetFileNameWithoutExtension(path), null, AppDomain.CurrentDomain.BaseDirectory, Path.GetDirectoryName(path), false );
            //load the object wanted
            try
            {
                loadedObject = (T)mydomain.CreateInstanceFromAndUnwrap(path, className);
                //return the appDomain the object is loaded into
                return mydomain;
            }
            catch (Exception e)
            {
                AppDomain.Unload(mydomain);
                return null;
            }
        }
    }
}
