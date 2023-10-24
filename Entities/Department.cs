using System;
using System.Collections.Generic;

namespace WebApplication1.Entities;

public partial class Department
{
    public int DepartmentId { get; set; }

    public string? DepartmentName { get; set; }

    public string? DepartmentHead { get; set; }

    public string? Budget { get; set; }

    public int? EmployeeCount { get; set; }
}
