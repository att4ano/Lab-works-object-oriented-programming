using Itmo.ObjectOrientedProgramming.Lab3.Entities.Messages;

namespace Itmo.ObjectOrientedProgramming.Lab3.Models;

public abstract record SendResult
{
    private SendResult() { }

    public sealed record Success : SendResult
    {
        public Success(IMessage resultMessage)
        {
            Message = resultMessage;
        }

        public IMessage Message { get; }
    }

    public sealed record Failure : SendResult;
}