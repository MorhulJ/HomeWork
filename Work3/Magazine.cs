using System;

public class Magazine
{
    private string name;
    private int yearFounded;
    private string description;
    private string phone;
    private string email;

    public void InputData()
    {
        Console.Write("Enter journal name: ");
        name = Console.ReadLine();

        Console.Write("Enter year founded: ");
        yearFounded = int.Parse(Console.ReadLine());

        Console.Write("Enter journal description: ");
        description = Console.ReadLine();

        Console.Write("Enter contact phone: ");
        phone = Console.ReadLine();

        Console.Write("Enter contact email: ");
        email = Console.ReadLine();
    }
    
    public void DisplayData()
    {
        Console.WriteLine("\nJournal Information:");
        Console.WriteLine($"Name: {name}");
        Console.WriteLine($"Year Founded: {yearFounded}");
        Console.WriteLine($"Description: {description}");
        Console.WriteLine($"Phone: {phone}");
        Console.WriteLine($"Email: {email}");
    }
    
    public string GetName() => name;
    public void SetName(string newName) => name = newName;

    public int GetYearFounded() => yearFounded;
    public void SetYearFounded(int newYear) => yearFounded = newYear;

    public string GetDescription() => description;
    public void SetDescription(string newDescription) => description = newDescription;

    public string GetPhone() => phone;
    public void SetPhone(string newPhone) => phone = newPhone;

    public string GetEmail() => email;
    public void SetEmail(string newEmail) => email = newEmail;
}