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
        
        private readonly static List<Student> _students = new List<Student>
        {
            new Student {StudentId = 001, FirstName = "Danial", LastName = "Para", EmailAddress = "danialpara@gmail.com", PhoneNumber = "5879207077" },
            new Student {StudentId = 002, FirstName = "Parker", LastName = "James", EmailAddress = "parkerjames@gmail.com", PhoneNumber = "7809304545"},
            new Student {StudentId = 003, FirstName = "Robin", LastName = "Smith", EmailAddress = "robinsmith@gmail.com",PhoneNumber = "6785674564"},
            new Student {StudentId = 004, FirstName = "Sura", LastName = "Tandan", EmailAddress = "suratandan@gmail.com",PhoneNumber = "2785674504"},
            new Student {StudentId = 005, FirstName = "Samuel", LastName = "Johnson", EmailAddress = "samueljohnson@gmail.com",PhoneNumber = "6785644560"},
            new Student {StudentId = 006, FirstName = "Tommy", LastName = "Lee", EmailAddress = "tommylee@gmail.com",PhoneNumber = "4785684564" }

        };
        public void CreateStudent(Student input)
        {
            _students.Add(input);
        }
        public IEnumerable<Student> GetAllStudents()
            {
                return _students;
            }

        public Student GetStudentsById(int id)
        {
            
            return _students.FirstOrDefault(s => s.StudentId == id);
        }

        public bool SaveChanges()
        {
            return true;
        }

        public void UpdateStudents(Student input)
        {
            var itemInTheList = _students.FirstOrDefault(s =>s.StudentId == input.StudentId);

            if (itemInTheList != null)
            {
                //itemInTheList.StudentId = input.StudentId;
                itemInTheList.FirstName = input.FirstName;
                itemInTheList.LastName = input.LastName;
                itemInTheList.EmailAddress = input.EmailAddress;
                itemInTheList.PhoneNumber = input.PhoneNumber;
              
            }
            }
    }
    
}
