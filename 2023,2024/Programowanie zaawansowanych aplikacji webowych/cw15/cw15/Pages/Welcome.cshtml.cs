using cw15.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace cw15.Pages
{
    public class WelcomeModel : PageModel
    {
        [BindProperty]
        public Person MyPerson{get; set;}
        public List<Person> Persons { get; set; }

        public void OnGet()
        {
            Persons = WelcomeRepo.AllFromFile();
        }

        public IActionResult OnPost()
        {
            if(ModelState.IsValid){
                
                WelcomeRepo.SaveToFile(MyPerson);

                return RedirectToPage(nameof(Index));
            }

            return Page();
        }
    }
}
