using System;


public static class LogAnalysis 
{
    // TODO: define the 'SubstringAfter()' extension method on the `string` type
    public static string SubstringAfter(this String str, string splitter)
    {
        return str.Substring(str.IndexOf(splitter) + splitter.Length);
    }

    // TODO: define the 'SubstringBetween()' extension method on the `string` type
    public static string SubstringBetween(this String str, string beginSplit, string endSplit)
    {
        return str.Split(Char.Parse(beginSplit), Char.Parse(endSplit))[1];
    }

    // TODO: define the 'Message()' extension method on the `string` type
    public static string Message(this String str)
    {
        return str.Substring(str.IndexOf(':') + 2);
    }

    // TODO: define the 'LogLevel()' extension method on the `string` type
    public static string LogLevel(this String str)
    {
        return str.Split('[', ']')[1];
    }
}