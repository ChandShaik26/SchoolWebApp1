using System;
using System.Collections.Generic;

namespace WebApplication1.Entities;

public partial class StudentsMark
{
    public string? Name { get; set; }

    public string? Rollnumber { get; set; }

    public string? Subject { get; set; }

    public int? Marks { get; set; }

    public bool? IsActive { get; set; }
}
