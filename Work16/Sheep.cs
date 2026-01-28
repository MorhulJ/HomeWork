public class Sheep : ICloneable
{
    public string Name { get; set; }
    public int Age { get; set; }

    public Sheep(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public object Clone()
    {
        return this.MemberwiseClone();
    }
}