using System;

namespace Itmo.ObjectOrientedProgramming.Lab4.Entities.Command.Builder;

public class DeleteCommandBuilder : ICommandBuilder
{
    private string? _filePath;

    public DeleteCommandBuilder WithFilePath(string filePath)
    {
        _filePath = filePath;
        return this;
    }

    public ICommand Build()
    {
        return new DeleteCommand(
            _filePath ?? throw new ArgumentNullException(nameof(_filePath), "cannot be null"));
    }
}