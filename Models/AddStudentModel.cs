using Microsoft.AspNetCore.Mvc.Rendering;

namespace OnlineStudentEnrollmentSystem.Models
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
