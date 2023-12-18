using Itmo.ObjectOrientedProgramming.Lab4.Models;

namespace Itmo.ObjectOrientedProgramming.Lab4.Entities.WriterService;

public interface IWriter
{
    void OutputTreeList(string treeListContent);

    void OutputFile(string fileContent);

    void OutputExecuteResult(FileSystemExecuteResult content);
}