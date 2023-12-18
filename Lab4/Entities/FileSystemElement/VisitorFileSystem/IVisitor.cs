using System.Text;

namespace Itmo.ObjectOrientedProgramming.Lab4.Entities.FileSystemElement.VisitorFileSystem;

public interface IVisitor
{
    StringBuilder VisitorContent { get; }
    void VisitFile(IFile file);

    void VisitDirectory(IDirectory directory);
}