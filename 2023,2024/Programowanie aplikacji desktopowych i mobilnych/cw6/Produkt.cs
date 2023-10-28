namespace cw6;

public class Produkt1
{
    private string produkt;
    private int cena;
    private int ilosc;
    private string opis;
    public Produkt1(string produkt, int cena,int ilosc, string opis)
    {
        Produkt = produkt;
        Cena = cena;
        Ilosc = ilosc;
        Opis = opis;
    }

    public Produkt1(){
        Produkt = "Kaczka";
        Cena = 12;
        Ilosc = 5;
        Opis = "Bardzo ladna kaczka";
    }
    public void Show(){
        Console.WriteLine($"Produkt: {Produkt} Cena: {Cena} Ilosc: {Ilosc} Opis: {Opis}");
    }

    public void Stan(){
        int Ilosc2;
        string UserInput;
        Console.WriteLine("-------------------------");
        Console.WriteLine("Podaj ile chcesz towaru : ");
        UserInput = Console.ReadLine();
        Ilosc2 = Convert.ToInt32(UserInput);
        if(Ilosc2 > Ilosc){
            Console.WriteLine("-------------------------");
            Console.WriteLine("Nie mamy tyle na stanie");
        }else{
            Console.WriteLine("-------------------------");
            Console.WriteLine($"Musisz zaplacic: {Ilosc2 * Cena} ");
        }
    }


    public string Produkt{
        get{
            return produkt;
        }
        set{
            produkt = value;
        }
    }

    public int Cena{
        get{
            return cena;
        }
        set{
            cena = Math.Abs(value);
        }
    }

    public int Ilosc{
        get{
            return ilosc;
        }
        set{
            ilosc = value;
        }
    }
    public string Opis{
        get{
            return opis;
        }
        set{
            opis = value;
        }
    }

}