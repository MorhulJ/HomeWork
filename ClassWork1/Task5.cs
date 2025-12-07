using Math = System.Math;

public interface IShape
{
    double CalculateArea();
    double CalculatePerimeter();
}

public class Circle : IShape
{
    public double Radius;

    public Circle(double radius)
    {
        Radius = radius;
    }

    public double CalculateArea()
    {
        return Math.PI * Radius * Radius;
    }

    public double CalculatePerimeter()
    {
        return 2 * Math.PI * Radius;
    }
}

public class Rectangle : IShape
{
    public double Width;
    public double Height;

    public Rectangle(double width, double height)
    {
        Width = width;
        Height = height;
    }

    public double CalculateArea()
    {
        return Width * Height;
    }

    public double CalculatePerimeter()
    {
        return 2 * (Width + Height);
    }
}

public class Triangle : IShape
{
    public double SideA;
    public double SideB;
    public double SideC;

    public Triangle(double sideA, double sideB, double sideC)
    {
        SideA = sideA;
        SideB = sideB;
        SideC = sideC;
    }

    public double CalculatePerimeter()
    {
        return SideA + SideB + SideC;
    }

    public double CalculateArea()
    {
        double s = CalculatePerimeter() / 2;
        return Math.Sqrt(s * (s - SideA) * (s - SideB) * (s - SideC));
    }
}

public class Program
{
    public static void Main()
    {
        IShape circle = new Circle(5);
        IShape rectangle = new Rectangle(4, 6);
        IShape triangle = new Triangle(3, 4, 5);

        Console.WriteLine("Cyrcle");
        Console.WriteLine($"Area: {circle.CalculateArea()}");
        Console.WriteLine($"Perimeter: {circle.CalculatePerimeter()}\n");

        Console.WriteLine("Rectangle");
        Console.WriteLine($"Area: {rectangle.CalculateArea()}");
        Console.WriteLine($"Perimeter: {rectangle.CalculatePerimeter()}\n");

        Console.WriteLine("Triangle");
        Console.WriteLine($"Area: {triangle.CalculateArea()}");
        Console.WriteLine($"Perimeter: {triangle.CalculatePerimeter()}");
    }
}
 