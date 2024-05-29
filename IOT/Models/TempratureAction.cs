using System;
using System.Collections.Generic;

namespace IOT.Models;

public partial class TempratureAction
{
    public int Id { get; set; }

    public string Effect { get; set; } = null!;

    public string Action { get; set; } = null!;

    public DateTime CreatedDate { get; set; }
}
