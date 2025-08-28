using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.IO;

namespace cw5.Views.Home
{
    public class IndexModel : PageModel
    {
        // Ścieżka do pliku licznik.txt w folderze wwwroot
        string FilePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "licznik.txt");

        public int VisitCount { get; set; }

        public void OnGet()
        {
            // Sprawdzamy, czy plik istnieje. Jeśli nie, tworzymy go i ustawiamy licznik na 0.
            if (!System.IO.File.Exists(FilePath))
            {
                WriteVisitCount(0); // Tworzymy plik, jeśli nie istnieje
            }

            VisitCount = ReadVisitCount(); // Odczytujemy aktualny licznik
            VisitCount++; // Zwiększamy licznik o 1
            WriteVisitCount(VisitCount); // Zapisujemy nową wartość do pliku

            // Wypisujemy pełną ścieżkę do pliku w konsoli
            Console.WriteLine($"Plik zapisywany w: {Path.GetFullPath(FilePath)}");
        }

        // Metoda do odczytu liczby odwiedzin z pliku
        private int ReadVisitCount()
        {
            string content = System.IO.File.ReadAllText(FilePath); // Odczytujemy zawartość pliku
            return int.TryParse(content, out int count) ? count : 0; // Zwracamy wartość lub 0, jeśli nie uda się odczytać liczby
        }

        // Metoda do zapisania liczby odwiedzin do pliku
        private void WriteVisitCount(int count)
        {
            System.IO.File.WriteAllText(FilePath, count.ToString()); // Zapisujemy licznik w pliku
        }
    }
}
