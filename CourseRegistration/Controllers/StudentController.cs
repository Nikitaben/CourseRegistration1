using CourseRegistration.Data;
using CourseRegistration.Data.Interfaces;
using CourseRegistration.Models;
using CourseRegistration.ModelsDto;
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
        private readonly Mapper _mapper = new Mapper();

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
                .Select(s => _mapper.Map(s))
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
            var list = _courseRepo.GetAllCourses()
                .Select(s => _mapper.Map(s))
                .ToList();
            ViewBag.Courses =
                new SelectList(list, "CourseId", "C_Name");
            return View();
        }
        [HttpPost]
        public ActionResult Create(StudentDto input)
        {
            _studentRepo.CreateStudent(_mapper.Map(input));
            _studentRepo.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
        public ActionResult Edit(int id)
        {
            var list = _courseRepo.GetAllCourses()
                .Select(s => _mapper.Map(s))
                .ToList();
                        ViewBag.Courses =
                new SelectList(list,
               "CourseId", "C_Name");
            var s = _mapper.Map(_studentRepo.GetStudentsById(id));
            return View(s);
        }
        [HttpPost]
       
        public ActionResult Edit(StudentDto student)
        {
            _studentRepo.UpdateStudents(_mapper.Map(student));
            _studentRepo.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
    }
}
