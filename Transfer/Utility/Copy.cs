using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;

namespace Transfer.Utility
{
    static class Copy
    {
        public static void PublicProp<T>(T src, T dest)
        {
            var props = typeof(T).GetProperties(BindingFlags.Public);
            foreach (var a in props)
            {
                a.SetValue(dest, a.GetValue(src));
            }
        }
    }
}
