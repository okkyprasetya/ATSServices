using System;
using System.Collections.Generic;

namespace testCRUD.Models;

public partial class EducationalRecord
{
    public int Id { get; set; }

    public string Major { get; set; } = null!;

    public decimal Gpa { get; set; }

    public short StartYear { get; set; }

    public short EndYear { get; set; }

    public string Document { get; set; } = null!;

    public string University { get; set; } = null!;

    public string Title { get; set; } = null!;

    public virtual ICollection<ApplicantDatum> ApplicantData { get; set; } = new List<ApplicantDatum>();
}
