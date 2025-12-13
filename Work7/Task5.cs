public interface IValidate
{
    public void Validate();
}

public class Password : IValidate
{
    public string Pass { get; set; }
    
    public Password(string password)
    {
        Pass = password;
    }

    public void Validate()
    {
        bool HasLetter = false;
        bool HasDigit = false;
        bool HasSpecial = false;
        
        if (string.IsNullOrWhiteSpace(Pass))
        {
            Console.WriteLine("Password CAN'T be empty!");
            return;
        }
        
        if (Pass.Length < 8) Console.WriteLine("Password is TOO short!");

        foreach (char c in Pass)
        {
            if (char.IsLetter(c))
                HasLetter = true;
            else if (char.IsDigit(c))
                HasDigit = true;
            else
                HasSpecial = true;  
        }

        if (!HasLetter) Console.WriteLine("Password MUST have letters!");
        if (!HasDigit) Console.WriteLine("Password MUST have digits!");
        if (!HasSpecial) Console.WriteLine("Password MUST have special!");
    }
}

public class Email : IValidate
{
    public string Mail { get; set; }

    public Email(string mail)
    {
        Mail = mail;
    }

    public void Validate()
    {
        if (string.IsNullOrWhiteSpace(Mail))
        {
            Console.WriteLine("Email CAN'T be empty!");
            return;
        }
        
        int atIndex = Mail.IndexOf('@');
        int lastAtIndex = Mail.LastIndexOf('@');
        int dotIndex = Mail.LastIndexOf('.');

        if (Mail.Contains(' ')) Console.WriteLine("Email CAN'T contain spaces!");
        if (atIndex == -1) Console.WriteLine("Email MUST contain '@'!");
        if (atIndex != lastAtIndex) Console.WriteLine("Email MUST contain ONLY one '@'!");
        if (atIndex == 0 || atIndex == Mail.Length - 1) Console.WriteLine("'@' CAN'T be first or last!");
        if (dotIndex < atIndex + 2 || dotIndex == Mail.Length - 1) Console.WriteLine("Email MUST contain '.' after '@'!");
    }
}
