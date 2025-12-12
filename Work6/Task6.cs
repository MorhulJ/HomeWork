public abstract class Product2
{
    public string Name { get; set; }
    public decimal Price { get; set; }

    public Product2(string name, decimal price)
    {
        Name = name;
        Price = price;
    }

    public abstract void CalculateDiscount();
}

public class Electronics : Product2
{
    public Electronics(string name, decimal price) : base(name, price)
    {
    }

    public override void CalculateDiscount()
    {
        Console.WriteLine($"Price with discount 10% on electronics is ${Price *= (decimal)1.10}");
    }
}

public class Furniture : Product2
{
    public Furniture(string name, decimal price) : base(name, price)
    {
    }

    public override void CalculateDiscount()
    {
        Console.WriteLine($"Price with discount 20% on furniture is ${Price *= (decimal)1.20}");
    }
}