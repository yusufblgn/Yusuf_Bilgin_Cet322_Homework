using Microsoft.AspNetCore.Mvc;
using System.Linq;
using WebAppCoreMVCCodeFirst._24._03._2023_22.Models;

namespace WebAppCoreMVCCodeFirst._24._03._2023_22.Controllers
{
    public class StudentController : Controller
    {
        Context c = new Context();

        public IActionResult Index()
        {
            var values = c.Students.ToList();
            return View(values);
        }

        [HttpGet]
        public IActionResult newStudent()
        {
            return View();
        }

        [HttpPost]
        public IActionResult newStudent(Student s)
        {
            c.Students.Add(s);
            c.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult removeStudent(int id)
        {
            var student = c.Students.Find(id);
            if (student == null)
            {
                return RedirectToAction("Index");
            }
            else
            {
                c.Students.Remove(student);
                c.SaveChanges();
                return RedirectToAction("Index");
            }
        }

        public IActionResult updateStudent(int id)
        {
            var student = c.Students.Find(id);
            return View("updateStudent", student);
        }

        public IActionResult updateSaveStudent(Student s)
        {
            var student = c.Students.Find(s.StudentdsID);

            if (student != null)
            {
                student.StudentdsName = s.StudentdsName;
                student.StudentdsSurname = s.StudentdsSurname;
                student.StudentdsNo = s.StudentdsNo;
                student.EMail = s.EMail;

                c.SaveChanges();
            }

            return RedirectToAction("Index");
        }
    }
}