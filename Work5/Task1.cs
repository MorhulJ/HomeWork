using System;

public struct Vector3D
{
    public double X;
    public double Y;
    public double Z;

    public Vector3D(double x, double y, double z)
    {
        X = x;
        Y = y;
        Z = z;
    }

    public void Show()
    {
        Console.WriteLine($"({X}, {Y}, {Z})");
    }

    public static void Mult(Vector3D v, double scalar)
    {
        Console.WriteLine($"Mult: ({v.X * scalar}, {v.Y * scalar}, {v.Z * scalar})");
    }

    public static void Sum(Vector3D v1, Vector3D v2)
    {
        Console.WriteLine($"Sum: ({v1.X + v2.X}, {v1.Y + v2.Y}, {v1.Z + v2.Z})");
    }

    public static void Diff(Vector3D v1, Vector3D v2)
    {
        Console.WriteLine($"Diff: ({v1.X - v2.X}, {v1.Y - v2.Y}, {v1.Z - v2.Z})");
    }
}