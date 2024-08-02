using System;
using System.Collections.Generic;

namespace testCRUD.Models;

public partial class HumanCapital
{
    public string Id { get; set; } = null!;

    public byte Position { get; set; }

    public string Name { get; set; } = null!;
}
