using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;


public class RailFenceCipher
{
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

        for (int i = 0; i < arraysLength.Length - 1; i++)
        {
            if (i == 0)
            {
                arraysLength[0] = baseLength;
                arraysLength[arraysLength.Length - 1] = baseLength;
            }
            else
            {
                arraysLength[i] = baseLength * 2;
            }
        }
        
        for (int i = 0; i < remain; i++)
        {
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

        int startPosition = 0;
        
        for (int i = 0; i < arraysLength.Length; i++)
        {
            int length = arraysLength[i];
            encodedArrays[i] = new List<char>(input.Substring(startPosition, length).ToCharArray());
            startPosition += length;
        }

        verticalMove = 0;
        increase = true;
        StringBuilder sb = new StringBuilder();
        
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

            sb.Append(encodedArrays[verticalMove][0]);
            encodedArrays[verticalMove].RemoveAt(0);
            
            if (increase)
            {
                verticalMove++;
            }
            else
            {
                verticalMove--;
            }
        }
        return sb.ToString();
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