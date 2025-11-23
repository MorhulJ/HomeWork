namespace System;

public class Task9
{
    public static void Run(int n)
    {
        int sum = 0;
        for (int i = 1; i < n; i++)
        {
            if (n % i == 0)
            {
                sum += i;
            }
        }

        if (sum == n)
        {
            Console.WriteLine("Number is perfect");
        }
        else
        {
            Console.WriteLine("Number isn't perfect");
        }
    }
}