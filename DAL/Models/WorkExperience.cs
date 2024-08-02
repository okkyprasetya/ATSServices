using System;
using System.Collections.Generic;

namespace testCRUD.Models;

public partial class WorkExperience
{
    public int Id { get; set; }

    public string CompanyName { get; set; } = null!;

    public string Position { get; set; } = null!;

    public string Description { get; set; } = null!;

    public short StartYear { get; set; }

    public short EndYear { get; set; }

    public virtual ICollection<ApplicantDatum> ApplicantData { get; set; } = new List<ApplicantDatum>();
}
