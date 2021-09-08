using System;
using System.Collections.Generic;
using System.Linq;

namespace Isogram {
    public static class Isogram
    {
        public static bool IsIsogram(string word)
        {
            if (word.Length == 0)
            {
                return true;
            }
            HashSet<char> chars = new HashSet<char>();
            string wordToProcess = new string(word.ToLower().Where(Char.IsLetter).ToArray());
            foreach (char item in wordToProcess)
            {
                chars.Add(item);
            }

            if (chars.Count == wordToProcess.Length)
            {
                return true;
            }
            return false;
        }
    }
}
