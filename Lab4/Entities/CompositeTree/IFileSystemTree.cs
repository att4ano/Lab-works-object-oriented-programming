using Itmo.ObjectOrientedProgramming.Lab4.Entities.FileSystemElement;
using Itmo.ObjectOrientedProgramming.Lab4.Entities.FileSystemElement.VisitorFileSystem;

namespace Itmo.ObjectOrientedProgramming.Lab4.Entities.CompositeTree;

public interface IFileSystemTree
{
    public void InitialiseTree(string path);
    IFileSystemElement Create(string path);
    public void Accept(IVisitor visitor);
}