using System;
using System.Collections.Generic;

namespace FileSystem;

// 1. Абстрактний компонент
public abstract class FileSystemComponent
{
    public string Name { get; protected set; }
    public FileSystemComponent(string name) => Name = name;

    public abstract int GetSize(); // Розмір у МБ
}

// 2. Листок (Файл)
public class File : FileSystemComponent
{
    private int _size;

    public File(string name, int size) : base(name)
    {
        _size = size;
    }

    public override int GetSize()
    {
        return _size;
    }
}

// 3. Композит (Папка)
public class Directory : FileSystemComponent
{
    private List<FileSystemComponent> _components = new();

    public Directory(string name) : base(name) { }

    public void Add(FileSystemComponent component)
    {
        _components.Add(component);
    }

    public override int GetSize()
    {
        // TODO: Пройтись по _components і підсумувати їх розмір
        int totalSize = 0;
        
        foreach (var component in _components)
            totalSize += component.GetSize();
            
        return totalSize;
    }
}

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        // Створення файлової структури
        var root = new Directory("Root");
        var movie = new File("Inception.mkv", 2000);
        
        var docsFolder = new Directory("Documents");
        docsFolder.Add(new File("Resume.pdf", 10));
        docsFolder.Add(new File("Picture.png", 5));

        root.Add(movie);
        root.Add(docsFolder);

        Console.WriteLine($"Загальний розмір Root: {root.GetSize()} MB");
        // Очікується: 2015 MB
    }
}