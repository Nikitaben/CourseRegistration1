using CourseRegistration.Models;
using CourseRegistration.ModelsDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseRegistration.Data
{
    public class Mapper
    {
        public Course Map(CourseDto input)
        {
            return new Course { 
                CourseId = input.CourseId,
                C_Name = input.C_Name,
                C_Number = input.C_Number,
                Description = input.Description

            };
        }
        public CourseDto Map(Course input)
        {
            return new CourseDto
            {
                CourseId = input.CourseId,
                C_Name = input.C_Name,
                C_Number = input.C_Number,
                Description = input.Description

            };
        }
        public Student Map(StudentDto input)
        {
            return new Student
            {
                StudentId = input.StudentId,
                FirstName = input.FirstName,
                LastName = input.LastName,
                EmailAddress = input.EmailAddress,
                PhoneNumber = input.PhoneNumber,
                //CourseId = input.CourseId,

            };
        }
        public StudentDto Map(Student input)
        {
            return new StudentDto
            {
                StudentId = input.StudentId,
                FirstName = input.FirstName,
                LastName = input.LastName,
                EmailAddress = input.EmailAddress,
                PhoneNumber = input.PhoneNumber,
                //CourseId = input.CourseId,
                //Courses = Map(input.Course)
            };
        }
        public Instructor Map(InstructorDto input)
        {
            return new Instructor
            {
                I_Id = input.I_Id,
                FirstName = input.FirstName,
                LastName = input.LastName,
                EmailAddress = input.EmailAddress,
                CourseId = input.CourseId,

            };
        }
        public InstructorDto Map(Instructor input)
        {
            return new InstructorDto
            {
                I_Id = input.I_Id,
                FirstName = input.FirstName,
                LastName = input.LastName,
                EmailAddress = input.EmailAddress,
                CourseId = input.CourseId,
                Course = Map(input.Course)
            };
        }


    }
}
