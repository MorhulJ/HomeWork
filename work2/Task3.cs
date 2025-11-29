using System;

public class Task3
{
    public static string Run(string l, int k)
    {
        char[] result = new char[l.Length];

        for (int i = 0; i < l.Length; i++)
        {
            char c = l[i];

            if (char.IsLetter(c))
            {
                char offset = char.IsUpper(c) ? 'A' : 'a';
                c = (char)(((c - offset + k) % 26 + 26) % 26 + offset);
            }

            result[i] = c;
        }

        return new string(result);
    }
}