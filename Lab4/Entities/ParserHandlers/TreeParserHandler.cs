using Itmo.ObjectOrientedProgramming.Lab4.Entities.ParserIterators;
using Itmo.ObjectOrientedProgramming.Lab4.Models;

namespace Itmo.ObjectOrientedProgramming.Lab4.Entities.ParserHandlers;

public class TreeParserHandler : BaseParserHandler
{
    private readonly BaseParserHandler _nextParserHandler;

    public TreeParserHandler(BaseParserHandler nextParserHandler)
    {
        _nextParserHandler = nextParserHandler;
    }

    public override ResultCommandBuild Handle(StringArgumentsIterator iterator)
    {
        if (iterator.Current() == "tree")
        {
            iterator.GetNext();
            return _nextParserHandler.Handle(iterator);
        }

        return base.Handle(iterator);
    }
}