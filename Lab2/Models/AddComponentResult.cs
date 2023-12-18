namespace Itmo.ObjectOrientedProgramming.Lab2.Models;

public abstract record AddComponentResult
{
    private AddComponentResult(string message)
    {
        Message = message;
    }

    public string Message { get; init; }

    public sealed record Success : AddComponentResult
    {
        public Success(string message)
            : base(message)
        {
        }
    }

    public sealed record Failure : AddComponentResult
    {
        public Failure(string message)
            : base(message)
        {
        }
    }

    public sealed record HeatDissipationWarning : AddComponentResult
    {
        public HeatDissipationWarning(string message)
            : base(message)
        {
        }
    }

    public sealed record PowerConsumptionWarning : AddComponentResult
    {
        public PowerConsumptionWarning(string message)
            : base(message)
        {
        }
    }
}