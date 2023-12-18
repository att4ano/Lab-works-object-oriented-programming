using Itmo.ObjectOrientedProgramming.Lab4.Entities.FileSystem;
using Itmo.ObjectOrientedProgramming.Lab4.Models;

namespace Itmo.ObjectOrientedProgramming.Lab4.Entities.Command;

public class RenameCommand : ICommand
{
    private readonly string _sourceFilePath;
    private readonly string _newFileName;

    public RenameCommand(string sourceFilePath, string newFileName)
    {
        _sourceFilePath = sourceFilePath;
        _newFileName = newFileName;
    }

    public FileSystemExecuteResult Execute(ContextFileSystem context)
    {
        return context.FileSystem.Rename(context.WorkingContext, _sourceFilePath, _newFileName);
    }
}