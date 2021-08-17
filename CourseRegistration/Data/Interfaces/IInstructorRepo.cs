﻿using CourseRegistration.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseRegistration.Data.Interfaces
{
    public interface IInstructorRepo
    {
        IEnumerable<Instructors> GetAllInstructors();
    }
}
