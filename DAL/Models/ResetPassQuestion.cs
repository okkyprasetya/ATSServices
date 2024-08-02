using System;
using System.Collections.Generic;

namespace testCRUD.Models;

public partial class ResetPassQuestion
{
    public int Id { get; set; }

    public string Question { get; set; } = null!;

    public virtual ICollection<UserDatum> UserData { get; set; } = new List<UserDatum>();
}
