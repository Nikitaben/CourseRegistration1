using CourseRegistration.Data.Interfaces;
using CourseRegistration.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseRegistration.Data.MockRepo
{
    public class MockInstructorRepo :IInstructorRepo
    {

        private readonly static List<Instructors> _instructors = new List<Instructors>
        {
            new Instructors { I_Id = 101, FirstName = "Mark", LastName = "Johnson", EmailAddress = "markjohnson@gmail.com", CourseId = 1001},
            new Instructors { I_Id = 102, FirstName = "Lucy", LastName = "Smith", EmailAddress = "lucysmith@gmail.com", CourseId = 1002},
            new Instructors { I_Id = 103, FirstName = "Trecy", LastName = "Brown", EmailAddress = "trecybrown@gmail.com", CourseId = 1003},
        };
        public IEnumerable<Instructors> GetAllInstructors()
        {
            return _instructors;
        }
    }
}
