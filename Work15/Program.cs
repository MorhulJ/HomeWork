using System;
using System.Reflection;
using System.Text.RegularExpressions;

// 1. Атрибут обов'язкового поля (ВЖЕ ГОТОВИЙ)
[AttributeUsage(AttributeTargets.Property)]
public class MyRequiredAttribute : Attribute { }

[AttributeUsage(AttributeTargets.Property)]
public class MyStringLengthAttribute : Attribute
{
    public int MaxLength { get; set; }

    public MyStringLengthAttribute(int maxLength)
    {
        MaxLength = maxLength;
    }
}

[AttributeUsage(AttributeTargets.Property)]
public class MyRangeAttribute : Attribute
{
    public int Min { get; set; }
    public int Max { get; set; }
    
    public MyRangeAttribute(int min, int max)
    {
        Min = min;
        Max = max;
    }
}

[AttributeUsage(AttributeTargets.Property)]
public class MyPhoneAttribute : Attribute
{
    public string Pattern { get; set; }
    public MyPhoneAttribute(string pattern)
    {
        Pattern = pattern;
    }
}

// 2. Валідатор (ПОТРІБНО РОЗШИРИТИ)
public static class SimpleValidator
{
    public static bool Validate(object obj)
    {
        Type type = obj.GetType();
        bool isValid = true;

        foreach (PropertyInfo prop in type.GetProperties())
        {
            var value = prop.GetValue(obj);

            // ПЕРЕВІРКА 1: MyRequired
            if (Attribute.IsDefined(prop, typeof(MyRequiredAttribute)))
            {
                if (value is string str && string.IsNullOrWhiteSpace(str))
                {
                    Console.WriteLine($"[Error] Field '{prop.Name}' is compulsory.");
                    isValid = false;
                }
            }

            var lengthAttr = prop.GetCustomAttribute<MyStringLengthAttribute>();
            if (lengthAttr != null && value is string strVal)
            {
                if (strVal.Length > lengthAttr.MaxLength)
                {
                    Console.WriteLine($"[Error] Field '{prop.Name}' is too long.");
                    isValid = false;
                }
            }


            var rangeAttr = prop.GetCustomAttribute<MyRangeAttribute>();
            if (rangeAttr != null && value is int intVal)
            {
                if (intVal < rangeAttr.Min || intVal > rangeAttr.Max)
                {
                    Console.WriteLine($"[Error] Field '{prop.Name}' isn't in range.");
                    isValid = false;
                }
            }


            var phoneAttr = prop.GetCustomAttribute<MyPhoneAttribute>();
            if (phoneAttr != null && value is string phone)
            {
                if (!Regex.IsMatch(phone, phoneAttr.Pattern))
                {
                    Console.WriteLine($"[Error] Field '{prop.Name}' has invalid phone format.");
                    isValid = false;
                }
            }
        }
        return isValid;
    }
}

// 3. Тестовий клас
public class UserProfile
{
    [MyRequired]
    [MyStringLength(20)]
    public string FullName { get; set; }

    [MyRange(18, 35)]
    public int Age { get; set; }
    [MyPhone(@"^\+0\d{10}$")]
    public string PhoneNumber { get; set; }
}

class Program
{
    static void Main()
    {
        var user = new UserProfile { FullName = "", Age = 150, PhoneNumber = "invalid" };

        Console.WriteLine("--- Validation start ---");
        bool result = SimpleValidator.Validate(user);

        if (result) Console.WriteLine("Success validation!");
        else Console.WriteLine("Failed validation!.");
    }
}