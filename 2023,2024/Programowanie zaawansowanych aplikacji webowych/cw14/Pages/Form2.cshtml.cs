using cw14;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MyApp.Namespace
{
    public class Form2Model : PageModel
    {
        [BindProperty]
        public Film MyFilm{get; set;}      
        public List<string> Genres { get; set; } 
        public Form2Model()
        {
            Genres = new List<string>{
                "Komedia",
                "Akcja", "Sci-Fi",
                "Fantasy","Wojenne"
            };
        }

        public void OnPost()
        {

        }
    }
}
