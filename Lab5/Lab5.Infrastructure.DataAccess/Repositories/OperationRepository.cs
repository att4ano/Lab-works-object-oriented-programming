using Itmo.Dev.Platform.Postgres.Connection;
using Itmo.Dev.Platform.Postgres.Extensions;
using Lab5.Application.Abstractions.Repositories;
using Lab5.Application.Models;
using Lab5.Application.Models.Operations;
using Npgsql;

namespace Lab5.Infrastructure.DataAccess.Repositories;

public class OperationRepository : IOperationRepository
{
    private readonly IPostgresConnectionProvider _connectionProvider;

    public OperationRepository(IPostgresConnectionProvider connectionProvider)
    {
        _connectionProvider = connectionProvider;
    }

    public async IAsyncEnumerable<Operation> GetAllOperationsOfUser(long userId)
    {
        const string sql =
            """
        SELECT *
        FROM operations
        WHERE user_id = @userId;
        """;

        NpgsqlConnection connection = await _connectionProvider.GetConnectionAsync(default);

        await using var command = new NpgsqlCommand(sql, connection);
        command.AddParameter("userId", userId);
        await using NpgsqlDataReader reader = await command.ExecuteReaderAsync();

        while (await reader.ReadAsync())
        {
            yield return new Operation(
                reader.GetInt64(0),
                reader.GetInt64(1),
                await reader.GetFieldValueAsync<OperationType>(2),
                new Money(reader.GetInt32(3)));
        }
    }

    public async Task AddNewOperation(long userId, OperationType operationType, Money moneyAmount)
    {
        const string sql = """
        INSERT INTO operations (user_id, operation_type, money)
        VALUES (@userId, @operationType, @moneyAmount);
        """;

        NpgsqlConnection connection = await _connectionProvider
            .GetConnectionAsync(default);

        await using var command = new NpgsqlCommand(sql, connection);
        command.AddParameter("userId", userId)
            .AddParameter("operationType", operationType)
            .AddParameter("moneyAmount", moneyAmount.Value);
        await command.ExecuteNonQueryAsync();
    }
}