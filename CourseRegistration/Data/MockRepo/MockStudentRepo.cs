using CourseRegistration.Data.Interfaces;
using CourseRegistration.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseRegistration.Data.MockRepo
{
    public class MockStudentRepo : IStudentRepo
    {
        
        private readonly static List<Students> _students = new List<Students>
        {
            new Students {StudentId = 001, FirstName = "Danial", LastName = "Para", EmailAddress = "danialpara@gmail.com", PhoneNumber = "5879207077", CourseId = 1001 },
            new Students {StudentId = 002, FirstName = "Parker", LastName = "James", EmailAddress = "parkerjames@gmail.com", PhoneNumber = "7809304545", CourseId = 1002},
            new Students {StudentId = 003, FirstName = "Robin", LastName = "Smith", EmailAddress = "robinsmith@gmail.com",PhoneNumber = "6785674564", CourseId = 1003},
            new Students {StudentId = 004, FirstName = "Sura", LastName = "Tandan", EmailAddress = "suratandan@gmail.com",PhoneNumber = "2785674504", CourseId = 1003},
            new Students {StudentId = 005, FirstName = "Samuel", LastName = "Johnson", EmailAddress = "samueljohnson@gmail.com",PhoneNumber = "6785644560", CourseId = 1001},
            new Students {StudentId = 006, FirstName = "Tommy", LastName = "Lee", EmailAddress = "tommylee@gmail.com",PhoneNumber = "4785684564", CourseId = 1002},

        };
            public IEnumerable<Students> GetAllStudents()
            {
                return _students;
            }
    }
    
}
