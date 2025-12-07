public interface IMath
{
    public int Max();
    public int Min();
    public float Avg();
    public bool Search(int searchValue);
}

public class Array : IMath
{
    private int[] Data;

    public Array(int[] data)
    {
        Data = data;
    }
    public int Max()
    {
        return Data.Max();
    }

    public int Min()
    {
        return Data.Min();
    }

    public float Avg()
    {
        return (float)Data.Average();
    }

    public bool Search(int searchValue)
    {
        return Data.Contains(searchValue);
    }
}

public class Program
{
    public static void Main()
    {
        Array arr = new Array([ 1, 8, 17, 2, 9 ]);
        int number = 17;

        Console.WriteLine($"Max: {arr.Max()}");
        Console.WriteLine($"Min: {arr.Min()}");
        Console.WriteLine($"Average {arr.Avg()}");
        Console.WriteLine($"Do array contains {number}: {arr.Search(number)}");
    }
}