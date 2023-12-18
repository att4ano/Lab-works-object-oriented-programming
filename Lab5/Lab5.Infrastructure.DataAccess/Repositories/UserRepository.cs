using Itmo.Dev.Platform.Postgres.Connection;
using Itmo.Dev.Platform.Postgres.Extensions;
using Lab5.Application.Abstractions.Repositories;
using Lab5.Application.Models;
using Lab5.Application.Models.Users;
using Npgsql;

namespace Lab5.Infrastructure.DataAccess.Repositories;

public class UserRepository : IUserRepository
{
    private readonly IPostgresConnectionProvider _connectionProvider;

    public UserRepository(IPostgresConnectionProvider connectionProvider)
    {
        _connectionProvider = connectionProvider;
    }

    public async Task<User?> FindUserByUsername(string username)
    {
        const string sql = """
        SELECT user_id, username, password, money
        FROM users
        WHERE username = @username;
        """;

        NpgsqlConnection connection = await _connectionProvider
            .GetConnectionAsync(default);

        await using var command = new NpgsqlCommand(sql, connection);
        command.AddParameter("username", username);
        await using NpgsqlDataReader reader = await command.ExecuteReaderAsync();

        if (await reader.ReadAsync() is false)
        {
            return null;
        }

        return new User(
            reader.GetInt64(0),
            reader.GetString(1),
            reader.GetString(2),
            new Money(reader.GetInt64(3)));
    }

    public async Task UpdateMoneyOfUserBalance(string username, long newMoneyValue)
    {
        const string sql = """
        UPDATE users
        SET money = @newMoneyValue
        WHERE username = @username;
        """;

        NpgsqlConnection connection = await _connectionProvider
            .GetConnectionAsync(default);

        await using var command = new NpgsqlCommand(sql, connection);
        command.AddParameter("username", username)
            .AddParameter("newMoneyValue", newMoneyValue);
        await command.ExecuteNonQueryAsync();
    }

    public async Task AddNewUser(string username, string password)
    {
        const string sql = """
        INSERT INTO users (username, password, money)
        VALUES (@username, @password, 0);
        """;

        NpgsqlConnection connection = await _connectionProvider
            .GetConnectionAsync(default);

        await using var command = new NpgsqlCommand(sql, connection);
        command.AddParameter("username", username)
            .AddParameter("password", password);
        await command.ExecuteNonQueryAsync();
    }
}