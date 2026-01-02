
namespace ConsoleApp;

public delegate void MessageHandler(string message);

public class MessageService
{
    public void DisplayMessage(string message)
    {
        Console.WriteLine("On screen: " + message);
    }

    public void SaveMessageToFile(string message)
    {
        string filePath = "message.txt";
        File.AppendAllText(filePath, message + Environment.NewLine);
        Console.WriteLine("Message saved to file: " + filePath);
    }

    public MessageHandler GetMulticastDelegate()
    {
        MessageHandler handler = DisplayMessage;
        handler += SaveMessageToFile;
        return handler;
    }
}