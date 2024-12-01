using System;
using cw4.Models;
using Microsoft.AspNetCore.Mvc;

namespace cw4.Controllers;

public class HomeController : Controller
{
    private readonly WycieczkaRepo _repo;
    public HomeController(IConfiguration configuration){
        _repo = new WycieczkaRepo(configuration);
    }

    [HttpPost]
    public IActionResult Index(string cel)
    {
        var wycieczki = _repo.GetWycieczki(cel);
        var zdjecia = _repo.GetZdjecia();

        var viewModel = new HomeViewModel
        {
            Wycieczki = wycieczki,
            Zdjecia = zdjecia
        };

        return View(viewModel);
    }
}
