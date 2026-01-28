public class FileLogger
{
    private static FileLogger _instance;
    private static readonly object _lock = new object();

    private FileLogger()
    {
        Console.WriteLine("Logger created");
    }

    public static FileLogger GetInstance()
    {
        if (_instance == null)
        {
            lock (_lock)
            {
                if (_instance == null)
                {
                    _instance = new FileLogger();
                }
            }
        }

        return _instance;
    }
}