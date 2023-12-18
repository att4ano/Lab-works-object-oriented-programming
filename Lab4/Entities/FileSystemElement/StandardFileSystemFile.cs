using System.IO;
using Itmo.ObjectOrientedProgramming.Lab4.Entities.FileSystemElement.VisitorFileSystem;

namespace Itmo.ObjectOrientedProgramming.Lab4.Entities.FileSystemElement;

public class StandardFileSystemFile : IFileSystemElement, IFile
{
    public StandardFileSystemFile(string path)
    {
        Path = path;
        FileContent = File.ReadAllText(path);
    }

    public string Path { get; }
    public string FileContent { get; }

    public void Accept(IVisitor visitor)
    {
        visitor.VisitFile(this);
    }
}
