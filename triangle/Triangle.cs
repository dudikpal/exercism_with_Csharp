using System;

public static class Triangle
{
    public static bool IsScalene(double side1, double side2, double side3)
    {
        return side1 != side2 && side2 != side3 && side1 != side3 && isTriangle(side1, side2, side3);
    }

    public static bool IsIsosceles(double side1, double side2, double side3) 
    {
        return (side1 == side2
            || side2 == side3
            || side1 == side3)
            && isTriangle(side1, side2, side3);
    }

    public static bool IsEquilateral(double side1, double side2, double side3) 
    {
        return side1 == side2 && side2 == side3 && side1 != 0;
    }


    private static bool isTriangle(double side1, double side2, double side3)
    {
        return side1 + side2 > side3
            && side2 + side3 > side1
            && side1 + side3 > side2;
    }
}