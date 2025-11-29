using System;

public class Task2
{
    public static void Run(int number)
    {
        string str = number.ToString();

        int left = 0;
        int right = str.Length - 1;

        while (left < right)
        {
            if (str[left] != str[right])
            {
                Console.WriteLine("False");
                return;
            }
            left++;
            right--;
        }

        Console.WriteLine("True");
    }
}