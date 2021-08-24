﻿using CourseRegistration.Data.Interfaces;
using CourseRegistration.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseRegistration.Data.MockRepo
{
    public class MockCourseRepo :ICourseRepo
    {
        private readonly static List<Courses> _courses = new List<Courses>
        {
            new Courses {CourseId = 1001, C_Number = 1, C_Name = "Math", Description = "Geometry"},
            new Courses {CourseId = 1002, C_Number = 2, C_Name = "Science", Description = "Biology"},
            new Courses {CourseId = 1003, C_Number = 3, C_Name = "Computer Science", Description = "Web Development"},

        };

        public void CreateCourse(Courses input)
        {
            int id = _courses.Max(c => c.CourseId) + 1;
            input.CourseId = id;
            _courses.Add(input);
        }

        public IEnumerable<Courses> GetAllCourses()
        {
            return _courses;
        }

        public Courses GetCoursesById(int id)
        {
            return _courses.FirstOrDefault(c => c.CourseId == id);
        }

        public bool SaveChanges()
        {
            return true;
        }

        public void UpdateCourse(Courses input)
        {
            var itemInTheList = _courses.FirstOrDefault(c => c.CourseId == input.CourseId);
            if (itemInTheList != null)
            {
                itemInTheList.CourseId = input.CourseId;
                itemInTheList.C_Name = input.C_Name;
                itemInTheList.C_Number = input.C_Number;
                itemInTheList.Description = input.Description;
            }
        }
    }
}
