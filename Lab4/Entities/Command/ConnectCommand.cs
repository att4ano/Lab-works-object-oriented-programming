using Itmo.ObjectOrientedProgramming.Lab4.Entities.FileSystem;
using Itmo.ObjectOrientedProgramming.Lab4.Models;

namespace Itmo.ObjectOrientedProgramming.Lab4.Entities.Command;

public class ConnectCommand : ICommand
{
    private readonly string _contextPath;
    private readonly string _mode;

    public ConnectCommand(string contextPath, string mode)
    {
        _contextPath = contextPath;
        _mode = mode;
    }

    public FileSystemExecuteResult Execute(ContextFileSystem context)
    {
        return context.Connect(_contextPath, _mode);
    }
}
