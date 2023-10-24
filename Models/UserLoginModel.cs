

using System.ComponentModel.DataAnnotations;

namespace OnlineStudentEnrollmentSystem.Models
{
    public class UserLoginModel
    {
        [Required]
        [StringLength(100)]
        [Display(Name = "User Name")]
        public string UserName { get; set; }


        [Required]
        [StringLength(8)]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
