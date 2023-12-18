using Lab5.Application.Abstractions.Repositories;
using Lab5.Application.Contracts;
using Lab5.Application.Contracts.Users;
using Lab5.Application.Models;
using Lab5.Application.Models.Operations;
using Lab5.Application.Models.Users;

namespace Lab5.Application.Users;

public class UserService : IUserService
{
    private readonly IOperationRepository _operationRepository;
    private readonly IUserRepository _userRepository;
    private readonly CurrentUserManager _currentUserManager;

    public UserService(
        IOperationRepository operationRepository,
        IUserRepository userRepository,
        CurrentUserManager currentUserManager)
    {
        _operationRepository = operationRepository;
        _userRepository = userRepository;
        _currentUserManager = currentUserManager;
        _currentUserManager.CurrentSession = new CurrentSession.UnauthorizedSession();
    }

    public async Task<LoginResult> Login(string username, string password)
    {
        if (_currentUserManager.CurrentSession is not CurrentSession.UnauthorizedSession)
        {
            return new LoginResult.Failure();
        }

        User? user = await _userRepository.FindUserByUsername(username);
        if (user is null)
        {
            return new LoginResult.NotFound();
        }

        if (user.Password != password)
        {
            return new LoginResult.Failure();
        }

        _currentUserManager.CurrentSession = new CurrentSession.UserSession(user);
        return new LoginResult.Success();
    }

    public async Task<OperationResult> UpdateMoney(Money value)
    {
        if (_currentUserManager.CurrentSession is not CurrentSession.UserSession userSession)
        {
            return new OperationResult.Failure("You need to be logged in");
        }

        await _userRepository.UpdateMoneyOfUserBalance(
            userSession.User.Username,
            userSession.User.MoneyAmount.Value + value.Value);

        if (userSession.User.MoneyAmount.Value + value.Value < 0)
        {
            return new OperationResult.Failure("Cannot be negative");
        }

        userSession.User = userSession.User with
        {
            MoneyAmount = new Money(userSession.User.MoneyAmount.Value + value.Value),
        };

        await _operationRepository.AddNewOperation(userSession.User.Id, OperationType.Addition, value);
        return new OperationResult.Success("Success add");
    }

    public async IAsyncEnumerable<Operation>? CheckUserHistory()
    {
        if (_currentUserManager.CurrentSession is not CurrentSession.UserSession userSession)
        {
            yield break;
        }

        IAsyncEnumerable<Operation>? operations = _operationRepository.GetAllOperationsOfUser(userSession.User.Id);
        if (operations is not null)
        {
            await foreach (Operation operation in operations)
                yield return operation;
        }

        yield break;
    }

    public async Task<Money?> CheckUserBalance()
    {
        if (_currentUserManager.CurrentSession is not CurrentSession.UserSession userSession)
        {
            return null;
        }

        User? user = await _userRepository.FindUserByUsername(userSession.User.Username);
        return user?.MoneyAmount;
    }
}