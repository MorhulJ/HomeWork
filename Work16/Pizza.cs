public class Pizza
{
    public string Dough { get; set; }
    public string Sauce { get; set; }
    public bool HasCheese { get; set; }
    public bool HasPepperoni { get; set; }
    public bool HasMushrooms { get; set; }

    public Pizza(string dough, string sauce, bool hasCheese, bool hasPeperoni, bool hasMashrooms)
    {
        Dough = dough;
        Sauce = sauce;
        HasCheese = hasCheese;
        HasPepperoni = hasPeperoni;
        HasMushrooms = hasMashrooms;
    }
    public Pizza() { }
}