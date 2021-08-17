using CourseRegistration.Data.Interfaces;
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

        public CourseController(ICourseRepo courseRepo)
        {
            _courseRepo = courseRepo;
        }
        public IActionResult Index()
        {
            return View(_courseRepo.GetAllCourses());
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
    }
}
