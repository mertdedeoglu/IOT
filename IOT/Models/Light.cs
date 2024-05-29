using System;
using System.Collections.Generic;

namespace IOT.Models;

public partial class Light
{
    public int Id { get; set; }

    public string Value { get; set; } = null!;

    public DateTime CreatedDate { get; set; }
}
