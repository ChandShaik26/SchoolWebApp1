

using System.ComponentModel.DataAnnotations;

<<<<<<< HEAD
namespace OnlineStudentEnrollmentSystem.Models
=======
namespace SchoolWebApplication.Models
>>>>>>> 888fb61ad308486e5a4b7694bdf6bb986f215ab4
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
