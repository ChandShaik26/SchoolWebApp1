using System;
using System.Collections.Generic;

namespace WebApplication1.Entities;

public partial class Teacher
{
    public int TeacherId { get; set; }

    public string? Name { get; set; }

    public string? Gender { get; set; }

    public string? Qualification { get; set; }

    public string? EmailId { get; set; }

    public string? PhoneNo { get; set; }
}
