using System;

namespace Itmo.ObjectOrientedProgramming.Lab4.Entities.Command.Builder;

public class CopyCommandBuilder : ICommandBuilder
{
    private string? _sourceFilePath;
    private string? _destinationFilePath;

    public CopyCommandBuilder WithSourceFilePath(string sourceFilePath)
    {
        _sourceFilePath = sourceFilePath;
        return this;
    }

    public CopyCommandBuilder WithDestinationPath(string destinationFilePath)
    {
        _destinationFilePath = destinationFilePath;
        return this;
    }

    public ICommand Build()
    {
        return new CopyCommand(
            _sourceFilePath ?? throw new ArgumentNullException(nameof(_sourceFilePath), "cannot be null"),
            _destinationFilePath ?? throw new ArgumentNullException(nameof(_destinationFilePath), "cannot be null"));
    }
}