using CourseRegistration.Data.Interfaces;
using CourseRegistration.Models;
using CourseRegistration.ModelsDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseRegistration.Data.SqlRepo
{
    public class SqlCourseRepo : ICourseRepo
    {
        private readonly AppDbContext _context;

        public SqlCourseRepo(AppDbContext context)
        {
            _context = context;
        }
        public void CreateCourse(Course input)
        {
            if (input == null)
            {

                throw new NotImplementedException(nameof(input));
            }
            _context.Courses.Add(input);
        }

        public void CreateCourse(CourseDto courseDto)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Course> GetAllCourses()
        {
            return _context.Courses.ToList();
        }

        public Course GetCoursesById(int id)
        {
            return _context.Courses.FirstOrDefault(c => c.CourseId == id);
        }

        public bool SaveChanges()
        {
            return _context.SaveChanges() >= 0;
        }

        public void UpdateCourse(Course input)
        {
            var itemInTheList = _context.Courses.FirstOrDefault(c => c.CourseId == input.CourseId);
            if (itemInTheList != null)
            {
                
                itemInTheList.C_Name = input.C_Name;
                itemInTheList.C_Number = input.C_Number;
                itemInTheList.Description = input.Description;
            }
        }
    }
}
