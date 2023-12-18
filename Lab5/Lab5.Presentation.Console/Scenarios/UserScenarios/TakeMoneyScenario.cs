using Lab5.Application.Contracts.Users;
using Lab5.Application.Models;
using Spectre.Console;

namespace Lab5.Presentation.Console.Scenarios.UserScenarios;

public class TakeMoneyScenario : IScenario
{
    private readonly IUserService _userService;

    public TakeMoneyScenario(IUserService userService)
    {
        _userService = userService;
    }

    public string Name { get; } = "Withdraw money";
    public async Task Run()
    {
        int moneyAmount = AnsiConsole.Ask<int>("How much money to withdraw:");
        await _userService.UpdateMoney(new Money(-1 * moneyAmount));
        AnsiConsole.Ask<string>("Ok");
    }
}