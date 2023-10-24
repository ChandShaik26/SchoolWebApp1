using System;
using System.Collections.Generic;

namespace WebApplication1.Entities;

public partial class EmployeeDetail
{
    public string EmpName { get; set; } = null!;

    public int EmpId { get; set; }

    public string EmpDepartment { get; set; } = null!;

    public decimal EmpSalary { get; set; }
}
