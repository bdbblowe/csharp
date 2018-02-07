using System;
using System.Collections.Generic;

public static class ReverseString
{
    public static string Reverse(string input)
    {
        if (input.Length == 0)
        {
            return "";
        }
        else
        {
            char[] charArray = input.ToCharArray();
            Array.Reverse(charArray);

            string reversedString = new string(charArray);
            return reversedString;
        }
    }
}
