using System;

public class WebSite
{
    private string name;
    private string url;
    private string description;
    private string ipAddress;
    
    public void InputData()
    {
        Console.Write("Enter website name: ");
        name = Console.ReadLine();

        Console.Write("Enter website URL/path: ");
        url = Console.ReadLine();

        Console.Write("Enter website description: ");
        description = Console.ReadLine();

        Console.Write("Enter website IP address: ");
        ipAddress = Console.ReadLine();
    }
    
    public void DisplayData()
    {
        Console.WriteLine("\nWebsite Information:");
        Console.WriteLine($"Name: {name}");
        Console.WriteLine($"URL/Path: {url}");
        Console.WriteLine($"Description: {description}");
        Console.WriteLine($"IP Address: {ipAddress}");
    }
    
    public string GetName() => name;
    public void SetName(string newName) => name = newName;

    public string GetUrl() => url;
    public void SetUrl(string newUrl) => url = newUrl;

    public string GetDescription() => description;
    public void SetDescription(string newDescription) => description = newDescription;

    public string GetIpAddress() => ipAddress;
    public void SetIpAddress(string newIp) => ipAddress = newIp;
}