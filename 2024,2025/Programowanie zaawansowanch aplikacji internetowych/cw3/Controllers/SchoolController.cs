using cw3.Models;
using Microsoft.AspNetCore.Mvc;

namespace cw3.Controllers
{
    public class SchoolController : Controller
    {
        private readonly StudentsRepo _repo;
        public SchoolController(IConfiguration configuration){
            _repo = new StudentsRepo(configuration);
        }


        // GET: SchoolController
        public ActionResult Index()
        {
            return View();
        }

        public IActionResult GroupsList(){
            var groups = _repo.GetGroups();
            return View(groups);
        }

        public IActionResult StudentsList()
        {
            var students = _repo.GetStudents();
            return View(students);
        }

        public IActionResult AddStudent()
        {
            return View();
        }
    }
}
