namespace ConsoleApp;

public class Shop
{
    private string _name;
    private double _area;

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

    public double Area
    {
        get => _area;
        set
        {
            if (value < 0)
                throw new ArgumentException("Shop area can't be negative");
            _area = value;
        }
    }

    public Shop(string name, double area)
    {
        Name = name;
        Area = area;
    }

    public void Show()
    {
        Console.WriteLine($"Shop: {Name}, Area: {Area}");
    }

    public static Shop operator +(Shop shop, double value)
    {
        return new Shop(shop.Name, shop.Area + value);
    }

    public static Shop operator -(Shop shop, double value)
    {
        return new Shop(shop.Name, shop.Area - value);
    }

    public static bool operator ==(Shop a, Shop b)
    {
        if (ReferenceEquals(a, b)) return true;
        if (a is null || b is null) return false;

        return a.Area == b.Area;
    }

    public static bool operator !=(Shop a, Shop b)
    {
        return !(a == b);
    }

    public static bool operator <(Shop a, Shop b)
    {
        return a.Area < b.Area;
    }

    public static bool operator >(Shop a, Shop b)
    {
        return a.Area > b.Area;
    }
}