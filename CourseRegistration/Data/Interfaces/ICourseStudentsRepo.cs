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
        void CreateCourseStudents(CourseStudents input);
        void UpdateCourseStudents(ICourseStudentsRepo input);
        bool SaveChanges();
    }
}
