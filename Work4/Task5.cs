namespace Library
{
    namespace Books
    {
        public class Book
        {
            public string Title { get; }
            public string Author { get; }
            public string Genre { get; }
            public bool IsAvailable { get; set; }

            public Book(string title, string author, string genre)
            {
                Title = title;
                Author = author;
                Genre = genre;
                IsAvailable = true;
            }
        }
    }

    namespace Members
    {
        public class Member
        {
            public string Name { get; }
            public int TicketNumber { get; }

            public Member(string name, int ticketNumber)
            {
                Name = name;
                TicketNumber = ticketNumber;
            }
        }
    }

    namespace Operations
    {
        using Books;
        using Members;

        public class LibraryManager
        {
            private List<Book> books = new List<Book>();
            private List<Member> members = new List<Member>();
            
            public void AddBook(Book book)
            {
                books.Add(book);
                Console.WriteLine($"Book added: {book.Title}");
            }
            
            public void BorrowBook(string title, int ticketNumber)
            {
                Book? book = books.Find(b => b.Title == title);
                Member? member = members.Find(m => m.TicketNumber == ticketNumber);

                if (book == null)
                {
                    Console.WriteLine("Book not found.");
                    return;
                }

                if (member == null)
                {
                    Console.WriteLine("Member not found.");
                    return;
                }

                if (!book.IsAvailable)
                {
                    Console.WriteLine("Book is already borrowed.");
                    return;
                }

                book.IsAvailable = false;
                Console.WriteLine($"{member.Name} borrowed '{book.Title}'");
            }
            
            public void ReturnBook(string title, int ticketNumber)
            {
                Book? book = books.Find(b => b.Title == title);
                Member? member = members.Find(m => m.TicketNumber == ticketNumber);

                if (book == null || member == null)
                {
                    Console.WriteLine("Invalid book or member.");
                    return;
                }

                if (book.IsAvailable)
                {
                    Console.WriteLine("Book was not borrowed.");
                    return;
                }

                book.IsAvailable = true;
                Console.WriteLine($"{member.Name} returned '{book.Title}'");
            }
            public void AddMember(Member member)
            {
                members.Add(member);
                Console.WriteLine($"Member added: {member.Name}");
            }
        }
    }
}