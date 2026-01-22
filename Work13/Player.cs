using System;
public class Player
{
    private string _name;
    private int _level;
    private int _health;

    public string Name
    {
        get => _name;
        set
        {
            if (string.IsNullOrWhiteSpace(value)) throw new ArgumentException("Name cannot be empty");
            _name = value;
        }
    }

    public int Level
    {
        get => _level;
        set
        {
            if (value < 1) throw new ArgumentException("Level cannot be less than 1");
            if (value > 50) throw new ArgumentException("Level cannot be greater than 50");
            _level = value;
        }
    }

    public int Health
    {
        get => _health;
        set
        {
            if (value < 1) throw new ArgumentException("Health cannot be less than 1");
            if (value > 100) throw new ArgumentException("Health cannot be greater than 100");
            _health = value;
        }
    }

    public Player(string name, int level, int health)
    {
        Name = name;
        Level = level;
        Health = health;
    }

    public Player()
    {
        Name = "Guest";
        Level = 1;
        Health = 100;
    }
    
    public void Show()
    {
        Console.WriteLine($"Player: {Name}\nLevel: {Level}\nHealth: {Health}");
    }
}