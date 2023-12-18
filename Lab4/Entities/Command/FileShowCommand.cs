using Itmo.ObjectOrientedProgramming.Lab4.Entities.FileSystem;
using Itmo.ObjectOrientedProgramming.Lab4.Models;

namespace Itmo.ObjectOrientedProgramming.Lab4.Entities.Command;

public class FileShowCommand : ICommand
{
    private readonly string _path;
    private readonly string _mode;

    public FileShowCommand(string path, string mode)
    {
        _path = path;
        _mode = mode;
    }

    public FileSystemExecuteResult Execute(ContextFileSystem context)
    {
        return context.FileOutput(_path, _mode);
    }
}