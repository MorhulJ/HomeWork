//Task 1
Console.WriteLine("Enter number between 1 and 100");
int numberTask1 = Convert.ToInt32(Console.ReadLine());

Task1.Run(numberTask1);


//Task 2
Console.WriteLine("Enter number");
int numberTask2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter persentage");
int percentageTask2 = Convert.ToInt32(Console.ReadLine());

Task2.Run(numberTask2, percentageTask2);


//Task 3
Console.WriteLine("Enter first number");
int number1Task3 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter second number");
int number2Task3 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter third number");
int number3Task3 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter fourth number");
int number4Task3 = Convert.ToInt32(Console.ReadLine());

Task3.Run(number1Task3, number2Task3, number3Task3, number4Task3);


//Task 4
Console.WriteLine("Enter six-digit number");
string numberTask4 = Console.ReadLine();
Console.WriteLine("Enter position of first number you want to change");
int positon1Task4 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter position of second number you want to change");
int position2Task4 = Convert.ToInt32(Console.ReadLine());

Task4.Run(numberTask4, positon1Task4, position2Task4);


//Task 5
Console.WriteLine("Enter date (dd.MM.yyyy)");
string dateTask5 = Console.ReadLine();

Task5.Run(dateTask5);


//Task 6
Console.WriteLine("Which action you want to do? (1 - °C to °F; 2 - °F to °C)");
int choiseTask6 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter degree");
int degreeTask6 = Convert.ToInt32(Console.ReadLine());

Task6.Run(choiseTask6, degreeTask6);


//Task 7
Console.WriteLine("Enter lower bound");
int lowerBoundTask7 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter upper bound");
int upperBoundTask7 = Convert.ToInt32(Console.ReadLine());

Task7.Run(lowerBoundTask7, upperBoundTask7);


//Task 8
Console.WriteLine("Enter number");
int numberTask8 = Convert.ToInt32(Console.ReadLine());

Task8.Run(numberTask8);


//Task 9
Console.WriteLine("Enter number");
int numberTask9 = Convert.ToInt32(Console.ReadLine());

Task9.Run(numberTask9);
