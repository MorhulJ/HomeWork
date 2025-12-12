public abstract class Worker
{
    public abstract void Print();
}

public class President : Worker
{
    public override void Print()
    {
        Console.WriteLine("President – leads the company.");
    }
}

public class Security : Worker
{
    public override void Print()
    {
        Console.WriteLine("Security – protects property and staff.");
    }
}

public class Manager : Worker
{
    public override void Print()
    {
        Console.WriteLine($"Manager – manages projects and the team.");
    }
}

public class Engineer : Worker
{
    public override void Print()
    {
        Console.WriteLine($"Engineer – works on technical development.");
    }
}