using System;
using System.Collections.Generic;

namespace testCRUD.Models;

public partial class AchievementRecord
{
    public int Id { get; set; }

    public string Title { get; set; } = null!;

    public string Description { get; set; } = null!;

    public DateTime Period { get; set; }

    public string Document { get; set; } = null!;

    public virtual ICollection<ApplicantDatum> ApplicantData { get; set; } = new List<ApplicantDatum>();
}
