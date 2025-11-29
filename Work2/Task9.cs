using System;

public class Task9
{
    public static void Run(string[] args)
    {
        if (args.Length < 3)
        {
            Console.WriteLine("Usage: Task9 <rows> <cols> <multiplier>");
            return;
        }

        if (!int.TryParse(args[0], out int rows) || !int.TryParse(args[1], out int cols) || !int.TryParse(args[2], out int multiplier))
        {
            Console.WriteLine("All arguments must be integers!");
            return;
        }

        Random rnd = new Random();
        int[,] array = new int[rows, cols];
        
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                array[i, j] = rnd.Next(1, 10) * multiplier;
            }
        }

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(array[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
}