using Library.Books;
using Library.Members;
using Library.Operations;

using Task = ToDoList.Task;
using TaskStatus = ToDoList.TaskStatus;

//Task 1
Task1 game1 = new Task1();
game1.Start();


//Task 2
Task2 game2 = new Task2();
game2.Start();


//Task 3
Console.Write("Enter text: ");
string? text1 = Console.ReadLine();
Task3.Run(text1);


//Task 4
Console.Write("Enter morse text: ");
string? text2 = Console.ReadLine();
Task4.Run(text2);


//Task 5
LibraryManager manager = new LibraryManager();

Book book = new Book("Harry Potter", "J.K. Rowling", "Fantasy");
manager.AddBook(book);

Member member = new Member("Yaroslav", 228);
manager.AddMember(member);

manager.BorrowBook("Harry Potter", 228);
manager.ReturnBook("Harry Potter", 228);


//Task 6
Task mainList = new Task("Main", "Main task list");
Task t1 = new Task("Learn C#", "Finish enum tutorial");
Task t2 = new Task("Workout", "Go to the gym");

mainList.AddTask(t1);
mainList.AddTask(t2);

t1.UpdateStatus(TaskStatus.InProgress);
t2.UpdateStatus(TaskStatus.Deferred);

mainList.PrintTasksByStatus(TaskStatus.InProgress);
mainList.PrintTasksByStatus(TaskStatus.Deferred);

