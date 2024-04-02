using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using cw15.Models;

namespace cw15.Pages
{
    public class IndexModel : PageModel
    {
        [BindProperty]
        public List<Person> Persons { get; set; }
        public void OnGet()
        {
            Persons = new List<Person>();
            WelcomeRepo.AllFromFile();
        }
    }
}
