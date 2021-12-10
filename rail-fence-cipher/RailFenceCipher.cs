using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;


public class RailFenceCipher
{
    /*public static void Main(string[] args)

    {
        RailFenceCipher start = new RailFenceCipher(3);
        Console.WriteLine(start.Encode("WE ARE DISCOVERED FLEE AT ONCE"));

    }*/

    private int rails;
    private List<char>[] message;

    public RailFenceCipher(int rails)
    {
        this.rails = rails;
    }



    public string Encode(string input)
    {
        return encodeString(input, true, 0);
    }

    public string Decode(string input)
    {
        return decodeString(input);
    }


    private string decodeString(string input)
    {
        int[] arrayIndexWithPlusLetter = new int[input.Length % rails];
        for (int i = 0; i < input.Length % rails; i++)
        {
            arrayIndexWithPlusLetter[i] = i;
        }

        string[] lines = new string[rails];
        for (int i = 0; i < rails; i++)     
        {
            int 
            lines[i] = input.
        }
        Console.WriteLine(arrayIndexWithPlusLetter);
        return null;
    }
    
    private string encodeString(string input, bool increase, int verticalMove)
    {
        input = Regex.Replace(input, "\\s", "");
        message = new List<char>[rails];

        for (int i = 0; i < rails; i++)
        {
            message[i] = new List<char>();
        }

        for (int i = 0; i < input.Length; i++)
        {
            if (verticalMove == rails - 1)
            {
                increase = false;
            }
            else if (verticalMove == 0)
            {
                increase = true;
            }

            message[verticalMove].Add(input[i]);

            if (increase)
            {
                verticalMove++;
            }
            else
            {
                verticalMove--;
            }
        }

        StringBuilder sb = new StringBuilder();
        foreach (List<char> list in message)
        {
            sb.Append(string.Join("", list));
        }

        return sb.ToString();
    }
    
}