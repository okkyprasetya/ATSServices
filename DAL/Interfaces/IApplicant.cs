using testCRUD.Models;

public interface IApplicant : IUserGeneral{
    Task<Task> Register(UserDatum data);
    Task<Task> CreateGeneralData(ApplicantDatum generalData);
    Task<ApplicantDatum> GetGeneralData();
    Task<Task> UpdateGeneralData(ApplicantDatum generalData);
    Task<Task> AddEducationalRecords(EducationalRecord educationalRecord);
    Task<EducationalRecord> GetEducationalRecords();
    Task<Task> UpdateEducationalRecords(EducationalRecord educationalRecord);
    Task<Task> DeleteEducationalRecords(int id);
    Task<Task> AddOrganizationalRecords(OrganizationalExperience organizationalExperience);
    Task<Task> UpdateOrganizationalRecords(OrganizationalExperience organizationalExperience);

}