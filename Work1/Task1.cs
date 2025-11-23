namespace System;

public class Task1
{
    public static void Run(int n)
    {
        if (n < 1 || n > 100)
        {
            Console.WriteLine("Invalid number");
            return;
        }

        if (n % 3 == 0 && n % 5 == 0)
            Console.WriteLine("Fizz Buzz");
        else if (n % 3 == 0)
            Console.WriteLine("Fizz");
        else if (n % 5 == 0)
            Console.WriteLine("Buzz");
        else
            Console.WriteLine(n);
    }
}