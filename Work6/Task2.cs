public abstract class Device
{
    public string Name { get; set; }
    public string Description { get; set; }

    public Device(string name, string description)
    {
        Name = name;
        Description = description;
    }

    public abstract void Sound();
    public abstract void Show();
    public abstract void Desc();
}

public class Kettle : Device
{
    public Kettle(string name, string description) : base(name, description)
    {
    }

    public override void Sound()
    {
        Console.WriteLine("Shhhhhhhhhhhhhh");
    }

    public override void Show()
    {
        Console.WriteLine(Name);
    }

    public override void Desc()
    {
        Console.WriteLine(Description);
    }
}

public class Microwave : Device
{
    public Microwave(string name, string description) : base(name, description)
    {
    }

    public override void Sound()
    {
        Console.WriteLine("brrrrrrrrrrrrrrrrr");
    }

    public override void Show()
    {
        Console.WriteLine(Name);
    }

    public override void Desc()
    {
        Console.WriteLine(Description);
    }
}

public class Auto : Device
{
    public Auto(string name, string description) : base(name, description)
    {
    }

    public override void Sound()
    {
        Console.WriteLine("brum brum brummmmmmmm");
    }

    public override void Show()
    {
        Console.WriteLine(Name);
    }

    public override void Desc()
    {
        Console.WriteLine(Description);
    }
}

public class Steamer : Device
{
    public Steamer(string name, string description) : base(name, description)
    {
    }

    public override void Sound()
    {
        Console.WriteLine("pszzzz pszzzz pszzzzz");
    }

    public override void Show()
    {
        Console.WriteLine(Name);
    }

    public override void Desc()
    {
        Console.WriteLine(Description);
    }
}