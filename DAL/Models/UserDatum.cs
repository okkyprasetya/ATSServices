using System;
using System.Collections.Generic;

namespace testCRUD.Models;

public partial class UserDatum
{
    public int Id { get; set; }

    public string Email { get; set; } = null!;

    public string Password { get; set; } = null!;

    public int ResetPassQuestionId { get; set; }

    public string ResetPassAnswer { get; set; } = null!;

    public int RoleId { get; set; }

    public virtual ICollection<ApplicantDatum> ApplicantData { get; set; } = new List<ApplicantDatum>();

    public virtual ResetPassQuestion ResetPassQuestion { get; set; } = null!;

    public virtual UserRole Role { get; set; } = null!;
}
