using System.Diagnostics.CodeAnalysis;
using Lab5.Application;
using Lab5.Application.Contracts.Admins;

namespace Lab5.Presentation.Console.Scenarios.Login;

public class LoginAsAdminProvider : IScenarioProvider
{
    private readonly IAdminService _service;
    private readonly ICurrentUserManager _currentUser;

    public LoginAsAdminProvider(
        IAdminService service,
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

        scenario = new LoginAsAdminScenario(_service);
        return true;
    }
}