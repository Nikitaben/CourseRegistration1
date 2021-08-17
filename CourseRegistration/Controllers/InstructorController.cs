using CourseRegistration.Data.Interfaces;
using CourseRegistration.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseRegistration.Controllers
{
    public class InstructorController : Controller
    {
        private IInstructorRepo _instructorRepo;
        private readonly ICourseRepo _courseRepo;

        public InstructorController(IInstructorRepo instructorRepo, ICourseRepo courseRepo)
        {
            _instructorRepo = instructorRepo;
            _courseRepo = courseRepo;
        }
        public IActionResult Index()
        {
            var courses = _courseRepo.GetAllCourses();
            var instructors = _instructorRepo.GetAllInstructors()
                .Select(c =>
                {
                    c.Courses = courses
                    .Where(i => i.CourseId == c.CourseId)
                    .FirstOrDefault() ?? new Courses
                    {
                        C_Name = "n/a"
                    };
                    return c;
                    
                    
                })
                
                .ToList();
            return View(instructors);
        }
    }
}
