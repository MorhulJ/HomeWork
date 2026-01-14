namespace  ConsoleApp;

//Task 1
public class Program1
{
    private static string text = "Hello world from C# extension";
    private static int[] numbers = { 1, 5, 8, 12, 3, 20 };
    private static decimal price = 100.5m;
    
    public static void Main(string[] args)
    {
        var wordCount = text.WordCount();
        Console.WriteLine(wordCount);
        
        var evenNumbers = numbers
            .Where(n => n % 2 == 0);

        foreach (var n in evenNumbers)
            Console.Write(n + ", ");

        var uah = price.ToUAH(41.5m);
        Console.WriteLine($"\n${price} to UAH: {uah:F2}");
    }
}

public static class StringExtension
{
    public static int WordCount(this string text)
    {
        var count = text.Split().Length;
        return count;
    }
}

public static class DecimalExtension
{
    public static decimal ToUAH(this decimal amount, decimal rate)
    {
        return amount * rate;
    }
}

//Task 2
public class Product
{
    public string Name { get; set; }
    public string Category { get; set; }
    public decimal Price { get; set; }
    public int Stock { get; set; }
}

public class Product2
{
    private static List<Product> productList1 = new List<Product>
    {
        new() { Name = "Laptop", Price = 1200m, Category = "Electronics", Stock = 5 },
        new() { Name = "Mouse", Price = 25m, Category = "Electronics", Stock = 50 },
        new() { Name = "Keyboard", Price = 75m, Category = "Electronics", Stock = 20 },
        new() { Name = "C# Guide", Price = 45m, Category = "Books", Stock = 15 },
        new() { Name = "LINQ Mastery", Price = 38m, Category = "Books", Stock = 10 },
        new() { Name = "Monitor", Price = 350m, Category = "Electronics", Stock = 8 },
        new() { Name = "Desk Chair", Price = 199m, Category = "Furniture", Stock = 12 }
    };

