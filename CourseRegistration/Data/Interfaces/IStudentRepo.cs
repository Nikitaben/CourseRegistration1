using CourseRegistration.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseRegistration.Data.Interfaces
{
    public interface IStudentRepo
    {
        IEnumerable<Students> GetAllStudents();
        void CreateStudent(Students input);
    }
}
