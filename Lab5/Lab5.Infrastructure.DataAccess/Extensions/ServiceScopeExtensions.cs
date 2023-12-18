using Itmo.Dev.Platform.Postgres.Extensions;
using Microsoft.Extensions.DependencyInjection;

namespace Lab5.Infrastructure.DataAccess.Extensions;

public static class ServiceScopeExtensions
{
    public static async void UseInfrastructureDataAccess(this IServiceScope scope)
    {
        await scope.UsePlatformMigrationsAsync(default);
    }
}