using System;

namespace Itmo.ObjectOrientedProgramming.Lab4.Entities.Command.Builder;

public class RenameCommandBuilder : ICommandBuilder
{
    private string? _sourceFilePath;
    private string? _newFileName;

    public RenameCommandBuilder WithSourceFilePath(string sourceFilePath)
    {
        _sourceFilePath = sourceFilePath;
        return this;
    }

    public RenameCommandBuilder WithNewFileName(string newFileName)
    {
        _newFileName = newFileName;
        return this;
    }

    public ICommand Build()
    {
        return new RenameCommand(
            _sourceFilePath ?? throw new ArgumentNullException(nameof(_sourceFilePath), "cannot be null"),
            _newFileName ?? throw new ArgumentNullException(nameof(_newFileName), "cannot be null"));
    }
}