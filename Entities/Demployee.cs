using System;
using System.Collections.Generic;

namespace WebApplication1.Entities;

public partial class Demployee
{
    public int? EmployeeId { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public int? Age { get; set; }

    public string? Email { get; set; }

    public string? JobTitle { get; set; }

    public DateTime? HireDate { get; set; }

    public decimal? Salary { get; set; }

    public int? DepartmentId { get; set; }
}
