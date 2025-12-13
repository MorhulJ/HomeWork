public interface ICalc
{
    public int Less(int valueToCompare);
    public int Greater(int valueToCompare);
}

public class MyArray1 : ICalc
{
    private int[] Data;

    public MyArray1(int[] data)
    {
        Data = data;
    }

    public int Less(int valueToCompare)
    {
        int counter = 0;
        
        foreach (var item in Data)
        {
            if (item < valueToCompare)
                counter++;
        }
        return counter;
    }

    public int Greater(int valueToCompare)
    {
        int counter = 0;
        
        foreach (var item in Data)
        {
            if (item > valueToCompare)
                counter++;
        }
        return counter;
    }
}
