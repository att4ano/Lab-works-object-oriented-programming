using System.Diagnostics.CodeAnalysis;
using Lab5.Application;
using Lab5.Application.Contracts.Users;

namespace Lab5.Presentation.Console.Scenarios.Login;

public class LoginAsUserProvider : IScenarioProvider
{
    private readonly IUserService _service;
    private readonly ICurrentUserManager _currentUser;

    public LoginAsUserProvider(
        IUserService service,
        ICurrentUserManager currentSession)
    {
        _service = service;
        _currentUser = currentSession;
    }

    public bool TryGetScenario(
        [NotNullWhen(true)] out IScenario? scenario)
    {
        if (_currentUser.CurrentSession is not CurrentSession.UnauthorizedSession)
        {
            scenario = null;
            return false;
        }

        scenario = new LoginAsUserScenario(_service);
        return true;
    }
}