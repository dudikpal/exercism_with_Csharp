using System;
using System.Linq;

namespace Hamming {
    public static class Hamming
    {
        public static int Distance(string firstStrand, string secondStrand)
        {
            if (firstStrand.Length != secondStrand.Length)
            {
                throw new ArgumentException("Need equal sequences!");
            }
            return firstStrand.Where((x, y) => x != secondStrand[y]).Count();
        }
    }
}