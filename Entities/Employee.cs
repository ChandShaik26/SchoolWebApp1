using System;
using System.Collections.Generic;

namespace WebApplication1.Entities;

public partial class Employee
{
    public string? EmployeeName { get; set; }

    public string? EmployeeId { get; set; }

    public string? Address { get; set; }

    public decimal? Salary { get; set; }

    public DateTime? Login { get; set; }
}
