using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CourseRegistration.Models
{
    public class Instructor
    {
       
        [Key]
        public int I_Id { get; set; }
     
        public string FirstName { get; set; }
       
        public string LastName { get; set; }
     
        public string EmailAddress { get; set; }
     
        [ForeignKey("Course")]
        public int CourseId { get; set; }
        public Course Course { get; set; }


    }
}
