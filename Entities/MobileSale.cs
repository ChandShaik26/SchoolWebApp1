using System;
using System.Collections.Generic;

namespace WebApplication1.Entities;

public partial class MobileSale
{
    public string? MobileBrand { get; set; }

    public string? Model { get; set; }

    public string? Specifications { get; set; }

    public decimal? Price { get; set; }

    public DateTime? SoldDate { get; set; }

    public int? NumberofPurchases { get; set; }
}
