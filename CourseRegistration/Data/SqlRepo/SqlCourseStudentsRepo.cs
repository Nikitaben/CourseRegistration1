using CourseRegistration.Data.Interfaces;
using CourseRegistration.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseRegistration.Data.SqlRepo
{
    public class SqlCourseStudentsRepo : ICourseStudentsRepo
    {
        private readonly AppDbContext _context;

        public SqlCourseStudentsRepo(AppDbContext context)
        {
            _context = context;
        }

      

        public void CreateCourseStudent(CourseStudents input)
        {
            throw new NotImplementedException();
        }

        public void DeleteCourseStudents(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<CourseStudents> GetAllCourseStudents()
        {
            return _context.CourseStudents.ToList();
        }

        public CourseStudents GetCourseStudentsById(int id)
        {
            throw new NotImplementedException();
        }

      
        public bool SaveChanges()
        {
            return _context.SaveChanges() >= 0;
        }

        public void UpdateCourseStudent(CourseStudents input)
        {
            throw new NotImplementedException();
        }
        public void AddRange(IEnumerable<CourseStudents> range)
        {
            _context.AddRange(range);
        }

        public void RemoveRange(int StudentId)
        {
            var rangeToRemove = _context.CourseStudents
                 .Where(cs => cs.StudentId == StudentId);
            _context.RemoveRange(rangeToRemove);
        }

    }
}
