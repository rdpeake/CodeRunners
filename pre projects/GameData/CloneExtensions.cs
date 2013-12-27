using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace GameData
{
    internal static class CloneExtensions
    {
        public static void CopyFrom(this GameData To, GameData From, bool SkipNonSerialized = true)
        {
            Type targetType = To.GetType();
            Type sourceType = From.GetType();

            PropertyInfo[] sourceProps = sourceType.GetProperties();
            foreach (var propInfo in sourceProps)
            {
                //filter the properties
                if (propInfo.GetCustomAttributes(typeof(NonSerializedAttribute), false).Length == 0 && SkipNonSerialized)
                    continue;

                //Get the matching property from the target
                PropertyInfo toProp =
                  (targetType == sourceType) ? propInfo : targetType.GetProperty(propInfo.Name);

                //If it exists and it's writeable
                if (toProp != null && toProp.CanWrite)
                {
                    //Copy the value from the source to the target
                    Object value = propInfo.GetValue(From, null);
                    toProp.SetValue(To, value, null);
                }
            }
        }
    }
}
