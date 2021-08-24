using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CourseRegistration.ModelsDto
{
    public class CourseDto
    {

        [DisplayName("Course Id")]
        [Key]
        public int CourseId { get; set; }

        [DisplayName("Course Number")]
        [Required]
        public int C_Number { get; set; }

        [DisplayName("Course Name")]
        [Required]
        public string C_Name { get; set; }

        [DisplayName("Description")]
        public string Description { get; set; }
    }
}