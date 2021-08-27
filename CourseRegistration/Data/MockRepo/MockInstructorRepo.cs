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

        private readonly static List<Instructor> _instructors = new List<Instructor>
        {
            new Instructor { I_Id = 101, FirstName = "Mark", LastName = "Johnson", EmailAddress = "markjohnson@gmail.com", CourseId = 1001},
            new Instructor { I_Id = 102, FirstName = "Lucy", LastName = "Smith", EmailAddress = "lucysmith@gmail.com", CourseId = 1002},
            new Instructor { I_Id = 103, FirstName = "Trecy", LastName = "Brown", EmailAddress = "trecybrown@gmail.com", CourseId = 1003},
        };

        public void CreateInstructor(Instructor input)
        {
            int code = _instructors.Max(i => i.I_Id) + 1;
            input.I_Id = code;
            _instructors.Add(input);
        }

        public IEnumerable<Instructor> GetAllInstructors()
        {
            return _instructors;
        }

        public Instructor GetInstructorsById(int id)
        {
            return _instructors.FirstOrDefault(i => i.I_Id == id);
        }

        public bool SaveChanges()
        {
            return true;
        }

        public void UpdateInstructor(Instructor input)
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
