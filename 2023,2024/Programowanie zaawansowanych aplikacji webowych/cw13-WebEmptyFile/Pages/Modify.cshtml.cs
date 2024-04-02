using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebEmptyFile.Models;

namespace WebEmptyFile.Pages
{

    public class ModifyModel : PageModel
    {

        [BindProperty]
        public Person? MyNewPerson { get; set; }

        public IActionResult OnPost(string? id)
        {
            if (id != null)
            {
                var persons = WelcomeRepo.AllFromFile();
                var personToModify = persons.FirstOrDefault(p => p.Id == id);
                if (personToModify != null)
                {
                    personToModify.Firstname = MyNewPerson.Firstname;
                    personToModify.Lastname = MyNewPerson.Lastname;
                    personToModify.Content = MyNewPerson.Content;
                    personToModify.PartyDate = MyNewPerson.PartyDate;
                }

                WelcomeRepo.SaveAllToFile(persons);
            }

            return RedirectToPage(nameof(Index));
        }
    }
}
