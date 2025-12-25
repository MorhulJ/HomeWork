using ConsoleApp;

//Task 1
Task1 task = new Task1();

int[] numbers = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 11, 13, 20 };

Delegate[] actions = {
    Task1.isEven,
    Task1.isOdd,
    Task1.IsPrime,
    Task1.IsFibonacci };

foreach (var processor in actions) processor(numbers);


//Task 2
Action showTime = Task2.ShowTime;
Action showDate = Task2.ShowDate;
Action showDay = Task2.ShowDayOfWeek;

showTime();
showDate();
showDay();

Func<double, double, double> triangleArea = Task2.TriangleArea;
Func<double, double, double> rectangleArea = Task2.RectangleArea;

double tArea = triangleArea(5, 10);
double rArea = rectangleArea(4, 8);

Console.WriteLine("Triangle area: " + tArea);
Console.WriteLine("Rectangle area: " + rArea);

Predicate<double> isLargeTriangle = area => area > 20;
Console.WriteLine("Is triangle area > 20? " + isLargeTriangle(tArea));



public delegate void Delegate(int[] array);