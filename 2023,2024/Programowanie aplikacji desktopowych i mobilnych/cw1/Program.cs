string imie;
Console.WriteLine("Podaj imie: ");
imie = Console.ReadLine();

string nazwisko;
Console.WriteLine("Podaj nazwisko: ");
nazwisko = Console.ReadLine();

int age = 0;
Console.Write("podaj wiek: ");
age = Convert.ToInt32( Console.ReadLine());

Console.WriteLine("Witaj " + imie + " Twoj wiek to " + age);