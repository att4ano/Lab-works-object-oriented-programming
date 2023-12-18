using Itmo.ObjectOrientedProgramming.Lab4.Entities.FileSystemElement.VisitorFileSystem;

namespace Itmo.ObjectOrientedProgramming.Lab4.Entities.FileSystemElement;

public interface IFile
{
    public string Path { get; }
    public string FileContent { get; }
    public void Accept(IVisitor visitor);
}