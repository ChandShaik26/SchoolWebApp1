using System;
using System.Collections.Generic;

namespace WebApplication1.Entities;

public partial class Player
{
    public int? PlayerId { get; set; }

    public string? PlayerName { get; set; }

    public string? Country { get; set; }

    public int? Centuries { get; set; }

    public bool? IsActive { get; set; }

    public decimal? Salary { get; set; }

    public DateTime? Bod { get; set; }
}
