using Lab5.Application.Contracts.Admins;
using Spectre.Console;

namespace Lab5.Presentation.Console.Scenarios.AdminScenarios;

public class CreateNewUserScenario : IScenario
{
    private readonly IAdminService _service;

    public CreateNewUserScenario(IAdminService service)
    {
        _service = service;
    }

    public string Name { get; } = "Create new user";

    public async Task Run()
    {
        string username = AnsiConsole.Ask<string>("Enter new username");
        string password = AnsiConsole.Ask<string>("Enter new password");

        await _service.CreateNewUser(username, password);

        AnsiConsole.Ask<string>("Ok");
    }
}