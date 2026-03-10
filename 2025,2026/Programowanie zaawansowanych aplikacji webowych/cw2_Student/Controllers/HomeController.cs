using System.Diagnostics;
using cw2_Student.Models;
using Microsoft.AspNetCore.Mvc;

namespace cw2_Student.Controllers
{
    public class HomeController : Controller
    {

        private readonly StudentDbContext _context;

        public HomeController(StudentDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var Students = _context.Students.ToList();
            return View(Students);
        }

        [HttpGet]
        public IActionResult AddStudent()
        {
            return View();
        }


        [HttpPost]
        public IActionResult AddStudent(Student student)
        {
            if (ModelState.IsValid)
            {
                _context.Students.Add(student);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }

        [HttpGet]
        public IActionResult DeleteStudent(int id)
        {
            var student = _context.Students.Find(id);
            if (student != null)
            {
                _context.Students.Remove(student);
                _context.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult ModifyStudent(int id)
        {
            var student = _context.Students.Find(id);
            if (student != null)
            {
                return View(student);
            }
            return RedirectToAction("Index");
        }
        [HttpPost]
        public IActionResult ModifyStudent(Student student)
        {
            if (ModelState.IsValid && student.Name != null)
            {
                _context.Students.Update(student);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(student);
        }
    }
}
