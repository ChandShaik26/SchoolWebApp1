using System;
using System.Collections.Generic;

<<<<<<< HEAD
namespace OnlineStudentEnrollmentSystem.Entities;
=======
namespace WebApplication1.Entities;
>>>>>>> 888fb61ad308486e5a4b7694bdf6bb986f215ab4

public partial class Student
{
    public int StudentId { get; set; }

    public string? Name { get; set; }

    public string? Gender { get; set; }

    public string? PhoneNo { get; set; }

    public string? EmailId { get; set; }

    public int? ClassId { get; set; }

    public string? ClassName { get; set; }

<<<<<<< HEAD
    public int? TeacherId { get; set; }

    public string? TeacherName { get; set; }

    public virtual Class? Class { get; set; }

    public virtual Teacher? Teacher { get; set; }
=======
    public virtual Class? Class { get; set; }
>>>>>>> 888fb61ad308486e5a4b7694bdf6bb986f215ab4
}
