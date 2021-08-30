using CourseRegistration.Models;
using CourseRegistration.ModelsDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseRegistration.Data.Interfaces
{
    public interface ICourseRepo
    {
        IEnumerable<Course> GetAllCourses();
        Course GetCoursesById(int id);
        void CreateCourse(Course input);
        void UpdateCourse(Course input);
        bool SaveChanges();
        void CreateCourse(CourseDto courseDto);
    }
}
