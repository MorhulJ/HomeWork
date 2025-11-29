//Task 1
Console.WriteLine("Enter height of square");
int size = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter symbol");
string symbol = Console.ReadLine();

Task1.Run(size, symbol);


//Task 2
Console.WriteLine("Enter number");
int number = Convert.ToInt32(Console.ReadLine());

Task2.Run(number);


//Task 3
int[] arrOrig = new int[5];
int[] arrFilter = new int[5];

Console.WriteLine("=== Fill original array ===");
for (int i = 0; i < arrOrig.Length; i++)
{
    Console.WriteLine($"Enter {i + 1} number");
    arrOrig[i] = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine("=== Fill filter array ===");
for (int i = 0; i < arrOrig.Length; i++)
{
    Console.WriteLine($"Enter {i + 1} number");
    arrFilter[i] = Convert.ToInt32(Console.ReadLine());
}

Task3.Run(arrOrig, arrFilter);


//Task 4
WebSite mySite = new WebSite();

mySite.InputData();

mySite.DisplayData();

Console.WriteLine("\nUpdating website IP...");
mySite.SetIpAddress("192.168.1.1");
Console.WriteLine($"Updated IP Address: {mySite.GetIpAddress()}");


//Task 5
Magazine myJournal = new Magazine();

myJournal.InputData();

myJournal.DisplayData();

Console.WriteLine("\nUpdating journal phone...");
myJournal.SetPhone("+380987654321");
Console.WriteLine($"Updated phone: {myJournal.GetPhone()}");


//Task 6
Shop myShop = new Shop();

myShop.InputData();

myShop.DisplayData();

Console.WriteLine("\nUpdating shop phone...");
myShop.SetPhone("+380123456789");
Console.WriteLine($"Updated phone: {myShop.GetPhone()}");


//Task 7
Reservoir r1 = new Reservoir(100);                      
Reservoir r2 = new Reservoir(200, "Steel");             
Reservoir r3 = new Reservoir(150, "Plastic", 50);       

r3.DisplayInfo();

r3.Fill(120);

r3.Empty(60);

r3.DisplayInfo();


