using System;
using System.Text.RegularExpressions;

public static class PhoneNumber
{
    public static (bool IsNewYork, bool IsFake, string LocalNumber) Analyze(string phoneNumber)
    {
        return (Regex.IsMatch(phoneNumber, "^212-\\d{3}-\\d{4}"),
            Regex.IsMatch(phoneNumber, "^\\d{3}-555-\\d{4}"), 
            phoneNumber.Substring(phoneNumber.Length - 4));
    }

    public static bool IsFake((bool IsNewYork, bool IsFake, string LocalNumber) phoneNumberInfo)
    {   
        return phoneNumberInfo.IsFake;
    }
}
