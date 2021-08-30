using CourseRegistration.Data;
using CourseRegistration.Data.Interfaces;
using CourseRegistration.Models;
using CourseRegistration.ModelsDto;
using CourseRegistration.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseRegistration.Controllers
{
    public class CourseController : Controller
    {
        private readonly ICourseRepo _courseRepo;
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
       
        public ActionResult Create()
        {
           
            return View();
        }
        [HttpPost]
        public ActionResult Create(Course input)
        {
            _courseRepo.CreateCourse(_mapper.Map(input));
            _courseRepo.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        public ActionResult Edit(int id)
        {
            var c = _mapper.Map(_courseRepo.GetCoursesById(id));
            return View(c);
        }
        [HttpPost]
        public ActionResult Edit(CourseDto course)
        {
            _courseRepo.UpdateCourse(_mapper.Map(course));
            _courseRepo.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
       
    }

}
