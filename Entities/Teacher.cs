using System;
using System.Collections.Generic;

<<<<<<< HEAD
namespace OnlineStudentEnrollmentSystem.Entities;
=======
namespace WebApplication1.Entities;
>>>>>>> 888fb61ad308486e5a4b7694bdf6bb986f215ab4

public partial class Teacher
{
    public int TeacherId { get; set; }

    public string? Name { get; set; }

    public string? Gender { get; set; }

    public string? Qualification { get; set; }

    public string? EmailId { get; set; }

    public string? PhoneNo { get; set; }
<<<<<<< HEAD

    public virtual ICollection<Student> Students { get; set; } = new List<Student>();
=======
>>>>>>> 888fb61ad308486e5a4b7694bdf6bb986f215ab4
}
