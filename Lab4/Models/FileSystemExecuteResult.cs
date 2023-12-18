namespace Itmo.ObjectOrientedProgramming.Lab4.Models;

public abstract record FileSystemExecuteResult
{
    private FileSystemExecuteResult(string message)
    {
        Content = message;
    }

    public string Content { get; }

    public sealed record Success : FileSystemExecuteResult
    {
        public Success(string message)
            : base(message)
        {
        }
    }

    public sealed record Failure : FileSystemExecuteResult
    {
        public Failure(string message)
            : base(message)
        {
        }
    }
}