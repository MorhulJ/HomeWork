//Task 1
MyArray1 arr1 = new MyArray1(new int[] { 5, 1, 9, 3, 7 });
Console.WriteLine($"Count of smaller number is {arr.Less(6)}");
Console.WriteLine($"Count of bigger number is {arr.Greater(6)}");


//Task 2
MyArray2 arr2 = new MyArray2(new int[] { 5, 2, 9, 3, 7 });

Console.Write("Even numbers: ");
arr2.ShowEven();

Console.WriteLine();

Console.Write("Odd numbers: ");
arr2.ShowOdd();


//Task 3
MyArray3 arr3 = new MyArray3(new int[] { 5, 2, 9, 5, 7 });
Console.WriteLine($"Count of unique numbers is {arr3.CountDistinct()}");
Console.WriteLine($"Count of equal numbers is {arr3.EqualToValue(5)}");


//Task 4
TV tv = new TV();
Radio radio = new Radio();

tv.TurnOn();
tv.SetChannel(4);
tv.TurnOff();

Console.WriteLine();

radio.TurnOn();
radio.SetChannel(3);
radio.TurnOff();


//Task 5
Password pass = new Password("139487252");
Email mail = new Email("Loefnwof@@gmailcom");

pass.Validate();

Console.WriteLine();

mail.Validate();