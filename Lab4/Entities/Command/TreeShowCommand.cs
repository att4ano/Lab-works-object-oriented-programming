using Itmo.ObjectOrientedProgramming.Lab4.Entities.FileSystem;
using Itmo.ObjectOrientedProgramming.Lab4.Models;

namespace Itmo.ObjectOrientedProgramming.Lab4.Entities.Command;

public class TreeShowCommand : ICommand
{
    private readonly int _depth;
    private readonly char _fileIcon;
    private readonly char _directoryIcon;

    public TreeShowCommand(char fileIcon = '\u263A', char directoryIcon = '\u2639', int depth = 0)
    {
        _fileIcon = fileIcon;
        _directoryIcon = directoryIcon;
        _depth = depth;
    }

    public FileSystemExecuteResult Execute(ContextFileSystem context)
    {
        return context.TreeList(_fileIcon, _directoryIcon, _depth);
    }
}