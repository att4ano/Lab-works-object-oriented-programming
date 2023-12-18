using System;

namespace Itmo.ObjectOrientedProgramming.Lab4.Entities.Command.Builder;

public class MoveCommandBuilder : ICommandBuilder
{
    private string? _sourceFilePath;
    private string? _destinationFilePath;

    public MoveCommandBuilder WithSourceFilePath(string sourceFilePath)
    {
        _sourceFilePath = sourceFilePath;
        return this;
    }

    public MoveCommandBuilder WithDestinationPath(string destinationFilePath)
    {
        _destinationFilePath = destinationFilePath;
        return this;
    }

    public ICommand Build()
    {
        return new MoveCommand(
            _sourceFilePath ?? throw new ArgumentNullException(nameof(_sourceFilePath), "cannot be null"),
            _destinationFilePath ?? throw new ArgumentNullException(nameof(_destinationFilePath), "cannot be null"));
    }
}