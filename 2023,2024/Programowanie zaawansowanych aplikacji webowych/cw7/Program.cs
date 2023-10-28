// 1 - dodaj nowy film title, director, price, length, year, language/s
//    dodawanie oboektu film do listy
//      zapis do pliku
// 2 - wyswietl wszystkie filmy popbranie z pliku
// 3 -  zakoncz program   ----  ambitnie moga dorobic usuwanie filmu
// title;director;price;length;year;language/s
using System;
using System.Collections.Generic;
using System.IO;

List<Film> Filmy = new List<Film>{};
List<string> FilmyDoPliku = new List<string>{};

void ShowMenu() {
    Console.WriteLine("======== Menu ========");
    Console.WriteLine("1 : Dodaj nowy film");
    Console.WriteLine("2 : Wyświetl filmy");
    Console.WriteLine("3 : Usuń filmy");
    Console.WriteLine("4 : Zakoncz program");
    Console.WriteLine("======================");

    var odpowiedz = Int32.Parse(Console.ReadLine());

    if (odpowiedz == 1){

        Console.WriteLine("Podaj Tytuł: ");
        var tytul = Console.ReadLine();

        Console.WriteLine("Podaj Reżysera: ");
        var rezyser = Console.ReadLine();

        Console.WriteLine("Podaj Cene: ");
        var cena = int.Parse(Console.ReadLine());

        Console.WriteLine("Podaj Dlugosc: ");
        var dlugosc = int.Parse(Console.ReadLine());

        Console.WriteLine("Podaj Rok Produkcji: ");
        var rok = int.Parse(Console.ReadLine());

        Console.WriteLine("Podaj Język: ");
        var jezyk = Console.ReadLine();

        Film mojfilm = new Film(tytul,rezyser, cena, dlugosc, rok, jezyk);
        Filmy.Add(mojfilm);

        DodajFilmDoPliku(mojfilm);

        ShowMenu();

    } else if(odpowiedz == 2){
        WyswietlFilmyZPliku();
        ShowMenu();

    } else if(odpowiedz == 3){
        
        //TODO Usuwanie pojedynczego filmu 
        
        File.Delete(@"filmy.txt");
        Console.WriteLine("Usunieto wszystkie filmy");
        ShowMenu();

    } else if(odpowiedz == 4){

        Console.WriteLine("Zakonczono program");

    } else {
        Console.WriteLine("Ty matole, nie to podałeś");
        ShowMenu();
    }

}

ShowMenu();

void DodajFilmDoPliku(Film film)
{
    string filmInfo = $"{film.Title};{film.Director};{film.Price};{film.Length};{film.Year};{film.Language}";

    FilmyDoPliku.Add(filmInfo);

    File.WriteAllLines("filmy.txt", FilmyDoPliku);
}

void WyswietlFilmyZPliku()
{
    if (File.Exists("filmy.txt"))
    {
        string[] lines = File.ReadAllLines("filmy.txt");

        foreach (string line in lines)
        {
            string[] filmInfo = line.Split(';');

            if (filmInfo.Length == 6)
            {
                string title = filmInfo[0];
                string director = filmInfo[1];
                decimal price = decimal.Parse(filmInfo[2]);
                int length = int.Parse(filmInfo[3]);
                int year = int.Parse(filmInfo[4]);
                string language = filmInfo[5];

                Film film = new Film(title, director, price, length, year, language);
                film.DisplayInfo();
            }
        }
    }
    else
    {
        Console.WriteLine("Brak zapisanych filmów w pliku.");
    }
}
