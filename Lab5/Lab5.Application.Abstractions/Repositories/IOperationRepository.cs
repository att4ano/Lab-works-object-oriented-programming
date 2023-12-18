using Lab5.Application.Models;
using Lab5.Application.Models.Operations;

namespace Lab5.Application.Abstractions.Repositories;

public interface IOperationRepository
{
    IAsyncEnumerable<Operation>? GetAllOperationsOfUser(long userId);

    Task AddNewOperation(long userId, OperationType operationType, Money moneyAmount);
}