using Itmo.ObjectOrientedProgramming.Lab4.Entities.CompositeTree;
using Itmo.ObjectOrientedProgramming.Lab4.Entities.FileSystem.FileSystemModule;
using Itmo.ObjectOrientedProgramming.Lab4.Entities.FileSystemElement;
using Itmo.ObjectOrientedProgramming.Lab4.Entities.FileSystemElement.VisitorFileSystem;
using Itmo.ObjectOrientedProgramming.Lab4.Entities.WriterService;
using Itmo.ObjectOrientedProgramming.Lab4.Models;

namespace Itmo.ObjectOrientedProgramming.Lab4.Entities.FileSystem;

public class ContextFileSystem
{
    public IFileSystem FileSystem { get; private set; } = new StandardFileSystem();
    public Context WorkingContext { get; private set; } = new Context();

    public IWriter OutputService { get; } = new StandardFileSystemWriter();

    public FileSystemExecuteResult Connect(string path, string mode)
    {
        if (WorkingContext.ContextPath is not null)
        {
            return new FileSystemExecuteResult.Failure("Already connected");
        }

        WorkingContext.SetNewContext(path);
        if (mode == "local")
        {
            FileSystem = new StandardFileSystem();
        }

        return new FileSystemExecuteResult.Success("Successful connection");
    }

    public FileSystemExecuteResult Disconnect()
    {
        if (WorkingContext.ContextPath is null)
        {
            return new FileSystemExecuteResult.Failure("No connection");
        }

        WorkingContext.SetNewContext(null);
        return new FileSystemExecuteResult.Success("Successful disconnection");
    }

    public FileSystemExecuteResult TreeList(char fileIcon, char directoryIcon, int depth)
    {
        if (WorkingContext.ContextPath is null)
        {
            return new FileSystemExecuteResult.Failure("You should be connected");
        }

        IFileSystemTree tree = FileSystem.TreeList(WorkingContext.ContextPath);
        var visitor = new StandardFileSystemVisitor(fileIcon, directoryIcon, depth, 0);
        tree.Accept(visitor);
        OutputService.OutputTreeList(visitor.VisitorContent.ToString());
        return new FileSystemExecuteResult.Success("Success tree directory build");
    }

    public FileSystemExecuteResult FileOutput(string path, string mode)
    {
        if (!WorkingContext.FileReachabilityCheck(path))
        {
            return new FileSystemExecuteResult.Failure("cannot reach this file");
        }

        IFile file = FileSystem.ShowFile(path);
        if (mode == "console")
        {
            OutputService.OutputFile(file.FileContent);
            return new FileSystemExecuteResult.Success("Success");
        }

        return new FileSystemExecuteResult.Failure("Fail");
    }
}