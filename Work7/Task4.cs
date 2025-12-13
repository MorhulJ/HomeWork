public interface IRemouteControle
{
    public void TurnOn();
    public void TurnOff();
    public void SetChannel(int channel);
}

public class TV :  IRemouteControle
{
    public void TurnOn()
    {
        Console.WriteLine("TV On");
    }

    public void TurnOff()
    {
        Console.WriteLine("TV Off");
    }

    public void SetChannel(int channel)
    {
        Console.WriteLine($"TV Channel: {channel}");
    }
}

public class Radio :  IRemouteControle
{
    public void TurnOn()
    {
        Console.WriteLine("Radio On");
    }

    public void TurnOff()
    {
        Console.WriteLine("Radio Off");
    }

    public void SetChannel(int channel)
    {
        Console.WriteLine($"Radio Channel: {channel}");
    }
}