using System;
using System.Collections.Generic;

namespace testCRUD.Models;

public partial class Hcdatum
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public byte Position { get; set; }

    public int UserDataId { get; set; }

    public virtual UserDatum UserData { get; set; } = null!;
}
