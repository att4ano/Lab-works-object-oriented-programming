using System.Diagnostics.CodeAnalysis;
using Lab5.Application;
using Lab5.Application.Contracts.Admins;

namespace Lab5.Presentation.Console.Scenarios.AdminScenarios;

public class CreateNewUserProvider : IScenarioProvider
{
    private readonly IAdminService _service;
    private readonly ICurrentUserManager _currentUser;

    public CreateNewUserProvider(IAdminService service, ICurrentUserManager currentUser)
    {
        _service = service;
        _currentUser = currentUser;
    }

    public bool TryGetScenario([NotNullWhen(true)] out IScenario? scenario)
    {
        if (_currentUser.CurrentSession is not CurrentSession.AdminSession)
        {
            scenario = null;
            return false;
        }

        scenario = new CreateNewUserScenario(_service);
        return true;
    }
}