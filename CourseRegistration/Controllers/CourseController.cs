using CourseRegistration.Data;
using CourseRegistration.Data.Interfaces;
using CourseRegistration.Models;
using CourseRegistration.ModelsDto;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseRegistration.Controllers
{
    public class CourseController : Controller
    {
        private ICourseRepo _courseRepo;
        private readonly Mapper _mapper = new Mapper();
        public CourseController(ICourseRepo courseRepo)
        {
            _courseRepo = courseRepo;
        }
        public IActionResult Index()
        {
            var list = _courseRepo.GetAllCourses()
                .Select(c => _mapper.Map(c))
                .ToList();
            return View(list);
        }
        public IEnumerable<string> GetStudentsByStudentId(int? id)
        {
            var res = _courseRepo.GetAllCourses()
                .Where(c => c.CourseId == id)
                .Select(c => c.C_Name + "\n");
            if(res == null || res.Count() == 0)
            {
                return new List <string> { "No Student found" };
            }
            return res;
        }

        public ActionResult Create()
        {
           
            return View();
        }
        [HttpPost]
        public ActionResult Create(Courses input)
        {
            _courseRepo.CreateCourse(input);
            _courseRepo.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        public ActionResult Edit(int id)
        {
            var c = _mapper.Map(_courseRepo.GetCoursesById(id));
            return View(c);
        }
        [HttpPost]
        public ActionResult Edit(CourseDto courses)
        {
            _courseRepo.UpdateCourse(_mapper.Map(courses));
            _courseRepo.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
    }

}
