using System;
using System.Collections.Generic;

namespace Api_BanQuanAo.Entities;

public partial class Orderdetail
{
    public string CartItemId { get; set; } = null!;

    public string? CartId { get; set; }

    public string? ProductId { get; set; }

    public int Quantity { get; set; }

    public decimal Price { get; set; }
}
