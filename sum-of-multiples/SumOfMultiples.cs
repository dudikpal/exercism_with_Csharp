using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

public static class SumOfMultiples
{
    public static int Sum(IEnumerable<int> multiples, int max)
    {
        HashSet<int> result = new HashSet<int>();

        foreach (int multiple in multiples)
        {
            for (int i = 1; i < max; i++)
            {
                if (multiple * i >= max)
                {
                    break;
                }

                result.Add(multiple * i);
            }
        }

        return result.Aggregate(0, (acc, x) => acc + x);
    }
}