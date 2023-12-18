using System.IO;
using System.Text;

namespace Itmo.ObjectOrientedProgramming.Lab4.Entities.FileSystemElement.VisitorFileSystem;

public class StandardFileSystemVisitor : IVisitor
{
    private readonly char _fileIcon;
    private readonly char _directoryIcon;
    private readonly int _depth;
    private readonly int _currentDepth;

    public StandardFileSystemVisitor(char fileIcon, char directoryIcon, int depth, int currentDepth)
    {
        _fileIcon = fileIcon;
        _directoryIcon = directoryIcon;
        _depth = depth;
        _currentDepth = currentDepth;
    }

    public StringBuilder VisitorContent { get; } = new StringBuilder();

    public void VisitFile(IFile file)
    {
        string currentCall = $"{new string(' ', _currentDepth * 3)}{_fileIcon}{Path.GetFileName(file.Path)}";
        VisitorContent.Append(currentCall);
    }

    public void VisitDirectory(IDirectory directory)
    {
        if (_currentDepth > _depth)
        {
            return;
        }

        string currentCall = $"{new string(' ', _currentDepth * 2)}{_directoryIcon}{Path.GetFileName(directory.Path)}";
        VisitorContent.Append(currentCall);
        foreach (IFileSystemElement fileSystemElement in directory.FileSystemElements)
        {
            fileSystemElement.Accept(this);
        }
    }
}