using Lab5.Application.Contracts;
using Lab5.Application.Contracts.Users;
using Spectre.Console;

namespace Lab5.Presentation.Console.Scenarios.Login;

public class LoginAsUserScenario : IScenario
{
    private readonly IUserService _userService;

    public LoginAsUserScenario(IUserService userService)
    {
        _userService = userService;
    }

    public string Name { get; } = "User login";

    public async Task Run()
    {
        string username = AnsiConsole.Ask<string>("Enter your username");
        string password = AnsiConsole.Ask<string>("Enter the password");

        LoginResult result = await _userService.Login(username, password);

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