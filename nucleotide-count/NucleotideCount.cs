using System;
using System.Collections.Generic;

namespace NucleotideCount {
    public static class NucleotideCount
    {
        public static IDictionary<char, int> Count(string sequence)
        {
            Dictionary<char, int> counter = new Dictionary<char, int> {
                ['A'] = 0,
                ['C'] = 0,
                ['G'] = 0,
                ['T'] = 0
            };
        
            foreach (char letter in sequence) {
                if (counter.ContainsKey(letter)) {
                    counter[letter]++;
                }
                else {
                    throw new ArgumentException("Wrong DNA");
                }
            }
        
            return counter;
        }
    }
}