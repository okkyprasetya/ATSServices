using System;
using System.Collections.Generic;

namespace testCRUD.Models;

public partial class ApplicantDatum
{
    public int Id { get; set; }

    public string FirstName { get; set; } = null!;

    public string? MiddleName { get; set; }

    public string LastName { get; set; } = null!;

    public string Description { get; set; } = null!;

    public DateOnly BirthDate { get; set; }

    public string Address { get; set; } = null!;

    public int CityId { get; set; }

    public int ProvinceId { get; set; }

    public int UserId { get; set; }

    public int EducationalRecordId { get; set; }

    public int? CertificationId { get; set; }

    public int? WorkExperienceId { get; set; }

    public int? OrganizationalExperienceId { get; set; }

    public int? AchievementRecordId { get; set; }

    public virtual AchievementRecord? AchievementRecord { get; set; }

    public virtual Certification? Certification { get; set; }

    public virtual CityDatum City { get; set; } = null!;

    public virtual EducationalRecord EducationalRecord { get; set; } = null!;

    public virtual OrganizationalExperience? OrganizationalExperience { get; set; }

    public virtual ProvinceDatum Province { get; set; } = null!;

    public virtual UserDatum User { get; set; } = null!;

    public virtual WorkExperience? WorkExperience { get; set; }
}
