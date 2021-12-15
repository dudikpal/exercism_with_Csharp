using System;
using System.Text;

public static class ResistorColorDuo
{
    public static int Value(string[] colors)
    {
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < 2; i++)
        {
            sb.Append(getValueOfColor(colors[i]));
        }

        return Int32.Parse(sb.ToString());
    }


    private static int getValueOfColor(string color) => color switch
    {
        "black" => 0,
        "brown" => 1,
        "red" => 2,
        "orange" => 3,
        "yellow" => 4,
        "green" => 5,
        "blue" => 6,
        "violet" => 7,
        "grey" => 8,
        "white" => 9
    };

}
