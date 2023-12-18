using Lab5.Application.Contracts.Users;
using Lab5.Application.Models.Operations;
using Spectre.Console;

namespace Lab5.Presentation.Console.Scenarios.UserScenarios;

public class CheckHistoryScenario : IScenario
{
    private readonly IUserService _userService;

    public CheckHistoryScenario(IUserService userService)
    {
        _userService = userService;
    }

    public string Name { get; } = "Check history";

    public async Task Run()
    {
        IAsyncEnumerable<Operation>? history = _userService.CheckUserHistory();
        if (history is not null)
        {
            await foreach (Operation operation in history)
            {
                AnsiConsole.Console.WriteLine($"{operation.Id}, {operation.MoneyAmount}, {operation.Type}");
            }

            AnsiConsole.Ask<string>("Ok");
        }
    }
}