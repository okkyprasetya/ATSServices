using System;
using System.Collections.Generic;

namespace testCRUD.Models;

public partial class ApplicationDatum
{
    public int ApplicantDataId { get; set; }

    public int VacancyId { get; set; }

    public DateOnly Date { get; set; }

    public byte? Status { get; set; }

    public string? ReviewedBy { get; set; }

    public virtual ApplicantDatum ApplicantData { get; set; } = null!;

    public virtual Vacancy Vacancy { get; set; } = null!;
}
