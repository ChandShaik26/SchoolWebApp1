using System;
using System.Collections.Generic;

<<<<<<< HEAD
namespace OnlineStudentEnrollmentSystem.Entities;
=======
namespace WebApplication1.Entities;
>>>>>>> 888fb61ad308486e5a4b7694bdf6bb986f215ab4

public partial class Class
{
    public int ClassId { get; set; }

    public string? ClassName { get; set; }

    public string? Standard { get; set; }

    public string? Block { get; set; }

    public virtual ICollection<Student> Students { get; set; } = new List<Student>();
}
