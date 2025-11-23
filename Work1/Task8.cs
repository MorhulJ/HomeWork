namespace System;

public class Task8
{
    public static void Run(int n)
    {
        int original = n;
        int digits = n.ToString().Length;
        int sum = 0;
        
        while (n > 0)
        {
            int digit = n % 10;
            sum += Power(digit, digits);
            n /= 10;
        }
        
        if (sum == original)
            Console.WriteLine("Number is 'Armstrong'");
        else
            Console.WriteLine("Number isn't 'Armstrong'");
    }

    static int Power(int n1, int n2)
    {
        int pow = 1;
        for (int i = 0; i < n2; i++)
        {
            pow *= n1;
        }
        return pow;
    }
}