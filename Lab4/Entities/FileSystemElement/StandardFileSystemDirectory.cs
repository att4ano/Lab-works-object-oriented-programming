using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab4.Entities.FileSystemElement.VisitorFileSystem;

namespace Itmo.ObjectOrientedProgramming.Lab4.Entities.FileSystemElement;

public class StandardFileSystemDirectory : IFileSystemElement, IDirectory
{
    public StandardFileSystemDirectory(string path)
    {
        Path = path;
    }

    public IList<IFileSystemElement> FileSystemElements { get; } = new List<IFileSystemElement>();

    public string Path { get; set; }
    public void Accept(IVisitor visitor)
    {
        visitor.VisitDirectory(this);
    }

    public void AddElement(IFileSystemElement fileSystemElement)
    {
        FileSystemElements.Add(fileSystemElement);
    }
}