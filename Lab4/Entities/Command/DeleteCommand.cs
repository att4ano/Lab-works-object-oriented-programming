using Itmo.ObjectOrientedProgramming.Lab4.Entities.FileSystem;
using Itmo.ObjectOrientedProgramming.Lab4.Models;

namespace Itmo.ObjectOrientedProgramming.Lab4.Entities.Command;

public class DeleteCommand : ICommand
{
    private readonly string _filePath;

    public DeleteCommand(string filePath)
    {
        _filePath = filePath;
    }

    public FileSystemExecuteResult Execute(ContextFileSystem context)
    {
        return context.FileSystem.Delete(context.WorkingContext, _filePath);
    }
}