using cw2.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace cw2.Controllers
{
    public class HomeController : Controller
    {

        private readonly GameRepo _repo;
        public HomeController(IConfiguration configuration){
            _repo = new GameRepo(configuration);
        }
        public ActionResult Index()
        {
            var Games = _repo.GetGames();
            return View(Games);
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

        [HttpGet]
        public IActionResult AddGame(){
            return View();
        }
        
        [HttpPost]
        public IActionResult AddGame(Game game){
            _repo.AddGame(game);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult RemoveGame(int id){
            _repo.RemoveGame(id);
            return RedirectToAction("Index");
        }
    }
}
