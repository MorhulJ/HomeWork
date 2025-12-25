namespace ConsoleApp;

public class Product
{
    private string _name;
    private int _count;
    private double _price;

    public string Name
    {
        get => _name;
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("Name can't be empty");
            
            _name = value;
        }
    }

    public int Count
    {
        get => _count;
        set
        {
            if (value < 0)
                throw new ArgumentException("Count can't be negative");
            
            _count = value;
        }
    }

    public double Price
    {
        get => _price;
        set
        {
            if (value < 0)
                throw new ArgumentException("Price can't be negative");
            
            _price = value;
        }
    }

    public Product(string name, int count, double price)
    {
        Name = name;
        Count = count;
        Price = price;
    }

    public void Show()
    {
        Console.WriteLine($"Name: {Name},  Count: {Count}, Price: {Price}");
    }

    public static Product operator +(Product p, int count)
    {
        return new Product(p.Name, p.Count + count, p.Price);
    }
    
    public static Product operator -(Product p, int count)
    {
        return new Product(p.Name, p.Count - count, p.Price);
    }

    public static bool operator ==(Product p1, Product p2)
    {
        if (p1 is null || p2 is null) return false;
        return p1.Price == p2.Price;
    }

    public static bool operator !=(Product p1, Product p2)
    {
        return !(p1 == p2);
    }

    public static bool operator >(Product p1, Product p2)
    {
        if (p1 is null || p2 is null) return false;
        return p1.Count > p2.Count;
    }

    public static bool operator <(Product p1, Product p2)
    {
        if (p1 is null || p2 is null) return false;
        return p1.Count < p2.Count;
    }
}