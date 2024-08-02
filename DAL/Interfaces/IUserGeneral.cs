using testCRUD.Models;

public interface IUserGeneral{
    Task<UserDatum> login (string email, string password);
    Task<Task> forgotPassword(string email);
    Task<Task> answerResetQuestion(string question);
    Task<Task> logout ();
}