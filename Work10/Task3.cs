namespace ConsoleApp;

public class CardDate
{
    private int _month;
    private int _year;

    public int Month
    {
        get => _month;
        set
        {
            if (value < 1 || value > 12)
                throw new ArgumentException("Month must be between 1 and 12");

            _month = value;
        }
    }

    public int Year
    {
        get => _year;
        set
        {
            if (value < DateTime.Now.Year)
                throw new ArgumentException("Year cannot be less than current year");

            _year = value;
        }
    }

    public CardDate(int month, int year)
    {
        Month = month;
        Year = year;
    }

    public void Show()
    {
        Console.WriteLine($"{Month:D2}/{Year % 100:D2}");
    }
}


public class CreditCard
{
    public event Action<decimal> AccountReplenished;
    public event Action<decimal> MoneySpent;
    public event Action CreditMoneyStarted; 
    public event Action PinChanged;
    
    private long _cardNumber;
    private string _userName;
    private int _pin;
    private decimal _creditLimit;
    private decimal _moneyAmount;

    public long CardNumber
    {
        get => _cardNumber;
        set
        {
            if (value < 1000000000000000 || value > 9999999999999999)
                throw new ArgumentException("Card number must contain 16 digits");

            _cardNumber = value;
        }
    }

    public string UserName
    {
        get => _userName;
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("User name cannot be empty");

            _userName = value;
        }
    }

    public CardDate CardDate { get; set; }

    public int PIN
    {
        get => _pin;
        set
        {
            if (value < 1000 || value > 9999)
                throw new ArgumentException("PIN must be 4 digits");

            _pin = value;
        }
    }

    public decimal CreditLimit
    {
        get => _creditLimit;
        set
        {
            if (value <= 0)
                throw new ArgumentException("Credit limit must be positive");

            _creditLimit = value;
        }
    }

    public decimal MoneyAmount
    {
        get => _moneyAmount;
        set
        {
            if (value < 0)
                throw new ArgumentException("Money amount cannot be negative");

            if (value > CreditLimit)
                throw new ArgumentException("Money amount cannot exceed credit limit");

            _moneyAmount = value;
        }
    }

    public CreditCard(long cardNumber, string userName, CardDate cardDate, int pin, decimal creditLimit, decimal moneyAmount)
    {
        CardNumber = cardNumber;
        UserName = userName;
        CardDate = cardDate;
        PIN = pin;
        CreditLimit = creditLimit;
        MoneyAmount = moneyAmount;
    }
    
    public void Deposit(decimal amount)
    {
        if (amount <= 0)
            throw new ArgumentException("Amount must be positive");

        _moneyAmount += amount;
        AccountReplenished?.Invoke(amount);
    }
    
    public void Withdraw(decimal amount)
    {
        if (amount <= 0)
            throw new ArgumentException("Amount must be positive");

        decimal before = _moneyAmount;

        if (_moneyAmount - amount < -CreditLimit)
            throw new InvalidOperationException("Credit limit exceeded");

        _moneyAmount -= amount;
        MoneySpent?.Invoke(amount);

        if (before >= 0 && _moneyAmount < 0)
            CreditMoneyStarted?.Invoke();
    }
    
    public void ChangePin(int oldPin, int newPin)
    {
        if (oldPin != PIN)
            throw new UnauthorizedAccessException("Wrong old PIN");

        PIN = newPin;
        PinChanged?.Invoke();
    }
}
