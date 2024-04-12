using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebEmptyFile.Models;

namespace WebEmptyFile.Pages
{
    public class ResetModel : PageModel
    {
        public IActionResult OnGet()
        {
            CounterRepo.Reset();

            return RedirectToPage("Counter");
        }
    }
}