    private static List<int> list = new List<int> {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
    private static List<int>? nullList = null;

    
    public static void Main (String[] args)
    {
        var electronicsInStock = productList1
                .Where(p => p.Category == "Electronics" && p.Stock > 0)
                .OrderByDescending(p => p.Price);

        foreach (var p in electronicsInStock) 
            Console.WriteLine($"{p.Name} | ${p.Price} | Stock: {p.Stock}");
        
        Console.WriteLine();
        
        var stringProducts = productList1
            .Select(p => $"{p.Name} | ${p.Price}");
        
        foreach (var p in stringProducts)
            Console.WriteLine(p);
        
        Console.WriteLine();
        
        foreach (var n in list.SafeEmpty())
        {
            Console.WriteLine(n);
        }
        
        foreach (var n in nullList.SafeEmpty())
        {
            Console.WriteLine(n);
        }
    }
}

public static class EnumerableExtensions
{
    public static IEnumerable<T> SafeEmpty<T>(this IEnumerable<T> source)
    {
        return source ?? Enumerable.Empty<T>();
    }
}

public class Product3
{
    private static List<Product> productList2 = new List<Product>
    {
        new() { Name = "Laptop Pro", Price = 1350m, Category = "Electronics", Stock = 6 }, // 1
        new() { Name = "Laptop Air", Price = 1100m, Category = "Electronics", Stock = 8 }, // 2
        new() { Name = "Gaming Laptop", Price = 1800m, Category = "Electronics", Stock = 4 }, // 3
        new() { Name = "Office Mouse", Price = 20m, Category = "Electronics", Stock = 60 }, // 4
        new() { Name = "Gaming Mouse", Price = 55m, Category = "Electronics", Stock = 40 }, // 5
        new() { Name = "Wireless Mouse", Price = 35m, Category = "Electronics", Stock = 45 }, // 6
        new() { Name = "Mechanical Keyboard", Price = 120m, Category = "Electronics", Stock = 25 }, // 7
        new() { Name = "Office Keyboard", Price = 40m, Category = "Electronics", Stock = 50 }, // 8
        new() { Name = "RGB Keyboard", Price = 95m, Category = "Electronics", Stock = 18 }, // 9
        new() { Name = "Monitor 24\"", Price = 220m, Category = "Electronics", Stock = 20 }, // 10
        new() { Name = "Monitor 27\"", Price = 320m, Category = "Electronics", Stock = 15 }, // 11
        new() { Name = "Monitor 32\"", Price = 450m, Category = "Electronics", Stock = 10 }, // 12
        new() { Name = "USB Hub", Price = 25m, Category = "Accessories", Stock = 70 }, // 13
        new() { Name = "Web Camera", Price = 80m, Category = "Electronics", Stock = 22 }, // 14
        new() { Name = "Headphones", Price = 150m, Category = "Electronics", Stock = 30 }, // 15
        new() { Name = "Bluetooth Speaker", Price = 90m, Category = "Electronics", Stock = 28 }, // 16
        new() { Name = "Smartphone A1", Price = 600m, Category = "Electronics", Stock = 35 }, // 17
        new() { Name = "Smartphone A2", Price = 750m, Category = "Electronics", Stock = 27 }, // 18
        new() { Name = "Smartphone A3", Price = 920m, Category = "Electronics", Stock = 19 }, // 19
        new() { Name = "Tablet 10\"", Price = 480m, Category = "Electronics", Stock = 21 }, // 20
        new() { Name = "C# Basics", Price = 30m, Category = "Books", Stock = 40 }, // 21
        new() { Name = "C# Advanced", Price = 45m, Category = "Books", Stock = 35 }, // 22
        new() { Name = "LINQ in Action", Price = 50m, Category = "Books", Stock = 28 }, // 23
        new() { Name = "ASP.NET Core", Price = 55m, Category = "Books", Stock = 25 }, // 24
        new() { Name = "Design Patterns", Price = 60m, Category = "Books", Stock = 20 }, // 25
        new() { Name = "Clean Code", Price = 58m, Category = "Books", Stock = 18 }, // 26
        new() { Name = "Algorithms", Price = 65m, Category = "Books", Stock = 15 }, // 27
        new() { Name = "Data Structures", Price = 62m, Category = "Books", Stock = 17 }, // 28
        new() { Name = "SQL Guide", Price = 42m, Category = "Books", Stock = 30 }, // 29
        new() { Name = "Git Handbook", Price = 35m, Category = "Books", Stock = 33 }, // 30
        new() { Name = "Office Chair", Price = 210m, Category = "Furniture", Stock = 14 }, // 31
        new() { Name = "Gaming Chair", Price = 320m, Category = "Furniture", Stock = 10 }, // 32
        new() { Name = "Desk Small", Price = 180m, Category = "Furniture", Stock = 16 }, // 33
        new() { Name = "Desk Large", Price = 280m, Category = "Furniture", Stock = 9 }, // 34
        new() { Name = "Bookshelf", Price = 150m, Category = "Furniture", Stock = 12 }, // 35
        new() { Name = "Drawer Cabinet", Price = 170m, Category = "Furniture", Stock = 11 }, // 36
        new() { Name = "Bedside Table", Price = 95m, Category = "Furniture", Stock = 20 }, // 37
        new() { Name = "Wardrobe", Price = 520m, Category = "Furniture", Stock = 5 }, // 38
        new() { Name = "Coffee Table", Price = 130m, Category = "Furniture", Stock = 14 }, // 39
        new() { Name = "TV Stand", Price = 200m, Category = "Furniture", Stock = 13 }, // 40
        new() { Name = "USB Cable", Price = 10m, Category = "Accessories", Stock = 100 }, // 41
        new() { Name = "HDMI Cable", Price = 15m, Category = "Accessories", Stock = 90 }, // 42
        new() { Name = "Power Bank", Price = 45m, Category = "Accessories", Stock = 40 }, // 43
        new() { Name = "Phone Case", Price = 18m, Category = "Accessories", Stock = 70 }, // 44
        new() { Name = "Screen Protector", Price = 12m, Category = "Accessories", Stock = 80 }, // 45
        new() { Name = "Laptop Bag", Price = 55m, Category = "Accessories", Stock = 25 }, // 46
        new() { Name = "Backpack", Price = 75m, Category = "Accessories", Stock = 22 }, // 47
        new() { Name = "Wireless Charger", Price = 40m, Category = "Accessories", Stock = 35 }, // 48
        new() { Name = "Smart Watch", Price = 250m, Category = "Electronics", Stock = 18 }, // 49
        new() { Name = "Fitness Tracker", Price = 120m, Category = "Electronics", Stock = 26 }, // 50
        new() { Name = "Printer", Price = 300m, Category = "Electronics", Stock = 12 }, // 51
        new() { Name = "Scanner", Price = 280m, Category = "Electronics", Stock = 8 }, // 52
        new() { Name = "Router", Price = 95m, Category = "Electronics", Stock = 34 }, // 53
        new() { Name = "Wi-Fi Extender", Price = 65m, Category = "Electronics", Stock = 29 }, // 54
        new() { Name = "NAS Storage", Price = 650m, Category = "Electronics", Stock = 6 }, // 55
        new() { Name = "External HDD", Price = 120m, Category = "Electronics", Stock = 24 }, // 56
        new() { Name = "External SSD", Price = 180m, Category = "Electronics", Stock = 20 }, // 57
        new() { Name = "Flash Drive 64GB", Price = 20m, Category = "Electronics", Stock = 70 }, // 58
        new() { Name = "Flash Drive 128GB", Price = 35m, Category = "Electronics", Stock = 55 }, // 59
        new() { Name = "Flash Drive 256GB", Price = 60m, Category = "Electronics", Stock = 40 }, // 60
        new() { Name = "Notebook", Price = 5m, Category = "Books", Stock = 100 }, // 61
        new() { Name = "Sketchbook", Price = 12m, Category = "Books", Stock = 50 }, // 62
        new() { Name = "Art Book", Price = 40m, Category = "Books", Stock = 30 }, // 63
        new() { Name = "Math Guide", Price = 35m, Category = "Books", Stock = 25 }, // 64
        new() { Name = "Physics Guide", Price = 38m, Category = "Books", Stock = 20 }, // 65
        new() { Name = "Chemistry Guide", Price = 42m, Category = "Books", Stock = 18 }, // 66
        new() { Name = "English Grammar", Price = 28m, Category = "Books", Stock = 22 }, // 67
        new() { Name = "Spanish Grammar", Price = 30m, Category = "Books", Stock = 20 }, // 68
        new() { Name = "French Grammar", Price = 32m, Category = "Books", Stock = 15 }, // 69
        new() { Name = "History of Art", Price = 50m, Category = "Books", Stock = 12 }, // 70
        new() { Name = "Ergonomic Chair", Price = 250m, Category = "Furniture", Stock = 10 }, // 71
        new() { Name = "Standing Desk", Price = 400m, Category = "Furniture", Stock = 5 }, // 72
        new() { Name = "Office Desk", Price = 300m, Category = "Furniture", Stock = 8 }, // 73
        new() { Name = "Drawer Unit", Price = 180m, Category = "Furniture", Stock = 12 }, // 74
        new() { Name = "Filing Cabinet", Price = 220m, Category = "Furniture", Stock = 7 }, // 75
        new() { Name = "Sofa", Price = 600m, Category = "Furniture", Stock = 6 }, // 76
        new() { Name = "Recliner Chair", Price = 350m, Category = "Furniture", Stock = 4 }, // 77
        new() { Name = "Coffee Table Glass", Price = 150m, Category = "Furniture", Stock = 10 }, // 78
        new() { Name = "Bookshelf Large", Price = 400m, Category = "Furniture", Stock = 5 }, // 79
        new() { Name = "Bookshelf Small", Price = 180m, Category = "Furniture", Stock = 8 }, // 80
        new() { Name = "HDMI Adapter", Price = 15m, Category = "Accessories", Stock = 50 }, // 81
        new() { Name = "Laptop Stand", Price = 60m, Category = "Accessories", Stock = 30 }, // 82
        new() { Name = "Mouse Pad", Price = 10m, Category = "Accessories", Stock = 100 }, // 83
        new() { Name = "Keyboard Cover", Price = 8m, Category = "Accessories", Stock = 90 }, // 84
        new() { Name = "Cable Organizer", Price = 12m, Category = "Accessories", Stock = 40 }, // 85
        new() { Name = "Monitor Mount", Price = 70m, Category = "Accessories", Stock = 20 }, // 86
        new() { Name = "Webcam Cover", Price = 5m, Category = "Accessories", Stock = 80 }, // 87
        new() { Name = "Stylus Pen", Price = 25m, Category = "Accessories", Stock = 35 }, // 88
        new() { Name = "Screen Cleaner", Price = 10m, Category = "Accessories", Stock = 50 }, // 89
        new() { Name = "Laptop Cooling Pad", Price = 40m, Category = "Accessories", Stock = 25 }, // 90
        new() { Name = "Smart Light", Price = 60m, Category = "Electronics", Stock = 22 }, // 91
        new() { Name = "Smart Plug", Price = 35m, Category = "Electronics", Stock = 30 }, // 92
        new() { Name = "Security Camera", Price = 120m, Category = "Electronics", Stock = 15 }, // 93
        new() { Name = "Door Sensor", Price = 25m, Category = "Electronics", Stock = 40 }, // 94
        new() { Name = "Motion Sensor", Price = 30m, Category = "Electronics", Stock = 35 }, // 95
        new() { Name = "Smart Thermostat", Price = 200m, Category = "Electronics", Stock = 12 }, // 96
        new() { Name = "Smart Lock", Price = 250m, Category = "Electronics", Stock = 8 }, // 97
        new() { Name = "Voice Assistant", Price = 100m, Category = "Electronics", Stock = 20 }, // 98
        new() { Name = "E-reader", Price = 120m, Category = "Electronics", Stock = 15 }, // 99
        new() { Name = "Portable Projector", Price = 350m, Category = "Electronics", Stock = 10 } // 100
    };
    
