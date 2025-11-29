using System;

public class Task8
{
    public static void Run(string[] args)
    {
        if (args.Length < 2)
        {
            Console.WriteLine("Usage: Task8 <text> <shift>");
            return;
        }
        
        string text = string.Join(" ", args, 0, args.Length - 1);
        
        if (!int.TryParse(args[args.Length - 1], out int shift))
        {
            Console.WriteLine("Shift must be a number!");
            return;
        }

        string encrypted = "";

        foreach (char c in text)
        {
            if (char.IsLetter(c))
            {
                char offset = char.IsUpper(c) ? 'A' : 'a';
                char encryptedChar = (char)(((c - offset + shift) % 26) + offset);
                encrypted += encryptedChar;
            }
            else
            {
                encrypted += c;
            }
        }

        Console.WriteLine(encrypted);
    }
}