//Task 1.1
Console.Write("Enter your name: ");
string name = Console.ReadLine();

File.WriteAllText("username.txt", $"User '{name}' recently online {DateTime.Now}");

string file1 = File.ReadAllText("username.txt");
Console.WriteLine(file1);


//Task 1.2
if (File.Exists("config.txt"))
{
    string file2 = File.ReadAllText("config.txt");
    Console.WriteLine(file2);
}
else
    throw new ArgumentException("File not found");


//Task 1.3
if (!File.Exists("log.txt")) File.Create("log.txt").Close();

while  (true)
{
    Console.Write("\nEnter message: ");
    string message = Console.ReadLine();
    File.AppendAllText("log.txt", message +  Environment.NewLine);
    if (message == "0") break;
}


//Task 2.1
if (!File.Exists("sales.csv")) File.Create("sales.csv").Close();

string[] file3 = File.ReadAllLines("sales.csv");

int total = 0;

foreach (var line in file3)
{
    string[] columns = line.Split(',');
    int price = int.Parse(columns[1]);
    total += price;
}

Console.WriteLine($"Total: {total}");


//Task 2.2
string[] allFiles1 = Directory.GetFiles("../../../MyDocuments/");

foreach (string file in allFiles1)
{
    FileInfo info = new FileInfo(file);

    Console.WriteLine($"{info.Name} — {info.Length} bait");
}


//Task 2.3
string text = File.ReadAllText("comment.txt");
string censored = text.Replace("bug", "***", StringComparison.OrdinalIgnoreCase);
Console.WriteLine(censored);


//Task 3.1
Player hero = new Player("GanvestPro2000", 5, 100);

GameSystem.SaveGame(hero);

Console.WriteLine();

GameSystem.LoadGame();


//Task 3.2
string headFolder = "../../../Downloads/";
string[] allFiles2 = Directory.GetFiles(headFolder);

string docsFolder = Path.Combine(headFolder, "Docs");
string imagesFolder = Path.Combine(headFolder, "Images");
string micsFolder = Path.Combine(headFolder, "Mics");

if (!Directory.Exists(docsFolder)) Directory.CreateDirectory(docsFolder);
if (!Directory.Exists(imagesFolder)) Directory.CreateDirectory(imagesFolder);
if (!Directory.Exists(micsFolder)) Directory.CreateDirectory(micsFolder);

foreach (var file in allFiles2)
{
    string fileName = Path.GetFileName(file);
    string ext = Path.GetExtension(file).ToLower();

    if (ext == ".txt")
        File.Move(file, Path.Combine(docsFolder, fileName));
    else if (ext == ".jpg")
        File.Move(file, Path.Combine(imagesFolder, fileName));
    else
        File.Move(file, Path.Combine(micsFolder, fileName));
}


//Task 3.3
string inputFile = "server.log";
string outputFile = "errors_only.txt";

using (StreamReader reader = new StreamReader(inputFile))
using (StreamWriter writer = new StreamWriter(outputFile))
{
    string line;
    while ((line = reader.ReadLine()) != null)
    {
        if (line.StartsWith("[ERROR]"))
        {
            writer.WriteLine(line);
        }
    }
}