using Itmo.ObjectOrientedProgramming.Lab4.Entities.Command.Builder;
using Itmo.ObjectOrientedProgramming.Lab4.Entities.ParserIterators;
using Itmo.ObjectOrientedProgramming.Lab4.Models;

namespace Itmo.ObjectOrientedProgramming.Lab4.Entities.ParserHandlers.GotoHandlers;

public class TreeGotoHandler : BaseParserHandler
{
    private readonly IParserArgumentHandler<GotoCommandBuilder> _nextHandler;

    public TreeGotoHandler(IParserArgumentHandler<GotoCommandBuilder> nextHandler)
    {
        _nextHandler = nextHandler;
    }

    public override ResultCommandBuild Handle(StringArgumentsIterator iterator)
    {
        if (iterator.Current() != "goto")
        {
            return base.Handle(iterator);
        }

        var moveCommandBuilder = new GotoCommandBuilder();
        iterator.GetNext();
        return _nextHandler.Handle(iterator, moveCommandBuilder);
    }
}