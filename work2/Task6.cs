using System;

public class Task6
{
    public static void Run(string text)
    {
        string result = "";
        bool makeUpper = true;

        foreach (char c in text)
        {
            if (makeUpper && char.IsLetter(c))
            {
                result += char.ToUpper(c);
                makeUpper = false;
            }
            else
            {
                result += c;
            }

            if (c == '.' || c == '!' || c == '?')
            {
                makeUpper = true;
            }
        }

        Console.WriteLine(result);
    }
}