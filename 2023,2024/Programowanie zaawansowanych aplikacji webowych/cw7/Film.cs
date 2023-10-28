public class Film
{
    public string Title { get; set; }
    public string Director { get; set; }
    public decimal Price { get; set; }
    public int Length { get; set; }
    public int Year { get; set; }
    public string Language { get; set; }

    public Film(string title, string director, decimal price, int length, int year, string language)
    {
        Title = title;
        Director = director;
        Price = price;
        Length = length;
        Year = year;
        Language = language;
    }
    public void DisplayInfo()
    {
        Console.WriteLine("---- " + Title + "----");
        Console.WriteLine("Reżyser: " + Director + " Cena: " + Price + " Długość: ");
        Console.WriteLine("Długość: " + Length + " minutes" + " Rok: " + Year + " Język: " + Language );
        Console.WriteLine("----------------------");
    }
}
