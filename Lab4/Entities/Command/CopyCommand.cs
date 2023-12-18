using Itmo.ObjectOrientedProgramming.Lab4.Entities.FileSystem;
using Itmo.ObjectOrientedProgramming.Lab4.Models;

namespace Itmo.ObjectOrientedProgramming.Lab4.Entities.Command;

public class CopyCommand : ICommand
{
    private readonly string _sourceFilePath;
    private readonly string _destinationFilePath;

    public CopyCommand(string sourceFilePath, string destinationFilePath)
    {
        _sourceFilePath = sourceFilePath;
        _destinationFilePath = destinationFilePath;
    }

    public FileSystemExecuteResult Execute(ContextFileSystem context)
    {
        return context.FileSystem.Copy(context.WorkingContext, _sourceFilePath, _destinationFilePath);
    }
}