using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class PasswordModel
    {

      

        [Required]
        [EmailAddress]
        [Display(Name = "Email-Id")]
        public string EmailId {  get; set; }
    }
}
