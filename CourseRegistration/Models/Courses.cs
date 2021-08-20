using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace CourseRegistration.Models
{
    public class Courses
    {
        [DisplayName("Course Id")]
        public int CourseId { get; set; }
        
        [DisplayName("Course Number")]
        public int C_Number { get; set; }

        [DisplayName("Course Name")]
        public string C_Name { get; set; }

        [DisplayName("Description")]
        public string Description { get; set; }

    }
}
