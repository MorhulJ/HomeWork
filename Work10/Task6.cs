namespace ConsoleApp;

public delegate void NumberHandler(int number);

public class NumberProcessor
{
    public void CheckPositive(int number)
    {
        if (number > 0)
            Console.WriteLine(number + " is positive");
        else
            Console.WriteLine(number + " is not positive");
    }

    public void CheckEven(int number)
    {
        if (number % 2 == 0)
            Console.WriteLine(number + " is even");
        else
            Console.WriteLine(number + " is odd");
    }

    public void CheckMultipleOfFive(int number)
    {
        if (number % 5 == 0)
            Console.WriteLine(number + " is a multiple of 5");
        else
            Console.WriteLine(number + " is not a multiple of 5");
    }

    public NumberHandler GetProcessingChain()
    {
        NumberHandler handler = CheckPositive;
        handler += CheckEven;
        handler += CheckMultipleOfFive;
        return handler;
    }
}