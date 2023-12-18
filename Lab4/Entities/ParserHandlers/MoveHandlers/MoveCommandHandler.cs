using Itmo.ObjectOrientedProgramming.Lab4.Entities.Command.Builder;
using Itmo.ObjectOrientedProgramming.Lab4.Entities.ParserIterators;
using Itmo.ObjectOrientedProgramming.Lab4.Models;

namespace Itmo.ObjectOrientedProgramming.Lab4.Entities.ParserHandlers.MoveHandlers;

public class MoveCommandHandler : BaseParserHandler
{
    private readonly IParserArgumentHandler<MoveCommandBuilder> _nextHandler;

    public MoveCommandHandler(IParserArgumentHandler<MoveCommandBuilder> nextHandler)
    {
        _nextHandler = nextHandler;
    }

    public override ResultCommandBuild Handle(StringArgumentsIterator iterator)
    {
        if (iterator.Current() != "move")
        {
            return base.Handle(iterator);
        }

        var moveCommandBuilder = new MoveCommandBuilder();
        iterator.GetNext();
        return _nextHandler.Handle(iterator, moveCommandBuilder);
    }
}