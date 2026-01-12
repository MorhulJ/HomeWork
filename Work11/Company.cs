namespace ConsoleApp;

public enum BusinessProfiles
{
    Marketing,
    IT,
    Finance,
    Education,
    Food
}

public class Company
{
    private string _name;
    private DateTime _date;
    private BusinessProfiles _profile;
    private string _companyOwnerFirstName;
    private string _companyOwnerSecondName;
    private int _employeeCount;
    private string _address;
    private List<Employee> _employees;

    public string Name
    {
        get => _name;
        set
        {
            if (string.IsNullOrWhiteSpace(value)) throw new ArgumentException("Name can't be empty");
            _name = value;
        }
    }

    public DateTime Date
    {
        get => _date;
        set
        {
            if (value >  DateTime.Now) throw new ArgumentException("Date can't be in the future");
            _date = value;
        }
    }

    public BusinessProfiles Profile
    {
        get => _profile;
        set
        {
            if (!Enum.IsDefined(typeof(BusinessProfiles), value)) throw new ArgumentException("Invalid business profile");
            _profile = value;
        }
    }
    
    public string CompanyOwnerFirstName
    {
        get => _companyOwnerFirstName;
        set
        {
            if (string.IsNullOrWhiteSpace(value)) throw new ArgumentException("Owners first name can't be empty");
            _companyOwnerFirstName = value;
        }
    }
    
    public string CompanyOwnerSecondName
    {
        get => _companyOwnerSecondName;
        set
        {
            if (string.IsNullOrWhiteSpace(value)) throw new ArgumentException("Owners second name can't be empty");
            _companyOwnerSecondName = value;
        }
    }

    public int EmployeeCount
    {
        get => _employeeCount;
        set
        {
            if (value < 1) throw new ArgumentException("Employee count can't be less than 1");
            _employeeCount = value;
        }
    }
    
    public string Address
    {
        get => _address;
        set
        {
            if (string.IsNullOrWhiteSpace(value)) throw new ArgumentException("Address can't be empty");
            _address = value;
        }
    }
    
    public List<Employee> Employees
    {
        get => _employees;
        set
        {
            if (value == null) throw new ArgumentException("Employees list cannot be null");
            _employees = value;
        }
    }

    public Company(string name, DateTime date, BusinessProfiles profile, string companyOwnerFirstName, string companuOwnerSecondName, int employeeCount, string address)
    {
        Name = name;
        Date = date;
        Profile = profile;
        CompanyOwnerFirstName = companyOwnerFirstName;
        CompanyOwnerSecondName = companuOwnerSecondName;
        EmployeeCount = employeeCount;
        Address = address;
        
        Employees = new List<Employee>();
    }

    public void CompanyShow()
    {
        Console.WriteLine($"Company name: {Name}");
        Console.WriteLine($"Company profile: {Profile}");
        Console.WriteLine($"Company employee count: {EmployeeCount}");
        Console.WriteLine($"Company address: {Address}\n");
    }
}