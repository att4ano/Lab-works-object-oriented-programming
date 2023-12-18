namespace Itmo.ObjectOrientedProgramming.Lab4.Entities.Command.Builder;

public class DisconnectCommandBuilder : ICommandBuilder
{
    public ICommand Build()
    {
        return new DisconnectCommand();
    }
}