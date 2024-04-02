using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebEmptyFile.Models;

namespace WebEmptyFile.Pages
{
    public class IndexModel : PageModel
    {
        [BindProperty] 
        public List<Person> Persons { get; set; }
        public void OnGet() {
            Persons = WelcomeRepo.AllFromFile();
                
        }
    }
}
