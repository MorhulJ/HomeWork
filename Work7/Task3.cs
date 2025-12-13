public interface ICalc2
{
    public int CountDistinct();
    public int EqualToValue(int valueToCompare);
}

public class MyArray3 : ICalc2
{
    private int[] Data;

    public MyArray3(int[] data)
    {
        Data = data;
    }

    public int CountDistinct()
    {
        int counter = 0;

        for (int i = 0; i < Data.Length; i++)
        {
            bool isUnique = true;

            for (int j = 0; j < i; j++)
            {
                if (Data[i] == Data[j])
                {
                    isUnique = false;
                    break;
                }
            }

            if (isUnique)
                counter++;
        }

        return counter;
    }

    public int EqualToValue(int valueToCompare)
    {
        int counter = 0;
        foreach (var item in Data)
        {
            if (item == valueToCompare)
            {
                counter++;
            }
        }
        return counter;
    }
}