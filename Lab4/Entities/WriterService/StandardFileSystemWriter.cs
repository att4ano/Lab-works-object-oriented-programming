using System;
using Itmo.ObjectOrientedProgramming.Lab4.Models;

namespace Itmo.ObjectOrientedProgramming.Lab4.Entities.WriterService;

public class StandardFileSystemWriter : IWriter
{
    public void OutputTreeList(string treeListContent)
    {
        Console.WriteLine(treeListContent);
    }

    public void OutputFile(string fileContent)
    {
        Console.WriteLine(fileContent);
    }

    public void OutputExecuteResult(FileSystemExecuteResult content)
    {
        Console.WriteLine(content.Content);
    }
}