using OpenSilver;
using System;
using System.Collections.Generic;
using System.Text;

namespace SukiUI.API
{
    public static class LocalStorage
    {
        public static void Set(string key, string value) => Interop.ExecuteJavaScript($"localStorage.setItem('{key}', '{value}');");
        
        public static string Get(string key)
        {
            return Interop.ExecuteJavaScript($"localStorage.getItem('{key}');").ToString();
        }

        public static void Remove(string key) => Interop.ExecuteJavaScript($"localStorage.removeItem('{key}');");

        public static void Clear() => Interop.ExecuteJavaScript($"localStorage.clear();");
    }
}
