using System.Collections.Generic;

namespace Itmo.ObjectOrientedProgramming.Lab4.Entities.FileSystemElement;

public interface IDirectory
{
    public IList<IFileSystemElement> FileSystemElements { get; }

    public string Path { get; set; }
}