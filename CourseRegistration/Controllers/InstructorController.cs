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
    public class InstructorController : Controller
    {
        private IInstructorRepo _instructorRepo;
        private ICourseRepo _courseRepo;
        private readonly Mapper _mapper = new Mapper();

        public InstructorController(IInstructorRepo instructorRepo, ICourseRepo courseRepo)
        {
            _instructorRepo = instructorRepo;
            _courseRepo = courseRepo;
        }
        public IActionResult Index()
        {
            var course = _courseRepo.GetAllCourses();
            var instructors = _instructorRepo.GetAllInstructors()
                .Select(c =>
                {
                    c.Course = course
                    .Where(i => i.CourseId == c.CourseId)
                    .FirstOrDefault() ?? new Course
                    {
                        C_Name = "n/a"
                    };
                    return c;
                    
                    
                })
                .Select(i => _mapper.Map(i))
                .ToList();
            return View(instructors);
        }
        public ActionResult Create(int id)
        {
            var list = _courseRepo.GetAllCourses()
                .Select(i => _mapper.Map(i))
                .ToList();
            ViewBag.Course = new SelectList(list, nameof(CourseDto.CourseId),nameof(CourseDto.C_Name));
                var i = _instructorRepo.GetInstructorsById(id);
            return View();
        }
        [HttpPost]
        public ActionResult Create(InstructorDto input)
        {
            _instructorRepo.CreateInstructor(_mapper.Map(input));
            _instructorRepo.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
        public ActionResult Edit(int id)
        {
            var list = _courseRepo.GetAllCourses()
              .Select(i => _mapper.Map(i))
              .ToList();
            ViewBag.Courses = new SelectList(list, nameof(CourseDto.CourseId), nameof(CourseDto.C_Name));
            var i = _instructorRepo.GetInstructorsById(id);
            return View(i);
        }
        [HttpPost]
        public ActionResult Edit(InstructorDto instructors)
        {
            _instructorRepo.UpdateInstructor(_mapper.Map(instructors));
            _instructorRepo.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
    }
}
