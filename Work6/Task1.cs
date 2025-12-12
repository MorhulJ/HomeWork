public class Money
{ 
    public int WholePart;
    public int CoinPart;

    public void PrintMoney()
    {
        Console.WriteLine($"Price: ${WholePart}.{CoinPart}");
    }

    public void SetMoney()
    {
        int wholePart;
        int coinPart;
        
        Console.Write($"Enter whole part: ");
        wholePart = Convert.ToInt32(Console.ReadLine());

        if (wholePart < 0)
        {
            Console.WriteLine("You can't enter a negative amount of money!");
            return;
        }

        Console.Write($"\nEnter coin part (0–99): ");
        coinPart = Convert.ToInt32(Console.ReadLine());

        if (coinPart < 0 || coinPart > 99)
        {
            Console.WriteLine("Invalid amount of coins!");
            return;
        }
        
        WholePart = wholePart;
        CoinPart = coinPart;
    }
    
    public void LowerPrice(float amount)
    {
        float amountCoins = amount * 100;
        float totalCoins = WholePart * 100 + CoinPart - amountCoins;

        if (totalCoins < 0) 
            totalCoins = 0;

        WholePart = (int)(totalCoins / 100);
        CoinPart  = (int)(totalCoins % 100);
    }
}

public class Product
{
    public string Name;
    public Money Price;
    
    public Product(string name)
    {
        Name = name;
        Price = new Money();
    }
    
    public void Discount(float amount)
    {
        Price.LowerPrice(amount);
    }
    
    public void PrintInfo()
    {
        Console.WriteLine($"Product: {Name}");
        Price.PrintMoney();
    }
}