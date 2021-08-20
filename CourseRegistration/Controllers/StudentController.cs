using CourseRegistration.Data.Interfaces;
using CourseRegistration.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseRegistration.Controllers
{
    public class StudentController : Controller
    {
        private IStudentRepo _studentRepo;
        private ICourseRepo _courseRepo;

        public StudentController(IStudentRepo studentRepo, ICourseRepo courseRepo)
        {
            _courseRepo = courseRepo;
            _studentRepo = studentRepo;
            
        }
        public IActionResult Index()
        {
            var courses = _courseRepo.GetAllCourses();
            var students = _studentRepo.GetAllStudents()
                .Select(c =>
                {
                    c.Courses = courses
                        .Where(s => s.CourseId == c.CourseId)
                        .FirstOrDefault() ?? new Models.Courses
                        {
                            C_Name = "n/a"
                        };
                    return c;
                })
                
                .ToList();
            return View(students);
        }
        public IEnumerable<string> GetStudentsByStudentId(int? id)
        {
            var res = _studentRepo.GetAllStudents()
                .Where(c => c.CourseId == id)
                .Select(c => $"{c.LastName} {c.FirstName}<br>");
            if (res == null || res.Count() == 0)
            {
                return new List<string> { "No Student found" };
            }
            return res;
        }
        public ActionResult Create()
        {
            ViewBag.Courses =
                new SelectList(_courseRepo.GetAllCourses().ToList(),
                "Course Id", "Course Name");
            return View();
        }
        [HttpPost]
        public ActionResult Create(Students student)
        {
            _studentRepo.CreateStudent(student);
            return RedirectToAction(nameof(Index));
        }
    }
}
