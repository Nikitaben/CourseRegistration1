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
        [DisplayName("S_Id")]
        public int StudentId { get; set; }

        [DisplayName("First Name")]
        [Required]
        public string FirstName { get; set; }

        [DisplayName("Last Name")]
        [Required]
        public string LastName { get; set; }

        [DisplayName("Email Address")]
        [EmailAddress]
        public string EmailAddress { get; set; }

        [DisplayName("Phone#")]
        [Required]
        [Phone]
        public string PhoneNumber { get; set; }

        //[DisplayName("Courses")]
        //[ForeignKey("Courses")]
        //public int? CourseId { get; set; }
        //public CourseDto Courses { get; set; }
    }
}
