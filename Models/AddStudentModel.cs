using Microsoft.AspNetCore.Mvc.Rendering;

<<<<<<< HEAD
namespace OnlineStudentEnrollmentSystem.Models
=======
namespace WebApplication1.Models
>>>>>>> 888fb61ad308486e5a4b7694bdf6bb986f215ab4
{
    public class AddStudentModel
    {

        public int StudentId { get; set; }

        public string Name {  get; set; }

        public string Gender { get; set; }

        public string PhoneNo { get; set; }

        public string EmailId { get; set; }

        public int? ClassId { get; set; }

        public string ClassName { get; set; }

        public IList<SelectListItem> ClassList { get; set; }

    }
}
