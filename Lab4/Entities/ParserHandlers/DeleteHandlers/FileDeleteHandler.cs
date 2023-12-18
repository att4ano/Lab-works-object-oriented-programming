using Itmo.ObjectOrientedProgramming.Lab4.Entities.Command.Builder;
using Itmo.ObjectOrientedProgramming.Lab4.Entities.ParserIterators;
using Itmo.ObjectOrientedProgramming.Lab4.Models;

namespace Itmo.ObjectOrientedProgramming.Lab4.Entities.ParserHandlers.DeleteHandlers;

public class FileDeleteHandler : BaseParserHandler
{
    private readonly IParserArgumentHandler<DeleteCommandBuilder> _nextHandler;

    public FileDeleteHandler(IParserArgumentHandler<DeleteCommandBuilder> nextHandler)
    {
        _nextHandler = nextHandler;
    }

    public override ResultCommandBuild Handle(StringArgumentsIterator iterator)
    {
        if (iterator.Current() != "delete")
        {
            return base.Handle(iterator);
        }

        var deleteCommandBuilder = new DeleteCommandBuilder();
        iterator.GetNext();
        return _nextHandler.Handle(iterator, deleteCommandBuilder);
    }
}