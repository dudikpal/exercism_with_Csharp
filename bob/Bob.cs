using System;
using System.Text.RegularExpressions;

public static class Bob
{
    public static string Response(string statement)
    {
        return statement switch
        {
            var s when Regex.IsMatch(s.Trim(), "^[^a-z]*[A-Z]+[^a-z]*\\?$") => "Calm down, I know what I'm doing!",
            var s when Regex.IsMatch(s.Trim(), "^[^a-z]*[A-Z]+[^a-z]*[^\\?]$") => "Whoa, chill out!",
            var s when Regex.IsMatch(s.Trim(), "^.+[^A-Z]?[\\s]*\\?\\s*$") => "Sure.",
            var s when Regex.IsMatch(s.Trim(), "^\\s*$") => "Fine. Be that way!",
            _ => "Whatever."
        };
    }
}