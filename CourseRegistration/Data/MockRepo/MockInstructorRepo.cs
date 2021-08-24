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

        public void CreateInstructor(Instructors input)
        {
            int code = _instructors.Max(i => i.I_Id) + 1;
            input.I_Id = code;
            _instructors.Add(input);
        }

        public IEnumerable<Instructors> GetAllInstructors()
        {
            return _instructors;
        }

        public Instructors GetInstructorsById(int id)
        {
            return _instructors.FirstOrDefault(i => i.I_Id == id);
        }

        public bool SaveChanges()
        {
            return true;
        }

        public void UpdateInstructor(Instructors input)
        {
            var itemInTheList = _instructors.FirstOrDefault(i => i.I_Id == input.I_Id);

            if (itemInTheList != null)
            {
                itemInTheList.FirstName = input.FirstName;
                itemInTheList.LastName = input.LastName;
                itemInTheList.EmailAddress = input.EmailAddress;
                itemInTheList.CourseId = input.CourseId;
            }
        }
    }
}
