using System.ComponentModel.DataAnnotations;

namespace Exam_ASPNETMVC.Models
{
    public class ContactViewModel
    {
        [Required]
        [MinLength(6, ErrorMessage = "vui lòng nhập tối thiểu  6 kí tự .")]
        [MaxLength(255)]
        [Display(Name = "Contact Name")]
        public string Contact_Name { get; set; }
        [Required]
        [Display(Name = "Contact Number")]
        public int Contact_Number { get; set; }
        [Required]
        [Display(Name = "Group Name")]

        public string Group_Name { get; set; }
        [Required]
        [Display(Name = "Hire Date")]
        public DateOnly Hire_Date { get; set; }

        [Required]
        [Display(Name = "Birthday")]

        public string Birthday { get; set; }

    }
}
