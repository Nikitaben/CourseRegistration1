using CourseRegistration.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseRegistration.Data.Interfaces
{
    public interface ICourseStudentsRepo
    {
        IEnumerable<CourseStudents> GetAllCourseStudents();
        CourseStudents GetCourseStudentsById(int id);
        void CreateCourseStudent(CourseStudents input);
        void UpdateCourseStudent(CourseStudents input);
        void DeleteCourseStudents(int id);
        bool SaveChanges();

        void RemoveRange(int StudentId);
        void AddRange(IEnumerable<CourseStudents> range);
    }
}
