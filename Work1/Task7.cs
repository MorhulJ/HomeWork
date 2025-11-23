namespace System;

public class Task7
{
    public static void Run(int lb, int ub)
    {
        if (ub < lb)
        {
            (ub, lb) = (lb, ub);
        }

        for (int i = lb; i <= ub; i++)
        {
            if (i % 2 == 0)
            {
                Console.Write(i + " ");
            }
        }
    }
}