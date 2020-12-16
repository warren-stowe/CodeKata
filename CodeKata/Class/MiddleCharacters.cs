using System;
using System.Collections.Generic;
using System.Text;

namespace CodeKata.Class
{
    public static class MiddleCharacters
    {
        //You are going to be given a word. Your job is to return the middle character of the word. If the word's length is odd, return the middle character. 
        // If the word's length is even, return the middle 2 characters.
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
