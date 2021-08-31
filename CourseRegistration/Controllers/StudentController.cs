using CourseRegistration.Data;
using CourseRegistration.Data.Interfaces;
using CourseRegistration.Models;
using CourseRegistration.ModelsDto;
using CourseRegistration.ViewModel;
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
        private readonly IStudentRepo _studentRepo;
        private readonly ICourseRepo _courseRepo;
        private readonly Mapper _mapper = new Mapper();
        private readonly ICourseStudentsRepo _courseStudentRepo;

        public StudentController(IStudentRepo studentRepo, ICourseRepo courseRepo, ICourseStudentsRepo courseStudentsRepo)
        {
            _courseRepo = courseRepo;
            _studentRepo = studentRepo;
            _courseStudentRepo = courseStudentsRepo;
            
        }
        public IActionResult Index()
        {
            var course = _courseRepo.GetAllCourses();
            var students = _studentRepo.GetAllStudents()
                //.Select(c =>
                //{
                //    c.Course = course
                //        .Where(s => s.CourseId == c.CourseId)
                //        .FirstOrDefault() ?? new Models.Course
                //        {
                //            C_Name = "n/a"
                //        };
                //    return c;
                //})
                .Select(s => _mapper.Map(s))
                .ToList();
            return View(students);
        }
        public IEnumerable<string> GetStudentsByStudentId(int? id)
        {
            var res = _studentRepo.GetAllStudents()
               //.Where(c => c.CourseId == id)
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
                new SelectList(list, nameof(CourseDto.CourseId), nameof(CourseDto.C_Name));
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
               nameof(CourseDto.CourseId), nameof(CourseDto.C_Name));
            var s = _mapper.Map(_studentRepo.GetStudentsById(id));
            return View(s);
        }
        [HttpPost]
       
        public ActionResult Edit(StudentDto student)
        {
            _studentRepo.UpdateStudents(_mapper.Map(student));
            _studentRepo.SaveChanges();
            return View(student);
        }
        public ActionResult GetCourseStudentById(int id)
        {
            var list = _courseStudentRepo.GetAllCourseStudents();
            var courses = _courseRepo.GetAllCourses()
                .Select(c => new CourseVM
                {
                    Id = c.CourseId,
                    Name = c.C_Name,
                    Description = c.Description,
                    IsActive = list
                    .Where(cs => cs.CourseId == c.CourseId && cs.StudentId == id)
                    .FirstOrDefault() == null ? false : true
                    
                }
                )
                .ToList();
            SaveCourseInStudentVM scs = new SaveCourseInStudentVM
            {
                Courses = courses,
                StudentId = id
            };
                return PartialView(scs);
        }
        public ActionResult SaveCourse(SaveCourseInStudentVM obj)
        {
            _courseStudentRepo.RemoveRange(obj.StudentId);
            var toAdd = obj.Courses
                .Where(c => c.IsActive)
                .Select(sc => new CourseStudents
                {
                    StudentId = obj.StudentId,
                    CourseId = sc.Id
                });

            _courseStudentRepo.AddRange(toAdd);
            _courseStudentRepo.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}
