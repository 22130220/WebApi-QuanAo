using System;
using System.Collections.Generic;

namespace Api_BanQuanAo.Entities;

public partial class Customer
{
    public int Id { get; set; }

    public string Email { get; set; } = null!;

    public string Password { get; set; } = null!;
}
