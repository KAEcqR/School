using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MyApp.Namespace
{
    public class Page3Model : PageModel
    {
    [BindProperty]
        public List<string> Gifts { get; set; }
        public Page3Model()
        {
            Gifts = new List<string>{
                "Konsola do gier",
                "Czerwony rower", "Nudna ksiazka",
                "Klocki lego","Swiateczne skarpetki"
            };
        }
        public void OnGet()
        {
        }
    }
}
