namespace Lab5.Application.Contracts.Admins;

public interface IAdminService
{
    Task<LoginResult> Login(string password);

    Task CreateNewUser(string username, string password);
}