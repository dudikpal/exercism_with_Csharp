using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

public static class RunLengthEncoding
{
    public static string Encode(string input)
    {
        if (input.Length == 0)
        {
            return "";
        }
        StringBuilder sb = new StringBuilder();
        int counter = 0;
        char prevChar = input[0];
        for (int i = 0; i < input.Length; i++)
        {
            if (prevChar == input[i])
            {
                counter++;
            }
            else
            {
                if (counter != 1)
                {
                    sb.Append(counter);
                }
                sb.Append(prevChar);
                counter = 1;
                prevChar = input[i];
            }

            if (i == input.Length - 1)
            {
                if (counter != 1)
                {
                    sb.Append(counter);
                }
                sb.Append(prevChar);
            }
        }

        return sb.ToString();
    }

    public static string Decode(string input)
    {
        Regex regex = new Regex(@"\d*[\w\s]");
        
        StringBuilder sb = new StringBuilder();

        List<string> commands = new List<string>();
            
        foreach (Match match in regex.Matches(input))
        {
            commands.Add(match.Value);
        }
        
        Regex regexOnlyNumber = new Regex(@"\d*");
        foreach (string command in commands)
        {
            MatchCollection letter = Regex.Matches(command, @"\D");
            GroupCollection number = regexOnlyNumber.Match(command).Groups;
            char character = char.Parse(letter[0].Value);
            int repeat = 1;
            if (number[0].Value != "")
            {
                repeat = int.Parse(number[0].Value);
            }

            sb.Append(character, repeat);
        }
        
        return sb.ToString();
    }
}
