using System;
using System.Collections.Generic;

public class Task3
{
    public static void Run(int[] arr1, int[] arr2)
    {
        List<int> result = new List<int>();

        for (int i = 0; i < arr1.Length; i++)
        {
            bool found = false;
            for (int j = 0; j < arr2.Length; j++)
            {
                if (arr1[i] == arr2[j])
                {
                    found = true;
                    break;
                }
            }

            if (!found)
            {
                result.Add(arr1[i]);
            }
        }

        Console.WriteLine("Array after filtration:");
        foreach (var item in result)
        {
            Console.Write(item + " ");
        }
    }
}