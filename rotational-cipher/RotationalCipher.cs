using System;
using System.Text;

public static class RotationalCipher
{
    public static string Rotate(string text, int shiftKey)
    {
        StringBuilder sb = new StringBuilder();
        foreach (char letter in text)
        {
            if (Char.IsLetter(letter))
            {
                sb.Append(charRotator(letter, shiftKey));
            }
            else
            {
                sb.Append(letter);
            }
        }

        return sb.ToString();
    }


    public static Char charRotator(Char letter, int rotate)
    {
        if (Char.IsUpper(letter))
        {
            if ((int)letter + rotate > 90)
            {
                return (Char)((int)letter + rotate - 90 + 64);
            }
        }
        else
        {
            if ((int)letter + rotate > 122)
            {
                return (Char)((int)letter + rotate - 122 + 96);
            }
        }

        return (Char)((int)letter + rotate);
    }
}