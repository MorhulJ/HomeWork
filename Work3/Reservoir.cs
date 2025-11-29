using System;

public class Reservoir
{
    private double volume;        
    private string material;      
    private double currentLevel;  
    
    public Reservoir(double volume)
    {
        this.volume = volume;
        material = "Unknown";
        currentLevel = 0;
    }
    
    public Reservoir(double volume, string material)
    {
        this.volume = volume;
        this.material = material;
        currentLevel = 0;
    }
    
    public Reservoir(double volume, string material, double currentLevel)
    {
        this.volume = volume;
        this.material = material;
        this.currentLevel = Math.Min(currentLevel, volume);
    }
    
    public void Fill(double amount)
    {
        if (amount < 0)
        {
            Console.WriteLine("Amount must be positive.");
            return;
        }

        if (currentLevel + amount > volume)
        {
            currentLevel = volume;
            Console.WriteLine("Reservoir is now full. Overflow prevented.");
        }
        else
        {
            currentLevel += amount;
            Console.WriteLine($"Added {amount} units. Current level: {currentLevel}.");
        }
    }
    
    public void Empty(double amount)
    {
        if (amount < 0)
        {
            Console.WriteLine("Amount must be positive.");
            return;
        }

        if (currentLevel - amount < 0)
        {
            currentLevel = 0;
            Console.WriteLine("Reservoir is now empty.");
        }
        else
        {
            currentLevel -= amount;
            Console.WriteLine($"Removed {amount} units. Current level: {currentLevel}.");
        }
    }


    public void DisplayInfo()
    {
        Console.WriteLine("\nReservoir Information:");
        Console.WriteLine($"Volume: {volume}");
        Console.WriteLine($"Material: {material}");
        Console.WriteLine($"Current Level: {currentLevel}");
    }
}
