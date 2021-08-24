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
        public Courses Map(CourseDto input)
        {
            return new Courses { 
                CourseId = input.CourseId,
                C_Name = input.C_Name,
                C_Number = input.C_Number,
                Description = input.Description

            };
        }
        public CourseDto Map(Courses input)
        {
            return new CourseDto
            {
                CourseId = input.CourseId,
                C_Name = input.C_Name,
                C_Number = input.C_Number,
                Description = input.Description

            };
        }
        public Students Map(StudentDto input)
        {
            return new Students
            {
                StudentId = input.StudentId,
                FirstName = input.FirstName,
                LastName = input.LastName,
                EmailAddress = input.EmailAddress,
                PhoneNumber = input.PhoneNumber,
                CourseId = input.CourseId,

            };
        }
        public StudentDto Map(Students input)
        {
            return new StudentDto
            {
                StudentId = input.StudentId,
                FirstName = input.FirstName,
                LastName = input.LastName,
                EmailAddress = input.EmailAddress,
                PhoneNumber = input.PhoneNumber,
                CourseId = input.CourseId,
                Courses = Map(input.Courses)
            };
        }
        public Instructors Map(InstructorDto input)
        {
            return new Instructors
            {
                I_Id = input.I_Id,
                FirstName = input.FirstName,
                LastName = input.LastName,
                EmailAddress = input.EmailAddress,
                CourseId = input.CourseId,

            };
        }
        public InstructorDto Map(Instructors input)
        {
            return new InstructorDto
            {
                I_Id = input.I_Id,
                FirstName = input.FirstName,
                LastName = input.LastName,
                EmailAddress = input.EmailAddress,
                CourseId = input.CourseId,
                Course = Map(input.Courses)
            };
        }


    }
}
