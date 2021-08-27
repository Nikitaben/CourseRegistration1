using CourseRegistration.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseRegistration.Data.Interfaces
{
    public interface IStudentRepo
    {
        IEnumerable<Student> GetAllStudents();
        void CreateStudent(Student input);
        Student GetStudentsById(int id);
        void UpdateStudents(Student input);
        bool SaveChanges();
    }
}