    public static void Main (String[] args)
    {
        var groupedProducts = productList2
            .GroupBy(p => p.Category)
            .Select(g => new
            {
                CategoryName = g.Key,
                ProductCount = g.Count(),
                AveragePrice = g.Average(p => p.Price)
            });
        
        foreach (var group in groupedProducts)
        {
            Console.WriteLine($"{group.CategoryName} | Count: {group.ProductCount} | Avg Price: {group.AveragePrice:F2}");
        }
        
        Console.WriteLine();
        
        var page2 = productList2.Page(2, 10);

        foreach (var p in page2)
        {
            Console.WriteLine($"{p.Name} | ${p.Price} | {p.Category}");
        }
        
        Console.WriteLine();
        
        var AllInStock =  productList2
            .All(p => p.Stock > 0);
        
        Console.WriteLine($"All products are in stock?: {AllInStock}");

        var containsProductMoreExpensiveThan10000 =  productList2
            .Any(p => p.Price > 10000);
        
        Console.WriteLine($"List contains products more expensive than 10000?: {containsProductMoreExpensiveThan10000}");
    }
}

public static class EnumerableExtensions
{
    public static IEnumerable<T> Page<T>(this IEnumerable<T> source, int pageNumber, int pageSize)
    {
        if (pageNumber < 1) throw new ArgumentOutOfRangeException(nameof(pageNumber), "Page number must be 1 or greater.");
        if (pageSize < 1) throw new ArgumentOutOfRangeException(nameof(pageSize), "Page size must be 1 or greater.");

        return source
            .Skip((pageNumber - 1) * pageSize)
            .Take(pageSize);
    }
}