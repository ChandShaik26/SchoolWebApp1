using System;
using System.Collections.Generic;

namespace OnlineStudentEnrollmentSystem.Entities;

public partial class Class
{
    public int ClassId { get; set; }

    public string? ClassName { get; set; }

    public string? Standard { get; set; }

    public string? Block { get; set; }

    public virtual ICollection<Student> Students { get; set; } = new List<Student>();
}
