namespace ConsoleApp;

public class Task2
{
    public static void ShowTime()
    {
        Console.WriteLine("Current time: " + DateTime.Now.ToLongTimeString());
    }
    
    public static void ShowDate()
    {
        Console.WriteLine("Current date: " + DateTime.Now.ToShortDateString());
    }
    
    public static void ShowDayOfWeek()
    {
        Console.WriteLine("Day of week: " + DateTime.Now.DayOfWeek);
    }
    
    public static double TriangleArea(double a, double h)
    {
        return 0.5 * a * h;
    }
    
    public static double RectangleArea(double a, double b)
    {
        return a * b;
    }
}