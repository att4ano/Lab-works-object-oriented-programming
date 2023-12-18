using System.Diagnostics.CodeAnalysis;
using Lab5.Application;
using Lab5.Application.Contracts.Users;

namespace Lab5.Presentation.Console.Scenarios.UserScenarios;

public class AddMoneyProvider : IScenarioProvider
{
    private readonly IUserService _service;
    private readonly ICurrentUserManager _currentUser;

    public AddMoneyProvider(IUserService userService, ICurrentUserManager currentUser)
    {
        _service = userService;
        _currentUser = currentUser;
    }

    public bool TryGetScenario([NotNullWhen(true)] out IScenario? scenario)
    {
        if (_currentUser.CurrentSession is not CurrentSession.UserSession)
        {
            scenario = null;
            return false;
        }

        scenario = new AddMoneyScenario(_service);
        return true;
    }
}
