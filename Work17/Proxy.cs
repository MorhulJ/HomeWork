using System;
using System.Collections.Generic;
using System.Threading;

namespace VideoHosting;

// 1. Спільний інтерфейс
public interface IVideoService
{
    string GetVideo(int videoId);
}

// 2. Реальний сервіс (важкий ресурс)
public class RealVideoService : IVideoService
{
    public string GetVideo(int videoId)
    {
        Console.WriteLine($"[RealService] Завантаження відео {videoId} з сервера...");
        Thread.Sleep(2000); // Імітація затримки
        return $"Video Content #{videoId}";
    }
}

// 3. Проксі (Кешування)
public class CachedVideoService : IVideoService
{
    private RealVideoService _realService;
    private Dictionary<int, string> _cache = new();

    public CachedVideoService(RealVideoService realService)
    {
        _realService = realService;
    }

    public string GetVideo(int videoId)
    {
        // TODO: Перевірити кеш. Якщо є - повернути.
        // Якщо немає - викликати _realService.GetVideo(), зберегти в кеш і повернути.
        if (_cache.ContainsKey(videoId))
        {
            Console.WriteLine($"[Cache] Відео {videoId} отримано з кешу");
            return _cache[videoId];
        }

        Console.WriteLine($"[Cache] Відео {videoId} відсутнє в кеші");
        var video = _realService.GetVideo(videoId);
        _cache[videoId] = video;

        return video;
    }
}

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        // Клієнт працює через проксі
        IVideoService manager = new CachedVideoService(new RealVideoService());

        Console.WriteLine("Запит відео #10:");
        Console.WriteLine(manager.GetVideo(10));

        Console.WriteLine("\nЗапит відео #10 (повторно):");
        Console.WriteLine(manager.GetVideo(10)); // Має бути миттєво
    }
}