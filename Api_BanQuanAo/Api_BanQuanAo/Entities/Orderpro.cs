using System;
using System.Collections.Generic;

namespace Api_BanQuanAo.Entities;

public partial class Orderpro
{
    public string CartId { get; set; } = null!;

    public string? UserId { get; set; }

    public decimal? TotalPrice { get; set; }

    public DateOnly? DateCreated { get; set; }

    public string Name { get; set; } = null!;

    public string Address { get; set; } = null!;

    public string Methodpayment { get; set; } = null!;
}
