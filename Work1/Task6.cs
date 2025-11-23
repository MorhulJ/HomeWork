namespace System;

public class Task6
{
    public static void Run(int choise, int d)
    {
        switch (choise)
        {
            case 1:
                double f = d * 9.0 / 5.0 + 32;
                Console.WriteLine(f);
                break;
            
            case 2:
                double c = (d - 32) * 5.0 / 9.0;
                Console.WriteLine(c);
                break;
        }
    }
}