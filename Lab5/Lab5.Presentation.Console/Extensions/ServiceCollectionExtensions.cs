using Lab5.Presentation.Console.Scenarios.AdminScenarios;
using Lab5.Presentation.Console.Scenarios.Login;
using Lab5.Presentation.Console.Scenarios.UserScenarios;
using Microsoft.Extensions.DependencyInjection;

namespace Lab5.Presentation.Console.Extensions;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddPresentationConsole(this IServiceCollection collection)
    {
        collection.AddScoped<ScenarioRunner>();

        collection.AddScoped<IScenarioProvider, LoginAsAdminProvider>();
        collection.AddScoped<IScenarioProvider, LoginAsUserProvider>();
        collection.AddScoped<IScenarioProvider, CreateNewUserProvider>();
        collection.AddScoped<IScenarioProvider, AddMoneyProvider>();
        collection.AddScoped<IScenarioProvider, TakeMoneyProvider>();
        collection.AddScoped<IScenarioProvider, CheckBalanceProvider>();
        collection.AddScoped<IScenarioProvider, CheckHistoryProvider>();

        return collection;
    }
}