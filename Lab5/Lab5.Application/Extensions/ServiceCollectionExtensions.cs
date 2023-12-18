using Lab5.Application.Admins;
using Lab5.Application.Contracts.Admins;
using Lab5.Application.Contracts.Users;
using Lab5.Application.Users;
using Microsoft.Extensions.DependencyInjection;

namespace Lab5.Application.Extensions;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddApplication(this IServiceCollection collection)
    {
        collection.AddScoped<IUserService, UserService>();
        collection.AddScoped<IAdminService, AdminService>();
        collection.AddScoped<CurrentUserManager>();

        collection.AddScoped<ICurrentUserManager>(
            p => p.GetRequiredService<CurrentUserManager>());
        return collection;
    }
}