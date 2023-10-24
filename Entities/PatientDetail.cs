using System;
using System.Collections.Generic;

namespace WebApplication1.Entities;

public partial class PatientDetail
{
    public string? PatientName { get; set; }

    public string? PatientId { get; set; }

    public string? HealthIssue { get; set; }

    public string? DocterName { get; set; }

    public DateTime? AppointmentDate { get; set; }

    public int? PatientPhoneNumber { get; set; }

    public string? PatientEmailId { get; set; }
}
