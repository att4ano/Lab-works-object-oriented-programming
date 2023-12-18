namespace Lab5.Application.Models.Operations;

public record Operation(long Id, long UserId, OperationType Type, Money MoneyAmount);