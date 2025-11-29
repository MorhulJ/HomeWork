using System;

public class Task2
{
    public static void Run(int[,] arr)
    {
        Random rnd = new Random();
        
        int sum = 0;
        
        for (int i = 0; i < 5; i++)
        for (int j = 0; j < 5; j++)
        {
            arr[i, j] = rnd.Next(-100, 101);
        }
        
        int[] flatArr = new int[25];
        int index = 0;

        for (int i = 0; i < 5; i++)
        for (int j = 0; j < 5; j++)
            flatArr[index++] = arr[i, j];

        int minIndex = 0;
        int maxIndex = 0;

        for (int i = 1; i < flatArr.Length; i++)
        {
            if (flatArr[i] < flatArr[minIndex])
                minIndex = i;
            if (flatArr[i] > flatArr[maxIndex]) 
                maxIndex = i;
        }

        int start = Math.Min(minIndex, maxIndex);
        int end = Math.Max(minIndex, maxIndex);
        

        for (int i = start + 1; i < end; i++)
            sum += flatArr[i];
        
        Console.WriteLine(sum);
    }
}