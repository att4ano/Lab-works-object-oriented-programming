using Itmo.ObjectOrientedProgramming.Lab4.Entities.FileSystemElement.VisitorFileSystem;

namespace Itmo.ObjectOrientedProgramming.Lab4.Entities.FileSystemElement;

public interface IFileSystemElement
{
    string Path { get; }

    void Accept(IVisitor visitor);
}