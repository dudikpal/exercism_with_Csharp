using System;
using System.Text;
using System.Text.RegularExpressions;

static class LogLine
{
    public static string Message(string logLine)
    {
        return logLine.Split(":")[1].Trim();
    }

    public static string LogLevel(string logLine)
    {
        return Regex.Split(logLine, "\\[|\\]")[1].ToLower();
    }

    public static string Reformat(string logLine)
    {        
        StringBuilder sb = new StringBuilder();
        sb.Append(Message(logLine))
            .Append(" (")
            .Append(LogLevel(logLine))
            .Append(")");

        return sb.ToString();
    }
}
