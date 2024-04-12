using Microsoft.AspNetCore.Mvc;

namespace cw16.Controllers;


public class HomeController : Controller
{
    public string Index(){
        return "Hello from Index and Home";
    }

    public string Welcome(){
        return "Moje imie i nazwisko";
    }

    public IActionResult Index2(){
        return View();
    }
}
