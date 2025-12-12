//Task 1
Product apple = new Product("Apple");

Console.WriteLine("Set price for Apple:");
apple.Price.SetMoney();

apple.PrintInfo();

Console.WriteLine("Enter discount: ");
float discount = Convert.ToSingle(Console.ReadLine());

apple.Discount(discount);

Console.WriteLine("After discount:");
apple.PrintInfo();


//Task 2
Kettle kettle = new Kettle("Kettle", "It's a kettle. You use it to boil water for tea or coffee");

kettle.Sound();
kettle.Show();
kettle.Desc();

Microwave microwave = new Microwave("Microwave", "It's a microwave. You use it to make our lunch warm and more tasty");

microwave.Sound();
microwave.Show();
microwave.Desc();

Auto auto = new Auto("Auto", "It's a Auto. You use it to get to work and get to the shop if u lazy");

auto.Sound();
auto.Show();
auto.Desc();

Steamer steamer = new Steamer("Steamer", "It's a Steamer. You don't use it, but someone use it to seal across the water");

steamer.Sound();
steamer.Show();
steamer.Desc();


//Task 3
Violine violine = new Violine("Violine", "Its violine");

violine.Sound();
violine.Show();
violine.Desc();

Trombone trombone = new Trombone("Trombone", "It's a trombone.");

trombone.Sound();
trombone.Show();
trombone.Desc();

Ukulele ukulele = new Ukulele("Ukulele", "It's a ukulele.");

ukulele.Sound();
ukulele.Show();
ukulele.Desc();

Cello cello = new Cello("Cello", "It's a cello.");

cello.Sound();
cello.Show();
cello.Desc();


//Task 4
President president = new President();
Security security = new Security();
Manager manager = new Manager();
Engineer engineer = new Engineer();

president.Print();
security.Print();
manager.Print();
engineer.Print();


//Task 5
Course course = new Course("Surfing", 3);
OnlineCourse onlineCourse = new OnlineCourse("3D modeling", 1);

Console.WriteLine(course.ToString());
Console.WriteLine(onlineCourse.ToString());


//Task 6
Electronics product1 = new Electronics("microwave", 200);
Furniture product2 = new Furniture("chainik", 100);

product1.CalculateDiscount();
product2.CalculateDiscount();