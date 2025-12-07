using System;

public struct DEC
{
    public int Number;

    public DEC(int number)
    {
        Number = number;
    }

    public void Show()
    {
        Console.WriteLine(Number);
    }

    public void ToBIN()
    {
        Console.WriteLine($"Number {Number} to Binary: {Convert.ToString(Number, 2)}");
    }
    
    public void ToOCT()
    {
        Console.WriteLine($"Number {Number} to Octal: {Convert.ToString(Number, 8)}");
    }
    
    public void ToHEX()
    {
        Console.WriteLine($"Number {Number} to Hexadecimal: {Convert.ToString(Number, 16)}");
    }
}