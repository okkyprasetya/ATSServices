using System;
using System.Collections.Generic;

namespace testCRUD.Models;

public partial class CityDatum
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<ApplicantDatum> ApplicantData { get; set; } = new List<ApplicantDatum>();
}
