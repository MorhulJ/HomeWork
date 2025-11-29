using System;

public class Shop
{
    private string name;
    private string address;
    private string profileDescription;
    private string phone;
    private string email;
    
    public void InputData()
    {
        Console.Write("Enter shop name: ");
        name = Console.ReadLine();

        Console.Write("Enter shop address: ");
        address = Console.ReadLine();

        Console.Write("Enter shop profile description: ");
        profileDescription = Console.ReadLine();

        Console.Write("Enter shop contact phone: ");
        phone = Console.ReadLine();

        Console.Write("Enter shop contact email: ");
        email = Console.ReadLine();
    }
    
    public void DisplayData()
    {
        Console.WriteLine("\nShop Information:");
        Console.WriteLine($"Name: {name}");
        Console.WriteLine($"Address: {address}");
        Console.WriteLine($"Profile Description: {profileDescription}");
        Console.WriteLine($"Phone: {phone}");
        Console.WriteLine($"Email: {email}");
    }
    
    public string GetName() => name;
    public void SetName(string newName) => name = newName;

    public string GetAddress() => address;
    public void SetAddress(string newAddress) => address = newAddress;

    public string GetProfileDescription() => profileDescription;
    public void SetProfileDescription(string newProfile) => profileDescription = newProfile;

    public string GetPhone() => phone;
    public void SetPhone(string newPhone) => phone = newPhone;

    public string GetEmail() => email;
    public void SetEmail(string newEmail) => email = newEmail;
}