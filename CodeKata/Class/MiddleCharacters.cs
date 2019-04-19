using System;
using System.Collections.Generic;
using System.Text;

namespace CodeKata.Class
{
    public static class MiddleCharacters
    {
        public static string GetMiddleCharacters(string s)
        {
            string result = "";

            if (s.Length % 2 == 0)
            {
                int charsToRemove = (s.Length - 2) / 2;
                result =  s.Substring(charsToRemove, 2);
            }
            else
            {
                int charsToRemove = (s.Length - 1) / 2;
                result = s.Substring(charsToRemove, 1);
            }

            return result;
        }
    }
}
