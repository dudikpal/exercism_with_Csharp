using System;

namespace Acronymspace
{
    
    public static class Acronym
    {
        public static string Abbreviate(string phrase)
        {
            string result = "";
            string[] words = phrase.Split(new char[]{' ', '-', '_'}, StringSplitOptions.RemoveEmptyEntries);
            foreach (string word in words)
            {
                if (char.IsLetter(word[0]))
                {
                    result += word[0];
                }
            }
            return result.ToUpper();
        }
    }
}
