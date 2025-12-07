public interface IOutput
{
    void Show();
    void Show(string info);
}

public class Array : IOutput
{
    private int[] Data;

    public Array(int[] data)
    {
        Data = data;
    }
    
    public void Show()
    {
        foreach (var i in Data)
        {
            Console.Write(i + ", ");
        }
    }
    
    public void Show(string info)
    {
        Console.WriteLine(info);
        foreach (var i in Data)
        {
            Console.Write(i + ", ");
        }
    }
}

class Program
{
    static void Main()
    {
        Array arr = new Array([1, 2, 3, 4, 5]);

        arr.Show();
        
        Console.WriteLine();
        
        arr.Show("\nHello world!");
    }
}