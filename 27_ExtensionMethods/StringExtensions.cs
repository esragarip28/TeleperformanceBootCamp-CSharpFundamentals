using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27_ExtensionMethods
{
    public static class StringExtensions
    {
        public static string ReverseString(this string text)
        {
            string reversed = string.Empty;
           
            for(int i = text.Length - 1; i >=0; i--)
            {
                reversed += text[i];
            }
            return reversed;
        }

    }
}
