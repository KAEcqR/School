using System.Diagnostics;
using cw8.Models;
using Microsoft.AspNetCore.Mvc;

namespace cw8.Controllers
{
    public class HomeController : Controller
    {
        private readonly PodzespolyRepo _repo;

        public HomeController(IConfiguration configuration)
        {
            _repo = new PodzespolyRepo(configuration);
        }

        public IActionResult Index()
        {
            var podzespoly = _repo.GetPodzespoly();
            return View(podzespoly);
        }

        public IActionResult Procesor()
        {
            var procesory = _repo.GetProcesor();
            return View(procesory);
        }

        public IActionResult Ram()
        {
            var ramy = _repo.GetRam();
            return View(ramy);
        }

        public IActionResult Grafika()
        {
            var grafiki = _repo.GetGrafika();
            return View(grafiki);
        }
    }
}
