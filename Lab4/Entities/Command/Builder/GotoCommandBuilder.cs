using System;

namespace Itmo.ObjectOrientedProgramming.Lab4.Entities.Command.Builder;

public class GotoCommandBuilder : ICommandBuilder
{
    private string? _destinationPath;

    public GotoCommandBuilder WithDestinationBuilder(string destinationPath)
    {
        _destinationPath = destinationPath;
        return this;
    }

    public ICommand Build()
    {
        return new GotoCommand(
            _destinationPath ?? throw new ArgumentNullException(nameof(_destinationPath), "cannot be null"));
    }
}