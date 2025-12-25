namespace ConsoleApp;

public class Fraction
{
    private int _numerator;
    private int _denominator;

    public int Numerator
    {
        get => _numerator;
        set => _numerator = value;
    }

    public int Denominator
    {
        get => _denominator;
        set
        {
            if (value == 0)
                throw new ArgumentException("Denominator cannot be zero");

            _denominator = value;
        }
    }
    
    public Fraction()
    {
        Numerator = 1;
        Denominator = 1;
    }

    public Fraction(int numerator, int denominator)
    {
        Numerator = numerator;
        Denominator = denominator;
    }
    
    public void Show()
    {
        Console.WriteLine($"{Numerator}/{Denominator}");
    }

    public static Fraction operator +(Fraction a, Fraction b)
    {
        int numerator = a.Numerator * b.Denominator + b.Numerator * a.Denominator;
        int denominator = a.Denominator * b.Denominator;

        return new Fraction(numerator, denominator);
    }
    
    public static Fraction operator -(Fraction a, Fraction b)
    {
        int numerator = a.Numerator * b.Denominator - b.Numerator * a.Denominator;
        int denominator = a.Denominator * b.Denominator;

        return new Fraction(numerator, denominator);
    }

    public static Fraction operator *(Fraction a, Fraction b)
    {
        int numerator = a.Numerator * b.Numerator;
        int denominator = a.Denominator * b.Denominator;
        
        return new Fraction(numerator, denominator);
    }

    public static Fraction operator /(Fraction a, Fraction b)
    {
        int numerator = a.Numerator * b.Denominator;
        int denominator = a.Denominator * b.Numerator;
        
        return new Fraction(numerator, denominator);
    }
    
    public static bool operator ==(Fraction a, Fraction b)
    {
        if (a is null || b is null) return false;

        return a.Numerator * b.Denominator == b.Numerator * a.Denominator;
    }

    public static bool operator !=(Fraction a, Fraction b)
    {
        return !(a == b);
    }
    
    private static int GCD(int a, int b)
    {
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }

    public void Reduction()
    {
        int gcd = GCD(Math.Abs(Numerator), Math.Abs(Denominator));

        Numerator /= gcd;
        Denominator /= gcd;

        if (Denominator < 0)
        {
            Numerator *= -1;
            Denominator *= -1;
        }
    }
}