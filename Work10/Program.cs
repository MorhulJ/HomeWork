using ConsoleApp;

//Task 3
var card = new CreditCard(1234567812345678, "Morhul Yaroslav", new CardDate(8, 2028), 1234, 5000, 1000 );

card.AccountReplenished += sum => Console.WriteLine($"Account replenished: +{sum}");
card.MoneySpent += sum => Console.WriteLine($"Money spent: -{sum}");
card.CreditMoneyStarted += () => Console.WriteLine("Credit funds usage started!");
card.PinChanged += () => Console.WriteLine("PIN code has been changed!");

card.Deposit(500);
card.Withdraw(2000);
card.ChangePin(1234, 4321);


// //Task 5
MessageService service = new MessageService();
MessageHandler multiDelegate = service.GetMulticastDelegate();
multiDelegate("abcdefghijklmnopqrstuvwxyz");


//Task 6
NumberProcessor processor = new NumberProcessor();
NumberHandler chain = processor.GetProcessingChain();

Console.WriteLine("Processing number 10:");
chain(10);

Console.WriteLine("\nProcessing number -3:");
chain(-3);

Console.WriteLine("\nProcessing number 7:");
chain(7);