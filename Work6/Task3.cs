public abstract class Instrument
{
    public string Name { get; set; }
    public string Description { get; set; }

    public Instrument(string name, string description)
    {
        Name = name;
        Description = description;
    }

    public abstract void Sound();
    public abstract void Show();
    public abstract void Desc();
    public abstract void History();
}

public class Violine : Instrument
{
    public Violine(string name, string description) : base(name, description)
    {
    }

    public override void Sound()
    {
        Console.WriteLine("Wiiiiiiiiiiii wiiiiiii");
    }

    public override void Show()
    {
        Console.WriteLine(Name);
    }

    public override void Desc()
    {
        Console.WriteLine(Description);
    }

    public override void History()
    {
        Console.WriteLine("The violin originated in Italy in the early 16th century as a development of the lute and other bowed string instruments. Its modern form was shaped by makers like Amati, Stradivari, and Guarneri, who perfected the body shape, neck, and sound quality. Since then, the violin has become a central instrument in classical music, gaining worldwide popularity.");
    }
}

public class Trombone : Instrument
{
    public Trombone(string name, string description) : base(name, description)
    {
    }

    public override void Sound()
    {
        Console.WriteLine("Bwaaaaaaah brooooom");
    }

    public override void Show()
    {
        Console.WriteLine(Name);
    }

    public override void Desc()
    {
        Console.WriteLine(Description);
    }

    public override void History()
    {
        Console.WriteLine("The trombone evolved in the 15th century from earlier slide instruments used in Europe for church and ceremonial music. Its modern design, featuring a telescoping slide to change pitch, was refined during the Renaissance and Baroque periods. Today, the trombone is a key instrument in orchestras, jazz bands, and brass ensembles worldwide.");
    }
}

public class Ukulele : Instrument
{
    public Ukulele(string name, string description) : base(name, description)
    {
    }

    public override void Sound()
    {
        Console.WriteLine("Ting-ting-ting");
    }

    public override void Show()
    {
        Console.WriteLine(Name);
    }

    public override void Desc()
    {
        Console.WriteLine(Description);
    }

    public override void History()
    {
        Console.WriteLine("The ukulele originated in the late 19th century in Hawaii, inspired by small Portuguese string instruments like the machete. Hawaiian musicians adapted it, creating a compact, four-stringed instrument with a bright, cheerful sound. Today, the ukulele is popular worldwide for both solo performances and accompaniment in various music genres.");
    }
}

public class Cello : Instrument
{
    public Cello(string name, string description) : base(name, description)
    {
    }

    public override void Sound()
    {
        Console.WriteLine("Vroooom vroooooom");
    }

    public override void Show()
    {
        Console.WriteLine(Name);
    }

    public override void Desc()
    {
        Console.WriteLine(Description);
    }

    public override void History()
    {
        Console.WriteLine("The cello originated in Italy in the early 16th century as part of the violin family, evolving from earlier bass string instruments. Its full, rich tone and versatile range were developed by makers like Amati and Stradivari. Today, the cello is a central instrument in orchestras, chamber music, and solo performances worldwide.");
    }
}