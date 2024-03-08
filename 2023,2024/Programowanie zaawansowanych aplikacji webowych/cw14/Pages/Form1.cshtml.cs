using System.ComponentModel;
using cw14;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MyApp.Namespace
{
    public class Form1Model : PageModel
    {
        [BindProperty]
        public Game MyGame{get; set;}
        public void OnGet()
        {
        }

        public void OnPost(){
        }
    }
}
