using System;

public interface IDrivable
{
    void StartEngine();
    void StopEngine();
    void Drive();
}

public class Car : IDrivable
{
    public string Model;

    public Car(string model)
    {
        Model = model;
    }

    public void StartEngine()
    {
        Console.WriteLine($"Car {Model}: Engine started.");
    }

    public void StopEngine()
    {
        Console.WriteLine($"Car {Model}: Engine stopped.");
    }

    public void Drive()
    {
        Console.WriteLine($"Car {Model}: Driving.");
    }
}

public class Motorcycle : IDrivable
{
    public string Model;

    public Motorcycle(string model)
    {
        Model = model;
    }

    public void StartEngine()
    {
        Console.WriteLine($"Motorcycle {Model}: Engine started.");
    }

    public void StopEngine()
    {
        Console.WriteLine($"Motorcycle {Model}: Engine stopped.");
    }

    public void Drive()
    {
        Console.WriteLine($"Motorcycle {Model}: Driving.");
    }
}

public class Program
{
    public static void Main()
    {
        IDrivable car = new Car("Lumbrgumbr");
        IDrivable bike = new Motorcycle("Kawasaki");

        car.StartEngine();
        car.Drive();
        car.StopEngine();

        Console.WriteLine();

        bike.StartEngine();
        bike.Drive();
        bike.StopEngine();
    }
}