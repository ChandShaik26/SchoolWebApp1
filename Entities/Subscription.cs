using System;
using System.Collections.Generic;

namespace WebApplication1.Entities;

public partial class Subscription
{
    public DateTime? SubscriptionDate { get; set; }

    public string? Customer { get; set; }

    public string? SubsPlan { get; set; }
}
