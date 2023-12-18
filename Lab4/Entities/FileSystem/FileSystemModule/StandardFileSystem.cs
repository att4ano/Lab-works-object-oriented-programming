using System.IO;
using Itmo.ObjectOrientedProgramming.Lab4.Entities.CompositeTree;
using Itmo.ObjectOrientedProgramming.Lab4.Entities.FileSystemElement;
using Itmo.ObjectOrientedProgramming.Lab4.Models;

namespace Itmo.ObjectOrientedProgramming.Lab4.Entities.FileSystem.FileSystemModule;

public class StandardFileSystem : IFileSystem
{
    public FileSystemExecuteResult TreeGoto(Context workingDirectory, string destinationPath)
    {
        if (!workingDirectory.FileReachabilityCheck(destinationPath))
        {
            return new FileSystemExecuteResult.Failure("Such file does not exist");
        }

        workingDirectory.SetNewContext(destinationPath);
        return new FileSystemExecuteResult.Success($"Success to {destinationPath}");
    }

    public FileSystemExecuteResult Copy(Context workingDirectory, string sourceFilePath, string destinationFilePath)
    {
        if (!Path.Exists(destinationFilePath))
        {
            return new FileSystemExecuteResult.Failure("Such path does not exist");
        }

        destinationFilePath = Path.GetFullPath(destinationFilePath);

        if (!workingDirectory.FileReachabilityCheck(sourceFilePath))
        {
            return new FileSystemExecuteResult.Failure("Such file does not exist");
        }

        try
        {
            File.Copy(sourceFilePath, destinationFilePath);
            return new FileSystemExecuteResult.Success("Success move");
        }
        catch (IOException)
        {
            return new FileSystemExecuteResult.Failure("File with such name already exists");
        }
    }

    public FileSystemExecuteResult Move(Context workingDirectory, string sourceFilePath, string destinationFilePath)
    {
        if (!Path.Exists(destinationFilePath))
        {
            return new FileSystemExecuteResult.Failure("Such path does not exist");
        }

        destinationFilePath = Path.GetFullPath(destinationFilePath);

        if (!workingDirectory.FileReachabilityCheck(sourceFilePath))
        {
            return new FileSystemExecuteResult.Failure("Such file does not exist");
        }

        try
        {
            File.Move(sourceFilePath, destinationFilePath);
            return new FileSystemExecuteResult.Success("Success copy");
        }
        catch (IOException)
        {
            return new FileSystemExecuteResult.Failure("File with such name already exists");
        }
    }

    public FileSystemExecuteResult Rename(Context workingDirectory, string sourceFilePath, string newFileName)
    {
        if (workingDirectory.ContextPath is null)
        {
            return new FileSystemExecuteResult.Failure("You should be connected to any directory");
        }

        if (!workingDirectory.FileReachabilityCheck(sourceFilePath))
        {
            return new FileSystemExecuteResult.Failure("Such file does not exist");
        }

        File.Move(sourceFilePath, Path.Combine(workingDirectory.ContextPath, newFileName), true);
        return new FileSystemExecuteResult.Success($"Success rename file to {newFileName}");
    }

    public FileSystemExecuteResult Delete(Context workingDirectory, string sourceFilePath)
    {
        if (workingDirectory.ContextPath is null)
        {
            return new FileSystemExecuteResult.Failure("You should be connected to any directory");
        }

        if (!workingDirectory.FileReachabilityCheck(sourceFilePath))
        {
            return new FileSystemExecuteResult.Failure("Such file does not exist");
        }

        File.Delete(sourceFilePath);
        return new FileSystemExecuteResult.Success($"Success delete {Path.GetFileName(sourceFilePath)}");
    }

    public IFileSystemTree TreeList(string path)
    {
        var compositeTree = new FileTree();
        compositeTree.InitialiseTree(path);
        return compositeTree;
    }

    public IFile ShowFile(string path)
    {
        return new StandardFileSystemFile(path);
    }
}