using System;
using System.Text;

public static class Identifier
{
    public static string Clean(string identifier)
    {
        StringBuilder sb = new StringBuilder();
        bool upperNext = false;

        foreach (char letter in identifier.ToCharArray())
        {
            if (letter == ' ')
            {
                sb.Append('_');
            } else if (letter < 13)
            {
                sb.Append("CTRL");
            } else if (letter >= 'α' && letter <= 'ω')
            {
                continue;
            } else if (letter == '-')
            {
                upperNext = true;
            } else if (upperNext)
            {
                sb.Append(Char.ToUpper(letter));
                upperNext = false;
            } else if (Char.IsLetter(letter))
            {
                sb.Append(letter);
            }
        }

        return sb.ToString();
    }
}
