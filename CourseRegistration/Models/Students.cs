using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace CourseRegistration.Models
{
    public class Students
    {
        [DisplayName("S_Id")]
        public int StudentId { get; set; }

        [DisplayName("F_Name")]
        public string FirstName { get; set; }

        [DisplayName("L_Name")]
        public string LastName { get; set; }

        [DisplayName("E_Address")]
        public string EmailAddress { get; set; }

        [DisplayName("Phone #")]
        public string PhoneNumber { get; set; }

        [DisplayName("Courses")]
        public int? CourseId { get; set; }
        public Courses Courses { get; set; }
    }
}
