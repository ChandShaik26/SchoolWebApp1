using System;
using System.Collections.Generic;

namespace WebApplication1.Entities;

public partial class Doctor
{
    public string DocName { get; set; } = null!;

    public string? DocLicence { get; set; }

    public string? Address { get; set; }

    public bool? IsActive { get; set; }

    public string SpecialistIn { get; set; } = null!;
}
