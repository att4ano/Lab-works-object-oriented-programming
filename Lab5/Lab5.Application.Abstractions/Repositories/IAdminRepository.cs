using Lab5.Application.Models.Users;

namespace Lab5.Application.Abstractions.Repositories;

public interface IAdminRepository
{
    IAsyncEnumerable<Admin> GetAllAdmins();

    Task<Admin?> FindAdmin(string password);
}