using System;
using System.Collections.Generic;

namespace WebApplication1.Entities;

public partial class SubscriptionDatum
{
    public DateTime? SubscriptionDate { get; set; }

    public string? CustomerName { get; set; }

    public string? SubscribedPlan { get; set; }

    public string? Email { get; set; }

    public string? Gender { get; set; }

    public string? MobileNumber { get; set; }

    public string? CustomerId { get; set; }
}
