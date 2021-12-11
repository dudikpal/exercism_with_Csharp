﻿using System;
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
        int sampleLength = (rails * 2) - 2;
        int remain = input.Length % sampleLength;
        int baseLength = (input.Length - remain) / sampleLength;
        int[] arraysLength = new int[rails];
        int verticalMove = 0;
        bool increase = true;
        List<char>[] encodedArrays = new List<char>[rails];
        for (int i = 0; i < remain; i++)
        {
            if (i < rails)
            {
                if (i == 0 || i == rails - 1)
                {
                    arraysLength[i] = baseLength;
                }
                else
                {
                    arraysLength[i] = baseLength * 2;
                }
            }
            if (verticalMove == rails - 1)
            {
                increase = false;
            }
            else if (verticalMove == 0)
            {
                increase = true;
            }

            arraysLength[i]++;

            if (increase)
            {
                verticalMove++;
            }
            else
            {
                verticalMove--;
            }
        }
        
        
        Console.WriteLine(arraysLength);
        
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