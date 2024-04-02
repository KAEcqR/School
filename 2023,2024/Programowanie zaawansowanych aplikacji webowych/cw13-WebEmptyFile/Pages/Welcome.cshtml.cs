using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebEmptyFile.Models;

namespace WebEmptyFile.Pages
{
    public class WelcomeModel : PageModel
    {
        [BindProperty]
        public Person MyPerson { get; set; }
        public void OnGet()
        {
        }

        public IActionResult OnPost() {
            if (ModelState.IsValid) {
                //zapisywanie do pliku
                WelcomeRepo.SaveToFile(MyPerson);
                return RedirectToPage(nameof(Index));
            }

            return Page();

        }
    }
}
