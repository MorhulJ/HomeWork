namespace ConsoleApp;

public class Magazine
{
    private string _name;
    private int _employeeCount;

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

    public int EmployeeCount
    {
        get => _employeeCount;
        set
        {
            if (value < 0)
                throw new ArgumentException("Employee count can't be negative");
            _employeeCount = value;
        }
    }

    public Magazine(string name, int employeeCount)
    {
        Name = name;
        EmployeeCount = employeeCount;
    }

    public void Show()
    {
        Console.WriteLine($"Magazine: {Name}, Employee count: {EmployeeCount}");
    }

    public static Magazine operator +(Magazine magazine, int value)
    {
        return new Magazine(magazine.Name, magazine.EmployeeCount + value);
    }

    public static Magazine operator -(Magazine magazine, int value)
    {
        return new Magazine(magazine.Name, magazine.EmployeeCount - value);
    }

    public static bool operator ==(Magazine a, Magazine b)
    {
        if (ReferenceEquals(a, b)) return true;
        if (a is null || b is null) return false;

        return a.EmployeeCount == b.EmployeeCount;
    }

    public static bool operator !=(Magazine a, Magazine b)
    {
        return !(a == b);
    }

    public static bool operator <(Magazine a, Magazine b)
    {
        return a.EmployeeCount < b.EmployeeCount;
    }

    public static bool operator >(Magazine a, Magazine b)
    {
        return a.EmployeeCount > b.EmployeeCount;
    }
}