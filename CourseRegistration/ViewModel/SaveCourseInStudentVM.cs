using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseRegistration.ViewModel
{
    public class SaveCourseInStudentVM
    {
        public List<CourseVM> Courses { get; set; }
        public int StudentId { get; set; }
    }
}
