using Itmo.ObjectOrientedProgramming.Lab4.Entities.Command.Builder;
using Itmo.ObjectOrientedProgramming.Lab4.Entities.ParserIterators;
using Itmo.ObjectOrientedProgramming.Lab4.Models;

namespace Itmo.ObjectOrientedProgramming.Lab4.Entities.ParserHandlers.TreeListHandlers;

public class ListHandler : BaseParserHandler
{
    private readonly IParserArgumentHandler<TreeShowCommandBuilder> _nextHandler;

    public ListHandler(IParserArgumentHandler<TreeShowCommandBuilder> nextHandler)
    {
        _nextHandler = nextHandler;
    }

    public override ResultCommandBuild Handle(StringArgumentsIterator iterator)
    {
        if (iterator.Current() != "list")
        {
            return base.Handle(iterator);
        }

        var moveCommandBuilder = new TreeShowCommandBuilder();
        iterator.GetNext();
        return _nextHandler.Handle(iterator, moveCommandBuilder);
    }
}