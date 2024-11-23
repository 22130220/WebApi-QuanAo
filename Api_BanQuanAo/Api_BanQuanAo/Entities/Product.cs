using System;
using System.Collections.Generic;

namespace Api_BanQuanAo.Entities;

public partial class Product
{
    public int Id { get; set; }

    public string Title { get; set; } = null!;

    public string Category { get; set; } = null!;

    public string Brand { get; set; } = null!;

    public string Description { get; set; } = null!;

    public int Price { get; set; }

    public int Stock { get; set; }

    public string Images { get; set; } = null!;

    public int DiscountedPercentage { get; set; }

    public decimal Rating { get; set; }

    public virtual ICollection<Productincart> Productincarts { get; set; } = new List<Productincart>();
}
