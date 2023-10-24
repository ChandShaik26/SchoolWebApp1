using System;
using System.Collections.Generic;

namespace WebApplication1.Entities;

public partial class NewAdmission
{
    public string? StudentFirstName { get; set; }

    public string? StudentLastName { get; set; }

    public string? FatherName { get; set; }

    public int? StudentAadharnumber { get; set; }

    public string? Qualification { get; set; }

    public decimal? Percentage { get; set; }
}
