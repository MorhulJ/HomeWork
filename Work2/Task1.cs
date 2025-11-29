using System;

public class Task1
{
    public static void Run(int[] A, double[,] B)
    {
        Random rnd = new Random();

        for (int i = 0; i < A.Length; i++)
        {
            Console.Write($"Enter A[{i}]: ");
            A[i] = Convert.ToInt32(Console.ReadLine());
        }

        for (int i = 0; i < B.GetLength(0); i++)
        for (int j = 0; j < B.GetLength(1); j++)
            B[i, j] = Math.Round(rnd.NextDouble() * 10, 2);

        Console.WriteLine("Array A:");
        foreach (int x in A)
            Console.Write(x + " ");
        Console.WriteLine("\nArray B:");
        for (int i = 0; i < B.GetLength(0); i++)
        {
            for (int j = 0; j < B.GetLength(1); j++)
                Console.Write(B[i, j] + "  ");
            Console.WriteLine();
        }

        double max = double.MinValue;
        double min = double.MaxValue;
        double sum = 0;
        double product = 1;
        int sumEvenA = 0;
        double sumOddColumnsB = 0;

        foreach (int x in A)
        {
            if (x > max)
                max = x;
            if (x < min)
                min = x;
            sum += x;
            product *= x;
            if (x % 2 == 0)
                sumEvenA += x;
        }

        for (int i = 0; i < B.GetLength(0); i++)
        {
            for (int j = 0; j < B.GetLength(1); j++)
            {
                double val = B[i, j];
                if (val > max)
                    max = val;
                if (val < min)
                    min = val;
                sum += val;
                product *= val;
                if (j % 2 == 1)
                    sumOddColumnsB += val;
            }
        }

        Console.WriteLine($"Global maximum: {max}");
        Console.WriteLine($"Global minimum: {min}");
        Console.WriteLine($"Total sum: {sum}");
        Console.WriteLine($"Total product: {product}");
        Console.WriteLine($"Sum of even elements in A: {sumEvenA}");
        Console.WriteLine($"Sum of odd columns in B: {sumOddColumnsB}");
    }
}