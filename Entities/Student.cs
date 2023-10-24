using System;
using System.Collections.Generic;

namespace OnlineStudentEnrollmentSystem.Entities;

public partial class Student
{
    public int StudentId { get; set; }

    public string? Name { get; set; }

    public string? Gender { get; set; }

    public string? PhoneNo { get; set; }

    public string? EmailId { get; set; }

    public int? ClassId { get; set; }

    public string? ClassName { get; set; }

    public int? TeacherId { get; set; }

    public string? TeacherName { get; set; }

    public virtual Class? Class { get; set; }

    public virtual Teacher? Teacher { get; set; }
}
