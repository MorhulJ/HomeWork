using ConsoleApp;

//Task 1
Magazine magazine1 = new Magazine("Magazine1", 5);
Magazine magazine2 = new Magazine("Magazine2", 10);

magazine1 = magazine1 + 1;
magazine2 = magazine2 + 3;

magazine1.Show();
magazine2.Show();

magazine1 = magazine1 - 1;
magazine2 = magazine2 - 3;

magazine1.Show();
magazine2.Show();


//Task 2
Shop shop1 = new Shop("atb", 10);
Shop shop2 = new Shop("silpo", 15);

shop1 = shop1 + 2;
shop2 = shop2 + 3;

shop1.Show();
shop2.Show();

shop1 = shop1 - 2;
shop2 = shop2 - 3;

shop1.Show();
shop2.Show();


//Task 3
BookList list =  new BookList();

list += "Harry Poter";
list += "Ten niger children";
list += "Three pigs";

list.Show();

list -= "Ten niger children";

list.Show();


//Task 4
TemperatureArray temps = new TemperatureArray();

temps[0] = 10;
temps[1] = 12;
temps[2] = 11;
temps[3] = 9;
temps[4] = 13;
temps[5] = 15;
temps[6] = 14;

Console.WriteLine("Temperature in wednesday: " + temps[2]);
Console.WriteLine("Average temperature: " + temps.GetAverageTemperature());


//Task 5
Fraction fraction1 = new Fraction(5, 3);
Fraction fraction2 = new Fraction(1, 9);
Fraction fraction3 = new Fraction();
Fraction fraction4 = new Fraction();
Fraction fraction5 = new Fraction();
Fraction fraction6 = new Fraction();

fraction3 = fraction1 + fraction2;
fraction4 = fraction1 - fraction2;
fraction5 = fraction1 * fraction2;
fraction6 = fraction2 / fraction2;

fraction3.Show();
fraction4.Show();
fraction5.Show();
fraction6.Show();

fraction3.Reduction();


//Task 6
Product product1 = new Product("Apple", 3, 5);
Product product2 = new Product("Orange", 100, 5);

bool b1;
bool b2;

product1 += 10;
product1.Show();
product1 -= 3;
product1.Show();

b1 = product1 == product2;
b2 = product1 != product2;

Console.WriteLine(b1);
Console.WriteLine(b2);




