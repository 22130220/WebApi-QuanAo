﻿using System;
using System.Collections.Generic;

namespace Api_BanQuanAo.Entities;

public partial class User
{
    public int Id { get; set; }

    public string UserName { get; set; } = null!;

    public string Password { get; set; } = null!;
}
