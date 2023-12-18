using System;

namespace Itmo.ObjectOrientedProgramming.Lab4.Entities.Command.Builder;

public class ConnectCommandBuilder : ICommandBuilder
{
    private string? _contextPath;
    private string? _mode;

    public ConnectCommandBuilder WithContextPath(string contextPath)
    {
        _contextPath = contextPath;
        return this;
    }

    public ConnectCommandBuilder WithModification(string mode)
    {
        _mode = mode;
        return this;
    }

    public ICommand Build()
    {
        return new ConnectCommand(
            _contextPath ?? throw new ArgumentNullException(nameof(_contextPath), "cannot be null"),
            _mode ?? throw new ArgumentNullException(nameof(_mode), "cannot be null"));
    }
}