namespace ConsoleApp;

public enum Positions
{
    Intern,
    Junior,
    Middle,
    Senior,
    TeamLead,
    Manager,
    Director,
    CEO
}

public class Employee
{
    private string _firstName;
    private string _secondName;
    private Positions _position;
    private string _phoneNumber;
    private string _email;
    private int _salary;
    
    public string FirstName
    {
        get => _firstName;
        set
        {
            if (string.IsNullOrWhiteSpace(value)) throw new ArgumentException("Owners first name can't be empty");
            _firstName = value;
        }
    }
    
    public string SecondName
    {
        get => _secondName;
        set
        {
            if (string.IsNullOrWhiteSpace(value)) throw new ArgumentException("Owners second name can't be empty");
            _secondName = value;
        }
    }
    
    public Positions Position
    {
        get => _position;
        set
        {
            if (!Enum.IsDefined(typeof(Positions), value)) throw new ArgumentException("Invalid business profile");
            _position = value;
        }
    }
    
    public string PhoneNumber
    {
        get => _phoneNumber;
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("Phone number cannot be empty");

            if (value.Length < 10 || value.Length > 15)
                throw new ArgumentException("Phone number must be between 10 and 15 digits");
            _phoneNumber = value;
        }
    }

    public string Email
    {
        get => _email;
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("Email cannot be empty");

            if (!value.Contains("@") || !value.Contains("."))
                throw new ArgumentException("Email is invalid");
            _email = value;
        }
    }

    public int Salary
    {
        get => _salary;
        set
        {
            if (value < 0)
                throw new ArgumentException("Salary can't be negative");
            
            _salary = value;
        }
    }

    public Employee(string firstName, string secondName, Positions position, string phoneNumber, string email, int salary)
    {
        FirstName = firstName;
        SecondName = secondName;
        Position = position;
        PhoneNumber = phoneNumber;
        Email = email;
        Salary = salary;
    }

    public void EmployeeShow()
    {
        Console.WriteLine($"First name: {FirstName}");
        Console.WriteLine($"Second name: {SecondName}");
        Console.WriteLine($"Position: {Position}");
        Console.WriteLine($"Phone number: {PhoneNumber}");
        Console.WriteLine($"Email: {Email}");
        Console.WriteLine($"Salary: {Salary}\n");
    }
}