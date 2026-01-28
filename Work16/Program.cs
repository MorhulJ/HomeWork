using System;

//Task 1.1
var gov1 = Government.GetInstance();
var gov2 = Government.GetInstance();

Console.WriteLine(gov1 == gov2);


//Task 1.2
Sheep dolly = new Sheep("Dolly", 5);
Sheep molly = (Sheep)dolly.Clone();
molly.Name = "Molly";

Console.WriteLine($"Original sheep: Name - {dolly.Name},  Age - {dolly.Age}");
Console.WriteLine($"Cloned sheep: Name - {molly.Name},  Age - {molly.Age}");


//Task 1.3
Pizza pizza = new PizzaBuilder()
    .SetDough("Thin")
    .SetSauce("Tomato")
    .AddCheese()
    .AddPepperoni()
    .Build();
    
    
Console.WriteLine($"Pizza: {pizza.Dough}, {pizza.Sauce}, cheese: {pizza.HasCheese}, pepperoni: {pizza.HasPepperoni}" );


//Task 2.1
var tasks = new List<Task>();

for (int i = 0; i < 10; i++)
{
    tasks.Add(Task.Run(() =>
    {
        var logger = FileLogger.GetInstance();
    }));
}

Task.WaitAll(tasks.ToArray());
