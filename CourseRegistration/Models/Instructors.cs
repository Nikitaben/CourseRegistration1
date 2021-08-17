using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseRegistration.Models
{
    public class Instructors
    {

        public int I_Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public int CourseId { get; set; }
        public Courses Courses { get; set; }


    }
}
