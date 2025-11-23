namespace System;

public class Task4
{
    public static void Run(string stringN, int p1, int p2)
    {
        if (stringN.Length != 6)
        {
            Console.WriteLine("Invalid number");
            return;
        }

        if (p1 < 1 || p1 > 6 || p2 < 1 || p2 > 6)
        {
            Console.WriteLine("Invalid positions");
            return;
        }
        
        char[] digits = stringN.ToCharArray();
        
        (digits[p1 - 1], digits[p2 - 1]) = (digits[p2 - 1], digits[p1 - 1]);
        
        string result = new string(digits);
        Console.WriteLine(result);
    }
}