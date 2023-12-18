using Itmo.ObjectOrientedProgramming.Lab2.Entities.Computer;

namespace Itmo.ObjectOrientedProgramming.Lab2.Models;

public abstract record ValidateComputerResult
{
    private ValidateComputerResult() { }

    public sealed record Success : ValidateComputerResult
    {
        public Success(IComputer computer)
        {
            ResultComputer = computer;
        }

        public IComputer ResultComputer { get; init; }
    }

    public sealed record DisclaimerOfWaranty : ValidateComputerResult
    {
        public DisclaimerOfWaranty(IComputer computer)
        {
            ResultComputer = computer;
        }

        public IComputer ResultComputer { get; init; }
    }

    public sealed record PowerConsumptionComment : ValidateComputerResult
    {
        public PowerConsumptionComment(IComputer computer)
        {
            ResultComputer = computer;
        }

        public IComputer ResultComputer { get; init; }
    }

    public sealed record Failure : ValidateComputerResult
    {
        public Failure(string message)
        {
            Message = message;
        }

        public string Message { get; init; }
    }

    public sealed record NoRequiredComponent : ValidateComputerResult;
}