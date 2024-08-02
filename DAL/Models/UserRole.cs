using System;
using System.Collections.Generic;

namespace testCRUD.Models;

public partial class UserRole
{
    public int Id { get; set; }

    public string RoleName { get; set; } = null!;

    public virtual ICollection<UserDatum> UserData { get; set; } = new List<UserDatum>();
}
