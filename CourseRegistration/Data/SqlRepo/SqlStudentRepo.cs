using CourseRegistration.Data.Interfaces;
using CourseRegistration.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseRegistration.Data.SqlRepo
{
    public class SqlStudentRepo : IStudentRepo
    {
        private readonly AppDbContext _context;

        public SqlStudentRepo(AppDbContext context)
        {
            _context = context;
        }
        public void CreateStudent(Student input)
        {
            if (input == null)
            throw new NotImplementedException(nameof(input));
            _context.Students.Add(input);
        }

        public IEnumerable<Student> GetAllStudents()
        {
            return _context.Students.ToList();
        }

        public Student GetStudentsById(int id)
        {
            return _context.Students.FirstOrDefault(s => s.StudentId == id);
        }

        public bool SaveChanges()
        {
            return _context.SaveChanges() >= 0;
        }

        public void UpdateStudents(Student input)
        {

            var itemInTheList = _context.Students.FirstOrDefault(s => s.StudentId == input.StudentId);

            if (itemInTheList != null)
            {

                itemInTheList.FirstName = input.FirstName;
                itemInTheList.LastName = input.LastName;
                itemInTheList.EmailAddress = input.EmailAddress;
                itemInTheList.PhoneNumber = input.PhoneNumber;
                
            }
        }
    }
}
