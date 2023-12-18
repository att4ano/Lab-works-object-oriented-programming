namespace Lab5.Application.Contracts;

public abstract record OperationResult
{
    private OperationResult(string message)
    {
        Message = message;
    }

    public string Message { get; }

    public sealed record Success : OperationResult
    {
        public Success(string message)
            : base(message)
        {
        }
    }

    public sealed record Failure : OperationResult
    {
        public Failure(string message)
            : base(message)
        {
        }
    }
}