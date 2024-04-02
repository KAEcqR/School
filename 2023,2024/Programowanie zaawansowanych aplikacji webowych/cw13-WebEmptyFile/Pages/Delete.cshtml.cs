using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebEmptyFile.Models;

namespace WebEmptyFile.Pages
{
    public class DeleteModel : PageModel
    {
        public IActionResult OnGet(string? id)
        {
            if (id != null) {
                var persons = WelcomeRepo.AllFromFile();
                var personToDelete = persons.FirstOrDefault(p => p.Id == id);
                if (personToDelete != null) {
                    //todo usuniecie z listy i zapisanie listy do pliku
                    persons.Remove(personToDelete);
                    WelcomeRepo.SaveAllToFile(persons);
                }
            }

            return RedirectToPage(nameof(Index));
        }
    }
}
