using System;

public class Task5
{
    public static void Run(string expr)
    {
        expr = expr.Replace(" ", "");
        int result = 0;
        int currentNumber = 0;
        char sign = '+';

        foreach (char element in expr)
        {
            if (char.IsDigit(element))
            {
                currentNumber = currentNumber * 10 + (element - '0');
            }
            else if (element == '+' || element == '-')
            {
                if (sign == '+') result += currentNumber;
                else if (sign == '-') result -= currentNumber;
                
                sign = element;
                currentNumber = 0;
            }
            else
            {
                Console.WriteLine("Invalid character: " + element);
                return;
            }
        }
        
        if (sign == '+') result += currentNumber;
        else if (sign == '-') result -= currentNumber;

        Console.WriteLine("Result: " + result);
    }
}