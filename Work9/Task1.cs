namespace ConsoleApp;

public class Task1
{
    public static void isEven(int[] array)
    {
        Console.Write("Even numbers:  ");
        foreach (var item in array)
        {
            if (item % 2 == 0)
                Console.Write(item + ", ");
        }

        Console.WriteLine();
    }

    public static void isOdd(int[] array)
    {
        Console.Write("Odd numbers: ");
        foreach (var item in array)
        {
            if (item % 2 != 0)
                Console.Write(item + ", ");
        }

        Console.WriteLine();
    }

    public static void IsPrime(int[] array)
    {
        Console.Write("Prime numbers: ");
        foreach (var item in array)
        {
            if (item <= 1) continue;
            if (item == 2)
            {
                Console.Write(item + ", ");
                continue;
            }

            if (item % 2 == 0) continue;

            int boundary = (int)Math.Sqrt(item);
            bool isPrime = true;
            for (int i = 3; i <= boundary; i += 2)
            {
                if (item % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }

            if (isPrime)
                Console.Write(item + ", ");
        }

        Console.WriteLine();
    }

    public static void IsFibonacci(int[] array)
    {
        Console.Write("Fibonacci numbers: ");
        foreach (var item in array)
        {
            if (item < 0) continue;

            if (IsPerfectSquare(5 * item * item + 4) || IsPerfectSquare(5 * item * item - 4))
            {
                Console.Write(item + ", ");
            }
        }

        Console.WriteLine();
    }

    static bool IsPerfectSquare(int x)
    {
        int s = (int)Math.Sqrt(x);
        return s * s == x;
    }
}