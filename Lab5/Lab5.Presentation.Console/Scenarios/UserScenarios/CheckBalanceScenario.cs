using System.Globalization;
using Lab5.Application.Contracts.Users;
using Lab5.Application.Models;
using Spectre.Console;

namespace Lab5.Presentation.Console.Scenarios.UserScenarios;

public class CheckBalanceScenario : IScenario
{
    private readonly IUserService _userService;

    public CheckBalanceScenario(IUserService userService)
    {
        _userService = userService;
    }

    public string Name { get; } = "Check balance";
    public async Task Run()
    {
        Money? balance = await _userService.CheckUserBalance();
        if (balance is not null)
        {
            AnsiConsole.Console.WriteLine(balance.Value.ToString(CultureInfo.InvariantCulture));
            AnsiConsole.Ask<string>("Ok");
        }
        else
        {
            AnsiConsole.Console.WriteLine("Failure");
        }
    }
}