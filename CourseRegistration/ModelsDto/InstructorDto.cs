using CourseRegistration.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CourseRegistration.ModelsDto
{
    public class InstructorDto
    {

        [DisplayName("Ins_Id")]
       
        public int I_Id { get; set; }

        [DisplayName("F_Id")]
        [Required]
        public string FirstName { get; set; }

        [DisplayName("L_Id")]
        [Required]
        public string LastName { get; set; }
        [DisplayName("E_Address")]
        public string EmailAddress { get; set; }
        [DisplayName("Courses")]
        
        public int CourseId { get; set; }
        public CourseDto Course { get; set; }
    }
}
