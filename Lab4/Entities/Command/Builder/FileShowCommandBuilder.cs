using System;

namespace Itmo.ObjectOrientedProgramming.Lab4.Entities.Command.Builder;

public class FileShowCommandBuilder : ICommandBuilder
{
    private string? _path;
    private string? _mode;

    public FileShowCommandBuilder WithPath(string path)
    {
        _path = path;
        return this;
    }

    public FileShowCommandBuilder WithShowMode(string mode)
    {
        _mode = mode;
        return this;
    }

    public ICommand Build()
    {
        return new FileShowCommand(
            _path ?? throw new ArgumentNullException(nameof(_path), "cannot be null"),
            _mode ?? throw new ArgumentNullException(nameof(_mode), "cannot be null"));
    }
}