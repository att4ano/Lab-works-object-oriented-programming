using Itmo.ObjectOrientedProgramming.Lab4.Entities.CompositeTree;
using Itmo.ObjectOrientedProgramming.Lab4.Entities.FileSystemElement;
using Itmo.ObjectOrientedProgramming.Lab4.Models;

namespace Itmo.ObjectOrientedProgramming.Lab4.Entities.FileSystem.FileSystemModule;

public interface IFileSystem
{
    FileSystemExecuteResult TreeGoto(Context workingDirectory, string destinationPath);

    FileSystemExecuteResult Copy(Context workingDirectory, string sourceFilePath, string destinationFilePath);

    FileSystemExecuteResult Move(Context workingDirectory, string sourceFilePath, string destinationFilePath);

    FileSystemExecuteResult Rename(Context workingDirectory, string sourceFilePath, string newFileName);

    FileSystemExecuteResult Delete(Context workingDirectory, string sourceFilePath);

    IFileSystemTree TreeList(string path);

    IFile ShowFile(string path);
}