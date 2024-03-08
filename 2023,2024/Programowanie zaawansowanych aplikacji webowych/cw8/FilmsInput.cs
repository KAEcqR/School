using cw8;

namespace Cw8;
public class FilmsInput
{
    public FilmsInput(List<Film> films)
    {
        Films = films;
    }
    public List<Film> Films { get; set; }
    public void ShowAllFilms(){
        Console.WriteLine(" ================ Wyswietlanie filmow ========");
        foreach(var film in Films){
            ShowFilm(film);
        }
    }
    public void ShowFilm(Film film){
        Console.WriteLine(" Informacje o filmie: ");
        Console.WriteLine($"\tTytul: {film.Title}");
        Console.WriteLine($"\tRezyser: {film.Director}");
        Console.WriteLine($"\tCena: {film.Price} zł");
        Console.WriteLine($"\tOpis: {film.Description}");
    }
    public void AddFilm(Film film){
        Console.WriteLine(" Podaj nowy film: ");
        Console.WriteLine($"\tTytul:"); 
        string Title = Console.ReadLine();
        Console.WriteLine($"\tRezyser: {film.Director}");
        string Director = Console.ReadLine();
        Console.WriteLine($"\tCena: {film.Price} zł");
        int Price= Int32.Parse(Console.ReadLine());
        Console.WriteLine($"\tOpis: {film.Description}");
        string Description = Console.ReadLine();
    }
}
