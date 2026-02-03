/*using System;

namespace CoffeeShop;

// 1. Абстрактний компонент
public abstract class Beverage
{
    public virtual string Description { get; protected set; } = "Unknown Beverage";
    public abstract double Cost();

    public string GetDescription()
    {
        return Description;
    }
}

// 2. Конкретні компоненти (Напої)
public class Espresso : Beverage
{
    public Espresso()
    {
        Description = "Espresso";
    }

    public override double Cost()
    {
        return 60;
    }
    // TODO: Реалізувати Cost() -> 60
}

public class Tea : Beverage
{
    public Tea()
    {
        Description = "Tea";
    }

    public override double Cost()
    {
        return 40;
    }
    // TODO: Реалізувати Cost() -> 40
}

// 3. Базовий декоратор
public abstract class CondimentDecorator(Beverage beverage) : Beverage
{
    protected Beverage _beverage = beverage;

    // Ми змушуємо декоратори перевизначити опис, щоб додати назву добавки
    public abstract override string Description { get; }
}

// 4. Конкретні декоратори (Добавки)
public class Milk : CondimentDecorator
{
    public Milk(Beverage beverage) : base(beverage) { }

    public override string Description => _beverage.Description + ", milk";

    public override double Cost()
    {
        return _beverage.Cost() + 15;
    }
}
// TODO: Реалізувати клас Milk (+15 грн)
public class Sugar : CondimentDecorator
{
    public Sugar(Beverage beverage) : base(beverage) { }

    public override string Description => _beverage.Description + ", sugar";

    public override double Cost()
    {
        return _beverage.Cost() + 5;
    }
}

// TODO: Реалізувати клас Sugar (+5 грн)
public class Chocolate : CondimentDecorator
{
    public Chocolate(Beverage beverage) : base(beverage) { }

    public override string Description => _beverage.Description + ", chocolate";

    public override double Cost()
    {
        return _beverage.Cost() + 20;
    }
}

// TODO: Реалізувати клас Chocolate (+20 грн)

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Beverage beverage = new Espresso();
        beverage = new Milk(beverage);
        beverage = new Chocolate(beverage);
        beverage = new Sugar(beverage);

        Console.WriteLine("Order: " + beverage.Description);
        Console.WriteLine("Cost: " + beverage.Cost());

        // TODO: Створити напій: Еспресо + Молоко + Цукор
        // Вивести на екран Опис та Загальну суму
    }
}*/