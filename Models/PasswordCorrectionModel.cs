using System.ComponentModel.DataAnnotations;
namespace WebApplication1.Models
{
    public class PasswordCorrectionModel
    {
        [Required]
        [EmailAddress]
        public string EmailId { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        


    }
}
