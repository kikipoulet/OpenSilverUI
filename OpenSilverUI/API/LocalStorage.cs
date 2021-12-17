using OpenSilver;
using System;
using System.Collections.Generic;
using System.Text;

namespace OpenSilverApplication3
{
    public static class LocalStorage
    {
        public static void Set(string key, string value)
        {
            Interop.ExecuteJavaScript($"localStorage.setItem('{key}', '{value}');");
        }

        public static string Get(string key)
        {
            return Interop.ExecuteJavaScript($"localStorage.getItem('{key}');").ToString();
        }
    }
}
