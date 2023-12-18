using Itmo.ObjectOrientedProgramming.Lab4.Entities.Command.Builder;

namespace Itmo.ObjectOrientedProgramming.Lab4.Models;

public abstract record ResultCommandBuild
{
    private ResultCommandBuild() { }

    public record Success : ResultCommandBuild
    {
        public Success(ICommandBuilder builder)
        {
            Builder = builder;
        }

        public ICommandBuilder Builder { get; }
    }

    public record Failure() : ResultCommandBuild;
}