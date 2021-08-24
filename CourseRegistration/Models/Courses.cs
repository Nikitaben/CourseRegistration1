using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CourseRegistration.Models
{
    public class Courses
    {
        
        [Key]
        public int CourseId { get; set; }
        
       
        public int C_Number { get; set; }

       
        public string C_Name { get; set; }

        
        public string Description { get; set; }

    }
}
