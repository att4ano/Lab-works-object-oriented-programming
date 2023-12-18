using Lab5.Application.Contracts;
using Lab5.Application.Contracts.Admins;
using Spectre.Console;

namespace Lab5.Presentation.Console.Scenarios.Login;

public class LoginAsAdminScenario : IScenario
{
    private readonly IAdminService _adminService;

    public LoginAsAdminScenario(IAdminService adminService)
    {
        _adminService = adminService;
    }

    public string Name { get; } = "Admin Login";
    public async Task Run()
    {
        string password = AnsiConsole.Ask<string>("Enter the password");

        LoginResult result = await _adminService.Login(password);

        string message = result switch
        {
            LoginResult.Success => "Successful login",
            LoginResult.NotFound => "User not found",
            LoginResult.Failure => "Login failure",
            _ => throw new ArgumentOutOfRangeException(nameof(result)),
        };

        AnsiConsole.WriteLine(message);
        AnsiConsole.Ask<string>("Ok");
    }
}