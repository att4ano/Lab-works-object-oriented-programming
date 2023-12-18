namespace Itmo.ObjectOrientedProgramming.Lab4.Entities.Command.Builder;

public class TreeShowCommandBuilder : ICommandBuilder
{
    private int _depth;
    private char _fileIcon;
    private char _directoryIcon;

    public TreeShowCommandBuilder WithDepth(int depth)
    {
        _depth = depth;
        return this;
    }

    public TreeShowCommandBuilder WithFileIcon(char fileIcon)
    {
        _fileIcon = fileIcon;
        return this;
    }

    public TreeShowCommandBuilder WithDirectoryIcon(char directoryIcon)
    {
        _directoryIcon = directoryIcon;
        return this;
    }

    public ICommand Build()
    {
        return new TreeShowCommand(
            _fileIcon,
            _directoryIcon,
            _depth);
    }
}