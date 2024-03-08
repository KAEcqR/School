using cw15.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace cw15.Pages
{
    public class WelcomeModel : PageModel
    {
        [BindProperty]
        public Person MyPerson{get; set;}
        public void OnGet()
        {

        }

        public IActionResult OnPost()
        {
            if(ModelState.IsValid){
                //zapisywanie do pliku
                return RedirectToPage(nameof(Index));
            }

            return Page();
        }
    }
}
