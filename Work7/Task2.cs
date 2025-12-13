public interface IOutput2
{
    public void ShowEven();
    public void ShowOdd();
}

public class MyArray2 : IOutput2
{
    private int[] Data;

    public MyArray2(int[] data)
    {
        Data = data;
    }

    public void ShowEven()
    {
        foreach (var item in Data)
        {
            if (item % 2 == 0)
            {
                Console.Write(item + " ");
            }
        }
    }

    public void ShowOdd()
    {
        foreach (var item in Data)
        {
            if (item % 2 != 0)
            {
                Console.Write(item + " ");
            }
        }
    }
}