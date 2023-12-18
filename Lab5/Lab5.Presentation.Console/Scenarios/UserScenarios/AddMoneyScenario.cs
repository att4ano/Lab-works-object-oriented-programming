using Lab5.Application.Contracts;
using Lab5.Application.Contracts.Users;
using Lab5.Application.Models;
using Spectre.Console;

namespace Lab5.Presentation.Console.Scenarios.UserScenarios;

public class AddMoneyScenario : IScenario
{
    private readonly IUserService _userService;

    public AddMoneyScenario(IUserService userService)
    {
        _userService = userService;
    }

    public string Name { get; } = "Add money";

    public async Task Run()
    {
        int moneyAmount = AnsiConsole.Ask<int>("How much money to add:");
        OperationResult result = await _userService.UpdateMoney(new Money(moneyAmount));

        string message = result switch
        {
            OperationResult.Success => "success",
            OperationResult.Failure => "Failure",
            _ => "Cannot resolve",
        };
        AnsiConsole.Ask<string>(message);
    }
}