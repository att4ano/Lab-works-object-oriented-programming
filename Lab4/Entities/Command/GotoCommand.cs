using Itmo.ObjectOrientedProgramming.Lab4.Entities.FileSystem;
using Itmo.ObjectOrientedProgramming.Lab4.Models;

namespace Itmo.ObjectOrientedProgramming.Lab4.Entities.Command;

public class GotoCommand : ICommand
{
    private readonly string _destinationPath;

    public GotoCommand(string destinationPath)
    {
        _destinationPath = destinationPath;
    }

    public FileSystemExecuteResult Execute(ContextFileSystem context)
    {
        return context.FileSystem.TreeGoto(context.WorkingContext, _destinationPath);
    }
}