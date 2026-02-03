/*using System;

namespace LoggingSystem;

// 1. Target (Цільовий інтерфейс)
public interface ILogger
{
    void Log(string message);
    void Error(string message);
}

// 2. Adaptee (Стороння бібліотека, яку треба адаптувати)
// Уявіть, що цей код ви не можете змінювати
public class FileWriter
{
    public void Write(string text)
    {
        Console.Write(text);
    }

    public void WriteLine(string text)
    {
        Console.WriteLine($"[FILE] >> {text}");
    }
}

// 3. Adapter
public class FileLoggerAdapter : ILogger
{
    private readonly FileWriter _fileWriter;

    public FileLoggerAdapter(FileWriter fileWriter)
    {
        _fileWriter = fileWriter;
    }

    public void Log(string message)
    {
        _fileWriter.WriteLine(message);
        // TODO: Перенаправити виклик до _fileWriter.WriteLine
    }

    public void Error(string message)
    {
        _fileWriter.WriteLine($"ERROR: {message}");
        // TODO: Перенаправити до _fileWriter, додавши префікс "ERROR: "
    }
}

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        // Старий спосіб (якби ми писали прямо)
        // var writer = new FileWriter();
        // writer.WriteLine("Test");

        // Новий спосіб (через універсальний інтерфейс)
        ILogger logger = new FileLoggerAdapter(new FileWriter());
        
        logger.Log("Користувач увійшов у систему");
        logger.Error("Зв'язок з базою даних втрачено");
    }
}*/