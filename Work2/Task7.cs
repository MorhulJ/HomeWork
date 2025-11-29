using System;

public class Task7
{
    public static void Run(string text, string bannedWord)
    {
        string[] words = text.Split(' ');

        for (int i = 0; i < words.Length; i++)
        {
            if (words[i] == bannedWord)
                words[i] = "*****";
        }
        string result = string.Join(" ", words);
        
        Console.WriteLine(result);
    }
}