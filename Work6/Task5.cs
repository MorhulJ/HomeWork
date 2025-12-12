public class Course
{
    public string Name { get; set; }
    public int Duration { get; set; }

    public Course(string name, int duration)
    {
        Name = name;
        Duration = duration;
    }

    public override string ToString()
    {
        return $"Course info - Name: {Name}, Duration: {Duration} hours";
    }
}

public class OnlineCourse : Course
{
    public OnlineCourse(string name, int duration) : base(name, duration)
    {}
    
    public override string ToString()
    {
        return $"Online course info - Name: {Name}, Duration: {Duration} hours";
    }
    
}