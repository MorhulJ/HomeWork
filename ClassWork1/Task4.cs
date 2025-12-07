public interface ISort
{
    public void SortAsc();
    public void SortDesc();
    public void SortByParam(bool isAsc);
}

public class MyArray : ISort
{
    private int[] Data;

    public MyArray(int[] data)
    {
        Data = data;
    }

    public void SortAsc()
    {
        Array.Sort(Data);
    }

    public void SortDesc()
    {
        Array.Sort(Data);
        Array.Reverse(Data);
    }

    public void SortByParam(bool isAsc)
    {
        if (isAsc)
            SortAsc();
        else
            SortDesc();
    }

    public void Show()
    {
        foreach (var item in Data)
        {
            Console.Write(item + ", ");
        }
    }
}


public class Program
{
    public static void Main()
    {
        MyArray arr = new MyArray(new int[] { 5, 1, 9, 3, 7 });

        Console.WriteLine("Array:");
        arr.Show();

        Console.WriteLine("\n\nSort Ascending:");
        arr.SortAsc();
        arr.Show();

        Console.WriteLine("\n\nSort Descending:");
        arr.SortDesc();
        arr.Show();

        Console.WriteLine("\n\nSort by Param:");
        arr.SortByParam(true);
        arr.Show();
    }
}