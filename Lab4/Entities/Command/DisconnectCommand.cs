using Itmo.ObjectOrientedProgramming.Lab4.Entities.FileSystem;
using Itmo.ObjectOrientedProgramming.Lab4.Models;

namespace Itmo.ObjectOrientedProgramming.Lab4.Entities.Command;

public class DisconnectCommand : ICommand
{
    public DisconnectCommand()
    {
    }

    public FileSystemExecuteResult Execute(ContextFileSystem context)
    {
        return context.Disconnect();
    }
}