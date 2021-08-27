using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CourseRegistration.ModelsDto
{
    public class StudentDto
    {
        
        [Key]
        public int StudentId { get; set; }

        
        public string FirstName { get; set; }

        
        public string LastName { get; set; }

        
        public string EmailAddress { get; set; }

        
        public string PhoneNumber { get; set; }

        [DisplayName("Courses")]
        [ForeignKey("Courses")]
        public int? CourseId { get; set; }
        public CourseDto Courses { get; set; }
    }
}
