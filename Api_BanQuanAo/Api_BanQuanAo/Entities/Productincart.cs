﻿using System;
using System.Collections.Generic;

namespace Api_BanQuanAo.Entities;

public partial class Productincart
{
    public string UserId { get; set; } = null!;

    public int ProductId { get; set; }

    public int Quantity { get; set; }

    public virtual Product Product { get; set; } = null!;

    public virtual Aspnetuser User { get; set; } = null!;
}
