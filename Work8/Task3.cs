namespace ConsoleApp;

public class BookList
{
    private List<string> books = new List<string>();

    public int Count
    {
        get { return books.Count; }
    }

    public string this[int index]
    {
        get { return books[index]; }
        set { books[index] = value; }
    }

    public void Show()
    {
        foreach (var book in books)
        {
            Console.Write(book + ", ");
        }
    }

    public void Add(string book)
    {
        books.Add(book);
    }

    public void Remove(string book)
    {
        books.Remove(book);
    }

    public bool Contains(string book)
    {
        return books.Contains(book);
    }

    public static BookList operator +(BookList list, string book)
    {
        list.Add(book);
        return list;
    }

    public static BookList operator -(BookList list, string book)
    {
        list.Remove(book);
        return list;
    }
}