//Task 1
int[] A = new int[5];
double[,] B = new double[3, 4];

Task1.Run(A, B);


//Task 2
int[,] arr = new int[5, 5];

Task2.Run(arr);


//Task 3
Console.WriteLine("Enter text");
string line = Console.ReadLine();

Console.WriteLine("Enter key");
int key = Convert.ToInt32(Console.ReadLine());

string encrypted = Task3.Run(line, key);
Console.WriteLine(encrypted);


//Task 4
int[,] matrix1 =  new int [3, 3];
int[,] matrix2 =  new int [3, 3];

Task4.Run(matrix1, matrix2);


//Task 5
Console.WriteLine("Enter mathematical expression (can be only one action)");
string expression = Console.ReadLine();

Task5.Run(expression);


//Task 6
Console.WriteLine("Enter text");
string text1 = Console.ReadLine();

Task6.Run(text1);


//Task 7
Console.WriteLine("Enter text");
string text2 = Console.ReadLine();
Console.WriteLine("Enter banned word");
string bannedWord = Console.ReadLine();

Task7.Run(text2, bannedWord);


//task 8
Task8.Run(args);

//Task 9 
Task9.Run(args);