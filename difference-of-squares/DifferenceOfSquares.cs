using System;
using System.Linq;

public static class DifferenceOfSquares
{
    public static int CalculateSquareOfSum(int max)
    {
        return (int)Math.Pow(Enumerable.Range(1, max)
            .Aggregate(0, (prev, actual) => prev + actual), 2);
            
    }

    public static int CalculateSumOfSquares(int max)
    {
        return Enumerable.Range(1, max)
            .Aggregate(0, (prev, actual) => prev + (int)Math.Pow(actual, 2));
    }

    public static int CalculateDifferenceOfSquares(int max)
    {
        return CalculateSquareOfSum(max) - CalculateSumOfSquares(max);
    }
}