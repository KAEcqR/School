using cw7.Models;
using Microsoft.AspNetCore.Mvc;

namespace cw7.Controllers
{
    public class SchoolController : Controller
    {
        private SchoolContext _context;
        public SchoolController(SchoolContext context)
        {
            _context = context;
        }
        // GET: SchoolController
        public ActionResult Index()
        {
            var students = _context.Students.ToList();
            return View(students);
        }
        //wyswietlenie formularza dodawania studenta
        [HttpGet]
        public IActionResult AddStudent()
        {
            return View();
        }

        //dodanie studenta do bazy danych
        [HttpPost]
        public IActionResult AddStudent(Student student)
        {
            if (ModelState.IsValid)
            {
                //ustawia entity jako dodana
                //dodaje do kontekstu
                _context.Students.Add(student);
                //zapisuje zmiany w bazie danych
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }
        public IActionResult DeleteStudent(int id)
        {
            var student = _context.Students.FirstOrDefault(s => s.Id == id);
            if (student != null)
            {
                _context.Students.Remove(student);
                _context.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        // Wyświetlenie formularza edycji
        [HttpGet]
        public IActionResult EditStudent(int id)
        {
            var student = _context.Students.FirstOrDefault(s => s.Id == id);
            if (student == null)
            {
                return NotFound();
            }
            return View(student);
        }

        // Obsługa zapisu zmian
        [HttpPost]
        public IActionResult EditStudent(Student updatedStudent)
        {
            if (ModelState.IsValid)
            {
                var student = _context.Students.FirstOrDefault(s => s.Id == updatedStudent.Id);
                if (student != null)
                {
                    student.Firstname = updatedStudent.Firstname;
                    student.Lastname = updatedStudent.Lastname;
                    student.IndexNumber = updatedStudent.IndexNumber;
                    student.Birthdate = updatedStudent.Birthdate;

                    _context.SaveChanges();
                    return RedirectToAction("Index");
                }
            }
            return View(updatedStudent);
        }

    }
}