using System.Security.Cryptography;
using cw6;

List<Produkt1> Lista = new List<Produkt1> { };
Produkt1 cola = new Produkt1("cola",4,23,"Bardzo slodki napoj");
Produkt1 frytki = new Produkt1("frytki",16,12,"Grube frytki");
Produkt1 pepsi = new Produkt1("pepsi",5,53,"Bardzo slodki napoj gorszy od coli");
Produkt1 czipsy = new Produkt1("czipsy",8,22,"Drogie czipsy lays");
Lista.Add(cola);
Lista.Add(frytki);
Lista.Add(pepsi);
Lista.Add(czipsy);

foreach(Produkt1 i in Lista) 
{
    Console.WriteLine(i.Produkt + " | " + i.Opis + " | ilosc | " + i.Ilosc + " | cena | " + i.Cena);
    Console.WriteLine("---------------------------------------------------------------------------");
}

string answer;

Console.WriteLine("Co chcesz kupić? : ");
answer = Console.ReadLine();

Produkt1 selectedProduct = Lista.FirstOrDefault(item => item.Produkt == answer);

if (selectedProduct != null)
{
    selectedProduct.Stan();
}
else
{
    Console.WriteLine("Nie mamy takiego produktu");
}