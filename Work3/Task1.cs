using System;

public class Task1
{
    public static void Run(int size, string symbol)
    {
        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                Console.Write(symbol + "  ");
            }
            Console.WriteLine();
        }
    }
}