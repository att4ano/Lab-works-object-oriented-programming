using Lab5.Application.Models;
using Lab5.Application.Models.Operations;

namespace Lab5.Application.Contracts.Users;

public interface IUserService
{
    Task<LoginResult> Login(string username, string password);

    Task<OperationResult> UpdateMoney(Money value);

    IAsyncEnumerable<Operation>? CheckUserHistory();

    Task<Money?> CheckUserBalance();
}