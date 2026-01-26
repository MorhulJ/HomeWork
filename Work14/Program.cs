using System;
using System.IO;
using System.Text.Json; // Для JSON
using System.Xml.Serialization; // Для XML
using System.Collections.Generic;
using System.Linq; // Для пошуку


//Task 1.1
// AppConfig config = new AppConfig("MyAppConfig", 6.7, true);
//
// XmlSerializer serializer1 = new XmlSerializer(typeof(AppConfig));
//
// using (FileStream fs1 = new FileStream("config.xml", FileMode.Create))
// {
//     serializer1.Serialize(fs1, config);
// }


//Task 1.2
List<Contact> contacts = new List<Contact>
{
    new Contact("Jaroslav", "+497508023122"),
    new Contact("Kiril", "+8759623234"),
    new Contact("Bogdan", "+32498690872"),
};

string jsonSerialize = JsonSerializer.Serialize(contacts);
File.WriteAllText("contacts.json", jsonSerialize);

string jsonDeserialize1 = File.ReadAllText("contacts.json");

List<Contact>? contactsDeserialize1 = JsonSerializer.Deserialize<List<Contact>>(jsonDeserialize1);

foreach (Contact contact in contactsDeserialize1) Console.WriteLine($"{contact.Name}:  {contact.PhoneNumber}");


//Task 1.3
// XmlSerializer serializer2 = new XmlSerializer(typeof(List<Contact>));
//
// string jsonDeserialize2 = File.ReadAllText("contacts.json");
//
// List<Contact>? contactsDeserialize2 = JsonSerializer.Deserialize<List<Contact>>(jsonDeserialize2);
//
// using (FileStream fs2 = new FileStream("contacts.xml", FileMode.Create))
// {
//     serializer2.Serialize(fs2, contactsDeserialize2);
// }


//Task 2.1
void AddContact(Contact newContact)
{
    List<Contact> contacts = new List<Contact>();

    if (File.Exists("contacts.json"))
    {
        string json = File.ReadAllText("contacts.json");
        contacts = JsonSerializer.Deserialize<List<Contact>>(json) ?? new List<Contact>();
    }

    contacts.Add(newContact);

    string jsonUpdated = JsonSerializer.Serialize(contacts, new JsonSerializerOptions { WriteIndented = true });
    File.WriteAllText("contacts.json", jsonUpdated);
}

AddContact(new Contact("Blablabla", "+497508023122"));
AddContact(new Contact("Blebleble", "+8759623234"));
AddContact(new Contact("Blublublu", "+32498690872"));

string jsonDeserialize = File.ReadAllText("contacts.json");
List<Contact>? contacts2 = JsonSerializer.Deserialize<List<Contact>>(jsonDeserialize);

foreach (var contact in contacts) Console.WriteLine($"{contact.Name}: {contact.PhoneNumber}");


//Task 2.2
void UpdatePhone(string name, string newPhone)
{
    List<Contact>? contacts = new List<Contact>();
    if (File.Exists("contacts.json"))
    {
        string json = File.ReadAllText("contacts.json");
        contacts = JsonSerializer.Deserialize<List<Contact>>(json);
    }
    
    Contact contactToUpdate = contacts.FirstOrDefault(c => c.Name.Equals(name, StringComparison.OrdinalIgnoreCase));

    if (contactToUpdate != null)
    {
        contactToUpdate.PhoneNumber = newPhone;
        
        string jsonUpdated = JsonSerializer.Serialize(contacts, new JsonSerializerOptions { WriteIndented = true });
        File.WriteAllText("contacts.json", jsonUpdated);
    }
    else Console.WriteLine($"Contact {name} not found");
}

UpdatePhone("Kiril", "+111222333");


//Task 2.3
void RemoveContact(string name)
{
    List<Contact>? contacts = new List<Contact>();
    
    if (File.Exists(""))
    {
        string json = File.ReadAllText("contacts.json");
        contacts = JsonSerializer.Deserialize<List<Contact>>(json);
    }
    
    int removedCount = contacts.RemoveAll(c => c.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
    
    string jsonUpdated = JsonSerializer.Serialize(contacts, new JsonSerializerOptions { WriteIndented = true });
    File.WriteAllText("contacts.json", jsonUpdated);
    
    if (removedCount > 0)
        Console.WriteLine($"Contact(s) '{name}' removed ({removedCount} record(s)).");
    else
        Console.WriteLine($"Contact '{name}' not found.");
}

RemoveContact("Bogdan");