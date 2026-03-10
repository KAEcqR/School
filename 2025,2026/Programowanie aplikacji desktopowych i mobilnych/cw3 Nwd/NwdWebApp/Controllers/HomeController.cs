using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Razor.TagHelpers;
using NwdClassLib;
using NwdWebApp.Models;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace NwdWebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View(new Nwd());
        }

        public NwdCalculator calc = new NwdCalculator();

        [HttpPost]
        public IActionResult Index(Nwd model)
        {

            if (ModelState.IsValid)
            {
                int result;

                if (model.recursive)
                {
                    result = calc.CalculateNwd(model.a, model.b);
                }
                else
                {
                    result = calc.CalculateNwdIteratively(model.a, model.b);
                }

                model.Result = result;
            }


            return View(model);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
