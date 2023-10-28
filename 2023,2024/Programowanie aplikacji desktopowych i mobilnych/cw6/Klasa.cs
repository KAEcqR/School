namespace cw6;

public class Pizza
{
    private string toppings;
    private string dough;
    private string price;
    public Pizza(string toppings,string dough,string price)
    {
        this.toppings = toppings;
        this.dough = dough;
        this.price = price;
    }

    public Pizza(){
        this.toppings = "Sos, Ser";
        this.dough = "Cienkie";
        this.price = "11zł";
    }
    public void Show(){
        Console.WriteLine($"Składniki: {toppings} Ciasto: {dough} Cena: {price}");
    }
}